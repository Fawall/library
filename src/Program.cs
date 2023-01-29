using src.Repository;

LibraryRepository libraryRepository = new LibraryRepository();

System.Console.WriteLine("Welcome. Type what you want to do");
while(true)
{
    System.Console.WriteLine();
    System.Console.WriteLine("##################################\n"+
                            "#                               #\n"+
                            "#  1 - Insert a new book        #\n"+
                            "#  2 - Get all books            #\n"+
                            "#  3 - Delete book              #\n"+
                            "#  4 - Edit details of book     #\n"+
                            "#  5 - Search one specify book  #\n"+
                            "#  6 - Exit                     #\n"+
                            "#                               #\n"+
                            "#################################");


    string input = string.Empty;

    while(string.IsNullOrWhiteSpace(input))
    {
        System.Console.WriteLine("Please enter a valid value.");
        input = Console.ReadLine();
    }
  
    
    switch(input)
    {
        case "1":
            System.Console.WriteLine("Insert: Title of book, description, genre and number of pages");
            
            System.Console.Write("Title: ");
            string? title = Console.ReadLine();
                

            System.Console.Write("Description: ");
            string? description = Console.ReadLine();

            System.Console.Write("Genre: ");
            string? genre = Console.ReadLine();

            System.Console.Write("Pages: ");
            int pages = Convert.ToInt32(Console.ReadLine());
            
            
            libraryRepository.InsertBook(title, description, genre, pages);

            break;
        
        case "2":
    
            var books = libraryRepository.GetAllBooks();

            int numberOfBooks = books.Count;
            System.Console.WriteLine($"Number of Books: {numberOfBooks}\n");
            foreach(var element in books)
            {     
                System.Console.WriteLine($"ID:{element.Id}, Title: {element.Title}, Description: {element.Description}, Pages: {element.Pages}");
            }
            
            break;
        
        case "3":

            System.Console.WriteLine("Please inform the ID of Book that you want remove");
            int id = Convert.ToInt32(Console.ReadLine());
        
            libraryRepository.RemoveBook(id);
            break;
        
        case "4":
            throw new System.NotImplementedException();
            break;
        
        case "5":
            throw new System.NotImplementedException();
            break;


        default:
            System.Console.WriteLine("Please enter with valid value");
            System.Console.WriteLine("##################################\n"+
                                      "#                               #\n"+
                                      "#  1 - Insert a new book        #\n"+
                                      "#  2 - Edit details of book     #\n"+
                                      "#  3 - Delete book              #\n"+
                                      "#  4 - Get all books            #\n"+
                                      "#  5 - Search one specify book  #\n"+
                                      "#  6 - Exit                     #\n"+
                                      "#                               #\n"+
                                      "#################################");
        break;
    }




}

