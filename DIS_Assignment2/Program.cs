using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_CT_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 9, 12 };
            int target = 9;
            int[] result1 = TargetRange(l1, target);
            // Write your code to print range r here
            Console.Write("[" + result1[0] + "," + result1[result1.Length-1]+"]"); 
           

            Console.WriteLine("\n");
            Console.WriteLine("Question 2");
            string s = "University of South Florida";
            string rs = StringReverse(s);
            Console.WriteLine(rs);


            /* Console.WriteLine("\n");
             Console.WriteLine("Question 3");
             int[] l2 = new int[] { 2, 2, 3, 5, 6 };
             int sum = MinimumSum(l2);
             Console.WriteLine(sum);
             Console.WriteLine("Question 4");
             string s2 = "Dell";
             string sortedString = FreqSort(s2);
             Console.WriteLine(sortedString);
             Console.WriteLine("Question 5-Part 1");
             int[] nums1 = { 1, 2, 2, 1 };
             int[] nums2 = { 2, 2 };
             int[] intersect1 = Intersect1(nums1, nums2);
             Console.WriteLine("Part 1- Intersection of two arrays is: ");
             DisplayArray(intersect1);
             Console.WriteLine("\n");
             Console.WriteLine("Question 5-Part 2");
             int[] intersect2 = Intersect2(nums1, nums2);
             Console.WriteLine("Part 2- Intersection of two arrays is: ");
             DisplayArray(intersect2);
             Console.WriteLine("\n");
             Console.WriteLine("Question 6");
             char[] arr = new char[] { 'a', 'g', 'h', 'a' };
             int k = 3;
             Console.WriteLine(ContainsDuplicate(arr, k));
             Console.WriteLine("Question 7");
             int rodLength = 4;
             int priceProduct = GoldRod(rodLength);
             Console.WriteLine(priceProduct);
             Console.WriteLine("Question 8");
             string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
             string keyword = "hhllo";

         Console.WriteLine(DictSearch(userDict, keyword));
             Console.WriteLine("Question 8");
             SolvePuzzle();*/
        }
        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }
        public static int[] TargetRange(int[] marks, int target)
        {
            try
            {
                List<int> result = new List<int>();
                int[] noTargetArray = new int[] { -1, -1 };
                for (int i = 0; i < marks.Length; i++)
                {
                    if (marks[i] == target)
                    {
                        result.Add(i);
                    }
                }
                if (result.Count == 0)
                {
                    return noTargetArray;
                }
                else
                {
                    return result.ToArray();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return new int[] { };
        }
        public static string StringReverse(string s)
        {
            try
            {
               
                string temp2 = "";
                List<string> splitString = new List<string>();
                for (int x = 0; x < s.Length; x++)
                {
                    if (!String.IsNullOrWhiteSpace(s[x].ToString()))
                    {
                        temp2 += s[x];
                    }
                    else
                    {
                        splitString.Add(temp2);
                        temp2 = "";
                    }
                }
                splitString.Add(temp2);
                string result2 = Reverse(splitString);
                Console.WriteLine(result2);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public static string Reverse(List<string> s)
        {
            try
            {
                int tempLength = s.Count;
                string tempString = "";
                string reversedString = "";
                int tempCount = 0;
                string tempWord = "";
                foreach(string word in s)
                {
                    tempString = "";
                    for(int i=1;i<=word.Length;i++)
                    {
                        tempString+= word[word.Length - i];
                    }
                    reversedString += tempString+" ";
                }
                return reversedString;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public static int MinimumSum(int[] l2)
        {
            try
            {
                //Write your code here;
            }
            catch (Exception)
            {
                throw;
            }
            return 0;
        }
        public static string FreqSort(string s2)
    
{
try
{
//Write Your Code Here
}
catch (Exception)
{
throw;
}
return null;
}
public static int[] Intersect1(int[] nums1, int[] nums2)
{
    try
    {
        // Write your code here
    }
    catch
    {
        throw;
    }
    return new int[] { };
}
public static int[] Intersect2(int[] nums1, int[] nums2)
{
    try
    {
        // Write your code here
    }
    catch
    {
        throw;
    }
    return new int[] { };
}
public static bool ContainsDuplicate(char[] arr, int k)
{
    try
    {
        //Write your code here;
    }
    catch (Exception)
    {
        throw;
    }
    return default;
}
public static int GoldRod(int rodLength)
{
    try
    {
        //Write Your Code Here
        
    }
    catch (Exception)
    {
        throw;
    }
    return 0;
}
public static bool DictSearch(string[] userDict, string keyword)
{
    try
    {
        //Write Your Code Here
    }
    catch (Exception)
    {
        throw;
    }
    return default;
}
public static void SolvePuzzle()
{
    try
    {
        //Write Your Code Here
    }
    catch (Exception)
    {
        throw;
    }
}
}
}