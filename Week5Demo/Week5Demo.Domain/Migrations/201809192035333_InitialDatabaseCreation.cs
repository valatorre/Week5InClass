namespace Week5Demo.Domain.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialDatabaseCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Guid(nullable: false),
                        AddressType = c.String(),
                        StreetAddress1 = c.String(),
                        StreetAddress2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.Int(nullable: false),
                        Country = c.String(),
                        Student_StudentId = c.Guid(),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.Students", t => t.Student_StudentId)
                .Index(t => t.Student_StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Guid(nullable: false),
                        StudentName = c.String(),
                        DateOfBirth = c.DateTime(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "Student_StudentId", "dbo.Students");
            DropIndex("dbo.Addresses", new[] { "Student_StudentId" });
            DropTable("dbo.Students");
            DropTable("dbo.Addresses");
        }
    }
}
