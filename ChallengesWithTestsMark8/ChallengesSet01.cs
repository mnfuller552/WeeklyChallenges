﻿using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double subtract = minuend - subtrahend;
            return subtract;
        }

        public int Add(int number1, int number2)
        {
           int Add = number1  + number2;
            return Add;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
                return number1;
            else
                return number2;
        }

        public long Multiply(long factor1, long factor2)
        {
            long multiply = factor1 * factor2;
            return multiply;
        }

        public string GetGreeting(string nameOfPerson)
        {

            if(nameOfPerson == "")
            {
                return "Hello!";

            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }


        }    

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
