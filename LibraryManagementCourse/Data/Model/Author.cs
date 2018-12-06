using System;
using System.Collections.Generic;

namespace LibraryManagementCourse.Data.Model
{
    public class Author
    {
        public Author()
        {
        }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }

      
    }
}