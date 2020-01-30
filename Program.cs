using System;

namespace HW_EX_3A_Calculating_Averages
{
    class Program
    {
      


        static void Main(string[] args)
        {

         
            Console.WriteLine( " Input ten school grade Values ranging from 0...100 : " ) ;

            double grade1 =int.Parse(Console.ReadLine());

            double grade2= int.Parse(Console.ReadLine());

            double grade3 = int.Parse(Console.ReadLine());

            double grade4 = int.Parse(Console.ReadLine());

            double grade5 = int.Parse(Console.ReadLine());

            double grade6 = int.Parse(Console.ReadLine());

            double grade7 = int.Parse(Console.ReadLine());

            double grade8 = int.Parse(Console.ReadLine());

            double grade9 = int.Parse(Console.ReadLine());

            double grade10 = int.Parse(Console.ReadLine());

            // implement adding the sums

            Console.WriteLine("The Sum of the ten values is : {0} ", AddValues(grade1, grade2, grade3, grade4, grade5, grade6, grade7, grade8, grade9, grade10));         
            


            // implement dividing ten values for the final grade with grade letter


            Console.WriteLine("The average of the ten test scores is: {0} ", DivideValues(grade1, grade2, grade3, grade4, grade5, grade6, grade7, grade8, grade9, grade10));
       

            
            // Implement a non-specific number of test scores and average them for the final grade



            double sumA = 0;

            double countB = 0;

            string input = "";          


            do
            {

                Console.WriteLine("Next Integer or type STOP: ");

                input = Console.ReadLine();

                if (input != "-1");
                {
                    sumA += int.Parse(input);

                    countB += 1;
                }
            }
              while (input != "-1");

                Console.WriteLine($"The Average is : {sumA / countB}");



            Console.WriteLine("Input an arbitrary number of test scores to find the final grade average: ");

            int sum = 0;

            int count = 0;

            
            for (double i = 0; i <= 10; i++)
            {

                Console.WriteLine("Enter the next integer: ");

                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The Average is : {sum / count}");



        }

        static double AddValues(double grade1, double grade2, double grade3, double grade4, double grade5, double grade6, double grade7, double grade8, double grade9, double grade10)
        {
            double addValues;

            addValues =grade1 + grade2 + grade3 + grade4 + grade5 + grade6 + grade7 + grade8 + grade9 + grade10;

            return addValues;
        }

        static double DivideValues(double grade1, double grade2, double grade3, double grade4, double grade5, double grade6, double grade7, double grade8, double grade9, double grade10)
        {
            double divideValues;

            divideValues = (grade1 + grade2 + grade3 + grade4 + grade5 + grade6 + grade7 + grade8 + grade9 + grade10) / 10;

           

            if (divideValues <= 60)
           {
                Console.WriteLine (" Grade : F ");
           }

            else if (divideValues <= 70)
            {
                Console.WriteLine(" Grade : D ");
            }

            else if (divideValues <= 80 )
            {
                Console.WriteLine(" Grade : C ");
            }

            else if (divideValues <= 90)
            {
                Console.WriteLine(" Grade : B ");
            }

           else if (divideValues <= 100)
            {
                Console.WriteLine(" Grade : A ");
            }

            return divideValues;

        }




    }



}


        

        


        
        
        
    

