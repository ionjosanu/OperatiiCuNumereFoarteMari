using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatiiCuNumereFoarteMari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Ce operatie doriti sa efectuati?\n" +
                "1 . Adunarea a doua numere foarte mari.\n" +
                //........WORK IN PROGRESS FOR THE OTHER OPERATIONS....
                "Inroduceti cifra : ");
            int operationNumber = int.Parse(Console.ReadLine());
            switch (operationNumber)
            {
                case 1: Adunarea(); ; break;
               
                default:
                    Console.WriteLine("Numarul introdus nu corespunde cerintelor.");
                    break;
            }
        }

        

        private static void Adunarea()
        {

            Console.Write("Introduceti primul numar: ");
            string firstNumber = Console.ReadLine();
            Console.Write("Introduceti al doilea numar: ");
            string secondNumber = Console.ReadLine();
            int[] primulNumar = new int[firstNumber.Length];
            int[] aldoileaNumar = new int[secondNumber.Length];
            
            for (int i = 0; i < firstNumber.Length; i++)
            {
                primulNumar[i] =int.Parse(firstNumber.Substring(i,1)) ;
            }
           
            for (int i = 0; i < secondNumber.Length; i++)
            {
                aldoileaNumar[i] = int.Parse(secondNumber.Substring(i, 1));
            }
            int[] suma = new int[firstNumber.Length+1];
            if (firstNumber.Length>secondNumber.Length)
            {
                
                for (int i = secondNumber.Length-1; i >=0; i--)
                {
                    primulNumar[firstNumber.Length -1 - i] = primulNumar[firstNumber.Length -1 - i] + aldoileaNumar[i];
                   
                    if ((primulNumar[firstNumber.Length -1- i])>9)
                    {
                        primulNumar[firstNumber.Length-1- i] = primulNumar[firstNumber.Length-1  - i]%10;
                        primulNumar[firstNumber.Length-2 - i]++;
                    }
                }
                for (int i = 0; i < firstNumber.Length; i++)
                {
                    Console.Write(primulNumar[i]);
                }
            }
            //
           else if (firstNumber.Length < secondNumber.Length)
            {

                for (int i = firstNumber.Length - 1; i >= 0; i--)
                {
                    aldoileaNumar[secondNumber.Length - 1 - i] = aldoileaNumar[secondNumber.Length - 1 - i] + primulNumar[i];

                    if ((aldoileaNumar[secondNumber.Length - 1 - i]) > 9)
                    {
                        aldoileaNumar[secondNumber.Length - 1 - i] = aldoileaNumar[secondNumber.Length - 1 - i] % 10;
                        aldoileaNumar[secondNumber.Length - 2 - i]++;
                    }
                }
                for (int i = 0; i < aldoileaNumar.Length; i++)
                {
                    Console.Write(aldoileaNumar[i]);
                }
           }
            //
            else if (firstNumber.Length == secondNumber.Length)
            {
              
                for (int i = firstNumber.Length - 1; i >= 0; i--)
                {
                    suma[suma.Length - 1 - i] = primulNumar[firstNumber.Length - 1 - i] + aldoileaNumar[firstNumber.Length - 1 - i];
                    if (suma[suma.Length - 1 - i]>9)
                    {
                        suma[suma.Length - 1 - i] = suma[suma.Length - 1 - i] % 10;
                        suma[suma.Length - 2 - i]++;
                    }
                    
                }
                if (suma[0] != 0)
                {
                    for (int i = 0; i < suma.Length; i++)
                    {

                        Console.Write(suma[i]);
                    }
                }
                else
                {
                    for (int i = 1; i < suma.Length; i++)
                    {

                        Console.Write(suma[i]);
                    }
                }
            }




            Console.ReadKey();
        }
    }
}
