namespace fiorelloMVC.Modals;

public class Catagory
{
    public int Id { get; set; } 
    public string Name { get; set; }    
    public List<Product> Products { get; set; }
}
