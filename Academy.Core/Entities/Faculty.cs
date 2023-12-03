namespace Academy.Core.Entities
{
    public class Faculty : Entity
    {
        public string Name {set; get;} = string.Empty;
        public string Code {set; get;} = string.Empty;
        public Guid InstitutionId {set; get;}
    }
}
