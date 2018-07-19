using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.ResourceLink.ID_String, AutoMap = true)]
    public interface IResourceLink : IBaseItem
    {
        [SitecoreField(FieldId = Templates.ResourceLink.Fields.Content.Link_String)]
        Link Link { get; set; }

        [SitecoreField(FieldId = Templates.ResourceLink.Fields.Content.Title_String)]
        string Title { get; set; }
    }
}
