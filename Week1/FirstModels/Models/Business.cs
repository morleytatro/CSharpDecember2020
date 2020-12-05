using System.ComponentModel.DataAnnotations;

namespace FirstModels.Models
{
    public class Business
    {
        [Required(ErrorMessage = "You must supply a name!")]
        public string Name {get;set;}

        [Range(1, 15, ErrorMessage = "Must be between 1 and 15.")]
        public int NumEmployees {get;set;}

        public string City {get;set;}

        public string State {get;set;}
    }
}