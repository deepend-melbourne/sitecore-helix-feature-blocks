using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.PageScheme.ID_String, AutoMap = true)]
    public interface IPageScheme : IBaseItem
    {
        [SitecoreField(FieldId = Templates.PageScheme.Fields.Content.PageColourScheme_String)]
        IColourScheme PageColourScheme { get; set; }
    }
}
