﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExperimentsInCoding
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder AppendFormattedLine(
            this StringBuilder @this,
            string format,
            params object[] args) =>
            @this.AppendFormat(format, args).AppendLine();

        public static StringBuilder AppendSequence<T>(
            this StringBuilder @this,
            IEnumerable<T> sequence,
            Func<StringBuilder, T, StringBuilder> fn) =>
            sequence.Aggregate(@this, fn);

        public static StringBuilder AppendLineWhen(
            this StringBuilder @this,
            Func<bool> predicate,
            string value) =>
            predicate()
                ? @this.AppendLine(value)
                : @this;

        public static StringBuilder AppendWhen(
            this StringBuilder @this,
            Func<bool> predicate,
            Func<StringBuilder, StringBuilder> fn) =>
            predicate()
                ? fn(@this)
                : @this;
    }
}
