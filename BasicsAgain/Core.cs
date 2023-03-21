
using System;

namespace BasicsAgain
{
    public class ZeroSizeArrayException : System.Exception { }
    public static class Core
    {
        public static int[] NewShelf(uint size, int defaultValue)
        {
            if (size == 0)
            {
                throw new ZeroSizeArrayException();
            }

            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = defaultValue;
            }
            return result;
        }

        public static string Uppercase(string bookContent)
        {
            string result = "";
            foreach (int current in bookContent)
            {
                if (current > 96 && current < 123)
                {
                    result += (char)(current - 32);
                }
                else
                {
                    result += (char)current;
                }
            }
            return result;
        }

        public static char[] Split(string bookContent)
        {
            int len = bookContent.Length;
            char[] result = new char[len];

            for (int i = 0; i < len; i++)
            {
                result[i] = bookContent[i];
            }

            return result;
        }
        
        public static void Print(char[][] bookContents)
        {
            foreach (char[] current in bookContents)
            {
                foreach (char showing in current)
                {
                    Console.Write(showing);
                }
                Console.Write("\n");
            }
        }
        
        public static int AreRecordsOkay(char[] record, char[] recordCopy)
        {
            /*int result = -2;
            int i = 0;
            int comp1 = 0;
            int comp2 = 0;
            while (result == -2)
            {

                try
                {
                    comp1 = record[i];
                    comp2 = recordCopy[i];

                }
                
                catch (Exception e)
                {
                    
                }
                
                if (comp1 != comp2)
                {
                    result += record[i] - recordCopy[i] +1;
                }
                
                i++;
            }

            return result+1;*/
            
            int len1 = record.Length;
            int len2 = recordCopy.Length;
            int max = len1;
            bool depass = false;
            bool rCopy = false; 
            if (len2 != len1)
            {
                depass = true;
                if (len2 < len1)
                {
                    rCopy = true;
                    max = len2;
                }
            }

            int i = 0;
            for(; i < max; i++)
            {
                if (record[i] != recordCopy[i])
                {
                    return record[i] - recordCopy[i];
                }
            }

            if (depass)
            {
                if (rCopy)
                {
                    return record[i] - 0;
                }
                else
                {
                    return 0 - recordCopy[i];
                }
            }
            return 0;
        }
        
        public static int FindFirstGrade(int[] grades, int grade)
        {
            int i = 0;
            foreach (int current in grades)
            {
                if (current == grade)
                {
                    return i;
                }

                i++;
            }

            return -1;
        }
        
        public static int ViceMin(int[] grades)
        {
            int len = grades.Length;
            if (len < 2)
            {
                throw new ArgumentException("Error: arr argument must be an integer array of at least size 2.");
            }

            int result = grades[1];
            int min = grades[0];

            if (result < min)
            {
                min = grades[1];
                result = grades[0];
            }

            for (int i = 2; i < len; i++)
            {
                if (grades[i] < result)
                {
                    if (grades[i] < min)
                    {
                        result = min;
                        min = grades[i];
                    }
                    else
                    {
                        result = grades[i];
                    }
                }
            }

            return result;
        }

        public static double Average(double[] grades)
        {
            int len = grades.Length;
            double result = 0;
            if (len == 0)
            {
                throw new ArithmeticException("Error: the size of array must be greater than 1 for Average.");
            }

            foreach (double current in grades)
            {
                result += current;
            }

            return result / len;
        }

        public static double WeightedAverage(double[] grades, double[] coefficients)
        {
            int leng = grades.Length;

            if (leng != coefficients.Length)
            {
                throw new ArgumentException("Error: the number of grades must be equal to the number of coefficients.");
            }

            if (leng == 0)
            {
                throw new ArithmeticException("Error: the size of arrays must be greater than 1 for Average.");
            }

            double allgrade = 0;
            double allcoeff = 0;
            for (int i = 0; i < leng; i++)
            {
                if (coefficients[i] <= 0)
                {
                    throw new ArithmeticException("Error: coefficients must be > 1");
                }

                allgrade += grades[i] * coefficients[i];
                allcoeff += coefficients[i];
            }

            return allgrade/allcoeff ;
        }
    }
}