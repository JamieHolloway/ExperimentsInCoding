using System;
using System.Collections.Generic;
using System.Text;

namespace ExperimentsInCoding
{
    public static class HtmlBuilder
    {
        public static Func<IDictionary<int, string>, string> BuildSelectBox(string id, bool includeUnknown) =>
            options =>
                new StringBuilder()
                    .AppendFormattedLine($"<select id=\"{id}\" name=\"{id}\">")
                    .When(
                        () => includeUnknown,
                        sb => sb.AppendFormattedLine("\t<option>unknown</option>"))
                    .AppendSequence(
                        options,
                        (sb, opt) => sb.AppendFormattedLine($"\t<option value=\"{opt.Key}\">{opt.Value}</option>"))
                    .AppendLine("</option>")
                    .ToString();
    }
}
