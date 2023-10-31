﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pop_maria_lab2.Data;
using pop_maria_lab2.Models;

namespace pop_maria_lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly pop_maria_lab2.Data.pop_maria_lab2Context _context;

        public IndexModel(pop_maria_lab2.Data.pop_maria_lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                    .Include(b => b.Publisher)
                    .ToListAsync();
            }
        }
    }
}
