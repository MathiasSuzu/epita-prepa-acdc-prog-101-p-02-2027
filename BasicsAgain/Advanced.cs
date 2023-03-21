namespace BasicsAgain
{
    public class Advanced
    {
        public static int KingOfTheHill(int[] performances)
        {
            int len = performances.Length;

            if (len == 0)
            {
                return -1;
            }

            int i = 0;
            while (i+1 < len && performances[i] <= performances[i+1])
            {
                i++;
            }

            int k = i;
            while (k+1 < len && performances[k] >= performances[k + 1])
            {
                k++;
            }

            if (k != len - 1)
            {
                return -1;
            }

            return i;
        }

        public static int Levenshtein(string str1, string str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            int[][] table = new int[len1+1][];
            int min;
            for (int a = 0; a <= len1; a++)
            {
                table[a] = new int[len2+1];
            }

            for (int a = 0; a <= len1; a++)
            {
                table[a][0] = a;
            }

            for (int a = 0; a <= len2; a++)
            {
                table[0][a] = a;
            }

            for (int i = 1; i <= len1; i++)
            {
                for (int j = 1; j <= len2; j++)
                {
                    min = table[i - 1][j - 1];
                    if (str1[i - 1] != str2[j - 1])
                    {
                        min +=  1;
                    }
                    
                    //min = table[i - 1][j - 1] + (str1[i - 1] != str2[j - 1]? 1:0);
                    if(min > table[i][j - 1]+1)
                    {
                        min = table[i][j - 1]+1;
                    }

                    if (min > table[i - 1][j]+1)
                    {
                        min = table[i - 1][j]+1;
                    }

                    /*if (str1[i - 1] != str2[j - 1])
                    {
                        min += 1;
                    }*/

                    table[i][j] = min;

                }
            }

            return table[len1][len2];
            
        }
    }
}