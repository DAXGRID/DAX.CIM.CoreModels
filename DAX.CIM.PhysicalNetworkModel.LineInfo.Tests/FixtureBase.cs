using System;
using System.Collections.Concurrent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAX.CIM.PhysicalNetworkModel.LineInfo.Tests
{
    public abstract class FixtureBase
    {
        readonly ConcurrentStack<IDisposable> _disposables = new ConcurrentStack<IDisposable>();

        protected void CleanUpDisposables()
        {
            IDisposable disposable;
            while (_disposables.TryPop(out disposable))
            {
                disposable.Dispose();
            }
        }

        protected TDisposable Using<TDisposable>(TDisposable disposable) where TDisposable : IDisposable
        {
            _disposables.Push(disposable);
            return disposable;
        }

        [TestInitialize]
        public void InnerSetup()
        {
            SetUp();
        }

        protected virtual void SetUp()
        {
        }

        [TestCleanup]
        public void TearDown()
        {
            CleanUpDisposables();
        }
    }
}