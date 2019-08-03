using System;

namespace ExperimentsInCoding
{
    public static class JamieExtensionMethods
    {
        public static DateTime RoundToNearest(this DateTime dateTime, TimeSpan span)
        {
            var delta = dateTime.Ticks % span.Ticks;
            var roundUp = delta > span.Ticks / 2;
            var offset = roundUp ? span.Ticks : 0;
            return new DateTime(dateTime.Ticks + offset - delta, dateTime.Kind);
        }

        public static DateTime RoundUp(this DateTime dateTime, TimeSpan span)
        {
            var modateTimeicks = dateTime.Ticks % span.Ticks;
            var delta = modateTimeicks != 0 ? span.Ticks - modateTimeicks : 0;
            return new DateTime(dateTime.Ticks + delta, dateTime.Kind);
        }

        public static DateTime RoundDown(this DateTime dateTime, TimeSpan span)
        {
            var delta = dateTime.Ticks % span.Ticks;
            return new DateTime(dateTime.Ticks - delta, dateTime.Kind);
        }

        public static T Tee<T>(this T @this, Action<T> action)
        {
            action(@this);
            return @this;
        }

        public static TResult Map<TSource, TResult>(this TSource @this, Func<TSource, TResult> fn) => fn(@this);

        public static T When<T>(this T @this, Func<bool> predicate, Func<T, T> fn) => predicate() ? fn(@this) : @this;
    }
}