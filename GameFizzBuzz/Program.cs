using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GameFizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FizzBuzz fizzBuzz = new FizzBuzz();

                Console.WriteLine("Gra FizzBuzz\nAby zakończyć grę wpisz liczbę 112.");

                while (true)
                {
                    Console.WriteLine("Podaj liczbę:");

                    var number = GetNumber();

                    //zakończenie gry, przerwane pętli gdy użytkownik wprowadzi wartość 112
                    if (number == 112)
                        break;

                    Console.WriteLine(fizzBuzz.GetResult(number));


                    //if (number != 112)
                    //{
                    //    Console.WriteLine(fizzBuzz.GetResult(number));
                    //}
                    //else
                    //    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int GetNumber()
        {
            try
            {
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out var number))
                    {
                        Console.WriteLine("Wprowadziłeś błedne dane !!!\nPodaj liczbę:");
                        //jeżeli uzytkownik wprowadzi błędne dane, to instrukcja continuee spowoduje 
                        //że dalsza część kodu nie bedzie wykonywana, wrócimy do początku pętli 
                        continue;
                    }
                    return number;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
