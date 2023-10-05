[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/B4g0WUIu)
# Datei einlesen
Lese die films.json Datei File ein.
Verwende einen StreamReader wie im unten angegeben Beispiel.

~~~csharp
StreamReader reader = new StreamReader(@"C:\films.json");
string json = reader.ReadToEnd();
~~~

Das @ Symbol wird in C# für die [String Interpolation](https://en.wikipedia.org/wiki/String_interpolation) verwendet. Es
wird [Verbatim Identifier](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/verbatim) genannt.

# Daten Deserialisierung

Verwende die bereits hinzugefügte Bibliothek von [newtonsoft](https://www.newtonsoft.com/json) um eine Liste an Filmen zu erstellen.

~~~csharp
JsonConvert.DeserializeObject<List<Film>>(json);
~~~

Iteriere die Liste und gib den Namen des Films aus.

# Linq

Implementiere die Methoden FilmOperations.cs und teste sie in Program.cs
