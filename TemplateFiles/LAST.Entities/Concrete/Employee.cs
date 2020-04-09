using $ext_safeprojectname$.Core.Entities;

namespace $safeprojectname$.Concrete
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public string Fullname { get; set; }
    }
}
