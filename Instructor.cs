namespace StudentExercises
{
    class Instructor
    {
        public Instructor(string firstName, string lastName, string specialty, string slackHandle)
        {
            FirstName = firstName;
            LastName = lastName;
            Specialty = specialty;
            SlackHandle = slackHandle;
        }

        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string SlackHandle {get; set;}
        public string Specialty {get; set;}

        public Cohort Cohort {get; set;}

        public void Assign(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }
    }
}
