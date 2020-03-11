using Midterm;
using System.Collections.Generic;
using Xunit;


namespace MidtermTest
{
    public class TVMenuTest
    {
        [Fact]
        public void AddShowTest()
        {
            var show = new TVShow();
            show.ShowName = "The Devil Wears Prada";
            show.MainActor = "Meryl Streep";
            show.Genre = "Comedy";
            show.Director = "David Frankel";
            show.Rating = "PG-13";

            var result = TVMenu.AddShow();

            Assert.Equal(show, result);
        }

        [Fact]
        public void ItemInList()
        {
            var show = new TVShow();
            List<TVShow> list = new List<TVShow>();

            list.Add(show);

            Assert.Contains(show, list);
        }

        [Fact]
        public void UserChoiceInRange()
        {
            Assert.InRange(2, 1, 9);
        }
    }
}
