namespace MVCDemo.Models
{
    public interface IStudentRepository
    {
        Student GetStudent(int id);
        void AddStudent(Student s);
    }
}
