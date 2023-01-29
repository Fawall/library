

public class Book {

    private static int _nextId = 1;
    public int Id {get; private set;}
    public string Title { get; set;}
    public string Description { get; set;}
    public string Genre { get; set; }
    public int Pages {get; set;}


    public Book(string title, string description, string genre, int pages)
    {
        this.Id = _nextId++;  
        Title = title;
        Description = description;
        Genre = genre;
        Pages = pages;
    }


}