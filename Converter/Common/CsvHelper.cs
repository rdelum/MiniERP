using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Common
{
    public static class CsvHelper
    {
        public static string[][] LoadCsv(string path, string newLineSeparator = " ", char separator = ',', char quote = '"', bool keepEmptyLines = false, bool mergeMultiLineInQuotes = true)
        {
            var lines = System.IO.File.ReadAllLines(path)
                .Where(line => keepEmptyLines || !string.IsNullOrEmpty(line));
            if (mergeMultiLineInQuotes)
                return lines.MergeMultiLine(newLineSeparator, keepEmptyLines, quote)
                    .Select(line => SplitFields(line, separator, quote))
                    .ToArray();
            else
                return lines.Select(line => line.Split(separator))
                    .ToArray();
        }

        /// <summary>
        /// Usuwa znaki " z początki i końca linii jeśli występują (dodatkowo zamienia również podwójne "" na "). Dla tekstów nie zamkniętych w cudzysłowiach zwraca tekst wejściowy
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string TrimQuotes(string text, char quote = '"')
        {
            if (text.StartsWith($"{quote}") && text.EndsWith($"{quote}"))
                text = text.Substring(1, text.Length - 2).Replace($"{quote}{quote}", $"{quote}");
            return text;
        }

        /// <summary>
        /// Rozdziela linię na pola (nie rozdziela pól ograniczonych cudzysłowami nawet jeśli zawiera separator, ale oczyszcza je z ograniczników i podwójnych codzysłowów) 
        /// </summary>
        /// <param name="line">linia tekstu wejściowa</param>
        /// <param name="separator">znak separatora, domyślnie ','</param>
        /// <param name="quote">znak cudzysłowa, domyślnie '"'</param>
        /// <returns>zwraca tablicę pól</returns>
        public static string[] SplitFields(this string line, char separator = ',', char quote = '"')
        {
            StringBuilder sb = new StringBuilder();
            List<string> pola = new List<string>();
            bool inQuotes = false;
            foreach (char c in line.ToCharArray())
            {
                if (inQuotes)
                {
                    sb.Append(c);
                    if (c == quote)
                        inQuotes = false;
                }
                else
                {
                    if (c == quote)
                    {
                        sb.Append(c);
                        inQuotes = true;
                    }
                    else if (c == separator)
                    {
                        pola.Add(sb.ToString());
                        sb.Clear();
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
            }
            pola.Add(sb.ToString());

            return pola.Select(pole => TrimQuotes(pole, quote)).ToArray();

        }

        /// <summary>
        /// Łączy linie rozbite na wiele wierszy. (posiadające tekst z otwartym cudzysłowiem)
        /// </summary>
        /// <param name="lines"></param>
        /// <returns>Zwraca listę połączonych linii</returns>
        public static List<string> MergeMultiLine(this string[] lines, string newlineSeparator = " ", bool keepEmptyLines = false)
        {
            List<string> linesUndivided = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                while (line.Count(c => c == '"') % 2 == 1)//uneven quotation marks -> unfinished line (text in quotation marks contains line break)
                    if (++i < lines.Length && (keepEmptyLines || !string.IsNullOrWhiteSpace(lines[i])))
                        line += newlineSeparator + lines[i];//append nextLine
                linesUndivided.Add(line);
            }
            return linesUndivided;
        }

        /// <summary>
        /// Łączy linie rozbite na wiele wierszy. (posiadające tekst z otwartym cudzysłowiem)
        /// </summary>
        /// <param name="lines"></param>
        /// <returns>Zwraca listę połączonych linii</returns>
        public static IEnumerable<string> MergeMultiLine(this IEnumerable<string> lines, string newlineSeparator = " ", bool keepEmptyLines = false, char quote = '"')
        {
            var enumerator = lines.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var line = enumerator.Current;
                while (line.Count(c => c == quote) % 2 == 1 && enumerator.MoveNext())//uneven quotation marks -> unfinished line (text in quotation marks contains line break)
                    if (keepEmptyLines || !string.IsNullOrWhiteSpace(enumerator.Current))
                        line += newlineSeparator + enumerator.Current;
                yield return line;
            }
        }
    }
}
