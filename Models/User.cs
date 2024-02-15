namespace ShipAndTrack.Models
{
    public class User{
        public int ID {get;set;}
        public string Email {get;set;}
        public string Password {get;set;}
        public string FullName {get;set;}
        public string Phone {get;set;}

        public string Role {get;set;}

        public ICollection<Package> Packages {get;set;}
    }
}