using System;
using System.Collections.Generic;
using System.Linq;

namespace DAX.CIM.PhysicalNetworkModel.Traversal.Internals
{
    class InMemCimContext : CimContext
    {
        readonly Dictionary<string, IdentifiedObject> _objects = new Dictionary<string, IdentifiedObject>();
        readonly Dictionary<string, List<IdentifiedObject>> _duplicates = new Dictionary<string, List<IdentifiedObject>>();

        public InMemCimContext(IEnumerable<IdentifiedObject> objects)
        {
            Load(objects);
        }

        public override int Count => _objects.Count;

        void Load(IEnumerable<IdentifiedObject> objects)
        {
            foreach (var obj in objects)
            {
                var id = obj.mRID;

                if (_objects.ContainsKey(id))
                {
                    List<IdentifiedObject> duplicates;

                    if (!_duplicates.TryGetValue(id, out duplicates))
                    {
                        duplicates = new List<IdentifiedObject> { _objects[id] };
                        _duplicates[id] = duplicates;
                    }

                    duplicates.Add(obj);
                }
                else
                {
                    _objects[id] = obj;
                }
            }
        }

        public override IEnumerable<TIdentifiedObject> OfType<TIdentifiedObject>()
        {
            return _objects.Values.OfType<TIdentifiedObject>();
        }

        public override TIdentifiedObject GetObject<TIdentifiedObject>(string mRID)
        {
            IdentifiedObject obj;

            if (!_objects.TryGetValue(mRID, out obj))
            {
                throw new ArgumentException($"Could not find object with mRID {mRID}");
            }

            try
            {
                return (TIdentifiedObject) obj;
            }
            catch (Exception exception)
            {
                throw new ArgumentException($"Could not return object with mRID {mRID} as {typeof(TIdentifiedObject)} because it is {obj.GetType()}", exception);
            }
        }

        public override double Tolerance => 0.00001;
    }
}