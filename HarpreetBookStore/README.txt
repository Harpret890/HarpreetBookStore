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