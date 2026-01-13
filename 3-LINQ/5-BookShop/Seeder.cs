using System;
using System.Collections.Generic;

namespace BookShop
{
    partial class Program
    {
        static List<Author> SeedAuthors()
        {
            return new List<Author>
            {
                new Author(1, "Szabó Magda", "Magyarország"),
                new Author(2, "Jókai Mór", "Magyarország"),
                new Author(3, "Rejtő Jenő", "Magyarország"),
                new Author(4, "George Orwell", "Egyesült Királyság"),
                new Author(5, "J. K. Rowling", "Egyesült Királyság"),
                new Author(6, "Stephen King", "Egyesült Államok"),
                new Author(7, "J. R. R. Tolkien", "Egyesült Királyság"),
                new Author(8, "Frank Herbert", "Egyesült Államok")
            };
        }

        static List<Book> SeedBooks()
        {
            return new List<Book>
            {
                // Szabó Magda
                new Book( 1, "Az ajtó",                     1, "Dráma",      1987, 365, 4200),
                new Book( 2, "Abigél",                      1, "Ifjúsági",  1970, 420, 3900),
                new Book( 3, "Régimódi történet",           1, "Dráma",      1977, 512, 4500),

                // Jókai Mór
                new Book( 4, "Az aranyember",              2, "Regény",    1872, 620, 4800),
                new Book( 5, "A kőszívű ember fiai",          2, "Történelmi",1869, 680, 5200),

                // Rejtő Jenő
                new Book( 6, "Piszkos Fred, a kapitány",    3, "Humor",     1940, 280, 3500),
                new Book( 7, "A három testőr Afrikában",    3, "Humor",     1938, 310, 3600),
                new Book( 8, "Elveszett cirkáló",           3, "Humor",     1939, 295, 3400),

                // George Orwell
                new Book( 9, "1984",                        4, "Disztópia", 1949, 328, 4300),
                new Book(10, "Állatfarm",                   4, "Szépirodalom",1945,112, 2800),

                // J. K. Rowling
                new Book(11, "Harry Potter és a bölcsek köve",5,"Fantasy",1997,320,5000),
                new Book(12, "Harry Potter és a titkok kamrája",5,"Fantasy",1998,341,5400),
                new Book(13, "Harry Potter és az azkabani fogoly",5,"Fantasy",1999,435,5500),

                // Stephen King
                new Book(14, "Ragyogás",                    6, "Horror",    1977, 447, 4800),
                new Book(15, "Az",                          6, "Horror",    1986, 1138,6500),
                new Book(16, "Halálsoron",                  6, "Dráma",     1996, 592, 5300),

                // Tolkien
                new Book(17, "A hobbit",                    7, "Fantasy",   1937, 310, 4900),
                new Book(18, "A Gyűrűk Ura – A gyűrű szövetsége",7,"Fantasy",1954,423, 5800),
                new Book(19, "A Gyűrűk Ura – A két torony", 7, "Fantasy",   1954, 352, 5500),

                // Frank Herbert
                new Book(20, "Dűne",                        8, "Sci-fi",    1965, 412, 6100),
                new Book(21, "A Dűne messiása",             8, "Sci-fi",    1969, 256, 5900),
                new Book(22, "A Dűne gyermekei",            8, "Sci-fi",    1976, 416, 6200)
            };
        }

        static List<Order> SeedOrders()
        {
            return new List<Order>
            {
                new Order( 1,  1,  80, DateTime.Now.AddDays(-30)),
                new Order( 2,  2,  95, DateTime.Now.AddDays(-29)),
                new Order( 3,  3,  60, DateTime.Now.AddDays(-28)),

                new Order( 4,  4, 120, DateTime.Now.AddDays(-27)),
                new Order( 5,  5,  90, DateTime.Now.AddDays(-26)),

                new Order( 6,  6, 150, DateTime.Now.AddDays(-25)),
                new Order( 7,  7, 130, DateTime.Now.AddDays(-24)),
                new Order( 8,  8, 110, DateTime.Now.AddDays(-23)),

                new Order( 9,  9, 170, DateTime.Now.AddDays(-22)),
                new Order(10, 10, 140, DateTime.Now.AddDays(-21)),

                new Order(11, 11, 220, DateTime.Now.AddDays(-20)),
                new Order(12, 12, 210, DateTime.Now.AddDays(-19)),
                new Order(13, 13, 200, DateTime.Now.AddDays(-18)),

                new Order(14, 14, 160, DateTime.Now.AddDays(-17)),
                new Order(15, 15, 180, DateTime.Now.AddDays(-16)),
                new Order(16, 16, 140, DateTime.Now.AddDays(-15)),

                new Order(17, 17, 190, DateTime.Now.AddDays(-14)),
                new Order(18, 18, 170, DateTime.Now.AddDays(-13)),
                new Order(19, 19, 160, DateTime.Now.AddDays(-12)),

                new Order(20, 20, 150, DateTime.Now.AddDays(-11)),
                new Order(21, 21, 120, DateTime.Now.AddDays(-10)),
                new Order(22, 22, 130, DateTime.Now.AddDays(-9)),

                new Order(23, 11,  90, DateTime.Now.AddDays(-8)),
                new Order(24, 15,  70, DateTime.Now.AddDays(-7)),
                new Order(25, 20,  85, DateTime.Now.AddDays(-6)),

                new Order(26,  9,  60, DateTime.Now.AddDays(-5)),
                new Order(27, 17,  75, DateTime.Now.AddDays(-4)),
                new Order(28, 18,  65, DateTime.Now.AddDays(-3)),

                new Order(29,  11,  85, DateTime.Now.AddDays(-7)),
                new Order(30,  2,  30, DateTime.Now.AddDays(-5)),
                new Order(31, 7,  15, DateTime.Now.AddDays(-3)),
                new Order(32, 11,  20, DateTime.Now.AddDays(-4)),

                new Order(29,  4,  55, DateTime.Now.AddDays(-2)),
                new Order(30,  6,  50, DateTime.Now.AddDays(-1)),
                new Order(31, 12,  45, DateTime.Now),
                new Order(32, 22,  40, DateTime.Now)
            };
        }
    }
}
