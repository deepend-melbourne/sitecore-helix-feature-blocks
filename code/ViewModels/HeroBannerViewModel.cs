using System.Collections.Generic;

namespace Sitecore.Feature.Blocks.ViewModels
{
    public class HeroBannerViewModel
    {
        public IEnumerable<HeroBannerSlide> Slides { get; set; }

        public class HeroBannerSlide
        {
            public string Image { get; set; }

            public string Title { get; set; }

            public string Description { get; set; }

            public string LinkTitle { get; set; }

            public string LinkUrl { get; set; }
        }
    }
}
