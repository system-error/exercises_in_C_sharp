using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace exercises_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroduceMySelf();
            Console.WriteLine();
            Addition();
            Console.WriteLine();
            Division();
            Console.WriteLine();
            Operations1();
            Console.WriteLine();
            Swap2Numbers();
            //Console.WriteLine();
            //MultiByUser();
            //Console.WriteLine();
            //Operations2();
            //Console.WriteLine();
            //MultiTable();
            //Console.WriteLine();
            //Average();
            //Console.WriteLine();
            //Operations3();
            //Console.WriteLine();
            //Age();
            //Console.WriteLine();
            //Border1();
            //Console.WriteLine();
            //Border2();
            //Console.WriteLine();
            //Check1();
            //Console.WriteLine();
            //Check2();
            //Console.WriteLine();
            //OddOrEven();
            //Console.WriteLine();
            //NegativeOrPossitive();
            //Console.WriteLine();
            //TheHeight();
            //Console.WriteLine();
            //FindTheMax();
            //Console.WriteLine();
            //EligibilityOfAdmission();
            //Console.WriteLine();
            //FindTheTemp();
            //Console.WriteLine();
            //ReverseTheLetters();
            //Console.WriteLine();
            //FindTheAlphabet();
            //Console.WriteLine();
            //AcceptTheGrade();
            //Console.WriteLine();
            //TellMeTheDay();
            //Console.WriteLine();
            //Console.WriteLine();
            //DoTheStaff();
            //Console.WriteLine();
            //NaturalNumbers();
            //Console.WriteLine();
            //SumOfNaturalNumbers();
            //Console.WriteLine();
            //GivenTheNaturalNumbers();
            //Console.WriteLine();
            //Numbers();
            //Console.WriteLine();
            //FindTheCube();
            Console.WriteLine();
            Geometry();
            Console.WriteLine();





        }

        public static void IntroduceMySelf()
        {
            string name = "Christos Dousmanopoulos";

            Console.WriteLine("Hello my name is: \n{0}", name);
            //Console.WriteLine(name);
            Console.WriteLine();
        }


        public static void Addition()
        {
            int a = 5, b = 3, sum;
            Console.WriteLine("The sum is: {0}", sum = a + b);
        }

        public static void Division()
        {
            float c = 5.0F, d = 3.0F, Div;
            Console.WriteLine("The sum is: {0}", Div = c / d);
        }

        public static void Operations1()
        {
            int e = 5, f = 6, g = 9, sum1, mult;
            float h = 32.0F, i = 12.0F, div;
            Console.WriteLine("The sum is: {0},\nthe multiplication is {1},\nand the division is: {2} ", sum1 = e + f,
                mult = g * f, div = (h * i / i % i));
        }

        public static void Swap2Numbers()
        {
            int swap1 = 5, swap2 = 3, temp;
            temp = swap1;
            swap1 = swap2;
            swap2 = temp;
            Console.WriteLine("The result is:\nswap1 = {0}\nswap2 = {1}", swap1, swap2);
        }

        public static void MultiByUser()
        {
            Console.WriteLine("For multiplication you must put 3 numbers:");
            Console.Write("Number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int result = number1 * number2 * number3;
            Console.WriteLine(result);
        }

        public static void Operations2()
        {
            Console.WriteLine("Give me 2 numbers:");
            Console.Write("Number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int addition, substracting, multiplying;
            float division;
            addition = number1 + number2;
            substracting = number1 - number2;
            multiplying = number1 * number2;
            division = (float) number1 / (float) number2;
            Console.WriteLine(
                "The addition result is: {0}\nThe substracting result is: {1}\nThe multiplication result is: {2}\nThe division result is: {3}",
                addition, substracting, multiplying, division);
        }

        public static void MultiTable()
        {
            Console.WriteLine("Give me a number:");
            Console.Write("Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0} times from {1} = {2}", i, number, i * number);
            }
        }

        public static void Average()
        {
            Console.WriteLine("For average you must put 4 numbers:");
            Console.Write("Number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 4: ");
            int number4 = Convert.ToInt32(Console.ReadLine());
            float result = (number1 + number2 + number3 + number4) / 4.0F;
            Console.WriteLine(result);
        }

        public static void Operations3()
        {
            Console.WriteLine("Give me 3 numbers:");
            Console.Write("Number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int result1 = (number1 + number2) * number3, result2 = number1 * number3 + number2 * number3;
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        public static void Age()
        {
            Console.WriteLine("Give me your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 20)
            {
                Console.WriteLine("You look younger than 20");
            }
            else
            {
                Console.WriteLine("You look older than 20");
            }
        }

        public static void Border1()
        {
            Console.Write("Give me a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int rows = 4;
            int columns = 4;
            //25 25 25 25
            //25 25 25 25
            //25 25 25 25
            //25 25 25 25

            for (int i = 0; i < rows; i++) //25
                //25
                //25
                //25
            {
                for (int j = 0; j < columns; j++) //25 25 25 25
                {
                    Console.Write(number);
                    Console.Write(" ");

                }

                Console.WriteLine(); //25
                //25
                //25
                //25
            }
        }

        public static void Border2()
        {
            Console.Write("Give me a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int rows = 5;
            int columns = 3;
            //25 25 25
            //25    25
            //25    25
            //25    25
            //25 25 25

            for (int i = 0; i < rows; i++) //25
                //25
                //25
                //25
            {
                for (int j = 0; j < columns; j++) //25 25 25 25
                {
                    if (j == 1 && i != 4 && i != 0)
                    {
                        Console.Write("  ");
                        continue;
                    }

                    Console.Write(number);
                    Console.Write(" ");

                }

                Console.WriteLine(); //25
                //25
                //25
                //25
            }
        }

        public static void Check1()
        {
            Console.Write("Give me a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 20 && number <= 100 || number == 200)
            {
                Console.WriteLine("The number is right");
            }
            else
            {
                Console.WriteLine("The number is not the right one");
            }
        }

        public static void Check2()
        {
            Console.WriteLine("Give me 2 numbers:");
            Console.Write("Number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                Console.WriteLine("The numbers are not equal");
            }
        }

        public static void OddOrEven()
        {
            Console.Write("Give me a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }

        public static void NegativeOrPossitive()
        {
            Console.Write("Give me a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else if (number > 0)
            {
                Console.WriteLine("The number is possitive");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
        }

        public static void TheHeight()
        {
            Console.Write("Give me your height:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 140)
            {
                Console.WriteLine("Dwarf");
            }
            else if (number == 140 || number < 160)
            {
                Console.WriteLine("Small");
            }
            else if (number == 160 || number < 180)
            {
                Console.WriteLine("Normal");
            }
            else
            {
                Console.WriteLine("Tall");
            }
        }

        public static void FindTheMax()
        {
            int[] arrayWithNumbers = new int[3];

            Console.WriteLine("Give me 3 numbers:");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                int number = Convert.ToInt32(Console.ReadLine());
                arrayWithNumbers[i] = number;
            }

            int maxNumber = arrayWithNumbers.Max();
            Console.WriteLine("The max number is: {0}", maxNumber);
        }

        public static void EligibilityOfAdmission()
        {
            float sum = 0.0F;
            string[] arrayCourses = new String[] {"Maths", "Physics", "Chemistry"};
            Dictionary<string, int> dictCourses = new Dictionary<string, int>();
            Console.WriteLine("Give your marks please:");

            foreach (var item in arrayCourses)
            {
                Console.Write("Input the marks obtained in {0}: ", item);
                int number = Convert.ToInt32(Console.ReadLine());
                dictCourses.Add(item, number);
                sum += number;

            }

            if (dictCourses[arrayCourses[0]] >= 65 && dictCourses[arrayCourses[1]] >= 55 &&
                dictCourses[arrayCourses[2]] >= 50 && sum >= 180)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if (sum >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }

        public static void FindTheTemp()
        {
            decimal temperature;
            Console.WriteLine("Give me the temperature:");
            Console.Write("Temperature: ");
            temperature = Convert.ToDecimal(Console.ReadLine());

            if (temperature < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temperature == 0 || temperature < 10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temperature == 10 || temperature < 20)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temperature == 20 || temperature < 30)
            {
                Console.WriteLine("Normal");
            }
            else if (temperature == 30 || temperature < 40)
            {
                Console.WriteLine("Its Hot");
            }
            else
            {
                Console.WriteLine("Its Very Hot");
            }
        }

        public static void ReverseTheLetters()
        {
            string text, reversedtext;
            reversedtext = "";
            Console.WriteLine("Give me the letters:");
            Console.Write("Letters: ");
            text = Console.ReadLine();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedtext += text[i];
            }

            Console.WriteLine(reversedtext);
        }

        public static void FindTheAlphabet()
        {
            string alphabet = "";
            Console.WriteLine("Give me your word");
            Console.Write("Letters: ");
            alphabet = Console.ReadLine();
            int letters = alphabet.Count("aeiouAEIOU".Contains);
            if (letters > 0)
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }


        }

        public static void AcceptTheGrade()
        {
            string grade = "";
            Console.WriteLine("Give me the grade");
            Console.Write("Grade: ");
            grade = Console.ReadLine().ToUpper();


            switch (grade)
            {
                case "A":
                    Console.WriteLine("Average");
                    break;
                case "E":
                    Console.WriteLine("Excellent");
                    break;
                case "F":
                    Console.WriteLine("Fail");
                    break;
                case "G":
                    Console.WriteLine("Good");
                    break;
                case "V":
                    Console.WriteLine("Very Good");
                    break;
                default:
                    Console.WriteLine("Give the right answer");
                    break;
            }


        }

        public static void TellMeTheDay()
        {
            string day = "";
            Console.WriteLine("Give me the day in number");
            Console.Write("Day: ");
            day = Console.ReadLine().ToUpper();

            switch (day)
            {
                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Thursday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Give a number between 1 - 7");
                    break;
            }

        }

        public static void DoTheStaff()
        {
            string[] options = new[] {"1-Addition", "2-Substraction", "3-Multiplication", "4-Division", "5-Exit"};

            int choise, number1, number2;
            Console.WriteLine("Give me the operation in number");
            foreach (var item in options)
            {
                Console.WriteLine(item);
            }

            Console.Write("Choise: ");
            choise = Convert.ToInt32(Console.ReadLine());
            if (choise == 5)
            {
                Console.WriteLine("Good Bye");

            }
            else if (choise <= 0 || choise > 5)
            {
                Console.WriteLine("Choose between 1 - 4");
            }
            else
            {
                Console.WriteLine("Now give me the numbers");
                Console.Write("Number 1: ");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number2: ");
                number2 = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.WriteLine("The Addition of {0} and {1} is: {2}", number1, number2, number1 + number2);
                        break;
                    case 2:
                        Console.WriteLine("The Substraction of {0} and {1} is: {2}", number1, number2,
                            number1 - number2);
                        break;
                    case 3:
                        Console.WriteLine("The Multiplication of {0} and {1} is: {2}", number1, number2,
                            number1 * number2);
                        break;
                    case 4:
                        if (number2 == 0)
                        {
                            Console.WriteLine("Cannot devide with zero");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The Division of {0} and {1} is: {2}", number1, number2,
                                (decimal) number1 / (decimal) number2);
                            break;
                        }
                }
            }


        }

        public static void NaturalNumbers()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.Write("{0} ", i);
            }
        }

        public static void SumOfNaturalNumbers()
        {
            int sum = 0;
            for (int i = 0; i < 11; i++)
            {
                sum += i;

            }

            Console.WriteLine("The sum is: {0} ", sum);
        }

        public static void GivenTheNaturalNumbers()
        {
            int number, sum = 0;
            Console.WriteLine("Give me the N term");
            Console.Write("N term: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number + 1; i++)
            {
                Console.Write("{0} ", i);
                
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine("The sum is: {0} ", sum);

        }

        public static void Numbers()
        {
            List<int> lista = new List<int>();
            int number;
            Console.WriteLine("Give me 10 numbers");
    
            for (int i = 1; i < 11; i++)
            {
                Console.Write("number {0}: ",i);
                number = Convert.ToInt32(Console.ReadLine());
                lista.Add(number);
            }
            var sum = lista.Sum();
            var average = lista.Average();
            
            Console.WriteLine("The sum is: {0}",sum);
            Console.WriteLine("The average is: {0}", average);

        }

        public static void FindTheCube()
        {
            int number, cube = 0;
            
            Console.WriteLine("Give me a number to tell you the cube");
            Console.Write("Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            cube = number * number * number;
            Console.WriteLine("The cube of {0} is: {1}" ,number,cube);
        }

        // The multiplication table in section 4 is the same from section 1

        public static void Geometry()
        {
            string[] options = new[] { "1-Circle", "2-Rectangle", "3-Triangle"};

            int choise, radius, length, width, recArea, triBase, triHeight;
            const double pi = 3.14159265;
            double ciArea,triArea;

            Console.WriteLine("Give me the area that you want to find: ");
            foreach (var item in options)
            {
                Console.WriteLine(item);
            }

            Console.Write("Choise: ");
            choise = Convert.ToInt32(Console.ReadLine());

            if (choise <= 0 || choise > 3)
            {
                Console.WriteLine("Choose between 1 - 3");
            }
            else
            {
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Give me the radius of the circle");
                        Console.Write("Radius: ");
                        radius = Convert.ToInt32(Console.ReadLine());
                        ciArea = pi * (radius * radius);
                        Console.WriteLine("The Area is: {0}" , Math.Round(ciArea, 2));
                        break;
                    case 2:
                        Console.WriteLine("Give me the width and length of the rectangle");
                        Console.Write("Width: ");
                        width = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Length: ");
                        length = Convert.ToInt32(Console.ReadLine());
                        recArea = width * length;
                        Console.WriteLine("The Area is: {0}", recArea);
                        break;
                    case 3:
                        Console.WriteLine("Give me the base and the height of the triangle");
                        Console.Write("Base: ");
                        triBase = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Height: ");
                        triHeight = Convert.ToInt32(Console.ReadLine());
                        triArea = (triBase * triHeight) / 2;
                        Console.WriteLine("The Area is: {0}", Math.Round(triArea, 2));
                        break;

                }
            }




        }

    


}




}
