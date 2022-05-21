using TranslationDictionary.DAL.Concrete;
using TranslationDictionary.DAL.Entities;

Console.WriteLine("add - to add a new word\nupdate - for the word whose meaning you want to change\nlist - to see all the words\ndelete - for the word you want to delete\nquit - to exit");

while (true)
{
    Console.WriteLine("\nType the action you want to do! (/help for commands)");
    string action = Console.ReadLine();
    if (action == "add" || action == "Add")
    {
        Create();
    }
    if (action == "update" || action == "Update")
    {
        Update();
    }
    if (action == "list" || action == "List")
    {
        GetAll();
    }
    if (action == "delete" || action == "Delete")
    {
        Delete();
    }
    if (action == "quit" || action == "Quit")
    {
        break;
    }
    if (action == "/help" || action == "/Help")
    {
        Console.WriteLine("add - to add a new word\nupdate - for the word whose meaning you want to change\nlist - to see all the words\ndelete - for the word you want to delete\nquit - to exit");
    }
}
static void Create()
{
    Console.WriteLine("Type the word you learned the meaning of :");
    string first = Console.ReadLine();
    Console.WriteLine("Meaning? :");
    string second = Console.ReadLine();
    var word = new WordList()
    {
        firstWord = first,
        secondWord = second
    };
    new WordsDal().Add(word);
}

static void GetAll()
{
    new WordsDal().GetAll().ForEach(w => Console.WriteLine(w));
}

static void Update()
{
    Console.WriteLine("Type the word you want to change the meaning of :");
    string first = Console.ReadLine();
    Console.WriteLine("New meaning? :");
    string second = Console.ReadLine();
    var word = new WordList()
    {
        firstWord = first,
        secondWord = second
    };
    new WordsDal().Update(word);
}

static void Delete()
{
    Console.WriteLine("Type the word you want to delete :");
    string first = Console.ReadLine();
    var word = new WordList()
    {
        firstWord = first
    };
    new WordsDal().Delete(word);
}