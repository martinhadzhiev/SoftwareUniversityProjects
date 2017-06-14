namespace HeiganDance
{
    using System;

    class HeiganDance
    {
        private const int ChamberSze = 15;
        private const int CloudDamage = 3500;
        private const int Eruption = 6000;
        private const double PlayerHealth = 18500;
        private const double HeiganHelath = 3000000;

        static void Main()
        {
            var playerPos = new int[] { ChamberSze / 2, ChamberSze / 2 };
            var heiganPoints = HeiganHelath;
            var playerPoints = PlayerHealth;
            var isHeiganDead = false;
            var isPlayerDead = false;
            var hasCloud = false;
            var deathCause = "";

            var damageToHeigan = double.Parse(Console.ReadLine());

            while (true)
            {
                var spellTokens = Console.ReadLine()
                    .Split();
                var spell = spellTokens[0];
                var spellRow = int.Parse(spellTokens[1]);
                var spellCol = int.Parse(spellTokens[2]);

                heiganPoints -= damageToHeigan;
                isHeiganDead = heiganPoints <= 0;

                if (hasCloud)
                {
                    playerPoints -= CloudDamage;
                    hasCloud = false;
                    isPlayerDead = playerPoints <= 0;
                }
                if (isHeiganDead || isPlayerDead)
                {
                    break;
                }

                if (isPlayerInDamagedArea(playerPos, spellRow, spellCol))
                {
                    if (!playerTryEscape(playerPos, spellCol, spellRow))
                    {

                        switch (spell)
                        {
                            case "Cloud":
                                playerPoints -= CloudDamage;
                                hasCloud = true;
                                deathCause = "Plague Cloud";
                                break;
                            case "Eruption":
                                playerPoints -= Eruption;
                                deathCause = "Eruption";
                                break;
                        }
                    }
                }
                isPlayerDead = playerPoints <= 0;
                if (isPlayerDead)
                {
                    break;
                }
            }

            PrintResult(playerPos, heiganPoints, playerPoints, deathCause);
        }

        private static void PrintResult(int[] playerPos, double heiganPoints, double playerPoints, string deathCause)
        {
            if (heiganPoints<=0)
            {
                Console.WriteLine("Heigan: Defeated!");
            }
            else
            {
                Console.WriteLine($"Heigan: {heiganPoints:F2}");
            }

            if (playerPoints<=0)
            {
                Console.WriteLine($"Player: Killed by {deathCause}");
            }
            else
            {
                Console.WriteLine($"Player: {playerPoints}");
            }
            Console.WriteLine($"Final position: {playerPos[0]}, {playerPos[1]}");
        }

        private static bool playerTryEscape(int[] playerPos, int spellCol, int spellRow)
        {
            if (playerPos[0] - 1 >= 0 && playerPos[0] - 1 < spellRow - 1)
            {
                playerPos[0]--;
                return true;
            }
            else if (playerPos[1] + 1 < ChamberSze && playerPos[1] + 1 > spellCol + 1)
            {
                playerPos[1]++;
                return true;
            }
            else if (playerPos[0] + 1 < ChamberSze && playerPos[0] + 1 > spellRow + 1)
            {
                playerPos[0]++;
                return true;
            }
            else if (playerPos[1] - 1 >= 0 && playerPos[1] - 1 < spellCol - 1)
            {
                playerPos[1]--;
                return true;
            }

            return false;
        }

        private static bool isPlayerInDamagedArea(int[] playerPos, int spellRow, int spellCol)
        {
            bool isHitRow = playerPos[0] >= spellRow - 1 && playerPos[0] <= spellRow + 1;
            bool isHitCol = playerPos[1] >= spellCol - 1 && playerPos[1] <= spellCol + 1;

            return isHitCol && isHitRow;
        }
    }
}
