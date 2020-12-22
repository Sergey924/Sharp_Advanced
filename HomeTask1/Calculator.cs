using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask1
{
    // Задание № 3
    class Calculator<T1,T2>
    {
        public double Add(T1 FirstNum, T2 SecondNum)
        {
            double res = 0.0;

            if ((typeof(T1) == typeof(double)) && (typeof(T2) == typeof(double)))
            {
                res = Convert.ToDouble(FirstNum) + Convert.ToDouble(SecondNum);

                return res;
                
            }
            else
            {
                return res;
            } 
        }

        public double Subtraction(T1 FirstNum, T2 SecondNum)
        {
            double res = 0.0;

            if ((typeof(T1) == typeof(double)) && (typeof(T2) == typeof(double)))
            {
                res = Convert.ToDouble(FirstNum) - Convert.ToDouble(SecondNum);

                return res;

            }
            else
            {
                return res;
            }
        }

        public double Multiplication(T1 FirstNum, T2 SecondNum)
        {
            double res = 0.0;

            if ((typeof(T1) == typeof(double)) && (typeof(T2) == typeof(double)))
            {
                res = Convert.ToDouble(FirstNum) * Convert.ToDouble(SecondNum);

                return res;

            }
            else
            {
                return res;
            }
        }

        public double Division(T1 FirstNum, T2 SecondNum)
        {
            double res = 0.0;

            if ((typeof(T1) == typeof(double)) && (typeof(T2) == typeof(double)))
            {
                res = Convert.ToDouble(FirstNum) / Convert.ToDouble(SecondNum);

                return res;

            }
            else
            {
                return res;
            }
        }
    }
}
