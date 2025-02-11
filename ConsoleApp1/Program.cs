using System;
using System.Collections.Generic;

class Book
{
    // Data members
    public string Author { get; set; }
    public double Price { get; set; }
    public string Title { get; set; }
    public int BookNumber { get; set; }
    public int NumberOfCopies { get; set; }

    // Constructor
    public Book(string author, double price, string title, int bookNumber, int numberOfCopies)
    {
        Author = author;
        Price = price;
        Title = title;
        BookNumber = bookNumber;
        NumberOfCopies = numberOfCopies;
    }

    // Display book details
    public void Display()
    {
        Console.WriteLine($"Book Number: {BookNumber}, Title: {Title}, Author: {Author}, Price: Ksh {Price:N2}, Copies: {NumberOfCopies}");
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    // Method to add a new book
    public void AddBook(string author, double price, string title, int bookNumber, int numberOfCopies)
    {
        books.Add(new Book(author, price, title, bookNumber, numberOfCopies));
        Console.WriteLine("Book added successfully.");
    }

    // Method to display all books
    public void DisplayBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available in the database.");
        }
        else
        {
            Console.WriteLine("\nList of Books:");
            foreach (var book in books)
            {
                book.Display();
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        Console.Write("Enter the number of books to add: ");
        int numBooks = int.Parse(Console.ReadLine());

        for (int i = 0; i < numBooks; i++)
        {
            Console.WriteLine($"\nEnter details for book {i + 1}:");
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Book Number: ");
            int bookNumber = int.Parse(Console.ReadLine());
            Console.Write("Number of Copies: ");
            int numberOfCopies = int.Parse(Console.ReadLine());

            library.AddBook(author, price, title, bookNumber, numberOfCopies);
        }

        // Display all books
        library.DisplayBooks();
    }
}
