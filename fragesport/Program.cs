using System;

namespace fragesport
{
    class Program
    {
        static void Main(string[] args)
        {

            int score = 0; 
            Console.WriteLine("Welcome to the quiz!");
            Console.ReadLine();

            System.Console.WriteLine("Which is the only vowel not used as the first letter in a US State?");

            System.Console.WriteLine("1)E   2)I   3) A");

            score += Ask(1);
            

            System.Console.WriteLine("What did the Romans call Scotland?");
            System.Console.WriteLine("1)England   2)Caledonia   3) Karthago");

            score += Ask(2);

            


            Console.WriteLine("score is " + score);
            Console.ReadLine();
        }

        static int Ask(int correctAnswer) // checkar svaret+ ger poäng//
        {
            int input = playerTryParse();
            
            if(input==correctAnswer){
                System.Console.WriteLine("correct! one point added");
                return 1;
            }

            else {
                System.Console.WriteLine("incorrect, no points added");
                return 0;
            }


        }



        static int playerTryParse() //convertar string till int//
        {
            string playerAnswer;

            bool resultat = false;

            int playAnswerInt = 0;
            while(resultat == false)
            {
                System.Console.WriteLine("please input valid answer");
                playerAnswer = Console.ReadLine(); 
                resultat=int.TryParse(playerAnswer,out playAnswerInt);

                while(playAnswerInt>=4){
                    System.Console.WriteLine("please input a valid answer");
                    playerAnswer = Console.ReadLine();
                    resultat=int.TryParse(playerAnswer,out playAnswerInt);

                }
            }


            return playAnswerInt;
        }
    }
}
