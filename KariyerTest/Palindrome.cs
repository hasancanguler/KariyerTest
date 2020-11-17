using System;

namespace KariyerTest
{
    public class Palindrome
    {
        public bool Check(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            string reverseText = Reverse(text);
            if (text == reverseText)
                return true;
            else
                return false;
        }

        private string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
