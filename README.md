
<H1 align="center">Development in VB NET</H1>

<p align="center">🚀 Development of a CRUD structure for future references</p>

## Resources Used
- Visual Studio 2015
- SQL Server Management Studio (SSMS):


# Initial environment setup

## Creating the project

Click on "Create a new project" from the start page or select "File" > "New" > "Project" from the menu.
In the "Create a new project" dialog, search for "Visual Basic" in the search box.
Select the type of project you want to create (e.g., "Console App", "Windows Forms App", "WPF App", etc.).
Click "Next".

![image](https://github.com/user-attachments/assets/817d4ecf-685b-4d12-b814-c5a21bcd71cb)


#### Configure Your Project:

Name your project in the "Project name" field.
Choose a location on your disk to save the project files.
Optionally, configure other settings like Solution name and .NET framework version.
Click "Create".

## Database Connection

#### Create Database:

Start SQL Server Management Studio and connect to the SQL Server instance and create a database called PROJETO_VB;

![image](https://github.com/user-attachments/assets/75c8b267-4550-4331-9aae-627db77b5f50)


#### Adding the Connection String in Web.config in VB.NET


Open the Web.config File, if your Web.config already contains a <connectionStrings> section, you can add your connection string within it.


![image](https://github.com/user-attachments/assets/1e0b2bc8-2192-4bd7-bc19-650530a0379b)


#### Adding the Database Connection Class to the IdentityModel

![image](https://github.com/user-attachments/assets/01c94883-d656-4c2f-818b-a2ad84c19e2b)

- The CustomDbContext class is declared as Public, meaning it can be accessed from other parts of the application.
- The class inherits from DbContext, which is the base class for working with Entity Framework. DbContext provides methods for querying and saving data to the database.
- The constructor Sub New() is defined to initialize the CustomDbContext class.
- The MyBase.New("name=ConnectProjetoDB") line calls the base class constructor and passes the name of the connection string ("ConnectProjetoDB"). This connection string is defined in the application's configuration file (e.g., web.config or app.config), and it specifies the database connection details.
- The OnModelCreating method is overridden to provide custom configuration for the model (entities) when the model is being created.
- The method receives an instance of DbModelBuilder as a parameter, which is used to configure the model's structure (e.g., entity relationships, property configurations).
- The MyBase.OnModelCreating(modelBuilder) line calls the base implementation of the method, ensuring that any default behavior is preserved unless explicitly overridden.




## Create Models

Creating models in VB.NET using the Code-First approach with Entity Framework involves defining your database schema through classes in your application code, rather than starting with a pre-existing database.

- Define the Model Classes : Models are simple classes that represent entities in your application, and each class corresponds to a table in the database.

![image](https://github.com/user-attachments/assets/7563a6da-b101-4b5a-8bc6-33fe0818ff9b)

- Create the DbContext Class : The DbContext class is responsible for managing the database connection and mapping the model classes to database tables.

![image](https://github.com/user-attachments/assets/01c94883-d656-4c2f-818b-a2ad84c19e2b)
  
- Configure the Model (Optional) : Use the OnModelCreating method in the DbContext class to configure model relationships, constraints, and other database schema details.
  
![image](https://github.com/user-attachments/assets/8a02dae5-cab8-454e-91eb-323bd63a54c1)

- Database Initialization : When you first run the application, Entity Framework will generate a database based on the defined models and context and Migrations can be used to apply changes to the database schema over time.
- Perform CRUD Operations : You can now use the context to perform Create, Read, Update, and Delete (CRUD) operations on your models using LINQ:
  
  ![image](https://github.com/user-attachments/assets/b9a99ad9-cdb8-4ee4-9637-0016d4b0d3cf)


## One to Many 

#### Setting Up the Classes (Models)

Let's assume you are creating a system to manage Orders and Order Items. Each Order can have multiple Order Items, but each Order Item belongs to a single Order.

![image](https://github.com/user-attachments/assets/c8468901-ec55-4010-b703-56e0a13b0583)

![image](https://github.com/user-attachments/assets/1e275b1d-c7db-46c2-84e9-1fd4b736d96f)

#### Configuring the DbContext

Next, you need to configure the DbContext to include these models.

![image](https://github.com/user-attachments/assets/8bad10c4-0aa7-4197-bf5d-d93665076403)

#### Migrations and Database Creation

- Create a Migration: In the Package Manager Console, run the following command to create a migration

![image](https://github.com/user-attachments/assets/cde54f62-0cae-4d23-b54d-6b840afc7dd9)

- Update the Database: After creating the migration, apply the changes to the database by running:

  ![image](https://github.com/user-attachments/assets/b8a6d901-b541-4d05-a895-ae8c9c16b0dd)


## Migration Structure:

![image](https://github.com/user-attachments/assets/000cc346-354b-433e-8921-09bedb182937)

- up() Method: Defines the operations to be performed when the migration is applied, such as creating a table.
- down() Method: Defines the operations to revert the changes performed by the up() method, such as deleting a table.

#### Creating Migrations:

#### Run Migrations:

#### Check Migration Status:

#### Update Tables:

#### Add Fields:

#### Apply Changes:

#### Undo Changes:

</details>

# Project Documentation

Use Artisan to start the server.

```

```

## Template Inheritance


#### Rendering Content


#### @extends('layouts.main'):



## Controller


#### Creating a Controller:


#### Using the Controller in Routes:


#### Actions


## Routes


## Creating a page


#### Creating the Dashboard Component:


#### Adding the Function to the Controller:


#### Changing the Route:


#### Changing Links:



## Relations one to many


#### Creating the Migration:


#### Change the Event Model:


#### Change to the User model:



## Relations many to many


#### Creating the Relationship Table:



#### Defining the Relationship in the Models:



#### Relationship Handling:



</details>

## Pages

![image](https://github.com/user-attachments/assets/6a949fcd-7edc-49ae-8eff-c5b0f0cfa149)

![image](https://github.com/user-attachments/assets/32beaf9c-e343-47c3-aa54-f5a75d07abc9)

![image](https://github.com/user-attachments/assets/8cfb07c4-24e3-47ea-8c21-c32b1af7aa16)

![image](https://github.com/user-attachments/assets/941e2be5-dd5e-4fce-bbd1-a4c4fb1398f2)
