using System.Collections.Generic;

namespace MyLibrary.Models.Patron
{
    public class PatronIndexModel
    {
        public IEnumerable<PatronDetailModel> Patrons { get; set; }
    }
}
