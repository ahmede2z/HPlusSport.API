namespace HPlusSport.API.Models
{
    public class ProductQueryParameters : QueryParameters
    {
        public decimal? MaxPrice { get; set; }
        public decimal? MinPrice { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Sku { get; set; } = string.Empty;

        public string SearchTirm { get; set; } = string.Empty;
    }
}
