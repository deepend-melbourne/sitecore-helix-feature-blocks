using Glass.Mapper.Sc.Configuration.Attributes;
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
        string Image { get; set; }

        [SitecoreField(FieldId = Templates.HeroBanner.Fields.Content.Video_String)]
        string Video { get; set; }

        [SitecoreField(FieldId = Templates.HeroBanner.Fields.Content.PrimaryAction_String)]
        string PrimaryAction { get; set; }

        [SitecoreField(FieldId = Templates.HeroBanner.Fields.Content.SecondaryAction_String)]
        string SecondaryAction { get; set; }
    }
}
