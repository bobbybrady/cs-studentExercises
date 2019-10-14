using System;
using System.Collections.Generic;
using System.Linq;

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
            Student Ted = new Student("Ted", "Rooselvelt", "TEDSLACK");

            ThirtyFive.AddStudent(Will);
            ThirtyFive.AddStudent(Brantley);
            ThirtyFour.AddStudent(Noah);
            ThirtySix.AddStudent(Bobby);
            ThirtySix.AddStudent(Ted);

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
            Jenna.Assign(Will, ChickenMonkey);
            Bryan.Assign(Will, StudentExercises);
            Bryan.Assign(Brantley, CoinsToCash);
            Bryan.Assign(Brantley, StudentExercises);

            List<Student> students = new List<Student>();
            students.Add(Will);
            students.Add(Noah);
            students.Add(Brantley);
            students.Add(Bobby);
            students.Add(Ted);

            List<Instructor> instructors = new List<Instructor>();
            instructors.Add(Andy);
            instructors.Add(Jenna);
            instructors.Add(Bryan);

            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(ChickenMonkey);
            exercises.Add(Nutshell);
            exercises.Add(StudentExercises);
            exercises.Add(CoinsToCash);

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
            List<Exercise> JSExercises = exercises.Where(exercise => exercise.Langauge == "Javascript").ToList();
            foreach (Exercise exercise in JSExercises)
            {
                Console.WriteLine(exercise.Name);
            }

            List<Student> c34 = students.Where(student => student.Cohort.Name == "34").ToList();
            List<Instructor> c34I = instructors.Where(instructor => instructor.Cohort.Name == "34").ToList();
            List<Student> c35 = students.Where(student => student.Cohort.Name == "35").ToList();
            List<Instructor> c35I = instructors.Where(instructor => instructor.Cohort.Name == "35").ToList();
            List<Student> c36 = students.Where(student => student.Cohort.Name == "36").ToList();
            List<Instructor> c36I = instructors.Where(instructor => instructor.Cohort.Name == "36").ToList();
            List<Student> LastName = students.OrderBy(student => student.LastName).ToList();
            List<Student> NoExercises = students.Where(student => student.Exercises.Count == 0).ToList();
            List<Student> MostExercises = students.OrderByDescending(student => student.Exercises.Count).ToList();
            foreach (Student student in c34)
            {
                Console.WriteLine("- - - - - - - - - - - -");
                Console.WriteLine("Cohort 34 Students");
                Console.WriteLine($"{student.FirstName} {student.LastName}");
                Console.WriteLine(c34.Count());
                Console.WriteLine("- - - - - - - - - - - -");
            }
                Console.WriteLine("Cohort 35 Students");
            foreach (Student student in c35)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
                Console.WriteLine(c35.Count());
                Console.WriteLine("- - - - - - - - - - - -");
                Console.WriteLine("Cohort 36 Students");
            foreach (Student student in c36)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
                Console.WriteLine(c36.Count());
                Console.WriteLine("- - - - - - - - - - - -");
                Console.WriteLine("Cohort 34 Instructors");
            foreach (Instructor instructor in c34I)
            {
                Console.WriteLine($"{instructor.FirstName} {instructor.LastName}");
            }
                Console.WriteLine("- - - - - - - - - - - -");
                Console.WriteLine("Cohort 35 Instructors");
            foreach (Instructor instructor in c35I)
            {
                Console.WriteLine($"{instructor.FirstName} {instructor.LastName}");
            }
                Console.WriteLine("- - - - - - - - - - - -");
                Console.WriteLine("Cohort 36 Instructors");
            foreach (Instructor instructor in c36I)
            {
                Console.WriteLine($"{instructor.FirstName} {instructor.LastName}");
            }
                Console.WriteLine("- - - - - - - - - - - -");

            Console.WriteLine("Sorted By Last Name");
            foreach (Student student in LastName)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine("- - - - - - - - - - - -");

            foreach (Student student in NoExercises)
            {
                Console.WriteLine($"No Exercises for {student.FirstName} {student.LastName}");
                Console.WriteLine("- - - - - - - - - - - -");
            }
            
            Console.WriteLine($"The student with the most exercises is {MostExercises[0].FirstName} {MostExercises[0].LastName}");
            // Console.WriteLine("Report:");
            // foreach (Student student in students)
            // {
            //     foreach (Exercise exercise in student.Exercises)
            //     {
            //         Console.WriteLine($"{student.FirstName} {student.LastName} is working on {exercise.Name}.");
            //     }
            // }
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");

        }
    }
}
