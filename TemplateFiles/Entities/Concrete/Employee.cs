using Core.$safeprojectname$;

namespace $safeprojectname$.Concrete
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public string Fullname { get; set; }
    }
}
