using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.FAQList.ID_String, AutoMap = true)]
    public interface IFAQList : IBaseItem
    {
        [SitecoreField(FieldId = Templates.FAQList.Fields.Content.Title_String)]
        string Title { get; set; }

        [SitecoreField(FieldId = Templates.FAQList.Fields.Content.Links_String)]
        IEnumerable<IBaseItem> Links { get; set; }

        [SitecoreField(FieldId = Templates.FAQList.Fields.Content.ViewMoreLink_String)]
        Link ViewMoreLink { get; set; }
    }
}
