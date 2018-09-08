# PokéAPI

[![GitHub latest release][ico-version]][link-github]
[![Software License][ico-license]](LICENSE.md)
<!-- [![Build Status][ico-travis]][link-travis]
[![Coverage Status][ico-scrutinizer]][link-scrutinizer]
[![Quality Score][ico-code-quality]][link-code-quality]
[![Total Downloads][ico-downloads]][link-downloads] -->

A Pokémon API written in C# using ASP.NET Web API 2. All the data are comes from [https://github.com/veekun/pokedex](veekun pokedex) and are hosted in a MySQL server. The solution is created using Visual Studio 2017.

## Prerequisites

* Visual Studio 2012+
* IIS server *(optional)*
* MySQL OR Maria DB

## Usage

First of all, get the [https://github.com/veekun/pokedex](veekun pokedex) and follow the instructions in order to setup the database.

Then, `clone` this repository or download as `zip` file.
* Using git: `$ git clone https://github.com/nlabiris/pokeapi.git`
* [Download zip](https://github.com/nlabiris/pokeapi/archive/master.zip) and extract to your desired location

The best way to manage the solution and the underlying project is to use Visual Studio in order to setup the database settings, build the project and publish it to the desired directory in order to host it and make it accessible throught a web server.

However, a simple text editor, eg. VS Code, will do the job. (if you know what files need to change).

### Setup database connection

#### 1. Using Visual Studio

From the menu, click on Project > PokeAPI Properties..., click at the Settings tab and fill the `DatabaseConnectionString` and `DatabaseUsed` fields. For the connection string check [https://www.connectionstrings.com/mysql/](MySQL connection strings) for the appropriate format.
Enter `MySQL` at the `DatabaseUsed` field. The last option (`LoggingLevel`) is not used at the moment.

#### 2. Using a simple text editor

Open the following files:
* `Web.config`
* `Properties/Settings.settings`
* `Properties/Settings.Designer.cs`

Then make the necessary changes at the connection string and database options (like the Visual Studio step).

## Publish

#### 1. Using Visual Studio

From the menu bar, click on Build > Publish PokeAPI to build the API using a Release configuration to the desired directory

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

This project is licensed under the GNU Affero General Public License v3.0 (AGPLv3). Please see [License File](LICENSE.md) for more information.

[ico-version]: https://img.shields.io/github/release/qubyte/rubidium.svg
[ico-license]: https://img.shields.io/badge/License-AGPL%20v3-green.svg
[link-author]: https://github.com/nlabiris
[link-contributors]: ../../contributors
[link-github]: https://github.com/nlabiris/pokeapi/releases