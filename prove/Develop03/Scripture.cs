using System;

public class Scripture
{
    private string _book;
    private int _chapter;
    private VerseRange _verseRange;
    private string _text;

    public Scripture(string book, int chapter, int verse, string text)
    {
        _book = book;
        _chapter = chapter;
        _verseRange = new VerseRange(verse, verse);
        _text = text;
    }

    public Scripture(string book, int chapter, VerseRange verseRange, string text)
    {
        _book = book;
        _chapter = chapter;
        _verseRange = verseRange;
        _text = text;
    }

    public string Book
    {
        get { 
            return _book;
         }
    }

    public int Chapter
    {
        get {
            return _chapter;
        }
    }

    public VerseRange VerseRange
    {
        get {
            return _verseRange;
        }
    }

    public string Text
    {
        get {
            return _text;
        }
    }
}