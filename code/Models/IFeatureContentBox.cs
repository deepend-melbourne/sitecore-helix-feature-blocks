using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.FeatureContentBox.ID_String, AutoMap = true)]
    public interface IFeatureContentBox : IBaseItem
    {
        [SitecoreField(FieldId = Templates.FeatureContentBox.Fields.Content.Title_String)]
        string Title { get; set; }

        [SitecoreField(FieldId = Templates.FeatureContentBox.Fields.Content.Text_String)]
        string Text { get; set; }

        [SitecoreField(FieldId = Templates.FeatureContentBox.Fields.Content.Image_String)]
        Image Image { get; set; }

        [SitecoreField(FieldId = Templates.FeatureContentBox.Fields.Content.PrimaryAction_String)]
        Link PrimaryAction { get; set; }

        [SitecoreField(FieldId = Templates.FeatureContentBox.Fields.Content.SecondaryAction_String)]
        Link SecondaryAction { get; set; }
    }
}
