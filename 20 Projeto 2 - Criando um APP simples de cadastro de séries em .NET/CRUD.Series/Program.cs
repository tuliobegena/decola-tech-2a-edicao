using CRUD.TerrorMovies;
using CRUD.TerrorMovies.Interfaces;
class Program
{
static MovieRepository repository = new MovieRepository();
static void Main(string[] args)
{
    string UserOption = ObtainUserOption();

    while (UserOption.ToUpper() != "X")
    {
        switch (UserOption)
        {
            case "1":
                ListMovies();
                break;
            case "2":
                InsertMovie();
                break;
            case "3":
                UpdateMovie();
                break;
            case "4":
                DeleteMovie();
                break;
            case "5":
                ViewMovie();
                break;
            case "C":
                Console.Clear();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        UserOption = ObtainUserOption();
    }

    System.Console.WriteLine("We'll see you, tonight.");
    System.Console.WriteLine();
}

private static void ViewMovie()
{
    System.Console.WriteLine("Type the movie Id: ");
    int indexMovie = int.Parse(Console.ReadLine());

    var movie = repository.ReturnId(indexMovie);

    System.Console.WriteLine(movie);
}
private static  void DeleteMovie()
{
    System.Console.WriteLine("Type the movie Id: ");
    int indexMovie = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Are you sure do you want to delete the movie #{0} ?" + Environment.NewLine + "Type the Id again to confirm or ohter Id to go back.", indexMovie);
    int indexDelete = int.Parse(Console.ReadLine());

    if (indexMovie == indexDelete)
    {
        System.Console.WriteLine("The movie #{0} was deleted.", indexMovie);
        repository.Delete(indexMovie);
    }else
    {
        System.Console.WriteLine("The movie #{0} is intact.", indexMovie);
    }
}

private static void UpdateMovie()
{
    System.Console.WriteLine("Type the movie Id: ");
    int indexMovie = int.Parse(Console.ReadLine());

    foreach (int i in Enum.GetValues(typeof(Genre)))
    {
        System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genre), i));
    }
    System.Console.WriteLine("Type the genre among the options above: ");
    int entryGenre = int.Parse(Console.ReadLine());

    switch (entryGenre)
        {
            case 1:
                foreach (int i in Enum.GetValues(typeof(Subgenre1)))
                    {
                        System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenre1), i));
                    }
                System.Console.WriteLine("Type the subgenre among the options above: ");
                break;
            case 2:
                foreach (int i in Enum.GetValues(typeof(Subgenre2)))
                    {
                        System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenre2), i));
                    }
                System.Console.WriteLine("Type the subgenre among the options above: ");
                break;
            case 3:
                foreach (int i in Enum.GetValues(typeof(Subgenre3)))
                    {
                        System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenre3), i));
                    }
                System.Console.WriteLine("Type the subgenre among the options above: ");
                break;
            case 4:
                foreach (int i in Enum.GetValues(typeof(Subgenre4)))
                    {
                        System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenre4), i));
                    }
                System.Console.WriteLine("Type the subgenre among the options above: ");
                break;
            case 5:
               foreach (int i in Enum.GetValues(typeof(Subgenre5)))
                    {
                        System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenre5), i));
                    }
                System.Console.WriteLine("Type the subgenre among the options above: ");
                break;
            case 6:
                foreach (int i in Enum.GetValues(typeof(Subgenre6)))
                    {
                        System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenre6), i));
                    }
                System.Console.WriteLine("Type the subgenre among the options above: ");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        int entrySubgenre = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Type the movie title: ");
    string entryTitle = Console.ReadLine();

    System.Console.WriteLine("Type the movie year: ");
    int entryYear = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Type the movie description: ");
    string entryDescription = Console.ReadLine();
    
    TerrorMovie updateMovie = new TerrorMovie(id: indexMovie,
                                            genre: (Genre)entryGenre,
                                            subgenre: (Subgenre)entrySubgenre,
                                            title: entryTitle,
                                            year: entryYear,
                                            description: entryDescription);
    repository.Update(indexMovie, updateMovie);

}
private static void ListMovies()
{
    System.Console.WriteLine("List movies");

    var list = repository.List();

    if (list.Count == 0)
    {
        System.Console.WriteLine("No movie registered");
        return;
    }
    
    foreach (var TerrorMovie in list)
    {
        var deleted = TerrorMovie.ReturnDeleted();
        System.Console.WriteLine("#ID {0}: - {1} {2}", TerrorMovie.returnId(), TerrorMovie.returnTitle(), deleted ? "(Deleted)" : "");
    }
}

private static void InsertMovie()
{
    System.Console.WriteLine("Insert new Movie");

    foreach (int i in Enum.GetValues(typeof(Genre)))
    {
        System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genre), i));
    }
    System.Console.WriteLine("Type the genre among the options above: ");
    int entryGenre = int.Parse(Console.ReadLine());
    //trying subgenre start
    switch (entryGenre)
        {
            case 1:
                foreach (int i in Enum.GetValues(typeof(Subgenre1)))
                    {
                        System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenre1), i));
                    }
                System.Console.WriteLine("Type the subgenre among the options above: ");
                break;
            case 2:
                foreach (int i in Enum.GetValues(typeof(Subgenre2)))
                    {
                        System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenre2), i));
                    }
                System.Console.WriteLine("Type the subgenre among the options above: ");
                break;
            case 3:
                foreach (int i in Enum.GetValues(typeof(Subgenre3)))
                    {
                        System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenre3), i));
                    }
                System.Console.WriteLine("Type the subgenre among the options above: ");
                break;
            case 4:
                foreach (int i in Enum.GetValues(typeof(Subgenre4)))
                    {
                        System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenre4), i));
                    }
                System.Console.WriteLine("Type the subgenre among the options above: ");
                break;
            case 5:
               foreach (int i in Enum.GetValues(typeof(Subgenre5)))
                    {
                        System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenre5), i));
                    }
                System.Console.WriteLine("Type the subgenre among the options above: ");
                break;
            case 6:
                foreach (int i in Enum.GetValues(typeof(Subgenre6)))
                    {
                        System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Subgenre6), i));
                    }
                System.Console.WriteLine("Type the subgenre among the options above: ");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        int entrySubgenre = int.Parse(Console.ReadLine());
    //trying subgenre finish
    System.Console.WriteLine("Type the movie title: ");
    string entryTitle = Console.ReadLine();

    System.Console.WriteLine("Type the movie year: ");
    int entryYear = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Type the movie description: ");
    string entryDescription = Console.ReadLine();
    
    TerrorMovie newMovie = new TerrorMovie(id: repository.NextId(),
                                            genre: (Genre)entryGenre,
                                            subgenre: (Subgenre)entrySubgenre,
                                            title: entryTitle,
                                            year: entryYear,
                                            description: entryDescription);
    repository.Insert(newMovie);

}

private static string ObtainUserOption()
{
    System.Console.WriteLine();
    System.Console.WriteLine("Terryfying things do happen here!");
    System.Console.WriteLine("Choose an option:");

    System.Console.WriteLine("1 - List movies");
    System.Console.WriteLine("2 - Insert new movie");
    System.Console.WriteLine("3 - Update movie");
    System.Console.WriteLine("4 - Delete movie");
    System.Console.WriteLine("5 - View movie");
    System.Console.WriteLine("C - Clear screen");
    System.Console.WriteLine("X - Exit");
    System.Console.WriteLine();

    string UserOption = Console.ReadLine().ToUpper();
    System.Console.WriteLine();
    return UserOption;
}
}