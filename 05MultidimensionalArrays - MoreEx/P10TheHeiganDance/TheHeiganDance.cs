using System;

namespace P10TheHeiganDance
{
    internal class TheHeiganDance
    {
        static int playerRow = 7;
        static int playerCol = 7;

        static int plagueCloud = 3500;
        static int eruption = 6000;

        static int playerLifePoints = 18500;
        static double heiganLifePoints = 3000000;
        static bool isPlageCloud = false;
        static string lastSpell = string.Empty;

        static void Main(string[] args)
        {
            double pointsAgainstHeigan = double.Parse(Console.ReadLine());

            while (true)
            {

                if (playerLifePoints > 0)
                {
                    heiganLifePoints -= pointsAgainstHeigan;
                }

                if (isPlageCloud)
                {
                    playerLifePoints -= plagueCloud;
                    isPlageCloud = false;
                }

                if (playerLifePoints <= 0 || heiganLifePoints <= 0)
                {
                    break;
                }

                //Cloud 7 7 
                string[] input = Console.ReadLine().Split();

                string magic = input[0];
                int targetRow = int.Parse(input[1]);
                int targetCol = int.Parse(input[2]);

                if (IsInImpactArea(playerRow, playerCol, targetRow, targetCol) == false)
                {
                    continue;
                }

                //up, right, down, left

                bool canMoveUp = !IsInImpactArea(playerRow - 1, playerCol, targetRow, targetCol) && IsInside(playerRow - 1);
                bool canMoveRight = !IsInImpactArea(playerRow, playerCol + 1, targetRow, targetCol) && IsInside(playerCol + 1);
                bool canMoveDown = !IsInImpactArea(playerRow + 1, playerCol, targetRow, targetCol) && IsInside(playerRow + 1);
                bool canMoveLeft = !IsInImpactArea(playerRow, playerCol - 1, targetRow, targetCol) && IsInside(playerCol - 1);

                if (canMoveUp)
                {
                    playerRow--;
                    continue;
                }

                if (canMoveRight)
                {
                    playerCol++;
                    continue;
                }

                if (canMoveDown)
                {
                    playerRow++;
                    continue;
                }

                if (canMoveLeft)
                {
                    playerCol--;
                    continue;
                }

                if (magic == "Cloud")
                {
                    playerLifePoints -= plagueCloud;
                    isPlageCloud = true;
                    lastSpell = "Plague Cloud";
                }
                else if (magic == "Eruption")
                {
                    playerLifePoints -= eruption;
                    lastSpell = "Eruption";
                }
            }

            if (heiganLifePoints <= 0)
            {
                Console.WriteLine("Heigan: Defeated!");
            }
            else
            {
                Console.WriteLine($"Heigan: {heiganLifePoints:f2}");
            }

            if (playerLifePoints <= 0)
            {
                Console.WriteLine($"Player: Killed by {lastSpell}");
            }
            else
            {
                Console.WriteLine($"Player: {playerLifePoints}");
            }

            Console.WriteLine($"Final position: {playerRow}, {playerCol}");
        }

        static bool IsInside(int rcIndex)
        {
            return rcIndex >= 0 && rcIndex < 15;
        }

        static bool IsInImpactArea(int targetPlayerRow, int targetPlayerCol, int row, int col)
        {
            return targetPlayerRow >= row - 1 && targetPlayerRow <= row + 1 &&
                   targetPlayerCol >= col - 1 && targetPlayerCol <= col + 1;
        }
    }
}
