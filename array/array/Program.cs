﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace array
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 5;
            arr[1] = 10;
            arr[2] = 15;
            arr[3] = 20;
            arr[4] = 25;
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);  
            }
        }
    }
        
}