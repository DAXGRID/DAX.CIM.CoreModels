﻿using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using DAX.CIM.PhysicalNetworkModel.Traversal.Internals;

namespace DAX.CIM.PhysicalNetworkModel.Traversal
{
    public abstract class CimContext : IDisposable
    {
        const string CurrentCimContextKey = "current-cim-context";

        internal static CimContext Current
        {
            get { return (CimContext)CallContext.LogicalGetData(CurrentCimContextKey); }
            set { CallContext.LogicalSetData(CurrentCimContextKey, value); }
        }

        public static CimContext Create(IEnumerable<IdentifiedObject> objects)
        {
            var context = new InMemCimContext(objects);
            Current = context;
            return context;
        }

        public void Dispose()
        {
            Current = null;
        }

        public static CimContext GetCurrent()
        {
            var current = Current;

            return current;
        }

        public abstract int Count { get; }

        public abstract double Tolerance { get; }

        public abstract IEnumerable<TIdentifiedObject> OfType<TIdentifiedObject>()
            where TIdentifiedObject : IdentifiedObject;

        public abstract TIdentifiedObject GetObject<TIdentifiedObject>(string mRID)
            where TIdentifiedObject : IdentifiedObject;
    }
}