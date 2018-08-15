using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.Video.ID_String, AutoMap = true)]
    public interface IVideo : IBaseItem
    {
        [SitecoreField(FieldId = Templates.Video.Fields.Content.YoutubeVideoId_String)]
        string YoutubeVideoId { get; set; }

        [SitecoreField(FieldId = Templates.Video.Fields.Content.Transcript_String)]
        File Transcript { get; set; }
    }
}
