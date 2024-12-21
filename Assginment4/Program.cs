using System.Text;
using System.Linq;

namespace Assginment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DEMO

            #region Loop Statements
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine($"{i} T");
            //}
            #endregion

            #region for - foreach

            //int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};


            // print with for

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    //numbers[i] += 10;

            //    if (numbers[i] == 5)
            //    {
            //        break; //  -> to stop if == 5
            //        //continue; // -> to skip if == 5 and continue after

            //    }
            //    Console.WriteLine(numbers[i]);
            //}


            //print with foreach
            // Class implement interface IEnumerable 

            //foreach (int number in numbers)
            //{
            //    //number += 10; not working 3shan da copy msh original
            //    Console.WriteLine(number);
            //}



            #endregion

            #region While - Do While

            //int num;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter Even Number");
            //    //num = int.Parse(Console.ReadLine());
            //    // num => string [Runtime Error]

            //    flag = int.TryParse(Console.ReadLine(),out num);

            //} while (num % 2 == 1 || !flag );



            //Console.WriteLine($"{num } is even");


            //int num = 3;
            //bool flag = false;
            //while (num % 2 ==1 || !flag)
            //{
            //    Console.WriteLine("Enter Even Number");
            //    flag = int.TryParse(Console.ReadLine(),out num);

            //}
            //Console.WriteLine($"{num } is even");






            #endregion

            #region String
            // Class => Reference Type
            // immutable Data Type [Value can not be changed]
            // Array of characters


            //load string => hy-check for the value law = hy5aly l hashcode same

            //string name01 ="Ahmed";
            //string name02 = "Ahmed";

            //Console.WriteLine(name01);
            //Console.WriteLine($"Name01 HC : {name01.GetHashCode()}");
            //Console.WriteLine(name02);
            //Console.WriteLine($"Name02 HC : {name02.GetHashCode()}");


            //string name01 = "Ahmed";
            //string name02 = "Ali";

            //Console.WriteLine(name01);
            //Console.WriteLine($"Name01 HC : {name01.GetHashCode()}");
            //Console.WriteLine(name02);
            //Console.WriteLine($"Name02 HC : {name02.GetHashCode()}");


            //name02 = name01;
            //Console.WriteLine("---------- name02 = name01-------");
            //Console.WriteLine(name01);
            //Console.WriteLine($"Name01 HC : {name01.GetHashCode()}");
            //Console.WriteLine(name02);
            //Console.WriteLine($"Name02 HC : {name02.GetHashCode()}");


            //name01 = "Mostafa";
            //Console.WriteLine("---------- name01 = mostafa -------");
            //Console.WriteLine(name01);
            //Console.WriteLine($"Name01 HC : {name01.GetHashCode()}");
            //Console.WriteLine(name02);
            //Console.WriteLine($"Name02 HC : {name02.GetHashCode()}");


            //// string -> fixed size array 

            //string message = "Hello";

            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());

            //message += " Route";

            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());

            #endregion

            #region StringBuilder
            // class reference type
            // linked list of characters


            //StringBuilder message; // 4bytes stack  0bytes heap

            //message = new StringBuilder("Hello");

            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());

            //// message += "Route";
            //message.Append(" Route");





            #endregion

            #region String Builder Methods

            //StringBuilder message = new StringBuilder("Welcome");

            //message.Append("To Route");
            //message.AppendLine("To Route");
            //Console.WriteLine(message);
            //message.Append("Samar");
            //Console.WriteLine(message);


            //message.Remove(0, 7);
            //Console.WriteLine(message);


            //message.Insert(0, "Hello");
            //Console.WriteLine(message);



            //int age = 10;
            //string name = "samar";
            //message.AppendFormat($"Name: {name} , Age: {age}");



            //message.AppendJoin("/", "Mostafa" , "Hany","Mohamed",2);


            // law kol shewya h3'ayr l value -> string
            // law l value msh htt3'ayr kol shewya -> StringBuilder
            #endregion

            #region Arrays
            #region Array 1D
            // one dimension Array
            // can not modify array size in direct way

            // int[] numbers = new int[3]; // 3*4 in heap  4 in stack
            //int[] numbers = new int[3] { 1, 2, 3 };
            //int[] numbers = { 1, 2, 3 };

            // insert in array
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //use for loop
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = i+1;
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(numbers.Rank); // 1D




            #endregion

            #region Array 2D
            // Two dimensional Array
            //1. Rectangular Array

            #region Rectangular Array

            //int[,] marks = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 },{ 100 ,200, 300 , 400 , 500 } };
            //Console.WriteLine(marks.Length);
            //Console.WriteLine(marks.Rank); // 2 3shan 2D
            //Console.WriteLine(marks.Length);
            //Console.WriteLine(marks.GetLength(0)); // rows
            //Console.WriteLine(marks.GetLength(1)); // columns

            //for (int row = 0; row < marks.GetLength(0); row++)
            //{
            //    Console.WriteLine($"Enter Grades Student({row+1}) ");
            //    for(int col=0; col<marks.GetLength(1); /*col++*/)
            //    {
            //        bool flag;
            //        Console.Write($"Enter Grade Subject[{col + 1}: ]");
            //        //marks[row,col] = int.Parse(Console.ReadLine());
            //        flag =int.TryParse(Console.ReadLine(), out marks[row, col]);

            //        col = flag && marks[row, col] >=0 ? ++col : col;

            //        //if (flag && marks[row,col] >=0)
            //        //{
            //        //    col++;
            //        //}
            //    }
            //}

            // another answer to print 2D array
            //for(int i =0; i<marks.Length;i++)
            //{
            //    Console.WriteLine(marks[i / marks.GetLength(1), i % marks.GetLength(1)]);
            //}
            #endregion

            //2. Judged Array

            #region Judged Array
            // 1D array of arrays

            //int[][] numbers = new int[3][];

            //numbers[0] = new int[3] {1,2,3};
            //numbers[1] = new int[2] {4,5};
            //numbers[2] = new int[1] {6};

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    for(int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.WriteLine(numbers[i][j]);
            //    }
            //}


            #endregion

            #endregion

            #endregion



            #endregion


            //---------------------------------------------------------

            #region Assignment 4

            #region Q1.Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Enter Positive number");
            //int num = int.Parse(Console.ReadLine());
            //if (num > 0)
            //{
            //    for (int i = 1; i <= num; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Q2.Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("Enter Positive number");
            //int num = int.Parse(Console.ReadLine());
            //if (num > 0)
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.WriteLine(num * i);
            //    }
            //}
            #endregion

            #region Q3.Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.WriteLine("Enter Positive number");
            //int num = int.Parse(Console.ReadLine());
            //if (num > 0)
            //{
            //    for (int i = 1; i < num; i++)
            //    {
            //        if (i % 2 == 0)
            //            Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Q4.Write a program that takes two integers then prints the power.
            //Console.Write("Enter  number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter power: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(Math.Pow(num1, num2));

            //// OR
            //int pow =num1;
            //for(int i=1; i<num2;i++)
            //{
            //    pow *= num1;
            //}
            //Console.WriteLine(pow);
            #endregion

            #region Q5.Write a program to allow the user to enter a string and print the REVERSE of it
            //Console.WriteLine("Enter String");
            //string text = Console.ReadLine();

            //for(int i = text.Length-1; i >=0; i--)
            //{
            //    Console.Write(text[i]);
            //}


            #endregion

            #region Q6.Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Enter start number: ");
            //int strt = int.Parse(Console.ReadLine());

            //Console.Write("Enter end number: ");
            //int end = int.Parse(Console.ReadLine());


            //Console.WriteLine("Prime numbers are:");

            //for(int i = strt; i<= end;i++)
            //{
            //    if (isPrime(i))
            //        Console.Write($"{i} ");
            //}

            #endregion

            #region Q7.Write a program in C# Sharp to convert a decimal number into binary without using an array

            //Console.Write("Enter a number to convert: ");
            //string binary= string.Empty ;
            //if (int.TryParse(Console.ReadLine(), out int num) && num >= 0)
            //{
            //    if (num == 0)
            //        binary = "0";
            //    else
            //        while (num > 0)
            //        {
            //            binary = (num % 2) + binary;
            //            num /= 2;
            //        }
            //    Console.WriteLine(binary);
            //}



            #endregion

            #region Q8.Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.Write("Enter number: ");
            //if(int.TryParse(Console.ReadLine(), out int num) && num > 0)
            //{
            //    for (int i=0; i<num;i++)
            //    {
            //        for(int j=0 ; j<num;j++)
            //        {
            //            if (i == j)
            //                Console.Write("1");
            //            else
            //                Console.Write("0");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            #endregion

            #region Q9.Write C# program that Extract a substring from a given string.

            //Console.WriteLine("Enter String");
            //string text = Console.ReadLine();

            //Console.Write("Enter starting point: ");
            //if(int.TryParse(Console.ReadLine() , out int strt) && strt >=0 && strt < text.Length)
            //{
            //    Console.Write("Enter End point: ");
            //    if (int.TryParse(Console.ReadLine() , out int length) &&  length > 0 && strt + length < text.Length)
            //    {
            //        Console.WriteLine(text.Substring(strt,length));
            //    }
            //}




            #endregion

            #region Q10.Write C# program that take two string variables and print them as one variable 

            //Console.WriteLine("Enter first string");
            //string str1 = Console.ReadLine();


            //Console.WriteLine("Enter first string");
            //string str2 = Console.ReadLine();

            //Console.WriteLine(string.Concat(str1, str2));

            #endregion

            #region Q11.Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.Write("Enter number: ");
            //if(int.TryParse(Console.ReadLine(), out int num) && num > 0)
            //{
            //    for (int i=0; i<num;i++)
            //    {
            //        for(int j=0 ; j<num;j++)
            //        {
            //            if (i == j)
            //                Console.Write("1");
            //            else
            //                Console.Write("0");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            #endregion

            #region Q12.Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int sum = arr.Sum();

            //OR 

            //int sum = 0;
            //for( int i =0; i< arr.Length;i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine($"sum = {sum}");

            #endregion

            #region Q13. Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] arr01 = { 1, 4, 3, 2 };
            //int[] arr02 = { 5, 7, 6, 8 };

            //if (arr01.Length == arr02.Length)
            //{
            //    int[] mergedArr = arr01.Union(arr02).ToArray();

            //    Array.Sort(mergedArr);
            //    foreach (int i in mergedArr)
            //    {
            //        Console.Write(i);
            //    }
            //}



            #endregion

            #region Q14.Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] nums = {1,2,3,4,3,2,5};
            //int[] freq = new int[nums.Length];
            //int count;


            //// change default val in freq array from 0 to -1
            //for(int i =0; i < freq.Length;i++)
            //{
            //    freq[i] = -1;
            //}
            
            //// modify in frequency table
            //for(int i =0;i<nums.Length;i++)
            //{
            //    count = 1;
            //    for(int j = i+1;j<nums.Length;j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            count++;
            //            freq[j] = 0;
            //        }

            //    }
            //    if (freq[i] != 0)
            //        freq[i] = count;
            //}
          

            //// print
            //for (int i=0;i<freq.Length;i++)
            //{
            //    if (freq[i]!=0)
            //    {
            //        Console.WriteLine($"{nums[i]} frequency is {freq[i]}");
            //    }
            //}
            




            #endregion

            #region Q15. Write a program in C# Sharp to find maximum and minimum element in an array


            //int[] arr = { 100, 3, 40, 222, 653, 039, 655, 2 };

            //Console.WriteLine($"Maximum: {arr.Max()}");
            //Console.WriteLine($"Minimum: {arr.Min()}");






            #endregion

            #region Q16. Write a program in C# Sharp to find the second largest element in an array.

            //int[] arr = { 100, 3, 40, 222, 653, 039, 655, 2 };

            //Array.Sort(arr);
            //Console.WriteLine($"Second Largest number is {arr[arr.Length - 2]}");



            #endregion

            #region Q17. Consider an Array of Integer values with size N, having values as in this Example

            //Console.WriteLine("Please enter array size");
            //if (int.TryParse(Console.ReadLine(),out int size) && size >0)
            //{
            //    int[] arr = new int[size];

            //    //int[] arr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };

            //    // get array values
            //    Console.WriteLine($"Please enter {size} numbers ");
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        int.TryParse(Console.ReadLine(), out arr[i]);
            //    }

            //    //get the number
            //    Console.WriteLine("enter the number to find the longest distance");
            //    int num = int.Parse(Console.ReadLine());

            //    int index = Array.IndexOf(arr, num);

            //    //Console.WriteLine(index);

                
            //        for (int i = arr.Length - 1; i > index; i--)
            //        {
            //            if(arr[i] == arr[index])
            //            {
            //                i--;
            //                Console.WriteLine(i - index);
            //                break; 
            //            }

            //        }
                

            //}


            #endregion

            #region Q18.Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //int[,] arr = new int[2, 3];
            //int[,] arrNew = new int[2,3];

            //// get elements from user
            //for (int row=0; row < arr.GetLength(0); row++)
            //{
            //    Console.WriteLine("Enter 3 numbers");
            //    for(int col =0; col < arr.GetLength(1);col++)
            //    {
            //        arr[row,col]= int.Parse(Console.ReadLine());
            //    }
            //}

            //// copy all values
            //for (int row = 0; row < arrNew.GetLength(0); row++)
            //{
            //    for (int col = 0; col < arrNew.GetLength(1); col++)
            //    {
            //        arrNew[row,col] = arr[row,col];
            //        Console.Write($"{arrNew[row, col]} ");
            //    }
            //    Console.WriteLine();
            //}






            #endregion

            #region Q19. Write a Program to Print One Dimensional Array in Reverse Order

            //int[] arr = { 10, 20, 30, 40, 50 };


            //for(int i=arr.Length-1; i>=0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            #endregion






            #endregion

        }



        static bool isPrime(int num)
        {
            if (num <= 1)
                return false;

            for(int i=2; i<= num/2;i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
