﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridemethos
{
    class Program
    {
        //int Power(int input)
        //{
        //    return input * input;
        //}
        //int Power(int input, int count)
        //{
        //    int num = 0;
        //    for (int i = 0; i < count; i++)
        //        num += input;
        //    return num;
        //}
        //int SumAll(int end)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < end; i++)
        //        sum += i;
        //    return sum;
        //}
        //int SumAll(int start, int end)
        //{
        //    int sum = 0;
        //    for (int i = start; i < end; i++)
        //        sum += i;
        //    return sum;
        //}

        static int Abs(int input)
        {
            return input > 0 ? input : -input;
        }
        static double Abs(int input)
        {
            return input > 0 ? input : -input;
        }
        static long Abs(long input)
        {
            return input > 0 ? input : -input;
        }
        static double Abs(long input)
        {
            return input > 0 ? input : -input;
        }
        static void Main(string[] args)
        {
        }
    }
}
