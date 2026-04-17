namespace lab4;

[TestClass]
public class Book
{
    [TestMethod]
    public void TestMethod1()
    {
        Book book = new Book { Title = "C# Programming", Author = "John Smith" };
        Assert.AreEqual("C# Programming", book.Title);
        Assert.AreEqual("John Smith", book.Author);
    }
}
