using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] allText = text.Split(' ');

        foreach (string aText in allText)
        {
            Word textWord = new Word($"{aText}");
            _words.Add(textWord);
        }
    }
    public string DisplayScripture()
    {
        string fullRef = $"{_reference.GetDisplayText()}";
        foreach (Word word in _words)
        {
            fullRef += $" {word.SwapText()}";
        }

        return fullRef;
    }
    public void HideWords()
    {
        int counter = 0;
        Random random = new Random();
        while (counter != 3 && FullyHidden() == false)
        {
            int randomAmt = random.Next(_words.Count());

            Word wordHide = _words[randomAmt];

            if (wordHide.IsHidden() == false)
            {
                wordHide.Hide();
                counter += 1;
            }
        }
    }
    public bool FullyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

}