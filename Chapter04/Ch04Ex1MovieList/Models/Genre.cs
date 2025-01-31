namespace Ch04Ex1MovieList.Models
{
    public class Genre
    {
        // GenreId property is the primary key. Because this property uses the string 
        // type instead of int type, the database doesn't generate values for it
        public string GenreId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
