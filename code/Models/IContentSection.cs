using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.ContentSection.ID_String, AutoMap = true)]
    public interface IContentSection : IBaseItem
    {
        [SitecoreField(FieldId = Templates.ContentSection.Fields.Content.SectionTitle_String)]
        string SectionTitle { get; set; }
    }
}
