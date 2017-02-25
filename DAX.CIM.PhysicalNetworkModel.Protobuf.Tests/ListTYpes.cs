using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using NUnit.Framework;
using Ploeh.AutoFixture;
using ProtoBuf;
using ProtoBuf.Meta;
// ReSharper disable UnusedMember.Local

namespace DAX.CIM.PhysicalNetworkModel.Protobuf.Tests
{
    [TestFixture]
    public class ListTYpes
    {
        [Test]
        public void ListTypes()
        {
            var allTypes = GetAllTypes();

            Console.WriteLine(string.Join(Environment.NewLine, allTypes));
        }

        [Test]
        public void CanAutofixtureDoIt()
        {
            var fixture = new Fixture();

            var instances = GetAllTypes()
                .Where(type => type.IsClass && !type.IsAbstract)
                .Select(type => CreateInstance(fixture, type))
                .Cast<IdentifiedObject>()
                .Skip(1)
                .Take(1)
                .ToList();

            var model = TypeModel.Create();

            PopulateModel(GetAllTypes(), model);

            Roundtrip(model, instances);
        }

        static void Roundtrip(RuntimeTypeModel model, List<IdentifiedObject> instances)
        {
            using (var destination = new MemoryStream())
            {
                model.Serialize(destination, instances);
                var data = destination.ToArray();

                using (var source = new MemoryStream(data))
                {
                    var list = (List<IdentifiedObject>) model.Deserialize(source, null, typeof(List<IdentifiedObject>));

                    Assert.That(list.Count, Is.EqualTo(instances.Count));

                    foreach (var pair in instances.Zip(list, (original, roundtripped) => new {original, roundtripped}))
                    {
                        var original = pair.original;
                        var roundtripped = pair.roundtripped;

                        var originalJson = original.ToJson();
                        var roundtrippedJson = roundtripped.ToJson();

                        if (roundtrippedJson != originalJson)
                        {
                            throw new AssertionException($@"Objects are not equal!

Original:

{originalJson}

Roundtripped:

{roundtrippedJson}
");
                        }
                    }
                }
            }
        }

        static object CreateInstance(Fixture fixture, Type type)
        {
            return typeof(ListTYpes).GetMethod("Create", BindingFlags.Static | BindingFlags.NonPublic)
                .MakeGenericMethod(type)
                .Invoke(null, new object[] { fixture });
        }

        static object Create<T>(Fixture fixture)
        {
            return fixture.Create<T>();
        }

        void PopulateModel(IEnumerable<Type> types, RuntimeTypeModel model)
        {
            var typesToRegister = types
                .Select(type => new
                {
                    Type = type,
                    SubTypes = GetSubTypes(type)
                });


            foreach (var typeToRegister in typesToRegister)
            {
                var type = typeToRegister.Type;
                Console.WriteLine($"Add: {type}");

                var metaType = model.Add(type, true);

                var index = 1;

                Console.WriteLine("  properties:");
                foreach (var property in type.GetProperties())
                {
                    Console.WriteLine($"     * {property.Name}");
                    metaType.Add(index++, property.Name);
                }

                Console.WriteLine("  subtypes:");
                foreach (var subType in typeToRegister.SubTypes)
                {
                    Console.WriteLine($"     * {subType.Name}");
                    metaType.AddSubType(index++, subType);
                }
            }
        }

        Type[] GetSubTypes(Type type)
        {
            return GetAllTypes()
                .Where(t => t != type)
                .Where(t => t.BaseType == type)
                .ToArray();
        }

        static IEnumerable<Type> GetAllTypes()
        {
            var allTypes = typeof(PhysicalNetworkModelEnvelope).Assembly.GetTypes()
                .Where(type => typeof(IdentifiedObject).IsAssignableFrom(type))
                .Concat(new[]
                {
                    typeof(Point2D)
                });

            return allTypes;
        }
    }
}
