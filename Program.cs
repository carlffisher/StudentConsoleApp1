// See https://aka.ms/new-console-template for more information

Student aStudent = new Student("Joe Bloggs", 'C', 3);
School aSchool = new School();

aStudent.DisplaySecretNicknameFromWithinStudentClass();

aSchool.GetSchoolStudentDetails();
aSchool.UpgradeStudentGrade();
aSchool.DowngradeStudentGrade();

public class Student
{
    public  string StudentName { get; set; }
    public  char StudentGrade { get; set; }
    public  int StudentGroup { get; set; }
    private string _secretNickname { get; set; }

    public Student(string name, char grade, int group)
    {
        StudentName = name;
        StudentGrade = grade;
        StudentGroup = group;
        _secretNickname = "MySecretNickname"; 
    }

    public void DisplaySecretNicknameFromWithinStudentClass()
    {
       Console.WriteLine("StudentSecretNicknameFromWithinStudentClass : {0}", _secretNickname);
    }
}

public class School
{
    private string schoolStudentSecretNickname = " ";

    Student bStudent = new Student("John Smith", 'B', 4);

    public School()
    {

    }

    public void UpgradeStudentGrade()
    {
        Console.WriteLine("School Student Grade before Increment : {0}", bStudent.StudentGrade);

        if (bStudent.StudentGrade < 'E')
        {
            bStudent.StudentGrade++;
        }
     
        Console.WriteLine("School Student Grade after Increment : {0}", bStudent.StudentGrade);
    }

    public void DowngradeStudentGrade()
    {
        Console.WriteLine("School Student Grade before Decrement : {0}", bStudent.StudentGrade);

        if (bStudent.StudentGrade > 'A')
        {
            bStudent.StudentGrade--;
        }

        Console.WriteLine("School Student Grade after Decrement : {0}", bStudent.StudentGrade);
    }

    public void GetSchoolStudentDetails()
    {
        // Compiler won't allow access to bStudent.secretNickname because of its protection level
        Console.WriteLine("SchoolStudentName : {0}", bStudent.StudentName);
        Console.WriteLine("SchoolStudentGrade : {0}", bStudent.StudentGrade);
        // schoolStudentSecretNickname = bStudent._secretNickname;
        Console.WriteLine("StudentSecretNicknameFromWithinSchoolClass : {0}", schoolStudentSecretNickname);

    }
}

