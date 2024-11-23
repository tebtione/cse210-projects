using System;
using System.Security.Cryptography.X509Certificates;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            var unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();
            if (!unhiddenWords.Any()) break;
            
            var wordToHide = unhiddenWords[random.Next(unhiddenWords.Count)];
            wordToHide.Hide();
        }
    }
    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}; " + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}