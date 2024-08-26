
<H1 align="center">Development in VB NET</H1>

<p align="center">🚀 Development of a CRUD structure for future references</p>

## Resources Used
- Visual Studio 2015
- SQL Server Management Studio (SSMS):
- LINQ
- Razor

# Initial environment setup

## Creating the project

<details>
<summary>Click to show details about </summary>

Click on "Create a new project" from the start page or select "File" > "New" > "Project" from the menu.
In the "Create a new project" dialog, search for "Visual Basic" in the search box.
Select the type of project you want to create (e.g., "Console App", "Windows Forms App", "WPF App", etc.).
Click "Next".

![image](https://github.com/user-attachments/assets/817d4ecf-685b-4d12-b814-c5a21bcd71cb)

</details>


## Database Connection

<details>
<summary>Click to show details about </summary>

#### Create Database:

Start SQL Server Management Studio and connect to the SQL Server instance and create a database called PROJETO_VB;

![image](https://github.com/user-attachments/assets/75c8b267-4550-4331-9aae-627db77b5f50)


#### Adding the Connection String

Open the Web.config File, if your Web.config already contains a <connectionStrings> section, you can add your connection string within it.

![image](https://github.com/user-attachments/assets/1e0b2bc8-2192-4bd7-bc19-650530a0379b)


#### Adding the Database Connection Class

![image](https://github.com/user-attachments/assets/01c94883-d656-4c2f-818b-a2ad84c19e2b)

- The CustomDbContext class is declared as Public, meaning it can be accessed from other parts of the application.
- The class inherits from DbContext, which is the base class for working with Entity Framework. DbContext provides methods for querying and saving data to the database.
- The constructor Sub New() is defined to initialize the CustomDbContext class.
- The MyBase.New("name=ConnectProjetoDB") line calls the base class constructor and passes the name of the connection string ("ConnectProjetoDB"). This connection string is defined in the application's configuration file (e.g., web.config or app.config), and it specifies the database connection details.
- The OnModelCreating method is overridden to provide custom configuration for the model (entities) when the model is being created.
- The method receives an instance of DbModelBuilder as a parameter, which is used to configure the model's structure (e.g., entity relationships, property configurations).
- The MyBase.OnModelCreating(modelBuilder) line calls the base implementation of the method, ensuring that any default behavior is preserved unless explicitly overridden.


##### Enable Migrations 

If you haven't enabled migrations yet, do so in Visual Studio's Package Manager Console:

```
Enable-Migrations -ContextTypeName CrudVB.CustomDbContext
```

</details>

# Project Documentation

## Create Models


Creating models in VB.NET using the Code-First approach with Entity Framework involves defining your database schema through classes in your application code, rather than starting with a pre-existing database.

<details>
<summary>Click to show details about </summary>

#### Define the Model Classes:

Models are simple classes that represent entities in your application, and each class corresponds to a table in the database.

![image](https://github.com/user-attachments/assets/7563a6da-b101-4b5a-8bc6-33fe0818ff9b)

#### Add model in the DbContext Class  

The DbContext class is responsible for managing the database connection and mapping the model classes to database tables.

![image](https://github.com/user-attachments/assets/a25c9b87-832e-4a7a-be04-a1b280c31d24)

  
#### Configure the Model (Optional) 

Use the OnModelCreating method in the DbContext class to configure model relationships, constraints, and other database schema details.
  
![image](https://github.com/user-attachments/assets/8a02dae5-cab8-454e-91eb-323bd63a54c1)

#### Database Initialization 

When you first run the application, Entity Framework will generate a database based on the defined models and context and Migrations can be used to apply changes to the database schema over time.

#### Perform CRUD Operations  

You can now use the context to perform Create, Read, Update, and Delete (CRUD) operations on your models using LINQ:
  
![image](https://github.com/user-attachments/assets/b9a99ad9-cdb8-4ee4-9637-0016d4b0d3cf)


### Create Models : One to Many 

#### Setting Up the Classes (Models)

Let's assume you are creating a system to manage Orders and Order Items. Each Order can have multiple Order Items, but each Order Item belongs to a single Order.

##### Many orders can belong to one material

![image](https://github.com/user-attachments/assets/c8468901-ec55-4010-b703-56e0a13b0583)

##### One material belongs to many orders

![image](https://github.com/user-attachments/assets/1e275b1d-c7db-46c2-84e9-1fd4b736d96f)

#### Configuring the DbContext

Next, you need to configure the DbContext to include these models.

![image](https://github.com/user-attachments/assets/8bad10c4-0aa7-4197-bf5d-d93665076403)

#### Migrations and Database Creation

- Create a Migration: In the Package Manager Console, run the following command to create a migration

```
  Add-Migration <MigrationName>
```

![image](https://github.com/user-attachments/assets/cde54f62-0cae-4d23-b54d-6b840afc7dd9)

- Update the Database: After creating the migration, apply the changes to the database by running:

```
Update-Database
```

![image](https://github.com/user-attachments/assets/b8a6d901-b541-4d05-a895-ae8c9c16b0dd)

</details>

## Migrations

Migrations in ASP.NET are an Entity Framework (EF) feature that allows you to manage changes to the database schema in an incremental and controlled manner

<details>
<summary>Click to show details about </summary>

#### Migrations Structure up() and down()

![image](https://github.com/user-attachments/assets/000cc346-354b-433e-8921-09bedb182937)

- up() Method: Defines the operations to be performed when the migration is applied, such as creating a table.
- down() Method: Defines the operations to revert the changes performed by the up() method, such as deleting a table.

#### Creating Migrations:

Add-Migration <MigrationName> : Creates a new migration file based on changes made to the model.

#### Run Migrations:

Update-Database :  Applies all pending migrations to the database.

#### Check Migration Status:

Get-Migrations : Lists all migrations that have been added to the project.

#### Update Tables:

Update-Database : Applies migrations to the database, updating the tables.

#### Add Fields:

Add-Migration <MigrationName> : Creates a new migration after adding new fields to the model.

#### Apply Changes:

Update-Database : Applies recent changes to the database  

</details>

## Template Inheritance

In ASP.NET MVC, template inheritance allows you to create a base layout or template that other views can inherit from, promoting reusability and consistency across your application. Here's how you can set up and use template inheritance in VB.NET MVC:

<details>
<summary>Click to show details about </summary>
 
#### Layout (Master Page):

First, a layout page will serve as the base template for other views. This layout page typically includes common elements like headers, footers, and navigation menus.

The base template it's called _Layout.vbhtml

![image](https://github.com/user-attachments/assets/b01fca5b-4dbd-4d24-bc11-7dfcc02df44c)

![image](https://github.com/user-attachments/assets/3d7bb2c0-bf53-4690-b88e-68d5220eb6ce)


#### Rendering Content

In your individual views, specify the layout page using the Layout property or use the base layout. This tells the view to use the specified layout page.

![image](https://github.com/user-attachments/assets/1f293dcb-673b-4680-b610-c85c3c7340c6)

</details>

## Controller

Controllers in ASP.NET MVC are fundamental components that act as intermediaries between the model (data) and the view (user interface). They are responsible for processing the HTTP requests received by the application, interacting with the model to manipulate data and deciding which view should be rendered and sent back to the client.

<details>
<summary>Click to show details about </summary>

#### Creating a Controller:

With Entity Framework, creating a controller based on a model is a very straightforward process. Here are the steps to create a controller that uses the Entity Framework to manipulate data from a model:

![image](https://github.com/user-attachments/assets/60159778-af20-42e3-9c0b-9ca553528f81)

![image](https://github.com/user-attachments/assets/c3c288cf-dcbf-40a9-ac63-3ac8057c47fa)



### Actions

Actions in controllers in ASP.NET MVC are methods that handle HTTP requests and return a response to the user. Each action corresponds to an application endpoint and can respond to different types of HTTP requests, such as GET, POST, PUT and DELETE.


#### Index():

- HTTP GET: Retrieves and displays a list of all MaterialMovel records from the database.
Returns a view with the list of MaterialMovels.]
- Route: MaterialMovels

![image](https://github.com/user-attachments/assets/32d4dbeb-ec64-4529-b84c-a18f1cf6ace1)


#### Details(ByVal id As Integer?):

- HTTP GET: Displays details of a specific MaterialMovel identified by the id.
If id is Nothing, it returns a BadRequest status. If the MaterialMovel is not found, it returns a HttpNotFound status. Otherwise, it returns the view with the details.
- Route: MaterialMovels/Details/5

![image](https://github.com/user-attachments/assets/67ff3219-cdcb-469e-9c00-8b952f6764c4)


#### Create():

- HTTP GET: Returns the view for creating a new MaterialMovel.
- Route: MaterialMovels/Create
  
![image](https://github.com/user-attachments/assets/2fa0fc9f-8551-46f5-8b96-95764343718f)


#### Create(ByVal materialMovel As MaterialMovel):

- HTTP POST: Handles the submission of the form to create a new MaterialMovel.
It uses model binding to populate the materialMovel object. If the model state is valid, the new entity is added to the database and saved, then redirects to the Index action. If the model state is invalid, it returns the view with the current materialMovel data for corrections.
- Route: MaterialMovels/Create

![image](https://github.com/user-attachments/assets/6bec7d53-64e4-4a98-b61e-f371ed633f9b)

  
#### Edit(ByVal id As Integer?):

- HTTP GET: Retrieves and displays the edit form for an existing MaterialMovel identified by id.
Similar to Details, it checks if id is valid and if the MaterialMovel exists before returning the view.
- Route: MaterialMovels/Edit/5

![image](https://github.com/user-attachments/assets/4ee62892-7a8b-429a-952e-44b299c5a589)


#### Edit(ByVal materialMovel As MaterialMovel):

- HTTP POST: Handles form submissions to update an existing MaterialMovel.
Updates the entity in the database if the model state is valid, and then redirects to the Index action. If the model state is invalid, it returns the view with the current data.
- Route: MaterialMovels/Edit/5
  
![image](https://github.com/user-attachments/assets/18fa0d07-8e7d-4790-a0d3-e34e3673063e)

#### Delete(ByVal id As Integer?):

- HTTP GET: Displays a confirmation page for deleting a specific MaterialMovel identified by id.
Checks if id is valid and if the MaterialMovel exists before returning the view.
- Route: MaterialMovels/Delete/5

![image](https://github.com/user-attachments/assets/42c2ca76-073d-4921-8635-1083c116d7e7)


#### DeleteConfirmed(ByVal id As Integer):

- HTTP POST: Handles the deletion of a MaterialMovel identified by id.
Finds the entity, removes it from the database, and saves the changes. Redirects to the Index action after deletion.
- Route: MaterialMovels/Delete/5

![image](https://github.com/user-attachments/assets/beff7d42-db91-4a65-b409-071c7f68f103)

</details>

## Routes

Routes are defined in the application configuration, usually in the RegisterRoutes method within the RouteConfig module or a similar file.
Each route is made up of a URL pattern and rules to direct a request to a specific driver and action.


<details>
<summary>Click to show details about </summary>

### Passing the Controller as a Parameter:

When you explicitly pass the controller name as a parameter to Html.ActionLink, the generated link will point to a specific action for a specific controller. This is the most common behavior when you want to create a link that directs the user to an action that is in a different controller than the one in which the current view was generated.

```
@Html.ActionLink("Detalhes", "Details", "Products", new { id = 5 }, null)
```

In this example, the "Details" link will be generated for the Details action in the Products controller, passing an id parameter with the value 5. The resulting URL could be something like /Products/Details/5.

### Not Passing the Controller as a Parameter:

If you do not pass the name of the controller in Html.ActionLink, the framework will assume that the desired controller is the same as the page (view) where the link is being generated. This behavior is useful when you want to create links to actions within the same controller, saving time and avoiding typos when repeating the controller name.

```
@Html.ActionLink("Editar", "Edit", new { id = 3 }, null)
```

In this case, if the current view is being rendered from the Products controller, the "Edit" link will be generated for the Edit action in the same controller (Products), with the id parameter set to 3. The resulting URL could be something like / Products/Edit/3.

#### Url.Action

![image](https://github.com/user-attachments/assets/528d559d-6414-4c6a-911b-c1e759d9c224)

```
@Url.Action(actionName, controllerName, routeValues)
```

When you use @Url.Action("Index", "Home") it generates the URL for the Index action in the HomeController controller. 

![image](https://github.com/user-attachments/assets/0a0cccb3-ce0a-44d2-9ae8-2a63ec7d186f)

![image](https://github.com/user-attachments/assets/12c39a00-c8c9-451f-8472-40575678e761)


#### URL Pattern:

![image](https://github.com/user-attachments/assets/d4425c40-af78-4a4a-a529-b857ccc5e8aa)


- Route: MaterialMovels
- Route: MaterialMovels/Details/5
- Route: MaterialMovels/Create
- Route: MaterialMovels/Edit/5
- Route: MaterialMovels/Delete/5


</details>

## Views

The Views directory contains subfolders, each named after the application's controllers. For example, if you have a controller called ProductsController, there will be a folder called Products inside the Views directory.

<details>
<summary>Click to show details about </summary>

![image](https://github.com/user-attachments/assets/65407154-5ada-4d51-a41d-364c232d58e5)


#### View Location:

When a controller returns a view, ASP.NET MVC uses a convention to find the appropriate view.
The convention is that the view name must match the action name in the controller. For example, if the ProductsController controller has an action called Index, ASP.NET MVC will look for a view called Index.cshtml inside the Views/Products folder.

#### View Resolution Process:

When an action method on the controller is called, ASP.NET MVC determines the view to return based on the name of the action.
The framework searches for the view in the directory corresponding to the controller name within the Views folder. 
For example:
 - Action: Index in ProductsController
 - Expected view path: Views/Products/Index.cshtml

</details>

## Pages

![image](https://github.com/user-attachments/assets/6a949fcd-7edc-49ae-8eff-c5b0f0cfa149)

![image](https://github.com/user-attachments/assets/32beaf9c-e343-47c3-aa54-f5a75d07abc9)

![image](https://github.com/user-attachments/assets/8cfb07c4-24e3-47ea-8c21-c32b1af7aa16)

![image](https://github.com/user-attachments/assets/941e2be5-dd5e-4fce-bbd1-a4c4fb1398f2)
