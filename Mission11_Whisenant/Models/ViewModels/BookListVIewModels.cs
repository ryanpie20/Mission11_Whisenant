namespace Mission11_Whisenant.Models.ViewModels
{
    public class BookListVIewModels
    {
        public IQueryable<Book> Books { get; set;}

        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();
    }
}
