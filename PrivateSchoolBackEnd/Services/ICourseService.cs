namespace PrivateSchoolBackEnd.Services
{
    public interface ICourseService
    {
        List<Course> GetAllCourses();
        Course GetCourse(int id);
        void DeleteCourse(int id);
        Course UpdateCourse (int id);
        Course CreateCourse (Course course);
    }
}
