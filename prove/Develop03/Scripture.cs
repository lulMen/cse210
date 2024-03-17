public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private List<Word> _hiddenWords = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] parts = text.Split(" ");

        foreach(string part in parts)
        {
            Word word = new Word(part);
            word.Show();
            _words.Add(word);
        }
        
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int index;
            string text = "";

            do
            {
                Random random = new Random();
                index = random.Next(_words.Count());
            }
            while (_words[index].IsHidden() && _hiddenWords.Count() < _words.Count());

            foreach (char c in _words[index].GetDisplayText())
            {
                text += "_";
            }

            if (_hiddenWords.Count() < _words.Count())
            {
                Word newWord = new Word(text);
                newWord.Hide();
                _hiddenWords.Add(newWord);
                _words[index] = newWord;
            }
        } 
    }

    public string GetDisplayText()
    {
        string text;
        text = _reference.GetDisplayText();
        foreach (Word word in _words){
            text += " " + word.GetDisplayText();
        }
        return text;
    }

    public bool IsCompletelyHidden()
    {
        if (_hiddenWords.Count() >= _words.Count())
        {
            return true;
        } else {
            return false;
        }
    }
}