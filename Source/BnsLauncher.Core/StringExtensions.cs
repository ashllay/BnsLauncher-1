﻿using System.Text.RegularExpressions;

namespace BnsLauncher.Core
{
    public static class StringExtensions
    {
        public static bool WildMatch(this string input, string pattern)
        {
            return new Regex(Regex.Escape(pattern)
                .Replace("\\*", ".*")
                .Replace("\\?", ".")).IsMatch(input);
        }
    }
}