namespace BookStoreApp.API.Models.Book
{
    public class BookDetailsDto : BookReadOnlyDto
    {
        public int Year { get; set; }
        public string Isbn { get; set; } = null!;
        public string Summary { get; set; }
    }
}
