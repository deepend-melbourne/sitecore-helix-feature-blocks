using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.Introduction.ID_String, AutoMap = true)]
    public interface IIntroduction : IBaseItem
    {
        string IntroductionContent { get; set; }
    }
}
