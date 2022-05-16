// See https://aka.ms/new-console-template for more information

Student aStudent = new Student("Joe Bloggs", 'C', 3);
School thisSchool = new School();

aStudent.GetSecretNicknameFromWithinStudentClass();

thisSchool.GetSchoolStudentDetails();
thisSchool.UpgradeStudentGrade();
thisSchool.DowngradeStudentGrade();

public class Student
{
    public static string? StudentName { get; set; }
    public static char StudentGrade { get; set; }
    public static int StudentGroup { get; set; }
    internal static string? secretNickname { private get; set; }

    public Student(string name, char grade, int group)
    {
        StudentName = name;
        StudentGrade = grade;
        StudentGroup = group;
        secretNickname = "MySecretNickname"; 
    }

    public void GetSecretNicknameFromWithinStudentClass()
    {
       Console.WriteLine("StudentSecretNicknameFromWithinStudentClass : {0}", secretNickname);
    }
}

public class School
{
    private static string schoolStudentSecretNickname = "Access Denied";

    Student bStudent = new Student("John Smith", 'B', 4);

    public School()
    {

    }

    public void UpgradeStudentGrade()
    {
        Console.WriteLine("School Student Grade before Increment : {0}", Student.StudentGrade);

        if (Student.StudentGrade < 'E')
        {
            Student.StudentGrade++;
        }
     
        Console.WriteLine("School Student Grade after Increment : {0}", Student.StudentGrade);
    }

    public void DowngradeStudentGrade()
    {
        Console.WriteLine("School Student Grade before Decrement : {0}", Student.StudentGrade);

        if (Student.StudentGrade > 'A')
        {
            Student.StudentGrade--;
        }

        Console.WriteLine("School Student Grade after Decrement : {0}", Student.StudentGrade);
    }

    public void GetSchoolStudentDetails()
    {
        // schoolStudentSecretNickname = Student.secretNickname;
        // Compiler won't allow access to Student.secretNickname because of its protection level
        Console.WriteLine("SchoolStudentName : {0}", Student.StudentName); // can't get compiler to access bStudent!
        Console.WriteLine("SchoolStudentGrade : {0}", Student.StudentGrade);
        Console.WriteLine("StudentSecretNicknameFromWithinSchoolClass : {0}", schoolStudentSecretNickname);
    }
}

