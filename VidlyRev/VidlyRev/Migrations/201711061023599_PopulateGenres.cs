namespace VidlyRev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) VALUES(1, 'Action'), (2, 'Comedy'),(3, 'Family'),(4, 'Romance')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id BETWEEN 1 AND 4");
        }
    }
}
