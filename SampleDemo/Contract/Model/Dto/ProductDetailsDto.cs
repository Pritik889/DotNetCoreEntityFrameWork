namespace SampleDemo.Contract.Model.Dto
{
    public class ProductDetailsDto
    {
        public int Id { get; set; }
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public decimal Price { get; set; }
    }
}
