# TestProject

Стартовое решение на C# для Visual Studio 2026 и .NET 10: консольное приложение
и готовый локальный git-репозиторий.

## Требования

- .NET SDK 10.0 (проверено на 10.0.400)
- Visual Studio 2026 с рабочей нагрузкой «Разработка классических приложений .NET»
  (не обязательно: проект собирается и из командной строки)

## Быстрый старт

### Visual Studio

1. Откройте файл `TestProject.slnx` (двойной щелчок или «Файл → Открыть → Проект/решение»).
2. Нажмите F5 — приложение соберётся и запустится.

### Командная строка

```powershell
dotnet build TestProject.slnx
dotnet run --project src/TestProject
dotnet run --project src/TestProject -- Мир
```

Приветствие по умолчанию — «Привет, мир!»; аргументы командной строки
подставляются вместо него.

## Структура

```
TestProject.slnx              решение
src/TestProject/              консольный проект
  Program.cs                  точка входа (top-level statements)
  Greeter.cs                  пример отдельного типа с логикой
  TestProject.csproj          настройки проекта (net10.0, nullable)
.editorconfig                 единые правила оформления кода
.gitignore                    исключения .NET (bin, obj и прочее)
.gitattributes                нормализация переводов строк
README.md                     этот файл
```

## Git

Ветка по умолчанию — `main`, она отслеживает удалённую `origin/main`:

- удалённый репозиторий: <https://github.com/SadidaNrok/TestForDeepSeekHarness>
- remote `origin` уже настроен, первый push выполнен

Обычный цикл работы:

```powershell
git add -A
git commit -m "Что изменилось"
git push
```

## Дальнейшие шаги

- Переименовать проект: имя `TestProject` встречается в `TestProject.slnx`,
  `src/TestProject/` и `TestProject.csproj`.
- Добавить тесты: `dotnet new xunit -o tests/TestProject.Tests` и
  `dotnet sln TestProject.slnx add tests/TestProject.Tests`.
