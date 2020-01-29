using System;

namespace HW_EX_3A_Calculating_Averages
{
    class Program
    {
        

        static void Main(string[] args)
        {

         
            Console.WriteLine( " Input ten school grade Values ranging from 0...100 : " ) ;

            int grade1 =int.Parse(Console.ReadLine() ) ;

            int grade2= int.Parse(Console.ReadLine() ) ;
                
            int grade3= int.Parse(Console.ReadLine() ) ;
                
            int grade4= int.Parse(Console.ReadLine() ) ;
                
            int grade5= int.Parse(Console.ReadLine() ) ;
                
            int grade6= int.Parse(Console.ReadLine() ) ;
               
            int grade7= int.Parse(Console.ReadLine() ) ;
                
            int grade8= int.Parse(Console.ReadLine() ) ;
               
            int grade9= int.Parse(Console.ReadLine() ) ;
                
            int grade10 = int.Parse(Console.ReadLine() ) ;

            // implement adding the sums

            Console.WriteLine("The sum of the ten values is : {0} ", AddValues(grade1, grade2, grade3, grade4, grade5, grade6, grade7, grade8, grade9, grade10));


            // implement dividing ten values for the final grade with grade letter


            Console.WriteLine("The average of the ten test scores is: {0} ", DivideValues(grade1, grade2, grade3, grade4, grade5, grade6, grade7, grade8, grade9, grade10));

           

            //implement dividing specific number of values for the final grade with grade letter


            Console.WriteLine( "Input an arbitrary number of test scores to find the final grade: " ) ;

            
            int input = int.Parse(Console.ReadLine());

           
            Console.WriteLine("Insert test scores equivalent to the input ");




            



            //implement dividing an unknown number of values for the final grade with grade letter

            

            
            
          
        }

        static double AddValues(int grade1, int grade2, int grade3, int grade4, int grade5, int grade6, int grade7, int grade8, int grade9, int grade10)
        {
            int addValues;

            addValues =grade1 + grade2 + grade3 + grade4 + grade5 + grade6 + grade7 + grade8 + grade9 + grade10;

            return addValues;
        }

        static double DivideValues(int grade1, int grade2, int grade3, int grade4, int grade5, int grade6, int grade7, int grade8, int grade9, int grade10)
        {
            int divideValues;

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


        

        


        
        
        
    

