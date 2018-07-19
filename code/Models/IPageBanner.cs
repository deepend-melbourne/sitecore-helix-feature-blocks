using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.PageBanner.ID_String, AutoMap = true)]
    public interface IPageBanner : IBaseItem, IBannerColour
    {
        [SitecoreField(FieldId = Templates.PageBanner.Fields.Content.Title_String)]
        string Title { get; set; }
    }
}
