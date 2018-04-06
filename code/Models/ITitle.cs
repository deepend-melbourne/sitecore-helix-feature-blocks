using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.Title.ID_String, AutoMap = true)]
    public interface ITitle : IBaseItem
    {
        [SitecoreField(FieldId = Templates.Title.Fields.Content.ID_String)]
        string Content { get; set; }
    }
}
