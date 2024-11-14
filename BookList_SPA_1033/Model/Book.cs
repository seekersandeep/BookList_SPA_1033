using System.ComponentModel.DataAnnotations;

namespace BookList_SPA_1033.Model
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string ISBN { get; set; }
        public int Price { get; set; }


    }
}
