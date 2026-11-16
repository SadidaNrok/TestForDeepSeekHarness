namespace TestProject;

/// <summary>
/// Формирует текст приветствия. Отдельный тип показывает, как раскладывать
/// логику по файлам по мере роста приложения.
/// </summary>
public static class Greeter
{
    /// <summary>
    /// Возвращает приветствие для указанного имени.
    /// </summary>
    /// <param name="name">Имя того, кого приветствуем.</param>
    public static string CreateGreeting(string name)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);

        return $"Привет, {name}!";
    }
}
