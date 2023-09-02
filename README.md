1. Download the Project:
Obtain the FishingShop project files.

2. Update Connection String:
Open the solution and locate the AppDbContext class.
In the connection string, replace the server name with the name of your own SQL Server Management Studio (SSMS) server, where you want to host the FishingShop database.

3. Perform Migrations:
Open the Package Manager Console in Visual Studio.

Run the following command to add an initial migration:
Add-Migration InitialMigration -OutputDir Data/Migrations -Project FishingShop.Data -StartupProject FishingShop.Data

After successfully adding the migration, run the following command to update the database:
Update-Database -Project FishingShop.Data -StartupProject FishingShop.Data

4. Seed the Database:
Change the StartUp project to FishingShop.Seeder and start it!

6. Test the Project:
Now you are ready to test the whole project(ConsoleApp, FormApp, WebApp)...

Cast your dreams into the waters of opportunity and reel in success, one catch at a time.
