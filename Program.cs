namespace LayeredArchitectureAndRepositorySimpleLibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Main entry point for the library system application
            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("4. Register Member");
                Console.WriteLine("5. Exit");
                Console.Write("Choose option: ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the book title");
                        string Title = Console.ReadLine();
                        Console.WriteLine("Enter the book author");
                        string Author = Console.ReadLine();
                        bool IsAvailable = true; // Assuming new books are available by default

                        // bookRepo.AddBook(Title, Author, IsAvailable);

                        break;
                    case "2":
                        Console.WriteLine("Borrowing a book is not implemented yet.");
                        break;
                    case "3":
                        Console.WriteLine("Returning a book is not implemented yet.");
                        break;
                    case "4":
                        Console.WriteLine("Registering a member is not implemented yet.");
                        break;
                    case "5":
                        Console.WriteLine("Exiting the application.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }
    }
}
