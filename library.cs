using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace App;

class Library
{
    public Book[] Books; // Array med böcker
    public int LibraryCapacity = 10; // Hur många böcker ska biblan ha?

    // Constructor - Körs med "new", kanske bra ställe å skapa böcker i bibl när man skapar ett library
    public Library(int libraryCapacity)
    {
        Books = new Book[libraryCapacity]; // Skapa en bok array med storlek som libraryCapacity
        LibraryCapacity = libraryCapacity;
        //lägger alltid till en bok med constructorn
        Book book1 = new Book("Fiskebok", "Robin", 01, "lärning", 1);
        this.Add(book1);
        Console.WriteLine($"created book {book1.Titel}");
    }

    public void Add(Book newBookToAdd)
    {
        for (int i = 0; i < LibraryCapacity; i++)
        {
            if (Books[i] == null || Books[i].Titel == "")
            {
                Console.WriteLine($"added book {newBookToAdd}");
                Books[i] = newBookToAdd;
                break;
            }
        }
    }

    public void show()
    {
        Console.WriteLine($"chosse between books 1-{LibraryCapacity + 1}");

        for (int i = 0; i < LibraryCapacity; i++)
        {
            if (Books[i] != null)
            {
                Console.WriteLine($"position: {i + 1} has book {Books[i].Titel}");
            }
        }


        Console.WriteLine("what postitioned book would you like to view?");
        int Booktoview = Convert.ToInt32(Console.ReadLine());
        Booktoview--;

        if (Books[Booktoview] != null && Books[Booktoview].Titel != "")
        {
            Console.Clear();
            Console.WriteLine($"position: {Booktoview}\n Titel: {Books[Booktoview].Titel}\n Author: {Books[Booktoview].Author}\n ISBN: {Books[Booktoview].ISBN}\n Category: {Books[Booktoview].Category}\n Stock: {Books[Booktoview].Stock}\n ");
        }
    }

    //(titel, author, isbn, category, stock)

    //public Book View(int position)

    //return Books[position]; // Returnera tillbaka bok i postion i array

    public void Delete(int position)
    {
        Books[position] = null; // Ta bort bok från position i array
    }

    public Book CreateNewBook()
    {
        Console.WriteLine("What is the titel of the book?");
        string titel = Console.ReadLine();
        Console.WriteLine("who is the author of the book?");
        string author = Console.ReadLine();
        Console.WriteLine("what is the ISBN number of the book?");
        int isbn = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("in whatcategory is the book in?");
        string category = Console.ReadLine();
        Console.WriteLine("how many of this book are you adding?");
        int stock = Convert.ToInt32(Console.ReadLine());
        Book NewBook = new Book(titel, author, isbn, category, stock);
        Console.WriteLine($"title: {NewBook.Titel}\nAuthor: {NewBook.Author}\nCategory: {NewBook.Category}\nISBN number:{NewBook.ISBN}\nadded: {NewBook.Stock}");


        return NewBook;
    }

    // public void AddNumbers(int x, int y)
    // {
    //     Console.WriteLine(x + y);
    // }

    // public int AddNumbers(int x, int y)
    // {
    //     return (x + y);
    // }
}


//Filtrera böcker baserat på författare.
//Visa alla böcker som har en viss kategori.
