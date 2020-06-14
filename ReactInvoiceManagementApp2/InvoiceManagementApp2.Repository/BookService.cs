using InvoiceManagementApp2.Entities.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManagementApp2.Repository
{
    public class BookService
    {
        public readonly ApplicationDbContext _context = null;
        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
