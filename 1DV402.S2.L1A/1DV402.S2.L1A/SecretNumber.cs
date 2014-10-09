using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
        public const int MaxNumberOfGuesses = 7;

        private int _count;
        private int _number;

        public SecretNumber()//konstructor
        {
            Initialize();//anropar initialize
        }

        public void Initialize()
        {
            Random myRandom = new Random();

            _number = myRandom.Next(1, 101);// tilldelar objektet number ett värde mellan 1-100.

            _count = 0;// Deklarerar att räkningen ska börja med 0
        }

        public bool MakeGuess(int number)
        {
            if (_count >= MaxNumberOfGuesses)
            {
                throw new ApplicationException();
            }

            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            ++_count;

            if (number == _number)
            {
                Console.WriteLine("Grattis Du Gissar Rätt.Du klarade det på {0} försök.", _count);
                return true;
            }

            if (number < _number)// Om gissniningen är mindre än det hemliga talet skrivs ett meddelande
            {
                Console.WriteLine("{0} är för lågt.Du har {1} gissning kvar.", number, (MaxNumberOfGuesses - _count));
            }
            else // om gissningen är högre än det hemliga talet skrivs ett meddelande.
            {
                Console.WriteLine("{0} är för högt. Du har {1} gissining kvar.", number, (MaxNumberOfGuesses - _count));
            }

            if (_count == MaxNumberOfGuesses)// Skriver ut det hemliga talet 
            {
                Console.WriteLine("Den Hemliga talet är {0}", _number);
            }

            // returnera falskt eftersom de misslyckades att vara lika mycket som det hemliga värdet
            return false;
        }

    }

}
