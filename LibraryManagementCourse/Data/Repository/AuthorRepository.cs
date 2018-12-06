using LibraryManagementCourse.Data.Interfaces;
using LibraryManagementCourse.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementCourse.Data.Repository
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {


        public AuthorRepository( LibraryDbContext context):base(context)
        {
                
        }
        public IEnumerable<Author> GetAllwithBooks()
        {
            return _context.Authors.Include(a => a.Books);
        }

        public Author GetWithBooks(int id)
        {
            return _context.Authors
                .Where(a => a.AuthorId == id)
                .Include(a => a.Books)
                .FirstOrDefault();
        }
    }
}
