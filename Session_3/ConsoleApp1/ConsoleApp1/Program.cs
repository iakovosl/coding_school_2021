using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            //question1
            //string line = "lorem ipsum dolor sit amet consectetur adipiscing elit.";
            //string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            //string word = "";
            //int ctr = 0;
            //foreach (String s in words) {
            //if (s.Length > ctr) {
            //word = s;
            //ctr = s.Length;
            //}
            //}

            //Console.WriteLine("The longest word is: " +word);
            //Console.WriteLine("The longest word with uppercase is: " + word.ToUpper());
            //Console.ReadLine();

            //question2
            //Console.Write("Enter a String : ");
            //string originalString = Console.ReadLine();
            //string reverseString = string.Empty;
            //for (int i = originalString.Length - 1; i >= 0; i--) {
            //    reverseString += originalString[i];
            //}
            //Console.Write($"Reverse String is : {reverseString} ");
            //Console.ReadLine();

            //question3
            //int i, n, sum = 1;
            //Console.Write("Please enter a number: ");
            //n = Int32.Parse(Console.ReadLine());
            //Console.Write("What would you like to compute? The sum (1) or the product (2): ");
            //switch (Console.ReadLine()) {
            //    case "1":
            //        for (i = 1; i <= n; i++) {
            //             sum += i;
            //         }
            //         Console.WriteLine(sum - 1);
            //         Console.ReadLine();
            //           break;
            //     case "2":
            //       for (i = 1; i <= n; i++) {
            //            sum = sum * i;
            //        }
            //        Console.WriteLine(sum);
            //        Console.ReadLine();
            //        break;
            //}

            //question4
            //int primes = 0;
            //Console.WriteLine("Enter a number");
            //int N = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= N; i++) {
            //bool isPrime = true;
            //for (int j = 2; j <= Math.Sqrt(i); j++) {
            //if (i % j == 0) {
            //isPrime = false;
            //}

            //}
            //if (isPrime) {
            //Console.WriteLine(i + " is a prime number");
            //primes++;
            //}
            //}
            //Console.WriteLine("Between 1 to " + N + " there are " + primes + " prime numbers");
            //Console.ReadLine();

            //question5
            //int[] first_array = { 2, 4, 9, 12 };
            //int[] second_array = { 1, 3, 7, 10 };

            //Console.WriteLine("\nArray1: [{0}]", string.Join(", ", first_array));
            //Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));

            //Console.WriteLine("\nMultiply corresponding elements of two arrays: ");

            //for (int i = 0; i < first_array.Length; i++) {

            //    Console.Write(first_array[i] * second_array[i] + " ");
            //}
            //Console.WriteLine("\n");
            //Console.ReadLine();

            //question6
            // declaring and initializing the array
            //int[] arr = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

            // Sort array in ascending order.
            // Array.Sort(arr);

            // print all element of array
            //foreach (int value in arr) {
            // Console.Write(value + " ");
            // }

            // Console.ReadLine();


        }
    }
}
