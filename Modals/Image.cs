namespace fiorelloMVC.Modals
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int MyProperty { get; set; }
    }
}
