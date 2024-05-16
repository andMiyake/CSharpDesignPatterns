
using System.Diagnostics;

var journal = new Journal();
journal.AddEntry("I cried today");
journal.AddEntry("I ate a bug");

Console.WriteLine(journal);

var persistance = new Persistance();
var fileName = @"C:\temp\journal.txt";
persistance.SaveToFile(journal, fileName, true);
Process.Start(new ProcessStartInfo("notepad.exe", fileName));




public class Journal
{
    private readonly List<string> entries = new List<string>();
    private static int count = 0;

    public int AddEntry(string text)
    {
        entries.Add($"{++count}: {text}");
        return count; //memento
    }

    public void RemoveEntry(int index)
    {
        entries.RemoveAt(index);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, entries);
    }
}

public class Persistance
{
    public void SaveToFile(Journal journal, string fileName, bool overwrite = false) 
    {
        if (overwrite || !File.Exists(fileName))
            File.WriteAllText(fileName, journal.ToString());
    }
}
