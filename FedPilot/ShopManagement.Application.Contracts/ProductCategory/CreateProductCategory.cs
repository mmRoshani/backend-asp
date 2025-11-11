using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application.Contracts.ProductCategory
{
    public class CreateProductCategory
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public string Picture { get; set; }

        public string PictureAlt { get; set; }

        public string PictureTitle { get; set; }

        public string Keywords { get; set; } // GEO and SEO

        public string MetaDescription { get; set; }

        public string Slug { get; set; }

        public string TargetedGeoLocations { get; set; }

        public int? ParentCategoryId { get; set; }

        public string LanguageCode { get; set; }

        public bool IsPublished { get; set; }

        public int DisplayOrder { get; set; }
    }
}
