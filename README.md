<h1 align='center'><img width='900' height='450' src='https://coding-assets.s3.us-west-2.amazonaws.com/hero_images/NewFavoriteThings.jpg'><br>


**<h1 align = 'center'>Travel Catalogue**


*<h2 align ='center'>Keep a record of places, pictures and descriptions of the cool places you've visited.*


<h3 align ='center'>•<a href='#requirements'> Requirements</a> •<a href='#setup'> Setup</a> •<a href='#technologies-used'> Technologies</a> •<a href='#❤️contributors'> Contributors</a> •<a href='#known-bugs'> Bugs</a> •<a href='#protecting-your-data'> Protecting Data</a></h3>


<h3 align='center'>This is an .Net Core MVC application allowing the user to Create, Read, Update and Delete travelogue entries</h3>

# **REQUIREMENTS**

_[Visual Studio Code](https://code.visualstudio.com/)_

_[MySql Workbench](https://www.mysql.com/products/workbench/)_

_[.Net Core v2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)_

# **SETUP**

# **PROTECTING YOUR DATA**

* Step 1: create a .gitignore file in the top level of your project directory. populate the file as shown in step 1 of the image below.

* Step 2: commit that .gitignore file (this prevents your sensitive information like your API key being shown to others). **DO NOT PROCEED UNTIL YOU DO THIS!**

![setup](https://coding-assets.s3-us-west-2.amazonaws.com/img/readme-image-3.jpg 'Set up instructions')

<br>

# **TECHNOLOGIES USED**

_[C#](https://docs.microsoft.com/en-us/dotnet/csharp/)_

_[Bootstrap](https://getbootstrap.com/)_

_[Asp.Net MVC](https://dotnet.microsoft.com/apps/aspnet/mvc)_

_[HTML](https://developer.mozilla.org/en-US/docs/Web/HTML)_

_[Visual Studio Code](https://code.visualstudio.com/)_

_[MySql Workbench](https://www.mysql.com/products/workbench/)_

<br>

# **KNOWN BUGS**


_**No known bugs as of:** 8/29/2020_

<br>

# **INSTALL**

## **INSTALLING WITH DOTNET**


with the root project folder open in your code editor, execute the following in your terminal:

``cd ProjectName``

``dotnet restore``

``dotnet build``

``dotnet watch run``

<br>

### Instructions for Obtaining an API Key

    1.  Download a web browser, such as Apple Safari, Brave, Google Chrome, Microsoft Edge, Mozilla Firefox, or Yandex.
    2.  Navigate to [API webpage].
    3.  Click the button to sign up for a new account or sign in to your existing account.
    4.  Navigate to the section of the API webpage that contains your API key.
    5.  Copy your API key.
    6.  Return to your cloned or downloaded copy of the program you are setting up and open the terminal.
    7.  Make sure you have entered the root menu of the program directory.
    8.  Enter "$ touch .env" into the terminal.
    9.  Open the .env file you have just created and type "API_KEY = " into the file.
    10. Paste your copied API key into the .env file directly after "API_KEY = ".
    11. Review any JavaScript files (*i.e.*, those ending in ".js") in the src subdirectory of the program directory for API calls from the API from which you have obtained the key.
    12. In any of the API calls, identify the section of the API URL that contains the sequence "appid=[API-KEY-GOES-HERE]".
    13. Replace "[API-KEY-GOES-HERE]" with "${process.env.API_KEY}".
    14. Make sure all files in the program directory and subdirectories are saved.
    15. Repeat this process for any other APIs that are called in the program.

# **❤️Contributors**

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/allison-sadin.jpeg' width='160px;'/><br /><sub><b>Allison Sadin</b></sub>](https://www.linkedin.com/in/allison-sadin-pdx/)<br />

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/cody-fritz.jpeg' width='160px;'/><br /><sub><b>Cody Fritz</b></sub>](https://www.linkedin.com/in/zentraxius/)<br />

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/thomas-glenn.jpeg' width='160px;'/><br /><sub><b>Thomas Glenn</b></sub>](https://www.linkedin.com/in/glennergy/)<br />

<br>

dotnet new mvc --framework netcoreapp2.2

<br>

![alt text][logo]

[logo]: https://img.shields.io/bower/l/bootstrap 'MIT License'


