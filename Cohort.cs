using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        public Cohort(string name)
        {
            Name = name;
        }

        public string Name {get; set;}

        public List<Student> Students = new List<Student>();
        public List<Instructor> Instructors = new List<Instructor>();

        public void AddStudent(Student student)
        {
            Students.Add(student);
            student.Cohort = this;
        }

         public void AddInstructor(Instructor instructor)
        {
            Instructors.Add(instructor);
            instructor.Cohort = this;
        }

    }
}
