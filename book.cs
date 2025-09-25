using System.Net.Security;

namespace App;

class Book
{
    public string Titel = "";
    public string Author = "";
    public int ISBN;
    public string Category = "";
    public int Stock;

    // Constructor - Körs när man skapar instans/object av klassen. dvs med "new"
    public Book(string titel, string author, int isbn, string category, int stock)
    {
        Titel = titel;
        Author = author;
        ISBN = isbn;
        Category = category;
        Stock = stock;
    }

    public void Update(string titel, string author, int isbn, string category, int stock)
    {
        Titel = titel;
        Author = author;
        ISBN = isbn;
        Category = category;
        Stock = stock;
    }


}
