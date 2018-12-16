using System;

namespace LibraryData.Models
{
    public class Patron
    { 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TelephoneNumber { get; set; }


        public virtual LibraryCard LibraryCard { get; set; } //Ctrl + K to comment out a line, Ctrl + u to uncomment
        public virtual LibraryBranch HomeLibraryBranch { get; set; }
    }
}
