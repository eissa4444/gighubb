namespace WebApplication2.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class populateGendreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name) VALUES ('Jazz')");
            Sql("INSERT INTO Genres(Name) VALUES ('country')");
            Sql("INSERT INTO Genres(Name) VALUES ('Blues')");
            Sql("INSERT INTO Genres(Name) VALUES ('Rock')");
        }

        public override void Down()
        {
            //Sql("DELETE FROM Genres WHERE Id IN(1,2,3,4)");
        }
    }
}
