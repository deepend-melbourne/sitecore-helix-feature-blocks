using System.Collections.Specialized;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.Accordion.ID_String, AutoMap = true)]
    public interface IAccordion : IBaseItem
    {
        [SitecoreField(FieldId = Templates.Accordion.Fields.Content.Sections_String)]
        NameValueCollection Sections { get; set; }
    }
}
