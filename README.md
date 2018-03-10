# Suave Example in an F# dotnet core console project

## Steps to re-create this project from scratch

1. Create a dotnet core console project using the CLI command 
        dotnet new console -lang F#

2. Install paket to the project.  
    a. If you haven't already, install the Ionide-Paket extension for VS Code.  
    b. Create the .paket folder using the File: New Folder command in the VS Code Command Palette.  
    c. Download the latest paket.bootstrapper.exe file from https://github.com/fsprojects/Paket/releases/latest into the .paket folder.  
    d. Finish the paket install using the Paket: Init command.  
    e. Add this line at the top of the paket.dependencies file:  
    &nbsp;&nbsp;&nbsp;&nbsp;```storage: none```  
    f. Make sure you have a .gitignore file in the project root folder that includes this:
    ```
        # Paket dependency manager
        .paket/paket.exe
        paket-files/
    ```
3. Install suave using the Paket: Add NuGet Package (to current project) command.

4. Add code to the Program.fs file as described in the https://suave.io/ section titled "The simplest possible application: Hello World!".  
    a. Add ```open Suave```  
    b. Add to the main function: ```startWebServer defaultConfig (Successful.OK "Hello World!")```  
5. Start the web server using the CLI command ```dotnet run -c Release```  
    You should see this output:  
    ```[11:38:29 INF] Smooth! Suave listener started in 86.523 with binding 127.0.0.1:8080```  

6. Navigate to http://localhost:8080/ in a browser to see the web app running.  

7. Press Ctrl+c in the CLI to stop the web server.  

## Suave related links

https://fsprojects.github.io/Paket/installation.html

https://suave.io/

https://www.hanselman.com/blog/LearningAboutTheFSAFEStackSuaveioAzureFableElmish.aspx
