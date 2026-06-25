using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba14
{
    public class ScoreManager
    {
        static List<string> studentNames = new List<string>();
        static Dictionary<string, int> studentScores = new Dictionary<string, int>();


        public void AddStudent()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("ENter student's score: ");
            if (int.TryParse(Console.ReadLine(), out int score))
            {
                //cehcking if the name exist, if not we add name and score
                if (!studentScores.ContainsKey(name))
                {
                    studentNames.Add(name);
                    studentScores[name] = score;
                    Console.WriteLine($"\n{name} and {name}'s score: {score} Added!");
                }
                else
                {
                    Console.WriteLine("student with that name exists! enter different student");
                }
            }
            else
            {
                Console.WriteLine("invalid score, enter correct number!!");
            }
        }

        public void SearchStudent()
        {
            Console.Write("search student's name: ");
            string name = Console.ReadLine();

            if (studentScores.ContainsKey(name))
            {
                Console.WriteLine($"{name}'s score is: {studentScores[name]}");
            }
            else
            {
                Console.WriteLine($"Student {name} isnt in the list");
            }
        }

        public void UpdateScore()
        {
            Console.Write("enter student's name to change their score: ");
            string name = Console.ReadLine();

            //checking if student is created 
            if (studentScores.ContainsKey(name))
            {
                Console.Write($"enter new score for {name}: ");

                //check if input is number with tryparse
                if (int.TryParse(Console.ReadLine(), out int newScore))
                {
                    studentScores[name] = newScore;
                    Console.WriteLine("{name}'s score was updated and is now {newScore}");
                }
                else
                {
                    Console.WriteLine("error!!! wrong score, enter a number!");
                }
            }
            else
            {
                Console.WriteLine("cant update the score. student {name} doesnt exist");
            }
        }

        public void ShowAllStudents()
        {
            if(studentNames.Count == 0)
            {
                //check if list isnt empty
                Console.WriteLine("there are no students in the list");
                return;
            }

            Console.WriteLine("created students");

            foreach (string name in studentNames)
            {
                Console.WriteLine($"Student {name} - Score: {studentScores[name]}");
            }
        }
        
        }
    }
