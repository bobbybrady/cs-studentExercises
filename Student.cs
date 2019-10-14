using System.Collections.Generic;

namespace StudentExercises
{
    class Student : NSSPerson
    {
        public Student(string firstName, string lastName, string slackHandle)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
        }


        public Cohort Cohort {get; set;}

        public List<Exercise> Exercises = new List<Exercise>();

    }
}
