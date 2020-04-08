using Core.Entities;

namespace Entities.Concrete
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public string Fullname { get; set; }
    }
}
