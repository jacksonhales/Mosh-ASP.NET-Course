namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieTable2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (1, 'Hangover', 1, '03/09/2018', '11/06/2009', 5)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (2, 'Die Hard', 2, '03/09/2018', '06/10/1988', 3)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (3, 'The Terminator', 2, '03/09/2018', '20/12/1984', 2)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (4, 'Toy Story', 3, '03/09/2018', '07/12/1995', 0)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (5, 'Titanic', 4, '03/09/2018', '18/12/1997', 1)");
        }
        
        public override void Down()
        {
        }
    }
}
