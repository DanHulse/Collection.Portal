using System;
using System.Collections.Generic;

namespace Collections.Portal.Extensions
{
    public static class StringEx
    {
        public static List<string> SplitStringToList(this string stringToSplit)
        {
            var list = new List<string>();

            if (!string.IsNullOrEmpty(stringToSplit))
            {
                list = new List<string>(stringToSplit.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));

                return list;
            }

            return list;
        }
    }
}
