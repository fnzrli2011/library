class Program
{
    public static void Main(string[] args)
    {
         Book b1=new Book(1,"Harry",12,"dram");
         Book b2=new Book(2,"Ferid",13,"fantastic");
         Library l1=new Library();
         l1.AddBook(b1);
         l1.AddBook(b2);
    }
}