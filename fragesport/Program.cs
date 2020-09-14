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

            QuizText("Which is the only vowel not used as the first letter in a US State?","E","I","A");

            score += Ask(1);

            //gör en klass av console.clear

            Console.ReadLine();
            Console.Clear();

            QuizText("What did the Romans call Scotland?", "England", "Caledonia", "Karthago");

            score += Ask(2);

            Console.ReadLine();
            Console.Clear();

            QuizText("In football, which team has won the Champions League (formerly the European Cup) the most?", "Milan", "Real Madrid", "Barcelona");

            score+= Ask(2);

            Console.ReadLine();
            Console.Clear();

            QuizText("Who is Donald Trump's vice president", "Margaret Thatcher", "Mike Pompeo", "Mike Pence");

            score+=Ask(3);

            Console.ReadLine();
            Console.Clear();


            QuizText("What is japanese Sake made from", "rice", "wheat", "flowers");

            score+=Ask(1);

            Console.ReadLine();
            Console.Clear();

            QuizText("What is the capital of Westeros in Game of Thrones?", "Qarth", "Meereen", "King's Landing");

            score+=Ask(3);

            
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("score is " + score);

            Console.ReadLine();
        }


        
        static void QuizText(string question, string answer1, string answer2, string answer3){
            System.Console.WriteLine(question);
            System.Console.WriteLine("1)"+ answer1+"   2)"+answer2+"   3)"+answer3);

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



        static int playerTryParse() //convertar string till int///
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
