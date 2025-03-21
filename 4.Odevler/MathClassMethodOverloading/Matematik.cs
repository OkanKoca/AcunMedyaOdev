using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClassMethodOverloading
{
    class Matematik
    {
        public double Topla(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Cikar(double number1, double number2)
        {
            return number1 - number2;
        }
        public double Carp(double number1, double number2)
        {
            return number1 * number2;
        }
        public double Bol(double number1, double number2)
        {
            return number1 / number2;
        }

        public int Topla(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Cikar(int number1, int number2)
        {
            return number1 - number2;
        }
        public int Carp(int number1, int number2)
        {
            return number1 * number2;
        }
        public int Bol(int number1, int number2)
        {
            return number1 / number2;
        }


        //overloaded topla int
        public int Topla(int number1, int number2, int   number3)
        {
            return number1 + number2 + number3;
        }

        //overloaded carp int
        public int Carp(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //overloaded topla
        public double Topla(double number1, double number2, double number3)
        {
            return number1 + number2 + number3;
        }

        //overloaded carp
        public  double Carp(double number1, double number2, double number3)
        {
            return number1 * number2 * number3;
        }
    }
}
