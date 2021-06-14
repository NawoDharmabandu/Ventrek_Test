Open 'NebulaApp' forlder and open 'NebulaApp.sln' from visual studio.(here I have used VS2019)

Set connection string under 'appsettings.json'
	Insert your local database credentials to below snippet in 'appsettings.json'
 "default": "Server=(local);Database=NebulaDB;User Id=YourUserID;password=YourUserID;Trusted_Connection=False;MultipleActiveResultSets=true;"
  
Open 'Package Manager Console' (Tools -> Library Package Manager -> Package Manager Console)
Enter 'remove-migration' to remove existing migrations to avoid errors.
Then run 'add-migration' and provide a name for the migration and then run 'update-migration' commands.
This will create the 'NebulaDB' database on your local sql server.

Open sql server and execute the attached initial data script 'InitialDataScript.sql' for some relative table of the application.
Then click 'IIS Express' to Build and Run the project

Then open the angular project 'NebulaToDoApp' from visual studio code. 