namespace Academy.Core.Entities
{
    public class Course : Entity
    {
       public string Name {set; get;} = string.Empty;
       public string Code {set; get;} = string.Empty;
       public Guid DepartmentId {set; get;}
       public Department? Department {set;get;}
       public ICollection<Program>? Programs {set; get;}
    }
}