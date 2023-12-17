namespace Academy.Services.Contracts.Institutions
{
    public class InstitutionRsp<T>
    {
        public string Code {set; get;} = string.Empty;
        public string? Messgae {set; get;}
        public T? Result {set; get;}
    }
}