public class Product
{
    public long id {get; set; }
    public string name {get; set;}
    private double prise;
    private long count;
    public double Prise
    {
        get
        {
            return prise;
        }
        set
        {
            if(value>0) prise=value;
        }
    }
    public long Count
    {
        get
        {
            return count;
        }
        set
        {
            if(value>0) count=value;   
        }
    }
    public Product(long ID,string NAME,double prc)
    {
        id=ID;
        name=NAME;
        Prise=prc;
    }
}