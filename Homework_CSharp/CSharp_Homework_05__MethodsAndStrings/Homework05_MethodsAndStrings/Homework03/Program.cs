using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter the number of wins: ");
                bool checkParsedWins = int.TryParse(Console.ReadLine(), out int winsInput);

                Console.Write("Please enter the number of draws: ");
                bool checkParsedDraws = int.TryParse(Console.ReadLine(), out int drawsInput);

                Console.Write("Please enter the number of losses: ");
                bool checkParsedLosses = int.TryParse(Console.ReadLine(), out int lossesInput);

                if (checkParsedWins && checkParsedDraws && checkParsedLosses && winsInput >= 0 && drawsInput >= 0 && lossesInput >= 0)
                {
                    GetFootballPoints(winsInput, drawsInput, lossesInput);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter numbers if you want to count the points!!!");
                }
            }
        }

        public static int GetFootballPoints(int winsInp, int drawsInp, int lossesInp)
        {
            int winsPoints = 3;
            int drawsPoints = 1;
            int lossesPoints = 0;
            int numberOfPoints = (winsInp * winsPoints) + (drawsInp * drawsPoints) + (lossesInp * lossesPoints);
            if (numberOfPoints == 0)
            {
                Console.WriteLine($"Your team earned {numberOfPoints}pts. We wish you more luck next time.\nAPOLOGIES :(");
            }
            else
            {
                Console.WriteLine($"Wins brings you {winsPoints}pts, draws brings you {drawsPoints}pts,\n" +
                    $"and losses bring you nothing or {lossesPoints}pts. So the calculated points are equal to {numberOfPoints}pts.\n" +
                    $"CONGRATULATIONS! ");
            }
            return numberOfPoints;
        }

    }
}
