namespace SchoolCore.Entities
{
    public interface IPlace
    {
       string Address {get; set;}  
       void CleanPlace();
    }
}