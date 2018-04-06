using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Grid.Models;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.RenderingParameters_Panel.ID_String, AutoMap = true)]
    public interface IRenderingParameters_Panel : IRenderingParameters_Spacing
    {
        bool EnableTopPlaceholder { get; set; }

        bool RoundedCorners { get; set; }
    }
}
