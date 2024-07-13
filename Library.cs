public class Library
{
    public Book[] Books=Array.Empty<Book>();
    public void AddBook(Book book)
    {
        Array.Resize(ref Books,Books.Length+1);
        Books[Books.Length-1]=book;
    }
    public Book? GetBookById(int Id)
    {
        foreach (Book item in Books)
        {
            if(item.id==Id)
            {
                return item;
            }
        }
        return null;
    }
    public Book? GetBookByName(string n)
    {
        foreach (Book item in Books)
        {
            if(item.name==n)
            {
                return item;
            }
        }
        return null;
    }
    public Book[] GetFilteredBooks(string value)
    {
        Book[] filtredbooks=Array.Empty<Book>();
         foreach (var item in Books)
        {
            if(item.Genre==value)
            {
                Array.Resize(ref filtredbooks,filtredbooks.Length+1);
                filtredbooks[filtredbooks.Length-1]=item;
            }
        }
        return filtredbooks;
    }
    public Book[] GetFilteredBooks(double minPrice,double maxPrice)
    {
        Book[] filtredBooksp=Array.Empty<Book>();
        foreach (var item in Books)
        {
            if(item.Prise>=minPrice && item.Prise<=maxPrice)
            {
                Array.Resize(ref filtredBooksp,filtredBooksp.Length+1);
                filtredBooksp[filtredBooksp.Length-1]=item;
            }
        }
        return filtredBooksp;
    }
}