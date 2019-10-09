using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise ChickenMonkey = new Exercise("Chicken Monkey", "Javascript");
            Exercise CoinsToCash = new Exercise("Coins to Cash", "Javascript");
            Exercise StudentExercises = new Exercise("Student Exercises", "C#");
            Exercise Nutshell = new Exercise("Nutshell", "C#");

            Cohort ThirtyFour = new Cohort("34");
            Cohort ThirtyFive = new Cohort("35");
            Cohort ThirtySix = new Cohort("36");

            Student Will = new Student("Will", "Wilkerson", "WILLSLACK");
            Student Noah = new Student("Noah", "Bartfield", "NOAHSLACK");
            Student Brantley = new Student("Brantley", "Jones", "BRANTLEYSLACK");
            Student Bobby = new Student("Bobby", "Brady", "BOBBYSLACK");

            ThirtyFive.AddStudent(Will);
            ThirtyFive.AddStudent(Brantley);
            ThirtyFour.AddStudent(Noah);
            ThirtySix.AddStudent(Bobby);

            Instructor Andy = new Instructor("Andy", "Collins", "ANDYSLACK", "Pointing");
            Instructor Jenna = new Instructor("Jenna", "Solis", "JENNASLACK", "Killing animals");
            Instructor Bryan = new Instructor("Bryan", "Nilsen", "ANDYSLACK", "High fives");

            ThirtyFive.AddInstructor(Andy);
            ThirtySix.AddInstructor(Jenna);
            ThirtyFour.AddInstructor(Bryan);

            Andy.Assign(Bobby, ChickenMonkey);
            Andy.Assign(Bobby, CoinsToCash);
            Andy.Assign(Noah, ChickenMonkey);
            Jenna.Assign(Noah, Nutshell);
            Jenna.Assign(Will, Nutshell);
            Bryan.Assign(Will, StudentExercises);
            Bryan.Assign(Brantley, CoinsToCash);
            Bryan.Assign(Brantley, StudentExercises);

            List<Student> students = new List<Student>();
            students.Add(Will);
            students.Add(Noah);
            students.Add(Brantley);
            students.Add(Bobby);

            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(ChickenMonkey);
            exercises.Add(Nutshell);
            exercises.Add(StudentExercises);
            exercises.Add(CoinsToCash);

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Report:");
            foreach (Student student in students)
            {
                foreach (Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is working on {exercise.Name}.");
                }
            }
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");

        }
    }
}
