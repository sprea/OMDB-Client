# OMDB-Client

Un semplice client Windows scritto in C# che utilizza l'API REST di [OMDBAPI](http://www.omdbapi.com/).

## Installazione delle dipendenze

Il progetto necessita dei seguenti pacchetti nuget:
- [Json.net](https://www.newtonsoft.com/json).
- [Gestione configurazione](https://www.nuget.org/packages/System.Configuration.ConfigurationManager/4.7.0?_src=template).

Puoi installarlo dalla console di gestione dei pacchetti tramite questi comandi:
```
Install-Package Newtonsoft.Json
```
```
Install-Package System.Configuration.ConfigurationManager
```
## Compilazione

### Prima opzione (preferita)
1. Clona il repository sul tuo computer
2. Apri il file della soluzione in Visual Studio ed eseguilo

### Seconda opzione
1. Clona il repository sul tuo computer
2. Apri un terminale (cmd o powershell) e cd nella directory del progetto
3. Esegui questo comando:
```
msbuild ClientFilm.sln
```

## Contributi
Il progetto è aperto a contributi tramite PR o issue

## Licenza
[GPL](https://www.gnu.org/licenses/licenses.it.html)

## English version

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
