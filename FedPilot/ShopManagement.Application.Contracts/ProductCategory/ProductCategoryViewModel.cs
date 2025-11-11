namespace ShopManagement.Application.Contracts.ProductCategory
{
    public class ProductCategoryViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string TargetedGeoLocations { get; set; }
        public int? ParentCategoryId { get; set; }
        public string LanguageCode { get; set; }
        public bool IsPublished { get; set; }
        public int DisplayOrder { get; set; }
        public string CreationDate { get; set; }
        public long ProductsCount { get; set; }
    }
}
