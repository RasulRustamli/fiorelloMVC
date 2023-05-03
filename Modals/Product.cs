namespace fiorelloMVC.Modals;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImgName { get; set; }
    public List<Catagory> Catagories { get; set; }
    public List<Tag> Tags { get; set; }
    
}
