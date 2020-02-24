using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Assignment2_CT_Spring2020
{
    class Program
    {
        public static List<List<int>> outList = new List<List<int>>();
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 9, 12 };
            int target = 9;
            int[] result1 = TargetRange(l1, target);
            // Write your code to print range r here
            DisplayArray(result1);
           // Console.Write("[" + result1[0] + "," + result1[result1.Length-1]+"]"); 
           

             Console.WriteLine("\n");
             Console.WriteLine("Question 2");
             string s = "University of South Florida";           
             string rs = StringReverse(s);
             Console.WriteLine(rs);


             Console.WriteLine("\n");
             Console.WriteLine("Question 3");
             int[] l2 = new int[] { 2, 2, 3, 5, 6 };
             int sum = MinimumSum(l2);
             Console.WriteLine(sum);

             Console.WriteLine("\n");
             Console.WriteLine("Question 4");
             string s2 = "eebhhh";
             string sortedString = FreqSort(s2);
             Console.WriteLine(sortedString);

             Console.WriteLine("\n");
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
             char[] arr = new char[] { 'k', 'k', 'y', 'k' };
             int k = 3;
             Console.WriteLine(ContainsDuplicate(arr, k));

             Console.WriteLine("\n");
             Console.WriteLine("Question 7");
             int rodLength = 10;
             int priceProduct = GoldRod(rodLength);
             Console.WriteLine("Maximum price will be "+priceProduct);

            Console.WriteLine("\n");
            Console.WriteLine("Question 8");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            string keyword = "hhllo";
            Console.WriteLine(DictSearch(userDict, keyword));

            Console.WriteLine("\n");
            Console.WriteLine("Question 9");
            SolvePuzzle();
        }
        public static void DisplayArray(int[] a)
        {
            //adding [ and ] to print in the required format
            Console.Write("[");
            for (int i = 0; i < a.Length; i++)
            {
                if(i==a.Length-1)
                    Console.Write(a[i]);
                else
                    Console.Write(a[i] + ",");
            }
            Console.Write("]");
        }
        //Contributed by Anusha.
        public static int[] TargetRange(int[] marks, int target)
        {
            try
            {
                if (marks.Length != 0)
                {
                    //using a list to store the result.
                    List<int> result = new List<int>();

                    //we will return this array if the target is not found in the array.
                    int[] noTargetArray = new int[] { -1, -1 };
                    //we will store the first index in the list if the target is found in the array, then we will break the loop.
                    for (int i = 0; i < marks.Length; i++)
                    {
                        if (marks[i] == target)
                        {
                            result.Add(i);
                            break;
                        }
                    }


                    //we will store the last index in the list if the target is found in the array, then we will break the loop.
                    for (int i = marks.Length-1; i >=0; i--)
                    {
                        if(marks[i]==target)
                        {
                            //checking if the index is already in the array.
                            if (!(result[0] == i))
                            {
                                result.Add(i);
                                break;
                            }
                        }
                    }

                    //returing [-1,-1] if target not found
                    if (result.Count == 0)
                    {
                        return noTargetArray;
                    }
                    else
                    {
                        return result.ToArray();
                    }
                }
                else
                {
                    //corner case checking if the input array is empty.
                    Console.WriteLine("The array should contain atleast one element");
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Question 1 exited with a message ",e.Message);
                throw;
            }
            
        }

        //Contributed by Anusha.
        public static string StringReverse(string s)
        {
            try
            {
                if (s.Length == 0)
                {
                    //if input string is empty, output is empty
                    Console.WriteLine("");
                    return null;
                }
                else
                {
                    //splitting the string using user defined method and storing the words in a string list.
                    List<string> split = splitMethod(s);                    
                    //passing the string list to reverse each word independently.
                    string result2 = Reverse(split);
                    //returning the reversed string
                    return result2;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Question 2 exited with error message "+e.Message);
                return null;
            }
            
        }

        public static List<string> splitMethod(string s)
        {
            string temp2 = "";
            List<string> splitString = new List<string>();

            for (int x = 0; x < s.Length; x++)
            {
                //adding the characters to a temp array till we get a white space.
                if (!String.IsNullOrWhiteSpace(s[x].ToString()))
                {
                    temp2 += s[x];
                }
                else
                {
                    //adding the temp to a string list and clearing the temp string.
                    splitString.Add(temp2);
                    temp2 = "";
                }
            }
            splitString.Add(temp2);
            return splitString;

        }
        public static string Reverse(List<string> s)
        {
            try
            {
                int tempLength = s.Count;
                string tempString = "";
                string reversedString = "";
                int count = 0;

                //taking each word in the string list and then 
                //reversing that word and adding it to the final result string
                foreach (string word in s)
                {
                    tempString = "";
                    for(int i=1;i<=word.Length;i++)
                    {
                        count++;
                        
                        tempString+= word[word.Length - i];
                    }
                    //adding space after reversing each word except for the last word.
                    if (word != s[tempLength - 1])
                        reversedString += tempString + " ";
                    else
                        reversedString += tempString;
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
                int sum1 = 0;
                int length = l2.Length;
                if (length == 0)
                {
                    Console.WriteLine("no elements in array");
                }
                if (length == 1)
                {
                    Console.WriteLine("only one element in array. That is the minimum one");
                }
                //Console.WriteLine(length);
                //iterate through all the elements of the array
                for (int i = 0; i < length; i++)
                {
                    if (i != 0)
                    {
                        //if the element is equal to previous element. add 1 to element 
                        if (l2[i - 1] == l2[i])
                        {
                            l2[i] = l2[i] + 1;
                        }
                    }
                }
                //finding sum of the elements of the list
                for (int i = 0; i < length; i++)
                {
                    sum1 = sum1 + l2[i];
                }
                //Console.WriteLine(sum1);
                return sum1;

            }
            catch (Exception)
            {
                throw;
            }
            
        }
           public static string FreqSort(string s2)
    
           {
             try
             {
                if (s2.Length != 0)
                {
                    string s = s2;
                    int val = 1;
                    //we are using a dictionary to store each unique character as key
                    //and store frequency as value.
                    Dictionary<char, int> dict = new Dictionary<char, int>();
                    for (int i = 0; i < s.Length; i++)
                    {
                        //if key is not present in the dictionary
                        if (!dict.ContainsKey(s[i]))
                        {
                            for (int j = i + 1; j < s.Length; j++)
                            {
                                //if a character occurs, increasing the value by 1 each time.
                                if (s[i] == s[j])
                                {
                                    val++;
                                }
                            }
                            //adding the character and it's frequency to the dictionary.
                            dict.Add(s[i], val);
                            //reset the value to 1 each time.
                            val = 1;
                        }

                    }

                    string result = "";
                    //sorting the dictionary according to values in descending order.
                    foreach (var temp in dict.OrderByDescending(a => a.Value))
                    {
                        for (int i = 0; i < temp.Value; i++)
                        {
                            //adding each character according to it's frequency.
                            result += temp.Key;
                        }
                    }


                    return result;
                }
                else
                {
                    Console.WriteLine("The input string cannot be empty");
                    return null;
                }
             }
              catch (Exception e)
             {
                Console.WriteLine("Question 4 exited with error message "+e.Message);
                throw;
             }
           
           }
public static int[] Intersect1(int[] nums1, int[] nums2)
{
    try
    {
                // Write your code here
                // Sorted array by merge sort- nlogn is input to this method
                int i = 0;
                int j = 0;
                //int val = 1;
                //Empty list
                List<int> L = new List<int>();
                //Navigating through both lists
                if (nums1.Length == 0 || nums2.Length == 0)
                {
                    Console.WriteLine("One of the numbers set is empty");
                }
                while (i < nums1.Length && j < nums2.Length)
                {
                    //Checking for equality of sorted elements in both and adding to list and simlateneously incrementing the list 
                    //This list now contains the intersected values 
                    if (nums1[i] == nums2[j])
                    {
                        L.Add(nums1[i]);
                        i++;
                        j++;
                    }
                    else if (nums1[i] < nums2[j])
                    {
                        i++;
                    }
                    else if (nums1[i] > nums2[j])
                    {
                        j++;
                    }

                }
                return L.ToArray();

            }
    catch
    {
        throw;
    }
    
}
public static int[] Intersect2(int[] nums1, int[] nums2)
{
    try
    {
                // Write your code here
                int i = 0;
                int j = 0;
                int val = 1;
                //initialising dic1,dict2 to strore array1,array2 elements as key and frequency as values 
                Dictionary<int, int> dict1 = new Dictionary<int, int>();
                Dictionary<int, int> dict2 = new Dictionary<int, int>();
                //initialising dic3 to store equal key in both dict and the absolute difference between the values of both the keys
                Dictionary<int, int> dict3 = new Dictionary<int, int>();
                //iterating through the list1 and storing them in dictionary1
                while (i < nums1.Length)
                {
                    if (!dict1.ContainsKey(nums1[i]))
                        dict1.Add(nums1[i], val);
                    else
                        dict1[nums1[i]] = dict1[nums1[i]] + 1;
                    i++;
                }
                //iterating through the list2 and storing them in dictionary2
                while (j < nums2.Length)
                {
                    if (!dict2.ContainsKey(nums2[j]))
                        dict2.Add(nums2[j], val);
                    else
                        dict2[nums2[j]] = dict2[nums2[j]] + 1;
                    j++;
                }
                //comparing each row of dictionaries.
                /* foreach (var dic1 in dict1)
                 {
                     foreach (var dic2 in dict2)
                     {
                         //if keys are equal add to result dictionary key and the absolute values of difference between 
                         if (dic1.Key == dic2.Key)
                         {
                             if (!dict3.ContainsKey(dic1.Key))
                                 dict3.Add(dic1.Key, Math.Abs(dic1.Value - dic2.Value));
                             break;// unique key exist break is good option to lessen number of iterations
                         }

                     }
                 }*/
                //comparing each row of dictionaries.
                foreach (var dic1 in dict1)
                {
                    //if keys are equal add to result list and the minimum of value
                    if (dict2.ContainsKey(dic1.Key))
                    {
                        if (!dict3.ContainsKey(dic1.Key))
                            dict3.Add(dic1.Key, Math.Min(dic1.Value, dict2[dic1.Key]));

                    }
                }

                List<int> resultList = new List<int>();
                //writing the dictionary elements to the output 


                foreach (var dic3 in dict3)
                {

                    for (int c = 0; c < dic3.Value; c++)
                    {
                        resultList.Add(dic3.Key);
                    }

                }
                return resultList.ToArray();
            }
    catch
    {
        throw;
    }
    
}

        public static int[] mergeSort(int[] array)
        {
            //merge sort by recursive algorithm
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            //base case
            if (array.Length <= 1)
                return array;
            //midpoint of array  
            int midPoint = array.Length / 2;
            // left position of array
            left = new int[midPoint];

            //if array-even number of elements, the left elements= right elements 
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            //if array-odd number of elements, the left elements +1 = right elements
            else
                right = new int[midPoint + 1];
            // left array from main array
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
            //right array from main array   
            int x = 0;
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            //sort left array -recursively
            left = mergeSort(left);
            //sort right array -recursively
            right = mergeSort(right);
            //Merge left and right arrays by merge method
            result = merge(left, right);
            return result;
        }


        public static int[] merge(int[] left, int[] right)
        {
            //merging two sorted arrays
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //Navigating through both the arrays till the end of arrays
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //if element on left array is less than element on right array, add left element to result 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // if element on left array is more than element on right array, add right element to result
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if left array is left with elements, add to result
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if left array is left with elements, add to result
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            //return merged array
            return result;
        }



        public static bool ContainsDuplicate(char[] arr, int k)
         {
            try
            {
                if (arr.Length == 0)
                {
                    Console.WriteLine("Input array should not be empty");
                    return false;
                }
                else
                {
                    char[] inp = arr;
                    bool flag = false;
                    //dictionary to store each character and it's indices in a list.
                    Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();
                    List<int> tempList = new List<int>();


                    for (int i = 0; i < inp.Length; i++)
                    {
                        List<int> uniqueList = new List<int>();
                        if (!dict.ContainsKey(inp[i]))
                        {
                            //adding character and list to dictionary
                            uniqueList.Add(i);
                            dict.Add(inp[i], uniqueList);
                        }
                        else
                        {
                            //adding new index to the list of a key
                            tempList = dict[inp[i]];
                            tempList.Add(i);
                            dict[inp[i]] = tempList;
                        }

                    }
                    foreach (var temp in dict)
                    {
                        if (temp.Value.Count > 1)
                        {
                            for (int i = 0; i < temp.Value.Count - 1; i++)
                            {
                                //checking for difference in indices and comaring it with k, for each character
                                if ((temp.Value[i + 1] - temp.Value[i]) <= k)
                                {
                                    //making the flag true if the condition gets satisfied.
                                    flag = true;
                                    break;
                                }

                            }
                            if (flag == true)
                                break;
                        }
                    }
                    return flag;
                }
            }
             catch (Exception e)
            {
                Console.WriteLine("Contains dupilcate function exited with error message "+e.Message);
                throw;
            }
         }
        public static int GoldRod(int rodLength)
        {
            try
            {
                if (rodLength == 0)
                {
                    Console.WriteLine("Length of the rod should be greater than 0");
                    return 0;
                }
                else
                {
                    int n = rodLength;
                    int[] arr = new int[n];
                    
                    recur(arr, 0, n, n);

                    int max = 1;
                    List<int> resultList = new List<int>();
                    //loop for finding the max product of each list and returning the max of all.
                    foreach (var l in outList)
                    {
                        int pr = 1;
                        for (int i = 0; i < l.Count; i++)
                        {
                            pr *= l[i];
                        }

                        if (pr > max)
                        {
                            resultList = l;
                            max = pr;
                        }
                    }

                    Console.Write("We should cut the rod like ");
                    foreach(int i in resultList)
                    {
                        Console.Write(i+" ");
                    }
                    Console.WriteLine();
                    return max;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Gold rod exited with message "+e.Message);
                throw;
            }

        }
        //function to find all the patterns that add up to an integer.
        public static void recur(int[] arr, int index,
                                 int num, int diff)
        {
            // base condition  
            if (diff < 0)
                return;

            //storing each combination to a new list and adding it that list to another list. 
            if (diff == 0)
            {
                List<int> list = new List<int>();
                //adding each integer to a new list.
                for (int i = 0; i < index; i++)
                {
                    list.Add(arr[i]);
                }
                //adding each list to a public list to find the max of all the lists.
                outList.Add(list);
                return;
            }
            int prev = (index == 0) ? 1 : arr[index - 1];

            //starting the loop from prev value to decrease iterations.
            for (int k = prev; k <= num; k++)
            {

                arr[index] = k;
                //calling the function recursively, increasing the index to store the
                //next element at next index.
                recur(arr, index + 1, num, diff - k);

            }
        }

             public static bool DictSearch(string[] userDict, string keyword)
             {
              try
              {
                if (userDict.Length == 0 || keyword.Length == 0)
                {
                    Console.WriteLine("Input array or the keyword cannot be empty");
                    return false;                       
                }
                else
                {
                    bool flag = false;
                    List<char> L = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                    for (int i = 0; i < keyword.Length; i++)
                    {
                        //we are using a stringbuilder to change our string in between.
                        StringBuilder temp = new StringBuilder(keyword);

                        //substituting each character at each place in the string and comparing with our input string.
                        foreach (char c in L)
                        {
                            temp[i] = c;
                            string s = "";
                            //converting the string builder to string again for comparision.
                            for (int y = 0; y < temp.Length; y++)
                            {
                                s += temp[y];
                            }
                            //comparing the manipulated string with each string in the input string array
                            for (int k = 0; k < userDict.Length; k++)
                            {
                                if (s == userDict[k])
                                {
                                    //break the loop if the flag is true.
                                    flag = true;
                                    break;
                                }
                            }
                            if (flag == true)
                                break;
                        }
                        if (flag == true)
                            break;
                    }
                    return flag;
                }

              }
                catch (Exception e)
                {
                   Console.WriteLine("DictSearch exited with message: "+e.Message);
                    throw;
                }
                
             }

        public static void SolvePuzzle()
        {
            //Example- UBER+COOL=UNCLE

            //List<List<int>> result = new List<List<int>>(stotallength) { };    

            //Taking inputs from user
            Console.WriteLine("Enter Input String 1");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter Input String 2");
            string s2 = Console.ReadLine();
            Console.WriteLine("Enter Output String S");
            string s3 = Console.ReadLine();

            //concatinating strings together
            string stotal = s1 + s2 + s3;

            //finding length of string by Slength  method
            int s1length = Slength(s1);
            int s2length = Slength(s2);
            int s3length = Slength(s3);
            int stotallength = Slength(stotal);

            //finding list of unknowns from the concatenated string
            List<char> unknowns = Unknown(stotal);
            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            Dictionary<char, int> dict2 = new Dictionary<char, int>();
            int unknownlength = unknowns.Count; //number of unknowns

            //with unknown as key and default value 0 as value create dictionary. dict1 to access keys and dict2 to store value of unknown key  
            foreach (var unkn in unknowns)
            {
                dict1.Add(unkn, 0);
                dict2.Add(unkn, 0);
            }
            Console.WriteLine("Printing only 10 outputs");

            //int q = new int();
            for (int q = Convert.ToInt32(Math.Pow(10, unknownlength - 1) + 1.0); q < Math.Pow(10, unknownlength); q++)
            //with number starting from 0 to max number possible with unknowns i.e if 2 unknowns 00 to 99, create dictionary each time and
            //call for its value
            //for (int q = 0; q < Math.Pow(10, unknownlength); q++)
            {
                //string1list.Add(q);
                // Console.Write(q+ " ");
                int nn = q;
                int temp = 0;

                //unknownnumberasslist[r] = numbass % (Math.Pow(10,r));

                while (nn > 0)
                {
                    dict2[unknowns[temp]] = nn % 10;
                    temp++;
                    nn = nn / 10;
                }
                //Console.WriteLine();



                //Console.WriteLine(s1 + " " + s2 + " " + s3);

                string str1 = Cal2(s1, dict2);
                string str2 = Cal2(s2, dict2);
                string str3 = Cal2(s3, dict2);
                // Console.WriteLine(str1 + " " + str2 + " " + str3);
                Cal1(str1, str2, str3, s1, s2, s3);
            }

            return;
        }

        static int count = 0;
        public static void Cal1(string s1, string s2, string s3, string str1, string str2, string str3)
        {

            if (count > 10) return;
            var int1 = Int64.Parse(s1);
            var int2 = Int64.Parse(s2);
            var int3 = Int64.Parse(s3);
            if (int3 == int1 + int2)
            {
                count++;
                Console.Write(" possible  " + str1 + " = " + s1 + ", " + str2 + " = " + s2 + ", " + str3 + " = " + s3);
                Console.WriteLine();
            }
        }
        public static string Cal2(String s, Dictionary<char, int> dict)
        {

            // Console.WriteLine(s);
            string s2 = "";
            char[] tempArr = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                // Console.Write(tempArr[i]+ " " + dict[tempArr[i]]);
                s2 = s2 + (dict[tempArr[i]]);//*(Math.Pow(10, k1));

            }
            //Console.WriteLine(s2);
            return s2;

        }
        public static int Slength(String s)
        {
            int length = 0;

            foreach (char m1 in s)
            {

                length++;

            }
            return length;

        }
        public static List<char> Unknown(String s)
        {
            int unknowns = 0;
            List<char> L = new List<char>() { };
            foreach (char st in s)
            {
                if (!L.Contains(st))
                {
                    L.Add(st);
                    unknowns++;
                }
            }
            return L;
        }


    }
}