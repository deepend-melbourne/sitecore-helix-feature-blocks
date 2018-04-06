using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Grid.Models;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.RenderingParameters_Image.ID_String, AutoMap = true)]
    public interface IRenderingParameters_Image : IRenderingParameters_Spacing
    {
        bool ImageResponsive { get; set; }
    }
}
