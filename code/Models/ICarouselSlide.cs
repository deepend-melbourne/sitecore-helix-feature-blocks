using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Feature.Blocks.Models
{
    [SitecoreType(TemplateId = Templates.CarouselSlide.ID_String, AutoMap = true)]
    public interface ICarouselSlide : IBaseItem
    {
        [SitecoreField(FieldId = Templates.CarouselSlide.Fields.Content.Link_String)]
        Link Link { get; set; }

        [SitecoreField(FieldId = Templates.CarouselSlide.Fields.Content.Image_String)]
        Image Image { get; set; }
    }
}
