using System.ComponentModel.DataAnnotations;

// Think of a Model as a database table

namespace RunGroopWebApp.Models
{
    public class Address
    {
        [Key]  //This [key] is what is referring to a primary key

        public int Id { get; set; }  //'public' keyword allows us to access this 'Id' in other places of our app, 'private' is the opposite
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }

    }
}
