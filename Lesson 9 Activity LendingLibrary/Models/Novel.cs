namespace Lesson_9_Activity_LendingLibrary.Models
{
    public class Novel : Book
    {
        public string Genre { get; set; }

        public Novel(string title, string author, int publicationyear, string genre)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationyear;
            Genre = genre;
        }
    }
}