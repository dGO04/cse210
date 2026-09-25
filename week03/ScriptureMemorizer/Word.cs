public class Word
{
    private string _text;
    
    public Word(string text)
    {
        _text = text;
    }

    public string GetDisplayText()
    {
        return _text;
    }

    public void Hide()
    {
        int length = _text.Length;

        _text = new string('_', length);
    }

    public bool IsHidden()
    {
        if (_text.Contains("_")) {
            return true;
        } else
        {
            return false;
        }
    }
}