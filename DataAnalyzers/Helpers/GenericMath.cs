using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAnalyzers.Helpers
{
    class GenericMath
    {
        private static Dictionary<(Type Type, string Op), Delegate> CacheAdd = new Dictionary<(Type Type, string Op), Delegate>();

        public static T Add<T>(T left, T right) where T : unmanaged
        {
            var t = typeof(T);
            // If op is cached by type and function name, use cached version
            if (CacheAdd.TryGetValue((t, nameof(Add)), out var del))
                return del is Func<T, T, T> specificFunc
                    ? specificFunc(left, right)
                    : throw new InvalidOperationException(nameof(Add));

            var leftPar = Expression.Parameter(t, nameof(left));
            var rightPar = Expression.Parameter(t, nameof(right));
            var body = Expression.Add(leftPar, rightPar);

            var func = Expression.Lambda<Func<T, T, T>>(body, leftPar, rightPar).Compile();

            CacheAdd[(t, nameof(Add))] = func;

            return func(left, right);
        }

        private static Dictionary<(Type Type, string Op), Delegate> CacheSubtraction = new Dictionary<(Type Type, string Op), Delegate>();

        public static T Subtraction<T>(T left, T right) where T : unmanaged
        {
            var t = typeof(T);
            // If op is cached by type and function name, use cached version
            if (CacheSubtraction.TryGetValue((t, nameof(Subtraction)), out var del))
                return del is Func<T, T, T> specificFunc
                    ? specificFunc(left, right)
                    : throw new InvalidOperationException(nameof(Subtraction));

            var leftPar = Expression.Parameter(t, nameof(left));
            var rightPar = Expression.Parameter(t, nameof(right));
            var body = Expression.Subtract(leftPar, rightPar);

            var func = Expression.Lambda<Func<T, T, T>>(body, leftPar, rightPar).Compile();

            CacheSubtraction[(t, nameof(Subtraction))] = func;

            return func(left, right);
        }


        private static Dictionary<(Type Type, string Op), Delegate> CacheMultiply = new Dictionary<(Type Type, string Op), Delegate>();

        public static T Multiply<T>(T left, T right) where T : unmanaged
        {
            var t = typeof(T);
            // If op is cached by type and function name, use cached version
            if (CacheMultiply.TryGetValue((t, nameof(Multiply)), out var del))
                return del is Func<T, T, T> specificFunc
                    ? specificFunc(left, right)
                    : throw new InvalidOperationException(nameof(Multiply));

            var leftPar = Expression.Parameter(t, nameof(left));
            var rightPar = Expression.Parameter(t, nameof(right));
            var body = Expression.Multiply(leftPar, rightPar);

            var func = Expression.Lambda<Func<T, T, T>>(body, leftPar, rightPar).Compile();

            CacheMultiply[(t, nameof(Multiply))] = func;

            return func(left, right);
        }

        private static Dictionary<(Type Type, string Op), Delegate> CacheDivision = new Dictionary<(Type Type, string Op), Delegate>();

        public static T Division<T>(T left, T right) where T : unmanaged
        {
            var t = typeof(T);
            // If op is cached by type and function name, use cached version
            if (CacheDivision.TryGetValue((t, nameof(Division)), out var del))
                return del is Func<T, T, T> specificFunc
                    ? specificFunc(left, right)
                    : throw new InvalidOperationException(nameof(Division));

            var leftPar = Expression.Parameter(t, nameof(left));
            var rightPar = Expression.Parameter(t, nameof(right));
            var body = Expression.Divide(leftPar, rightPar);

            var func = Expression.Lambda<Func<T, T, T>>(body, leftPar, rightPar).Compile();

            CacheDivision[(t, nameof(Division))] = func;

            return func(left, right);
        }
    }
}
