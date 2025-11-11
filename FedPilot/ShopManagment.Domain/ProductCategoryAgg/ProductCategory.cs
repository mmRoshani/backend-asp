using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Domain;

namespace ShopManagement.Domain.ProductCategoryAgg
{

    public class ProductCategory : EntityBase
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public string Picture { get; private set; }

        public string PictureAlt { get; private set; }

        public string PictureTitle { get; private set; }

        public string Keywords { get; private set; } // GEO and SEO

        public string MetaDescription { get; private set; }

        public string Slug { get; private set; }

        public string TargetedGeoLocations { get; private set; }

        public int? ParentCategoryId { get; private set; }

        public string LanguageCode { get; private set; }

        public bool IsPublished { get; private set; }

        public int DisplayOrder { get; private set; }

        public ProductCategory(
            string name,
            string description,
            string picture,
            string pictureAlt,
            string pictureTitle,
            string keywords,
            string metaDescription,
            string slug,
            string targetedGeoLocations,
            int? parentCategoryId,
            string languageCode,
            bool isPublished,
            int displayOrder
            )
        {
            Name = name;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
            TargetedGeoLocations = targetedGeoLocations;
            ParentCategoryId = parentCategoryId;
            LanguageCode = languageCode;
            IsPublished = isPublished;
            DisplayOrder = displayOrder;
        }
    
    
    
        public void Edit(
            string name,
            string description,
            string picture,
            string pictureAlt,
            string pictureTitle,
            string keywords,
            string metaDescription,
            string slug,
            string targetedGeoLocations,
            int? parentCategoryId,
            string languageCode,
            bool isPublished,
            int displayOrder
            )
        {
            Name = name;
            Description = description;
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
            TargetedGeoLocations = targetedGeoLocations;
            ParentCategoryId = parentCategoryId;
            LanguageCode = languageCode;
            IsPublished = isPublished;
            DisplayOrder = displayOrder;
        }
    }
}
