using Midterm;
using System.Collections.Generic;
using Xunit;


namespace MidtermTest
{
    public class MovieMenuTest
    {
        [Fact]
        public void ItemInList()
        {
            var movie = new Movie();
            List<Movie> list = new List<Movie>();

            list.Add(movie);

            Assert.Contains(movie, list);
        }

        [Fact]
        public void AddMovieCheck()
        {
            var movie = new Movie();
            movie.MovieName = "The Devil Wears Prada";
            movie.MainActor = "Meryl Streep";
            movie.Genre = "Comedy";
            movie.Director = "David Frankel";
            movie.Rating = "PG-13";

            var result = MovieMenu.AddMovie();

            Assert.Equal(movie, result);
        }

        [Fact]
        public void UserChoiceInRange()
        {
            Assert.InRange(2, 1, 9);
        }
    }
}
