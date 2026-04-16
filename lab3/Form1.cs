namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        
        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public string Format { get; set; } 

            public override string GetInfo()
            {
                return $"{Title} by {Author} [{Format}]";
            }
        }

        public class Textbook : Book
        {
            public string Subject { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} [{Subject}]";
            }
        }

        public class AudioBook: Book
        {
            public double Duration { get; set; }
            public string Narrator { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} | Narrated by {Narrator} ({Duration} hrs)";
            }
        }


        private void ProcessBooks(Book[] books)
        {
            listBoxBooks.Items.Clear();

            foreach (Book b in books)
            {
               
                string info = b.GetInfo();

               
                string entry = $"[{b.GetType().Name}] {info}";
                listBoxBooks.Items.Add(entry);
            }
        }

        
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book[] books = new Book[]
            {
                new Book
                {
                    Title = "Clean Code",
                    Author = "Robert Martin"
                },
                new Magazine
                {
                    Title = "Tech Weekly",
                    Author = "John Doe",
                    IssueNumber = 45
                },
                new Ebook
                {
                    Title = "Pro C# 10",
                    Author = "Andrew Troelsen",
                    Format = "PDF"
                },
                new Magazine
                {
                    Title = "Science Today",
                    Author = "Jane Smith",
                    IssueNumber = 12
                },
                new Ebook
                {
                    Title = "Design Patterns",
                    Author = "GoF",
                    Format = "EPUB"
                },
                new Textbook
                {
                    Title = "Introduction to Algorithms",
                    Author = "Thomas Cormen",
                    Subject = "Computer Science"
                },
                new Textbook
                {
                    Title = "Calculus: Early Transcendentals",
                    Author = "James Stewart",
                    Subject = "Mathematics"
                },
                new AudioBook
                {
                    Title = "Atomic Habits",
                    Author = "James Clear",
                    Narrator = "James Clear",
                    Duration = 5.35
                },
                new AudioBook
                {
                    Title = "The Clean Coder",
                    Author = "Robert Martin",
                    Narrator = "Robert Martin",
                    Duration = 6.5
                }
            };

            ProcessBooks(books);
        }
    }
}