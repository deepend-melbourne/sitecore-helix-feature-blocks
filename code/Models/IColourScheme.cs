using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.ColourScheme.ID_String, AutoMap = true)]
    public interface IColourScheme
    {
        [SitecoreField(FieldId = Templates.ColourScheme.Fields.CssClass_String)]
        string CssClass { get; set; }

        [SitecoreField(FieldId = Templates.ColourScheme.Fields.Badge_String)]
        Image Badge { get; set; }
    }
}
