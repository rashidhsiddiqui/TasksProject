# TasksProject
.Net based Tasks related CRUD operation

The project is build using ASP.MVC 5, Entity framework 6.0 and SQL Server (any version).

There is a list of tasks page that is the entry point of the application. The url of the page is http://localhost:54755/Tasks [where your localhost address may be different]. Before running the application for the first time, you have to modify web.config file that is placed on the root of the application code for the database connection. For this you just have to modify the highlighted sections of the following code:

<add name="DefaultConnection" connectionString="data source=RASHID-PC;initial catalog=TasksProjectMVC5App;user id=sa;password=test123;MultipleActiveResultSets=True;App=EntityFramework;" providerName="System.Data.SqlClient" />

You have to change the data-source attribute and assign it the name of your SQL Server instance name. Next thing you have to modify is the login user name and password for your SQL Server instance.

The database will create automatically when you first open the tasks listing page.

You can perform all CRUD based operations related to tasks.

Just it! No more changes required.
