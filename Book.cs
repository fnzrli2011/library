public class Book : Product
{
    public string Genre;

    public Book(long ID, string NAME, double prc, string genre) : base(ID, NAME, prc)
    {
        Genre = genre;
    }
}
