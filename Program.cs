

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using App;

bool running = true;

// Skapar variablen mylibrary som är av typen Library, dvs klassen vi skapade, dvs i denna variabel kan bara Library finnas.
// Med "new" skapar vi instans/object av klassen Library
// I parantesen är vad som skickas till Construktorn i klassen, dvs 10
Library mylibrary = new Library(libraryCapacity: 10);

// Skapa en ny bok
//Book Book1 = new Book(author: "kalle", titel: "Fiske", isbn: 101, category: "Horror", stock: 1);

// Lägg till en bok i biblan
//mylibrary.Add(newBook: book1);

// Ta ut bok i position 0 i array´n i biblan, är av typen Book
//Book viewedBook = mylibrary.View(position: 0);

// Använd boken och printa Author
//Console.WriteLine(viewedBook.Author);


// Ta bort bok i position 0 från biblan
mylibrary.Delete(0);


while (running)
{
    Console.WriteLine("Welcome to the Library!");
    Console.WriteLine("select wich option you would like to use(1-4)");
    Console.WriteLine("1. Add book");
    Console.WriteLine("2. Show book");
    Console.WriteLine("3. Delete book");
    Console.WriteLine("4. End program");
    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Book newBook = mylibrary.CreateNewBook();
            mylibrary.Add(newBook);
            Console.WriteLine("Successfully created a book");
            break;

        case "2":
            mylibrary.show();
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
            break;
    }


}


            //(titel, author, isbn, category, stock)
