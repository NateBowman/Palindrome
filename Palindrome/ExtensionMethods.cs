//  --------------------------------------------------------------------------------------------------------------------
//     <copyright file="ExtensionMethods.cs">
//         Copyright (c) Nathan Bowman. All rights reserved.
//         Licensed under the MIT License. See LICENSE file in the project root for full license information.
//     </copyright>
//  --------------------------------------------------------------------------------------------------------------------
namespace Palindrome
{
    using System;
    using System.Text.RegularExpressions;

    public static class ExtensionMethods
    {
        /// <summary>
        ///     Indicates whether a string is a palindrome.
        /// </summary>
        /// <remarks>
        ///     A palindrome is a word, phrase, number, or other sequence of characters
        ///     which reads the same backward or forward. Is is usual to ignore spaces and punctuation.
        ///     An empty string and a single character should both return true
        /// </remarks>
        /// <returns>Returns true if the input value is a palindrome</returns>
        public static bool IsPalindrome(this string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Parameter cannot be null");
            }

            if ((value == string.Empty) || (value.Length == 1))
            {
                return true;
            }

            // Replace all non-word chars with nothing
            var charArray = Regex.Replace(value, @"[^\w]", string.Empty).ToLower();

            var comparisonCount = charArray.Length / 2;

            for (var i = 0; i < comparisonCount; i++)
            {
                if (charArray[i] != charArray[(charArray.Length - 1) - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}