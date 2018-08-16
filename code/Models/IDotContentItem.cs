using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.DotContentItem.ID_String, AutoMap = true)]
    public interface IDotContentItem : IBaseItem
    {
        [SitecoreField(FieldId = Templates.DotContentItem.Fields.Content.DotColour_String)]
        IColourScheme DotColour { get; set; }

        [SitecoreField(FieldId = Templates.DotContentItem.Fields.Content.Title_String)]
        string Title { get; set; }

        [SitecoreField(FieldId = Templates.DotContentItem.Fields.Content.Text_String)]
        string Text { get; set; }
    }
}
