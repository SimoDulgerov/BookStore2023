using BookStore.Models;

namespace BookStore.DL
{
    public static class InMemmory
    {
        public static List<Author> Authors =
            new List<Author>()
            {
                new Author()
                {
                    Id = 1,
                    Name = "Jhon",
                    BirthDay = DateTime.Now,
                },
                new Author()
                {
                    Id = 2,
                    Name = "Simeon",
                    BirthDay = DateTime.Now,
                },
                new Author()
                {
                    Id = 3,
                    Name = "Victoria",
                    BirthDay = DateTime.Now,
                }
            };
    }
}