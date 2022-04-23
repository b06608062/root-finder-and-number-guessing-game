using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace root_finder_and_number_guessing_game
{
    internal class NumberGuessingGame
    {
        readonly int[] num = new int[10] { 9, 5, 2, 7, 0, 1, 3, 4, 6, 8 };
        readonly Random myRandomNumberGenerator = new Random();

        public void ResetDigits()
        {
            for (int i = 0; i < 100; i++)
            {
                int random = myRandomNumberGenerator.Next(10);  // 0-9
                (num[random], num[0]) = (num[0], num[random]);
            }
        }

        public string GetAnswer()
        {
            string answer = "";
            for (int i = 0; i < 4; i++)
            {
                answer += num[i].ToString();
            }
            return answer;
        }

        public string Guessing(string guess)
        {
            int countA = 0, countB = 0;
            for (int i = 0; i < 4; i++)
            {
                if (num[i].ToString() == guess[i].ToString())
                {
                    countA++;
                } else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (num[i].ToString() == guess[j].ToString()) countB++;
                    }
                }
            }

            if (countA == 4) return "You got it!";
            return $"{guess} is {countA}A {countB}B";
        }
    }
}
