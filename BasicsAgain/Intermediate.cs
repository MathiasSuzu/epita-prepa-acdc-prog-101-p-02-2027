using System;

namespace BasicsAgain
{
     public static class Intermediate
    {
        public static bool Palindrome(string str)
        {
            string inter = "";
            foreach (char current in str)
            {
                if (current != ' ')
                {
                    if (current > 64 && current < 91)
                    {
                        inter += (char)((int)current + 32);
                    }
                    else
                    {
                        inter += current;
                    }
                }
            }

            int len = inter.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (inter[i] != inter[len-1 - i])
                {
                    return false;
                }
            }

            return true;
        }
        
        public static int[] Reverse(int[] arr)
        {
            int len = arr.Length;
            int inter;
            for (int i = 0; i < len/2; i++ )
            {
                inter = arr[i];
                arr[i] = arr[len - i - 1];
                arr[len - i - 1] = inter;
            }
            return arr;
        }

        public static string MyTrim(string toTrim, char[] toRemove)
        {
            int lenRemove = toRemove.Length;
            if (lenRemove == 0)
            {
                toRemove = new[] { ' ' };
                lenRemove = 1;
            }

            if (toTrim == "")
            {
                return "";
            }

            bool match = true;
            int lenTrim = toTrim.Length;

            int i = 0;
            int j;
            string result = "";
            for (; i <= lenTrim / 2 && match; i++)
            {
                j = 0;
                match = false;
                for (; j < lenRemove; j++)
                {
                    if (toRemove[j] == toTrim[i])
                    {
                        match = true;
                        j = lenRemove + 1;
                    }
                }
            }
            //return toTrim[(i-1)..(lenTrim-i+1)];
            int k = lenTrim-1;
            match = true;
            for (; k >= lenTrim / 2 - 1 && match; k--)
            {
                j = 0;
                match = false;
                for (; j < lenRemove; j++)
                {
                    if (toRemove[j] == toTrim[k])
                    {
                        match = true;
                        j = lenRemove + 1;
                    }
                }
            }
            Console.WriteLine(k);

            for (int a = i - 1; a <= k+1; a++)
            {
                result += toTrim[a];
            }

            return result;
        }
        
        public static bool DivineProofValidator(string victimsText, string divineProof)
        {
            int lenV = victimsText.Length;
            int lenD = divineProof.Length;

            if (lenD == 0)
            {
                return true;
            }

            if (lenV < lenD)
            {
                return false;
            }
            char first = divineProof[0];
            bool match;
            for (int i = 0; i < lenV; i++)
            {
                if (victimsText[i] == first)
                {
                    match = true;
                    for (int j = 1; j < lenD && match; j++)
                    {

                        if (i + j == lenV)
                        {
                            return false;
                        }
                        
                        if (victimsText[i + j] != divineProof[j])
                        {
                            match = false;
                        }
                    }

                    if (match)
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        public static string CodeZeus(string str, int n)
        {
            string result = "";
            char inter;
            if (n < 0)
            {
                n = 26 - n;
            }
            foreach (int current in str)
            {
                if (current > 64 && current < 91)
                {
                    inter = (char)((current - 65 + n) % 26 + 65);
                }
                else if (current > 96 && current < 123)
                {
                    inter = (char)((current - 97 + n) % 26 + 97);
                }
                else
                {
                    inter = (char)current;
                }

                result += inter;
            }

            return result;
        }
    }
}