using Glass.Mapper.Sc.Configuration.Attributes;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.RenderingParameters_ContentSection.ID_String, AutoMap = true)]
    public interface IRenderingParameters_ContentSection
    {
        [SitecoreField(FieldId = Templates.RenderingParameters_ContentSection.Fields.Content.ShowPanelBox_String)]
        bool ShowPanelBox { get; set; }
    }
}
