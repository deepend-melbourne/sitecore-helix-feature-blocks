using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.AccordionSection.ID_String, AutoMap = true)]
    public interface IAccordionSection : IBaseItem
    {
        [SitecoreField(FieldId = Templates.AccordionSection.Fields.Content.Title_String)]
        string Title { get; set; }

        [SitecoreField(FieldId = Templates.AccordionSection.Fields.Content.Abstract_String)]
        string Abstract { get; set; }

        [SitecoreField(FieldId = Templates.AccordionSection.Fields.Content.Body_String)]
        string Body { get; set; }
    }
}
