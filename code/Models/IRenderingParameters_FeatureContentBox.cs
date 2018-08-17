using Glass.Mapper.Sc.Configuration.Attributes;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.RenderingParameters_FeatureContentBox.ID_String, AutoMap = true)]
    public interface IRenderingParameters_FeatureContentBox
    {
        [SitecoreField(FieldId = Templates.RenderingParameters_FeatureContentBox.Fields.Content.ImageAlignRight_String)]
        bool ImageAlignRight { get; set; }
    }
}
