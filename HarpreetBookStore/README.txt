10;42
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
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css"></script>
    <script src="https://kit.fontawesome.com/e19c476714.js"></script>


    <link rel="stylesheet" href="https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css"/>