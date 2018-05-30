using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.ContentFinder.ID_String, AutoMap = true)]
    public interface IContentFinder : IBaseItem
    {
        [SitecoreChildren]
        IEnumerable<IGrouping> Groupings { get; set; }
    }

    [SitecoreType(TemplateId = Templates.ContentFinder.Grouping.ID_String, AutoMap = true)]
    public interface IGrouping : IBaseItem
    {
        [SitecoreChildren]
        IEnumerable<ITarget> Targets { get; set; }
    }

    [SitecoreType(TemplateId = Templates.ContentFinder.Target.ID_String, AutoMap = true)]
    public interface ITarget : IBaseItem
    {
        [SitecoreField(FieldId = Templates.ContentFinder.Target.Fields.Content.Link_String)]
        Link Link { get; set; }
    }
}
