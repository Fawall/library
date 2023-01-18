

class Book {

    public string Title { get; set;}
    public string Description { get; set;}
    public string Genre { get; set; }
    public string Pages {get; set;}


    public Book(string title, string description, string genre, string pages)
    {
        Title = title;
        Description = description;
        Genre = genre;
        Pages = pages;
    }


}