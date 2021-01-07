using System;

namespace HomeWork3
{
    class Program
    {

        delegate int MyDelegate(int a, int b, int c);

        delegate int Operation(int a, int b);

        delegate double Anonim(Operation[] operations);
      

        static void Main(string[] args)
        {
            #region Задание 1
            MyDelegate delegate1 = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3;

            };
            #endregion Задание 1

            #region Задание 2
            Operation[] OperationArray = new Operation[4];

            Operation Add = (a, b) => { return a + b; };

            Operation Subtraction = (a, b) => { return a - b; };

            Operation Multiplication = (a, b) => {return a * b; };

            Operation Division = (a, b) => { if (b != 0)
                {
                    return a / b;
                }
                else
                    return 0;
            };

            OperationArray[0] = Add;
            OperationArray[1] = Subtraction;
            OperationArray[2] = Multiplication;
            OperationArray[3] = Division;

            #endregion Задание 2

            #region Задание 3
            Anonim anonim = delegate (Operation[] operations)
            {
               double res = 0;

                for (int i = 0; i < operations.Length; i++)
                {
                    Random rnd = new Random();
                  
                   res = operations[i].Invoke(3,3);
                    Console.WriteLine(res);
                }
                return res;
            };
            Console.WriteLine(anonim.Invoke(OperationArray));
            #endregion Задание 3

        }
    }
}
