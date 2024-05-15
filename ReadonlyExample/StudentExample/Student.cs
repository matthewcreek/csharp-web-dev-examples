
namespace StudentExample
{
    public class Student
	{
        private static int nextStudentId = 1;
        public string Name { get; set; }
        private readonly int studentId;
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int sId, int numberOfCredits, double gpa)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int sId)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            studentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string StudentInfo()
        {
            return (Name + " has a GPA of: " + Gpa);
        }

        public void AddGrade(int courseCredits, double grade)
        {
            NumberOfCredits += courseCredits;
            //TODO: code to calculate GPA
        }
        public string GetGradeLevel()
        {
            int grade = NumberOfCredits/4;
            string gradeLevel = grade.ToString();
            return gradeLevel;
        }

        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   studentId == student.studentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(studentId);
        }
    }
}

