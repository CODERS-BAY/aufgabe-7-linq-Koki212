namespace LinqExercise;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Alle Filme:");
        FilmOperations filmOperations = new FilmOperations();
        var films = filmOperations.GetAllMovies();
        foreach (Film film in films)
        {
            Console.WriteLine(film.title);
        }
        Console.WriteLine();

        Console.WriteLine("Wähle einen Director aus:");
        string director = Console.ReadLine();
        Console.WriteLine("Filme von " + director + ":");
        var filmsByDirector = filmOperations.GetMoviesByDirector(director);
        foreach (Film film in filmsByDirector)
        {
            Console.WriteLine(film.title);
        }
        Console.WriteLine();

        Console.WriteLine("Wähle ein Erscheinungsjahr aus:");
        int releaseYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Filme von " + releaseYear + ":");
        var filmsByYear = filmOperations.GetMoviesByYear(releaseYear);
        foreach (Film film in filmsByYear)
        {
            Console.WriteLine(film.title + ", Erscheinungsjahr: " + film.releaseYear);
        }
        Console.WriteLine();

        Console.WriteLine("Wähle eine Mindestbewertung aus:");
        double ratingMin = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Wähle eine Maximalbewertung aus:");
        double ratingMax = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Filme mit einer Bewertung zwischen " + ratingMin + " und " + ratingMax + ":");
        var filmsByRatingRange = filmOperations.GetMoviesByRatingRange(ratingMin, ratingMax);

        foreach (Film film in filmsByRatingRange)
        {
            Console.WriteLine(film.title + ", Rating: " + film.rating);
        }
        Console.WriteLine();

        Console.WriteLine("Wie viele bestbewertete Filme sollen angezeigt werden?");
        int maxFilms = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Die " + maxFilms + " best bewerteten Filme:");
        var filmsByRatingSortedLimited = filmOperations.GetMoviesByRatingSortedLimited(maxFilms);
        try
        {
            for (int i = 0; i <= maxFilms; i++)
            {
                Console.WriteLine(i + 1 + ". " + filmsByRatingSortedLimited[i].title + ", Rating: " + filmsByRatingSortedLimited[i].rating);
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
