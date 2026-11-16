using TestProject;

// Аргументы командной строки передаются в приветствие:
//   dotnet run --project src/TestProject -- Мир
string name = args.Length > 0 ? string.Join(' ', args) : "мир";

Console.WriteLine(Greeter.CreateGreeting(name));
Console.WriteLine($"Платформа: .NET {Environment.Version}");
