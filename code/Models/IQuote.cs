using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.Quote.ID_String, AutoMap = true)]
    public interface IQuote : IBaseItem
    {
        [SitecoreField(FieldId = Templates.Quote.Fields.Content.Body_String)]
        string Body { get; set; }

        [SitecoreField(FieldId = Templates.Quote.Fields.Content.Author_String)]
        string Author { get; set; }

        [SitecoreField(FieldId = Templates.Quote.Fields.Content.Title_String)]
        string Title { get; set; }
    }
}
