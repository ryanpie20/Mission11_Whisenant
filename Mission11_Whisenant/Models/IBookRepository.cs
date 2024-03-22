namespace Mission11_Whisenant.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
