# Constants Folder 

## In Code
```
    using BulletinBoardSampleFrame.Properties;

	int status =1;
    if(status== PostConst.STATUS_ACTIVE)
    {
        Debug.WriteLine("True");
    }
```

# Utility Folder

## In Code
```
    using OJTBulletinBoard.Utilities;

    PostValidtion postValidation = new PostValidtion();
    bool passwordValidation = postValidation.CheckPasswordValidation(password, newPassword, confirmPassword);
    if (passwordValidation == true)
    {
        //something to do
    }
    else
    {
         //something to do
    }
```

# DAOs Folder

    Mainly used for retrieving and inserting data from database

# Services Folder

    Mainly used between controller calss and DAO class.
    All condition are placed in this folder.

# Resources Folder

Mainly use for image,external css and external ja file

## CSS
## In View
         @section usage{
            <link href="~/Resources/css/post/table.css" rel="stylesheet" />
          }

## In Layout Page
        @RenderSection("usage", required: false)

## JS
## In View
        @section script
        {
             <script src="~/Resources/js/post/JavaScript.js"></script>
        }

## In Layout Page
        @RenderSection("script", required: false)

# ViewModel

    It mainly reponsible for getter and setter method that are not related to database.
    Sometimes it's used as a join table 


# Route Config

We don't use defaults when creating Route Constraint to a Set of Specific Values
## In RegisterRoute
              routes.MapRoute(
              "Default",                    // Route name
              "{controller}/{action}/{id}", // Route Pattern
              new { controller = "Home", action = "Index", id = UrlParameter.Optional }, // Default values for parameters
              new { controller = "^H.*", action = "^Details$|^About$" } //Restriction for controller and action
           );

We can also use the custom route
## In In RegisterRoute
                routes.MapRoute(
                name: "Post",
                url: "Post/{id}",
                defaults: new { controller = "Post", action = "PostView"}
            );


# Bundle Config

    Mainly use for designing the whole web page.

# Layout Page

    In Layout page name, "_" means it is not intented to be served directly in web page. And web 
    Pages framework has been configured not to allow files with leading underscores in their names 
    from being requested directly.Consequently, it makes sense to carry over naming conventions 
    established within Web Pages to MVC Razor files. So there is a technical reason for prefixing 
    the file names with an underscore - it just isn't  relevant to MVC.That's why it makes sense to 
    name layout and  partial files with a leading underscore in a Razor Pages application if they 
    are not intended to be browsed.

    Link:: https://stackoverflow.com/questions/4576548/why-does-razor-layout-cshtml-have-a-leading-underscore-in-file-name

    How to use::
## In Layout Page
            @Html.Partial("_TopLayout")

# Changing the folder name

    We can change the folder name by using "Directory.Move()" but the folder name will become hidden folder name after
    that right click on that folder and choose "include in project".
## eg.   
                using System.IO namespace;

                    string path = Server.MapPath("~");
                    string Fromfol = "\\[Foldername]\\";
                    string Tofol = "\\[Foldername]\\";
                    Directory.Move(path + Fromfol, path + Tofol);

# For Bootstrap

    In Visual Studio 2019, if we choose the MVC template, bootstrap will be automatically download and placed under
    the "Resources\content" folder.
        
How to use the bootstrap in code
## In Layout file
            In header section::
                @Styles.Render("~/Resources/css/lib/css")
            In body section::
                @RenderBody()
            And you also need to put on "BundleConfig::
                bundles.Add(new StyleBundle("~/Resources/css/lib/css").Include(
                      "~/Resources/css/lib/bootstrap.css",
                      "~/Resources/css/common/site.css"));

# For AppStart

    There is nothing special about App_Start, it's just a folder. What's special is how it's used, 
    and that's specific to the WebActivator framework, which is a NuGet package you can install. 
    App_Start and WebActivator are not specific to .NET 4.5, but they do require .net 4 
    (which means VS 2010 or 2012)

    Link:: https://stackoverflow.com/questions/14228072/app-start-folder-in-asp-4-5-only-in-webapplications-projects

## For AppData

    Contains application data files including .mdf database files, XML files, and other data store 
    files. The App_Data folder is used by ASP.NET to store an application's local database, such as 
    the database for maintaining membership and role information. For more information, see 
    Introduction to Membership and Understanding Role Management.

    Link::https://docs.microsoft.com/en-us/previous-versions/ex526337(v=vs.140)?redirectedfrom=MSDN

# For CSS/HTML Code Style
In Code Style file.
## ShortCut Key:: 
    Ctrl+K,Ctrl+D