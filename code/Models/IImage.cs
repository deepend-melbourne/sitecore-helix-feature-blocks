using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.Image.ID_String, AutoMap = true)]
    public interface IImage : IBaseItem
    {
        Image ImageSource { get; set; }
    }
}
