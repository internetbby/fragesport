using System;
using System.Collections.Generic;

namespace fragesport
{
    class Program
    {
        static void Main(string[] args)
        {
           /* List<string[]> answers = new List<string[]>();
            List<string> questions = new List<string>();
            List<int> correctAnswers = new List<int>();
            
            

            questions.Add("Fråga 1: aregay");
            answers.Add(new string[]{"A", "B", "C"});
            correctAnswers.Add(1);

            questions.Add("Fråga 2: sthsrth");
             answers.Add(new string[]{"O", "Y", "U"});



            System.Console.WriteLine(answers[1][0]);

            Random generator = new Random();

            int q = generator.Next(2);

            System.Console.WriteLine(questions[q]);
            string answer = Console.ReadLine();

            int corr = correctAnswers[q]
            if (answer == answers[q][corr])
            {

            }*/
            int score = 0; 
            Random Generator= new Random();

            List<string> questions = new List<string>();
            List<string[]> answers = new List<string[]>();
            List<int> correctAnswer = new List<int>();

            questions.Add("Which is the only vowel not used as the first letter in a US State?");
            answers.Add(new string[]{"E","I","A"});
            correctAnswer.Add(1);


            questions.Add("What did the Romans call Scotland?");
            answers.Add(new string[]{"England", "Caledonia", "Karthago"});
            correctAnswer.Add(2); // add the questions

            int questionsListed = questions.Count + 1;  //gives the randomizer number to go by when randomizing

            string exit = "N"; 

            while (exit!= "N"){

                Console.WriteLine("Welcome to the quiz!");
                Console.ReadLine();

                if (questions.Count>0){
                    int randomizer = Generator.Next(questionsListed);
                    System.Console.WriteLine(questions[randomizer]);
                    System.Console.WriteLine(answers[randomizer]);
                    int corr= correctAnswer[randomizer];
                    score+= Ask(corr);  //asks the random question, then the answers at that list index samt ger correctAnswer och checkar om det rätt med ask metoden

                    questions.RemoveAt(randomizer);

                }

                System.Console.WriteLine("quiz done! wanna retry?");
                System.Console.WriteLine("[Y/N]");
                string exitAnswer = Console.ReadLine();
                

                exit = exitAnswer.ToUpper();
                while (exit != "Y" ^ exit != "N"){
                    System.Console.WriteLine("please input valid answer");
                    exitAnswer = Console.ReadLine();
                    exit = exitAnswer.ToUpper();
                }


                if (exit = "Y"){

                }  // fixa så om man retryar så läggs alla frågor in igen 


            }
           

            

            


            

            /*QuizText("Which is the only vowel not used as the first letter in a US State?");
            QuizAnswer("E","I","A");

            score += Ask(1);

            //gör en klass av console.clear

            Console.ReadLine();
            Console.Clear();

            QuizText("What did the Romans call Scotland?");
            QuizAnswer("England", "Caledonia", "Karthago");

            score += Ask(2);

            Console.ReadLine();
            Console.Clear();

            QuizText("In football, which team has won the Champions League (formerly the European Cup) the most?");
            QuizAnswer("Milan", "Real Madrid", "Barcelona");

            score+= Ask(2);

            Console.ReadLine();
            Console.Clear();

            QuizText("Who is Donald Trump's vice president");
            QuizAnswer("Margaret Thatcher", "Mike Pompeo", "Mike Pence");

            score+=Ask(3);

            Console.ReadLine();
            Console.Clear();


            QuizText("What is japanese Sake made from");
            QuizAnswer("rice", "wheat", "flowers");

            score+=Ask(1);

            Console.ReadLine();
            Console.Clear();

            QuizText("What is the capital of Westeros in Game of Thrones?");
            QuizAnswer("Qarth", "Meereen", "King's Landing");

            score+=Ask(3);

            
            Console.ReadLine();
            Console.Clear();*/


            Console.WriteLine("score is " + score);

            Console.ReadLine();
        }


        
        static void QuizText(string question){
            System.Console.WriteLine(question);

        }

        static void QuizAnswer(string answer1, string answer2, string answer3){
           System.Console.WriteLine("1)"+ answer1+"   2)"+answer2+ "   3)"+answer3);
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
