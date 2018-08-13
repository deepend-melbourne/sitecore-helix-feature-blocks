using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.Button.ID_String, AutoMap = true)]
    public interface IButton : IBaseItem
    {
        [SitecoreField(FieldId = Templates.Button.Fields.Content.Link_String)]
        Link Link { get; set; }

        [SitecoreField(FieldId = Templates.Button.Fields.Content.Text_String)]
        string Text { get; set; }
    }
}
