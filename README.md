# 👨🏻‍⚕️ Appointment Scheduling 📅

[![Build Status](https://travis-ci.org/maria-rd/AppointmentScheduling.svg?branch=master)](https://travis-ci.org/maria-rd/AppointmentScheduling)
[![GitHub stars](https://img.shields.io/github/stars/maria-rd/AppointmentScheduling.svg?style=social)](https://github.com/maria-rd/AppointmentScheduling/stargazers)
[![GitHub forks](https://img.shields.io/github/forks/maria-rd/AppointmentScheduling?style=social)](https://github.com/maria-rd/AppointmentScheduling/network)

This is a ASP.NET Core 7.0 C# MVC webapp, formerly in 3.1. ✈️

## Features 🎉

Coming soon!

## Technologies 💻
* .NET Core 7.0 MVC
* Entity Framework
* MaterializeCSS
* HTML5
* jQuery

## Requirements 🛠

* .NET Core 7.0 SDK ([install!](https://dotnet.microsoft.com/en-us/download/dotnet/7.0))
* Visual Studio 2022 (Community Edition) ([install!](https://visualstudio.microsoft.com/vs/)) or Visual Studio Code ([install!](https://code.visualstudio.com/download))
* SQL Server 2019 (Developer Edition) ([install!](https://go.microsoft.com/fwlink/?linkid=866662))
* SQL Server Management Studio (SSMS) 19 ([install!](https://aka.ms/ssmsfullsetup)) 

## Getting Started 🚀

1. Clone the repository from GitHub.
~~~
git clone https://github.com/Maria-RD/AppointmentScheduling.git
~~~
2. Open the project in Visual Studio or Visual Studio Code.
~~~
cd AppointmentScheduling/src
~~~
3. Install the EF Core command-line tools.
~~~
dotnet tool install --global dotnet-ef --version 9.0
~~~
4. Create a new EF Migrations file.
~~~
dotnet ef migrations add Migrations
~~~
5. Update the DB schema to the latest migration.
~~~
dotnet ef database update
~~~
6. Go to SQL Server Management Studio. Login as follows.
~~~
Server type: Database Engine
Server name: .\
Authentication: Windows Authentication
~~~
7. Connect to the TurnsDB database. Use the [DataPopulation.sql](https://github.com/Maria-RD/AppointmentScheduling/blob/master/documentation/DataPopulation/DataPopulation.sql) script to populate the tables.
8. Run the project. 
~~~
dotnet watch run
~~~

## Usage 📜

Coming soon!

## Contributing 🤝🏻

Contributions are welcome! Please fork the repository and submit a pull request.

## License 📕

This project is licensed under the MIT License.

## Contact 📬

If you have any questions, please contact me on private message!

## Thanks! 🎊

Thanks for checking out my project! I hope you all enjoy it. 😊

![](https://raw.githubusercontent.com/JoeyBling/JoeyBling/master/pic/pusheencode.gif?raw=true)
