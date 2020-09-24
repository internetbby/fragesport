using System;
using System.Collections.Generic;

namespace fragesport
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0; 
            Random Generator= new Random();

            List<string> completeQuestions = new List<string>();
            List<string[]> completeAnswers = new List<string[]>();
            List<int> completeCorrectAnswer = new List<int>();

            completeQuestions.Add("Which is the only vowel not used as the first letter in a US State?");
            completeAnswers.Add(new string[]{"1)E  ","2)I  ","3)A  "});
            completeCorrectAnswer.Add(1);

            completeQuestions.Add("In football, which team has won the Champions League (formerly the European Cup) the most?");
            completeAnswers.Add(new string[]{"1)Milan  ", "2)Real Madrid  ", "3)Barcelona  "});
            completeCorrectAnswer.Add(2);

            completeQuestions.Add("What did the Romans call Scotland?");
            completeAnswers.Add(new string[]{"1)England  ", "2)Caledonia  ", "3)Karthago  "});
            completeCorrectAnswer.Add(2); // add the questions

            completeQuestions.Add("Who is Donald Trumps vice president?");
            completeAnswers.Add(new string[]{"1)Margaret Thatcher  ", "2)Mike Pompeo  ", "3)Mike Pence  "});
            completeCorrectAnswer.Add(3);

            completeQuestions.Add("what is sake made from?");
            completeAnswers.Add(new string[]{"1)rice  ", "2)wheat  ", "3)flower  "});
            completeCorrectAnswer.Add(1); // 



            




            List<string> questions = new List<string>(completeQuestions);
            List<string[]> answers = new List<string[]>(completeAnswers);
            List<int> correctAnswer = new List<int>(completeCorrectAnswer); //duplicates a list so i can change them up and then return them to their full state after the quiz is done
            int questionsListed =questions.Count;
            int randomizer = Generator.Next(questionsListed);
            

            string exit ="" ; 

            while (exit != "n"){

                Console.WriteLine("Welcome to the quiz!");
                Console.ReadLine(); 

                while (questions.Count>0){
                    questionsListed = questions.Count ;  //gives the randomizer number to go by when randomizing
                    randomizer = Generator.Next(questionsListed);
                    System.Console.WriteLine(questions[randomizer]);
                    Console.WriteLine(String.Join("\n", answers[randomizer]));
                    int corr= correctAnswer[randomizer];
                    score+= Ask(corr);  //asks the random question, then the answers at that list index samt ger correctAnswer och checkar om det rätt med ask metoden

                    questions.RemoveAt(randomizer);
                    answers.RemoveAt(randomizer);
                    correctAnswer.RemoveAt(randomizer);
                    Console.ReadLine();
                    Console.Clear();

                }

                System.Console.WriteLine("quiz done! wanna retry?");
                System.Console.WriteLine("[Y/N]");
                string exitAnswer = Console.ReadLine();
                exit = exitAnswer.ToLower();


                while (exit != "y" || exit != "n"){
                    System.Console.WriteLine("please input valid answer");
                    exitAnswer = Console.ReadLine();
                    exit = exitAnswer.ToLower();
                }


                if (exit == "y"){

                       questions = completeQuestions; 
                       answers = completeAnswers; 
                       correctAnswer = completeCorrectAnswer;
                }  


            }
           

            

            


            

            /*

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
