using System.Text.RegularExpressions;
namespace lab_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Max length
            //int[] arr = [1, 0, 0, 0, 5, 6, 7, 5, 0, 7, 1, 1];
            //int[] arr = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1];
            // we need to get the max length btw two matched elements 
            //int maxLength = 0;
            //int currentLength = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            currentLength = j - i - 1;
            //        }

            //    }
            //    if(maxLength < currentLength)
            //        maxLength = currentLength;
            //}
            //Console.WriteLine(maxLength);
            #endregion

            #region reverse the order of the words.

            //string input = "this is a test";
            //string[] arr = input.Split(' ');
            //Array.Reverse(arr);
            //Console.WriteLine(String.Join(' ',arr));

            #endregion

            #region number of ones
            #region 1st
            //int sum = 0;
            //for (int i = 0; i < 999999999; i++)
            //{
            //    string current = i.ToString();

            //    for (int j = 0; j < current.Length; j++)
            //    {
            //        if (current[j] == '1')
            //        {
            //            sum++;
            //        }
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 2nd
            //string input = "99999999";
            //int numberOfOne = input.Length * (int)Math.Pow(10, input.Length - 1);
            //Console.WriteLine(numberOfOne);
            #endregion

            #region 3rd
            //int sum = 0;
            //for(int i = 0; i<20; i++)
            //{
            //    int number = i;
            //    while (number > 0)
            //    {
            //        int reminder = number % 10;
            //        number = number / 10;

            //        if (reminder == 1)
            //        {
            //            sum++;
            //        }

            //    }

            //}
            //Console.WriteLine(sum);
            #endregion
            #endregion

        }
    }
}
