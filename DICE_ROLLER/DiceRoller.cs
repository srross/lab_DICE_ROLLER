using System;

namespace DICE_ROLLER
{
    // Extra Challenges:Come up with a set of winning combinations for other dice sizes besides 6.
    public class DiceRoller
    {

        public static string generateRandonDiceRoll(int sidesOnDice)
        {
            Random rand = new Random();
            int ranNum1 = rand.Next(1, (sidesOnDice + 1));
            int ranNum2 = rand.Next(1, (sidesOnDice + 1));

            var outcomeMessage = EvaluateDiceRoll(ranNum1, ranNum2);

            return outcomeMessage;
        }

        public static string EvaluateDiceRoll(int diceOne, int diceTwo)
        {
            int total = diceOne + diceTwo;

            switch (total)
            {
                case 2:
                    return $"Snake Eyes: Two {diceOne}s"; // Clarify this - Craps: A total of 2, 3, or 12 (will also generate another message!)
                case 3:
                    return $"Ace Deuce: A {diceOne} and {diceTwo}";
                case 7:
                    return $"A {diceOne} and a {diceTwo}! Total {total}. YOU WIN!";
                case 11:
                    return $"A {diceOne} and a {diceTwo}! Total {total}. YOU WIN!";
                case 12:
                    return $"Box Cars: Two {diceOne}s";
                default:
                    return $"{diceOne} and {diceTwo}, you rolled {total}.";
            }
        }

        static void Main(string[] args)
        {
            var rollDice = true;

            Console.WriteLine("So ya feeling Lucky, huh? - Enter number of sides for your dice: ");
            var sidesOnDice = int.Parse(Console.ReadLine());

            Console.WriteLine("Please hit ENTER to roll the dice.");
            Console.ReadLine();

            do
            {
                var outcomeMessage = generateRandonDiceRoll(sidesOnDice);
                Console.WriteLine(outcomeMessage);

                Console.WriteLine("To roll again, please enter 'yes' or 'y' -OR- press any other key to exit.");
                var rollAgain = Console.ReadLine().ToLower();

                if (rollAgain != "y" && rollAgain != "yes")
                {
                    rollDice = false;
                    Console.WriteLine("Thank you for trying your luck. Bye-bye!");
                }

            } while (rollDice == true);
        }
    }
}