using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab4tests;

[TestClass]
public class PolymorphismTests
{
    // ── Original Test ──────────────────────────────────────────
    [TestMethod]
    public void TestPolymorphism_GetInfo_Method()
    {
        Book[] books = new Book[]
        {
            new Book     { Title = "Generic Book", Author = "John Smith" },
            new Magazine { Title = "Tech Weekly",  Author = "Jane Doe",  IssueNumber = 12 },
            new Ebook    { Title = "Learn C#",     Author = "Mark Jones", FileSizeMB = 5 }
        };

        Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
        Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
        Assert.AreEqual("Learn C# (Ebook, 5MB)", books[2].GetInfo());
    }

    // ── Task 2: Error Handling ─────────────────────────────────
    [TestMethod]
    public void TestInvalidMagazineCreation()
    {
        try
        {
            Magazine magazine = new Magazine { Title = "Invalid", Author = "Jane Doe", IssueNumber = -1 };
            Assert.Fail("Expected ArgumentException was not thrown.");
        }
        catch (ArgumentException)
        {
            // ✅ Test passes — exception was thrown as expected
        }
    }

    [TestMethod]
    public void TestBookWithEmptyTitle()
    {
        try
        {
            Book book = new Book { Title = "", Author = "John Smith" };
            Assert.Fail("Expected ArgumentException was not thrown.");
        }
        catch (ArgumentException) { }
    }

    [TestMethod]
    public void TestMagazineWithNegativeIssueNumber()
    {
        try
        {
            Magazine magazine = new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = -5 };
            Assert.Fail("Expected ArgumentException was not thrown.");
        }
        catch (ArgumentException) { }
    }

    [TestMethod]
    public void TestTextbookWithEmptySubject()
    {
        try
        {
            Textbook tb = new Textbook { Title = "Math 101", Author = "Dr. Smith", Subject = "" };
            Assert.Fail("Expected ArgumentException was not thrown.");
        }
        catch (ArgumentException) { }
    }
}