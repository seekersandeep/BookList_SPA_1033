using BookList_SPA_1033.Data;
using BookList_SPA_1033.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList_SPA_1033.Pages.Booklist
{
    public class UpsertModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public UpsertModel(ApplicationDbContext context)
        {
            _context = context;

        }
        public Book Book { get; set; }
        public async Task<IActionResult> OnGet(int? id)
        {
            Book = new Book();
            if (id == null) return Page();//create;

            Book = await _context.Books.FindAsync(id);
            if (Book == null) return NotFound();
            return Page();
        }
        public async Task<IActionResult> OnPost(Book book)
        {
            if (book == null) return NotFound();
            if (!ModelState.IsValid) return Page();
            if (book.Id == 0)
                _context.Books.Add(book);
            else
                _context.Books.Update(book);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
