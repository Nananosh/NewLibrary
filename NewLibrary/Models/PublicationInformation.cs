namespace NewLibrary.Models
{
    public class PublicationInformation
    {
        public int Id { get; set; }
        
        public int BookId { get; set; }
        public int PublisherId { get; set; }
        public int YearPubl { get; set; }
        public string PlacePublication { get; set; }
        public string BookName { get; set; }
        public int BookPages { get; set; }
        public string BookImage { get; set; }
        public string PublisherName { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImage { get; set; }
        public string GreneName { get; set; }

        public PublicationInformation(int id, int bookId, int publisherId, int yearPubl, string placePublication, string bookName, int bookPages, string bookImage, string publisherName, string authorImage, string authorName,  string greneName)
        {
            Id = id;
            BookId = bookId;
            PublisherId = publisherId;
            YearPubl = yearPubl;
            PlacePublication = placePublication;
            BookName = bookName;
            BookPages = bookPages;
            BookImage = bookImage;
            PublisherName = publisherName;
            AuthorName = authorName;
            AuthorImage = authorImage;
            GreneName = greneName;
        }

        public PublicationInformation()
        {
            
        }
    }
}