using System;

namespace DAX.CIM.PhysicalNetworkModel.Traversal.Extensions
{
    public static class DoubleExtensions
    {
        public static bool IsEqualTo(this double value, double other, double? tolerance = null)
        {
            var currentTolerance = tolerance ?? CimContext.GetCurrent().Tolerance;

            return Math.Abs(value - other) < currentTolerance;
        }
    }
}