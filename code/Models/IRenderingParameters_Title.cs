using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Grid.Models;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.RenderingParameters_Title.ID_String, AutoMap = true)]
    public interface IRenderingParameters_Title : IRenderingParameters_Spacing
    {
        string HeadingSize { get; set; }

        string HeadingStyle { get; set; }

        bool TitleUnderline { get; set; }

        bool TitleStrike { get; set; }

        bool TitleCenter { get; set; }

        bool TitleNormalFont { get; set; }
    }
}
