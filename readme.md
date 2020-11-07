# .NET Core StartUpTaskRunner
This repository shows how to create tasks that can be run once on application startup in any .NET Core application.

## Usage
1. Create a class that implements `IStartUpTask`. Put the code you want to run at start up in the `Run` method.
2. Register the class, for example
```
var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<IStartUpTask, ExampleStartUpTask>();
```
3. Ensure you call the `ServiceProvider` extension method `RunStartUpTasks()` after creating the service provider.

## TestApp
An example usage can be found in the console app project `core-startuptaskrunner-testapp`.

### Build
To build this application just run `dotnet build StartUpTaskRunner.csproj` at the command line.

### Run
To run this application just run `dotnet run StartUpTaskRunner.csproj` at the command line.