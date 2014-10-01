using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
   public class SecretNumber
    { 
        private int _count;
        private int _number;
       
        public const int MaxNumberOfGuesses = 7;

        public void Initialize() 
        {
            Random myRandom = new Random();
            _number = myRandom.Next(1, 101);
            _count = 0;
        }

        public bool MakeGuess(int number)
        {
            _count++;
            
            int guessNumber = MaxNumberOfGuesses - _count++;
           
            if (number ==_number)
            {
                Console.WriteLine("{0} är rätt, har{1} gissning kvar", number,guessNumber);
                    return true;
            }

            if (number < _number) 
            {
                Console.WriteLine("{0} för lågt, har {1} gissning kvar" , number,guessNumber);
                return false;
            }
            if (number > _number) 
            {
                Console.WriteLine("{0} för högt, har {1} har gissning kvar", number,guessNumber);
                return false;
            }
            return false;
        }


       
        public SecretNumber()//konstructor
        {
            Initialize();//anropar initialize
        }


   }

}
