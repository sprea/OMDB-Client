# OMDB-Client

A simple windows client written in C# that consumes the REST API of [OMDBAPI](http://www.omdbapi.com/).

## Dependency Installation

The project needs the following nuget packages:
- [Json.net](https://www.newtonsoft.com/json).
- [Configuration Manager](https://www.nuget.org/packages/System.Configuration.ConfigurationManager/4.7.0?_src=template).

You can install it from the package management console via this commands:
```
Install-Package Newtonsoft.Json
```
```
Install-Package System.Configuration.ConfigurationManager
```
## Build

### First Option (preffered)
1. Clone the repo on your machine 
2. Open the solution file in Visual Studio and run it

### Second Option
1. Clone the repo on your machine 
2. Open a terminal (cmd or powershell) and cd into the project directory
3. Run this command:
```
msbuild ClientFilm.sln
```

## Contributing
Feel free to contribute to improve the project by submit a PR or open an issue.

## License
[GPL](https://www.gnu.org/licenses/licenses.it.html)
