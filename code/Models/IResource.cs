using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.Resource.ID_String, AutoMap = true)]
    public interface IResource : IBaseItem
    {
        [SitecoreField(FieldId = Templates.Resource.Fields.Content.File_String)]
        File File { get; set; }

        [SitecoreField(FieldId = Templates.Resource.Fields.Content.Title_String)]
        string Title { get; set; }
    }
}
