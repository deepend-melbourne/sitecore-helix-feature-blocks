using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.FeatureIconContentItem.ID_String, AutoMap = true)]
    public interface IFeatureIconContentItem : IBaseItem
    {
        [SitecoreField(FieldId = Templates.FeatureIconContentItem.Fields.Content.Theme_String)]
        IColourScheme Theme { get; set; }

        [SitecoreField(FieldId = Templates.FeatureIconContentItem.Fields.Content.IconImage_String)]
        Image IconImage { get; set; }

        [SitecoreField(FieldId = Templates.FeatureIconContentItem.Fields.Content.Title_String)]
        string Title { get; set; }

        [SitecoreField(FieldId = Templates.FeatureIconContentItem.Fields.Content.Text_String)]
        string Text { get; set; }

        [SitecoreField(FieldId = Templates.FeatureIconContentItem.Fields.Content.Link_String)]
        Link Link { get; set; }
    }
}

