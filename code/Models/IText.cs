using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.Text.ID_String, AutoMap = true)]
    public interface IText : IBaseItem
    {
        string TextContent { get; set; }
    }
}
