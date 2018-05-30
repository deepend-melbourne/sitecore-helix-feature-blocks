using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.Audio.ID_String, AutoMap = true)]
    public interface IAudio : IBaseItem
    {
        [SitecoreField(FieldId = Templates.Audio.Fields.Content.Source_String)]
        Link Source { get; set; }
    }
}
