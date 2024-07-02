﻿using System;
using System.Collections.Generic;
public class Program
    {
        public static void Main(string[] args)
        {
            // Common-Elements
            int[] newArr = { 5, 10, 15, 20 };
            int[] newArr2 = { 10, 15, 25 };

            int[] output = CommonElements(newArr, newArr2);
            Console.WriteLine("Input: [5, 10, 15, 20]");
            Console.WriteLine("Output: [" + string.Join(", ", output) + "]");

        }
        public static int[] CommonElements(int[] arr1, int[] arr2)
        {
            int[] newArr = new int[Math.Min(arr1.Length, arr2.Length)];
            int count = 0;

            if (arr1 == null || arr2 == null)
            {
                Console.WriteLine("Invalid Inputs!");
                return new int[0];
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        newArr[count] = arr1[i];
                        count++;
                    }
                }
            }

            int[] resultArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                resultArray[i] = newArr[i];
            }

            return resultArray;
        }
    
}