using System;
using System.Reflection;

namespace TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        class Game
        {
            string gameName = "Trivia Game";

            public Game()
            {
                Title = gameName;
                Console.WriteLine("Hello, welcom to Harry Potter Trivia, a game created by Eden Szopa");
                Play();
                Console.ReadKey();
            }

            public string Title { get; }

            private void Play()
            {

            }

        }

        class Player
        {
            string name = "Player";
            int score = 0;
        }

        class TriviaItem
        {
            public string questionOne = "What Hogwarts House is Harry Potter in? ";
            public string answerOne = "Gryffindor";
            public string questionTwo = "What is the name of the second Harry Potter book?";
            public string anserTwo = "Harry Potter and the Chamber of Secrets";
            public string questionThree = "What Hogwarts House is Draco Malfoy in?";
            public string answerThree = "Slytherin";
            public string questionFour = "How many books are in the Harry Potter series?";
            public string questionFive = "True or False, there are many more Harry Potter movies than books.";
            public string answerFive = "True";
            public string questionSix = "How many Hogwarts houses are there?";
            public string answerSix = "four";
            public string questionSeven = "How many Horcruxes are there?";
            public string answerSeven = "eight";
        }
    }
}