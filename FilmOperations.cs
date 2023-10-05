using Newtonsoft.Json;

namespace LinqExercise;

public class FilmOperations
{
    /// <returns>eine Liste aller Filme zurück.</returns>
    public List<Film> GetAllMovies()
    {
        StreamReader reader = new(@"C:\Users\HP\source\repos\aufgabe-7-linq-Koki212\films.json");
        string json = reader.ReadToEnd();
        List<Film> films = JsonConvert.DeserializeObject<List<Film>>(json);
        
        // Querys with LINQ
        var filmsQuery = from film in films
                    select film;
        var filmsList = filmsQuery.ToList();
        return filmsList;
    }

    /// <returns>ein Array von Filmen zurück, die von dem angegebenen Regisseur stammen.</returns>
    public Film[] GetMoviesByDirector(string directorName)
    {
        // Querys witout LINQ
        // Film[] films = GetAllMovies().Where(film => film.director == directorName).ToArray();
        // return films;

        // Querys with LINQ
        var filmsQuery = from film in GetAllMovies()
                         where film.director == directorName
                         select film;
        var filmsList = filmsQuery.ToList();
        return filmsList.ToArray();

        throw new NotSupportedException(directorName + " ist kein gültiger Regisseur.");
    }

    /// <returns>ein Array von Filmen zurück, die im angegebenen Erscheinungsjahr veröffentlicht wurden.</returns>
    public Film[] GetMoviesByYear(int releaseYear)
    {
        // Querys witout LINQ
        // Film[] films = GetAllMovies().Where(film => film.releaseYear == releaseYear).ToArray();
        // return films;

        // Querys with LINQ
        var filmsQuery = from film in GetAllMovies()
                         where film.releaseYear == releaseYear
                         select film;
        var filmsList = filmsQuery.ToList();
        return filmsList.ToArray();
        throw new NotImplementedException();
    }
   
    /// <returns>ein Array von Filmen zurück, die zwischen der angegebenen Mindest- und Höchstbewertung liegen, absteigend.</returns>
    public Film[] GetMoviesByRatingRange(double minRating, double maxRating)
    {
        // Querys witout LINQ
        // Film[] films = GetAllMovies().Where(film => film.rating >= minRating && film.rating <= maxRating).OrderByDescending(film => film.rating).ToArray();
        // return films;

        // Querys with LINQ
        var filmsQuery = from film in GetAllMovies()
                         where film.rating >= minRating && film.rating <= maxRating
                         orderby film.rating descending
                         select film;
        var filmsList = filmsQuery.ToList();
        return filmsList.ToArray();
        throw new NotImplementedException();
    }
    
    /// <returns>gibt ein Array mit den best bewerteten Filme zurück, sortiert nach Bewertung. numberOfFilms gibt die
    /// Anzahl der zurückgegeben Filme an.</returns>
    public Film[] GetMoviesByRatingSortedLimited(int numberOfFilms)
    {
        // Querys witout LINQ
        // Film[] films = GetAllMovies().OrderByDescending(film => film.rating).Take(numberOfFilms).ToArray();
        // return films;

        // Querys with LINQ
        var filmsQuery = from film in GetAllMovies()
                         orderby film.rating descending
                         select film;
        var filmsList = filmsQuery.ToList();
        return filmsList.Take(numberOfFilms).ToArray();
        throw new NotImplementedException();
    }
}