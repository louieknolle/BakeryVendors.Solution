# Pierre's Bakery Vendor Tracker

#### By: Louie Knolle

#### Allows the owner of the baker to track vendors and their orders

## Technologies Used

* C#
* dotnet5 
* MSTest
* Command Line Interface
* asp.net Core MVC
* Razor
* CSS

## Description 

This C# web application allows the owner of Pierre's Bakery to add vendors they sell to, create orders for the vendors and their various details, and creates a log of both vendors and active orders. It is still in beta, so the lists of orders and vendors can not be erased once completed...yet!

## Setup/Installation Requirements

* _On your computer, install .NET 5 if you do not already have it_
  * _Direct link for Mac download here: ```https://download.visualstudio.microsoft.com/download/pr/846d5680-b804-4903-8d8d-255804bcfaeb/436101afc96998f75efb452f5ded3c1a/dotnet-sdk-5.0.401-osx-x64.pkg```_
  * _Direct link for Windows download here: ```https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.401-windows-x64-installer```_
  * _Open the file that downloads and follow instructions in the installer that opens_
  * _Confirm that install was successful by opening your command terminal and run the command ```$ dotnet --version``` (```5.0.401``` should display)_ 
  
* _Use the terminal to clone the repository from Github by inputting ```git clone https://github.com/louieknolle/BakeryVendors.Solution.git```_
*_Open the project's directory in the code editor of your choosing, I wrote this project in Visual Studio Code_
* _run command in terminal ```cd BakeryVendor``` to move into the main project directory_
* _run command ```dotnet build``` to build the project and ```dotnet run``` launch the live server_
* _Once the development environment is launched, copy and paste ```http://localhost:5000``` (or whatever link to the server the terminal gives you) into your browser and you can use the application_

## Known Bugs

* _I was unable to suss out the issue with the sizing of the "New Vendor" button, probably due to reusing classes to speed up designing each page. I also wanted to add the ability to erase/clear orders and vendors but was pressed for time._


## License

_Email knollelw@gmail.com with any comments or contributions. This software is licensed under the Microsoft license_

Copyright (c) _2022_ _Louie Knolle_