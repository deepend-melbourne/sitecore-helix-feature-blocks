using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Grid.Models;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.RenderingParameters_AlertBar.ID_String, AutoMap = true)]
    public interface IRenderingParameters_AlertBar : IRenderingParameters_Spacing
    {
    }
}
