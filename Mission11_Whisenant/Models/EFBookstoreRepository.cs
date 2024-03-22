namespace Mission11_Whisenant.Models
{
    public class EFBookstoreRepository : IBookRepository
    {
        private BookstoreContext _context;

        public EFBookstoreRepository(BookstoreContext temp)
        {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
