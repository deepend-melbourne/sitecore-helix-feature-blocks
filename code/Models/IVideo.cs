using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.Video.ID_String, AutoMap = true)]
    public interface IVideo : IBaseItem
    {
        [SitecoreField(FieldId = Templates.Video.Fields.Content.VideoUrl_String)]
        Link VideoUrl { get; set; }

        [SitecoreField(FieldId = Templates.Video.Fields.Content.Transcript_String)]
        File Transcript { get; set; }
    }
}
