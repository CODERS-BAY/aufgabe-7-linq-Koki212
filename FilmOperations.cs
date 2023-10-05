namespace LinqExercise;

public class FilmOperations
{
    /// <returns>eine Liste aller Filme zurück.</returns>
    public List<Film> GetAllMovies()
    {
        throw new NotImplementedException();
    }

    /// <returns>ein Array von Filmen zurück, die von dem angegebenen Regisseur stammen.</returns>
    public Film[] GetMoviesByDirector(string directorName)
    {
        throw new NotImplementedException();
    }

    /// <returns>ein Array von Filmen zurück, die im angegebenen Erscheinungsjahr veröffentlicht wurden.</returns>
    public Film[] GetMoviesByYear(int releaseYear)
    {
        throw new NotImplementedException();
    }
   
    /// <returns>ein Array von Filmen zurück, die zwischen der angegebenen Mindest- und Höchstbewertung liegen.</returns>
    public Film[] GetMoviesByRatingRange(double minRating, double maxRating)
    {
        throw new NotImplementedException();
    }
    
    /// <returns>gibt ein Array mit den best bewerteten Filme zurück, sortiert nach Bewertung. numberOfFilms gibt die
    /// Anzahl der zurückgegeben Filme an.</returns>
    public Film[] GetMoviesByRatingSortedLimited(int numberOfFilms)
    {
        throw new NotImplementedException();
    }
}