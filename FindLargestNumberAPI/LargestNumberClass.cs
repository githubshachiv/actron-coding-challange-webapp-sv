
    using System.Collections.Generic;
    using System;

    namespace FindLargestNumberAPI
    {
        public class LargestNumberClass
        {
        // Given a list of non-negative
        // integers,
        // arrange them such that they
        // form the largest number.
        // Note: The result may be very
        // large, so you need to
        // return a string instead
        // of an integer.

        public static string LargestNumberMethod(List<int> inputList)
        {
            if (inputList.Count == 0)
                return string.Empty;

            string output = string.Empty;

            var containsNegatives = inputList.Any(n => n < 0);

            if (containsNegatives)
                return output;

            List<string> newList = inputList.ConvertAll<string>(
                    delegate (int i) { return i.ToString(); });

            newList.Sort(MyCompare);

            for (int i = 0; i < inputList.Count; i++)
            {
                output = output + newList[i];
            }

            if (output[0] == '0' && output.Length > 1)
            {
                return "0";
            }
            return output;
        }

            internal static int MyCompare(string X, string Y)
            {
                // first append Y at the end of X
                string XY = X + Y;

                // then append X at the end of Y
                string YX = Y + X;

                // Now see which of the two
                // formed numbers is greater
                return XY.CompareTo(YX) > 0 ? -1 : 1;
            }
        }
    }
