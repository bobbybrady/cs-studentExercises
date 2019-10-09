using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        public Student(string firstName, string lastName, string slackHandle)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
        }

        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string SlackHandle {get; set;}

        public Cohort Cohort {get; set;}

        public List<Exercise> Exercises = new List<Exercise>();

    }
}
