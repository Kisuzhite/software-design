namespace lab4tests;



public class Book
{
    private string _title = string.Empty;
    private string _author = string.Empty;

    public string Title
    {
        get => _title;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Title cannot be empty.");
            _title = value;
        }
    }

    public string Author
    {
        get => _author;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Author cannot be empty.");
            _author = value;
        }
    }

    public virtual string GetInfo() => $"Generic Book by {Author}";
}

public class Magazine : Book
{
    private int _issueNumber;

    public int IssueNumber
    {
        get => _issueNumber;
        set
        {
            if (value < 0)
                throw new ArgumentException("IssueNumber cannot be negative.");
            _issueNumber = value;
        }
    }

    public override string GetInfo() => $"{Title} - Issue {IssueNumber}";
}

public class Ebook : Book
{
    public int FileSizeMB { get; set; }
    public override string GetInfo() => $"{Title} (Ebook, {FileSizeMB}MB)";
}

// Task 3 — Textbook class
public class Textbook : Book
{
    private string _subject = string.Empty;

    public string Subject
    {
        get => _subject;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Subject cannot be empty.");
            _subject = value;
        }
    }

    public override string GetInfo() => $"{Title} - Subject: {Subject}";
}