namespace BtkAkademi.Models
{
    public class Candicate
    {
       public String? Email {get;set;} = String.Empty;
       public String? FirstName {get;set;} = String.Empty;
       public String? LastName {get;set;} = String.Empty;
       public int? Age {get;set;}

       public String? SelectedCourse {get;set;} = String.Empty;

       public DateTime ApplyAt {get;set;}

       public Candicate(){
         ApplyAt=DateTime.Now;
       }
    }
}