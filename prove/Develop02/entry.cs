using System.Reflection.Metadata;

public class Entry
{

    public string _date;
    public string _input;
    public string _prompt;
    public Entry(string input, string prompt)
    {
        DateOnly date = DateOnly.FromDateTime(DateTime.Now);

        _date = date.ToString();

        _input = input;
        _prompt = prompt;
    }

    public Entry(string date, string prompt, string input)
    {
        _date = date;
        _prompt = prompt;
        _input = input;
    }
}