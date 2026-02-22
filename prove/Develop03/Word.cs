public class Word
{
    private string _text;
    private bool _show;

    public Word(string text)
    {
        _text = text;
        _show = true;
    }

    public void Hide()
    {
        _show = false;
    }
    public bool IsHidden()
    {
        return !_show;
    }

    public string SwapText()
    {
        if (_show)
        {
            return (_text);
        }
        else
        {
            return new string('_', _text.Length); ;
        }
    }
}


