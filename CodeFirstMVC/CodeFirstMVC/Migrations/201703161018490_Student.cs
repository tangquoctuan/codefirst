namespace CodeFirstMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Student : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "Age", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Student", "Age");
        }
    }
}
