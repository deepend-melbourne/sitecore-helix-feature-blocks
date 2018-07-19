using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.BannerColour.ID_String, AutoMap = true)]
    public interface IBannerColour : IBaseItem
    {
        [SitecoreField(FieldId = Templates.BannerColour.Fields.Content.BackgroundColour_String)]
        string BackgroundColour { get; set; }
    }
}
