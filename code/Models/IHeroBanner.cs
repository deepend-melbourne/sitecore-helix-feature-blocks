using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.HeroBanner.ID_String, AutoMap = true)]
    public interface IHeroBanner : IBaseItem
    {
        [SitecoreField(FieldId = Templates.HeroBanner.Fields.Content.Title_String)]
        string Title { get; set; }

        [SitecoreField(FieldId = Templates.HeroBanner.Fields.Content.Subtitle_String)]
        string Subtitle { get; set; }

        [SitecoreField(FieldId = Templates.HeroBanner.Fields.Content.Image_String)]
        Image Image { get; set; }

        [SitecoreField(FieldId = Templates.HeroBanner.Fields.Content.Video_String)]
        Link Video { get; set; }

        [SitecoreField(FieldId = Templates.HeroBanner.Fields.Content.PrimaryAction_String)]
        Link PrimaryAction { get; set; }

        [SitecoreField(FieldId = Templates.HeroBanner.Fields.Content.SecondaryAction_String)]
        Link SecondaryAction { get; set; }

        [SitecoreField(FieldId = Templates.HeroBanner.Fields.Content.BackgroundColour_String)]
        string BackgroundColour { get; set; }
    }
}
