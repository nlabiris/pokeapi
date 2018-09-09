# PokéAPI

[![Software License](https://img.shields.io/github/license/nlabiris/pokeapi.svg)](LICENSE.md)
[![GitHub (pre-)release](https://img.shields.io/badge/alpha-v0.0.1-red.svg)](https://github.com/nlabiris/pokeapi/releases)

A Pokémon API written in C# using [ASP.NET Web API 2](https://docs.microsoft.com/en-us/aspnet/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api). All the data are comes from [veekun pokedex](https://github.com/veekun/pokedex) and are hosted in a MySQL server. The solution is created using Visual Studio 2017.

## Prerequisites

* [Visual Studio 2017 version 15.7.3 or later](https://www.microsoft.com/net/download/windows) with the following workloads:
   *  ASP.NET and web development
   * .NET Core cross-platform development
* IIS server *(optional)*
* MySQL or MariaDB server
* [.NET Core 2.1 SDK or later](https://www.microsoft.com/net/download/windows)
* [.NET Framework 4.7.2 or later](https://www.microsoft.com/net/download/windows)

## Usage

First of all, get the [veekun pokedex](https://github.com/veekun/pokedex) and follow the instructions in order to setup the database.

Then, `clone` this repository or download as `zip` file.
* Using git: `git clone https://github.com/nlabiris/pokeapi.git`
* [Download zip](https://github.com/nlabiris/pokeapi/archive/master.zip) and extract to your desired location

The best way to manage the solution and the underlying project is to use Visual Studio in order to setup the database settings, build the project and publish it to the desired directory in order to host it and make it accessible throught a web server.

However, a simple text editor, eg. VS Code, will do the job. (if you know what files need to change).

### Setup database connection

#### 1. Using Visual Studio

From the menu, click on **Project > PokeAPI Properties...**, click at the Settings tab and fill the `DatabaseConnectionString` and `DatabaseUsed` fields. For the connection string check [MySQL connection strings](https://www.connectionstrings.com/mysql/) for the appropriate format.
Enter `MySQL` at the `DatabaseUsed` field. The last option (`LoggingLevel`) is not used at the moment.

#### 2. Using a simple text editor

Open the following files:
* `Web.config`
* `Properties/Settings.settings`
* `Properties/Settings.Designer.cs`

Then make the necessary changes at the connection string and database options (like the Visual Studio step).

## Publish

#### 1. Using Visual Studio

From the menu bar, click on **Build > Publish PokeAPI** to build the API using a Release configuration to the desired directory

## Change log

Please see [CHANGELOG](CHANGELOG.md) for more information on what has changed recently.

## Credits

* **Nikos Labiris** - *Initial work* - [nlabiris](https://github.com/nlabiris)

See also the list of [contributors](https://github.com/nlabiris/pokeapi/graphs/contributors) who participated in this project.

### Contributing

Please see [CONTRIBUTING](CONTRIBUTING.md) and [CODE_OF_CONDUCT](CODE_OF_CONDUCT.md) for details.

### Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/nlabiris/pokeapi/releases). 

## License

This project is licensed under the *GNU Affero General Public License v3.0* (AGPLv3). Please see [License File](LICENSE.md) for more information.