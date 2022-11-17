10;42 2022-10-25
CREATED A NEW WEBAPPLICTION MVC core .
set to indvidual accounts
https config enabled the runtime for razor . 
3.1 LTS
10;44 
run the aplication 
commented the line 7 in the elaunch settings in the properties folder . 
rebuild the application
checked the aplication 
10;47
review the pakages in the dependencies , pakages  folder 
creating a git repos. 

2022-10-25
"" options => options.SignIn.RequireConfirmedAccount = true "" commented this is the startup page at line 33  

reviews the github repos annd created a README.md file with all the starting description of the project 

2022-10-27
clone the repositary 
rebuild the application 
10;35
moving to debugging 
by looking at slides added  two break points in the homecontroller.cs page in the index and privacy line .

10;50
replaced the bootstarp file with the downlaoded version . 
made changes in the _layout.cshtml 
 changed the last bootstarp.min.css to bootstarp.cs
  changed the navbar-light to navbar-dark and bg-white to bg-primary
  at line 24 and 27 removed text dark 
  at line 40 in the layout.cshtml file  added text-white-50 bg-primary
   @await RenderSectionAsync("Scripts", required: false) added this line in the  layout.cshtml
made changes in the loginPartial.cshtml file . 
removed the text dark 

31/10/2021
just had to work on the esign boot strap template wasnt working earlier 
and now it does 
i have changed the boot strap file again and all other changes in the layout were made earlier 
and it finally worked 
7:19 
added alll the sources checked though all the websites 
i couldnt find the fontawsome scripttag one so i just used the same code as the slides 
7:51 that took a long while  
added these scrupt file s in the and updated it on the layout because the last day i had searched it on google ...

script files
<script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
<script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<script src="https://kit.fontawesome.com/e19c476714.js"></script>
Css filess 
<link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" />

7:59 
added the nav drp down 

2022/11/01
9:51 am 
still working on dropdown menu as its not working . 
10:41 am
completed the dropdown , ran the application and checked the working dropdown menu 

10:42 am 
moving to add Projects and Modify 

1) creating 3 .Net Core class library (uses 3.1 LTS version )
	* HarpreetsBooks.DataAccess
	* HarpreetsBooks.Models
	* HarpreetsBooks.Utility

2) copied the data folder and pasted in the .DataAccess project and just renamed the old data folder to data_bk 

3) deleted the migration folder in the .DataAccess project and added all the pakages required 
you can check those under the dependencies folder 
4) modified the name space for the ApplicationdbContext.cs file under the .DataAccess project 
5) deleted all the class1.cs files for all the new projects that was new created 

11:11 am 
moving on the models to HarpreetsBooks.Models file and renamed the models_bk file for the original 
added the project reference for the .DataAccess and .Models
11:27
renamed the models folder to view models 
changed yhe ErrorViewModels.cs namespace to .Models.ViewModels

2022-11-02
starting the application 
8:01
added a classs in the Utility folder named SD.cs
and edited the properties of the class 
added the refereneces for the Utility folder 
8:18
modified the pattern with the {area=Customer} inthe startup page at line 65
8:23
moved the HomeController.cs to the Area>Customer>Controllers folder
and deleted the Data and Models folder in it 
8:30
[Area("Customer")]  // specified that the controller is in the Customer Area at lin 12 
moved the view>home an dmodifed the HomeController namespace
8:46 
modified the _viewStart.cshtml to reflect the new new path 
11/03/2022
made changes in th startup file , removed the folder for shaed from the areas and replaced it to the views in the main folder 

2022-11-17 2:15pm 
replacing my all the files through github because all the older file were completed till the bootstrap theme and i have al ready completed the part for the project modification

2:16 
rebuild the solution and ran the application 
everything looks good 

2:17 
created an new area named Amin in the area folder 
2:19
added the proper view files and deleted the data and model folder in it .
and renamed the original controllers folder to controller_bk 

2:22
moving on to create the DB 
build the solution to confirm their is no errors 
changed the name of the database connection from aspnet-HarpreetBookStore-17B0B5F1-26DE-4B88-A694-12367526A027 to HarpreetBookStore

moving on to add migration .dataAccess ( problem)
add-migration addDefaultIdentityMigration
 gives us an error tp specify the context 

 add-migration AddDefaultIdentityMigration -Context ApplicationDbContext
 error : - More than one DbContext named 'ApplicationDbContext' was found. Specify which one to use by providing its fully qualified name using its exact case.

 solution : -


 10:24
 changing the original files applicationDbContext file to to applicationDbContext just to retry the migration part for .dataaccess file 
 still have to provide with the name 

 2022-11-08 10:31 
 still didnt get the migration 

 finally got the migration done , the errors were after deleting the original fle of applicationDbReference , we had to change the file reference as well 
 the reference changes where made in the create identiy schema , startup , and applicationdbcontextmodelsnapshot 

 the file name for the new migration is 20221108153556_AddDefaultIdentityMigration 

 updated the database and build succeeded 
 
 10:41
In the .Models project created a new Category.cs file and added all the new changes in it 

10:48 
added the migration in the .DataAccess folder for the category class 

11:01
added all the changes in the ApplicationDbContext of the using statement and added the field for the Categories

2022-11-10
removed the errors that was poping	related to refences 
soluton:- added project refernece fr the dataacess and model and it workd 

rebild the application 
and ran the application 

10:49 
added the new migration 
got an error of duplication 
The name 'AddCategoryToDb' is used by an existing migration
10:53
deleted the old migration for AddCategoryToDb and re-did it and it has been updated with the new column of categories and updated the database 

11:12
added an new folder in the .DataAccess folder name Repository 
created an new folder in it named IRepository 
added an new interface type item named IRepository 

added all the required changes in it 
also added comments 

11:32
added all the modification in the Repository.cs
added the individual repos for the category 

1:58
updated and modified the content for the both the Category Repository 

2:08
updated the CategoryRepository.cs to implement the insterface 

2:56 
added an new SP_Call.cs in the IRepository folder and added all the content in it 
and added the new class in the ISP-Call in the repository folder 

2022-11-14 4:00pm 
updated all the changed in  the SP_Call file 

4:07PM 
Added an new interface named IUnitOfWork in the IRepository folder 

4:14PM 
created a new class named UnitOfWork in the Repository folder and added all the content 

4:19pm 
made changes in the UnitOfWork
updated the startup.cs 

2022/11/15
updated the UnitofWork in the startup.cs  and added the refernece for it 

10:24 
added a new controller for category inside the admin folder/ controllers 
10:34
added the category content in it  
10:51
added the content in the CategoryController

2022-11-17  10:30 
added all the missing statements in the CategoryController,
In startup.cs added a using statements to clear out the IUnitOfWork error 
created a new folder in Admin views named Category 
added an new vie inside the category folder named Index.cshtml

11:02
added all the data inside the Index.cshtml , data was given in the assignment 2 files 

11:20
The type 'HarpreetsBooks.DataAccess.Repository.UnitOfWork' cannot be used as type parameter 'TImplementation' in the generic 
type or method 'ServiceCollectionServiceExtensions.AddScoped<TService, TImplementation>(IServiceCollection)'.
There is no implicit reference conversion from 'HarpreetsBooks.DataAccess.Repository.UnitOfWork' 
to 'HarpreetsBooks.DataAccess.Repository.IRepository.IUnitOfWork'.	
HarpreetBookStore	C:\Users\W0802461\Source\Repos\Harpret890\HarpreetBookStore\HarpreetBookStore\Startup.cs	38	Active

11:29 
added a new link for category in the _Layout.cshtl file 

12:35 
WORKING ON THE ASSIGNMENT 

added an repository folder refernce in the .DataAccess.csproj folder 

No webpage was found for the web address: http://localhost:55972/Category?area=Admin :- not able to access the webpage 

12:47 
added the new edits for edit and trash button in the layout.cshtml file and upadated the index.cshtml 

12:51 
added an new file in the wwwroot/ js file named category.js and added all he contenr in it from the provided file 

1:09
added an additional statement for the Back and Edit to the controllerCategory.cs 
and added an new upsert.cshtml view in the Views Category and added all ots content from the file provided 
addded to new view files in the named _CreateAndBackToListButton and _EditAndBackToListButton in the views shared folder 