using Sitecore.Data;

namespace Sitecore.Feature.Blocks
{
    public static class Templates
    {
        public struct RenderingParameters_Panel
        {
            public const string ID_String = "{87B62D68-A595-4ECF-816F-7D02807F9F24}";
            public static readonly ID ID = new ID(ID_String);
        }

        public struct RenderingParameters_Title
        {
            public const string ID_String = "{13DB47BA-5265-4CB8-898A-759302E44A98}";
            public static readonly ID ID = new ID(ID_String);
        }

        public struct RenderingParameters_Image
        {
            public const string ID_String = "{F965EC29-9526-4907-82EF-C71959EA9260}";
            public static readonly ID ID = new ID(ID_String);
        }

        public struct RenderingParameters_AlertBar
        {
            public const string ID_String = "{EFCAA850-DA51-4C36-BFE6-827392667CD4}";
            public static readonly ID ID = new ID(ID_String);
        }

        public struct Title
        {
            public const string ID_String = "{1BDD6A57-AF21-4F37-A7F8-81B804C2688B}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public struct Content
                {
                    public const string ID_String = "{3673654F-A42D-4189-8C65-9E40594A5F84}";
                    public static readonly ID ID = new ID(ID_String);
                }
            }
        }

        public struct Text
        {
            public const string ID_String = "{8707903B-0168-4F85-9D26-3040DAA68F08}";
            public static readonly ID ID = new ID(ID_String);
        }

        public struct Introduction
        {
            public const string ID_String = "{4A0CE8C3-518C-40D9-ABDF-7AE24BB01AB4}";
            public static readonly ID ID = new ID(ID_String);
        }

        public struct TextStyle
        {
            public const string ID_String = "{186CADB1-A3AB-40CC-B8DF-D424332E72CA}";
            public static readonly ID ID = new ID(ID_String);
        }

        public struct Image
        {
            public const string ID_String = "{2CF161B5-4090-4D93-8009-54736D54BDC5}";
            public static readonly ID ID = new ID(ID_String);
        }

        public struct HeroBanner
        {
            public const string ID_String = "{6B014397-A75A-41D7-A09B-5AE80406B64B}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public struct Content
                {
                    public const string Title_String = "{310DFC2A-586A-48D0-874D-01CE6024D4B7}";
                    public const string Subtitle_String = "{C59B9714-225E-4B06-9272-E88A122F6303}";
                    public const string Image_String = "{8E5C0144-1FBB-4B1A-901A-9EE8DB8900AF}";
                    public const string ImageBackgroundColour_String = "{8E5C0144-1FBB-4B1A-901A-9EE8DB8900AF}";
                    public const string PrimaryAction_String = "{D9B717F0-4E9C-4EF6-B0AC-02FF24EE86E9}";
                    public const string SecondaryAction_String = "{3991E59C-2CC9-4362-BCE7-52FC07A56980}";

                    public static readonly ID Title = new ID(Title_String);
                    public static readonly ID Subtitle = new ID(Subtitle_String);
                    public static readonly ID Image = new ID(Image_String);
                    public static readonly ID ImageBackgroundColour = new ID(ImageBackgroundColour_String);
                    public static readonly ID PrimaryAction = new ID(PrimaryAction_String);
                    public static readonly ID SecondaryAction = new ID(SecondaryAction_String);
                }
            }
        }

        public struct PageBanner
        {
            public const string ID_String = "{EA058A9F-828E-4607-868B-3D4EB78C1BC0}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public struct Content
                {
                    public const string Title_String = "{13CB04F0-6467-4ABD-B767-A46595714087}";

                    public static readonly ID Title = new ID(Title_String);
                }
            }
        }

        public struct PageScheme
        {
            public const string ID_String = "{204FFCCF-B46B-4C3A-AE43-5BD439CAC7BA}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public struct Content
                {
                    public const string PageColourScheme_String = "{032FEB94-AF7B-480F-9F53-BCED7EA0CDCF}";

                    public static readonly ID PageColourScheme = new ID(PageColourScheme_String);
                }
            }
        }

        public static class ColourScheme
        {
            public const string ID_String = "{D30EDEDD-BA1B-4C43-B640-EAB748B9FB49}";
            public static readonly ID ID = new ID(ID_String);

            public static class Fields
            {
                public const string CssClass_String = "{0BEC50E4-2D6C-4F88-82BA-87088F217CE1}";
                public const string Badge_String = "{82A4304A-AA70-4DA9-B53F-003F30C2293A}";

                public static readonly ID CssClass = new ID(CssClass_String);
                public static readonly ID Badge = new ID(Badge_String);
            }
        }

        public struct Video
        {
            public const string ID_String = "{85C97A85-046E-4D78-969C-C13C2E2E3E05}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public struct Content
                {
                    public const string YoutubeVideoId_String = "{C61B72BA-ED69-48B8-8AFC-8FD1CBE42F9B}";
                    public const string Transcript_String = "{A5250100-8B7C-4DAC-A690-18C291C7CACC}";

                    public static readonly ID YoutubeVideoId = new ID(YoutubeVideoId_String);
                    public static readonly ID Transcript = new ID(Transcript_String);
                }
            }
        }

        public struct Accordion
        {
            public const string ID_String = "{F40BF67B-6D59-43C9-87CA-94B703C059F4}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public struct Content
                {
                    public const string Sections_String = "{29FB716D-8A90-49E5-B176-E47B8F55313D}";

                    public static readonly ID Sections = new ID(Sections_String);
                }
            }
        }

        public struct AccordionSection
        {
            public const string ID_String = "{D4A35B12-33DE-4721-AD78-E5B4DE223A2B}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public struct Content
                {
                    public const string Title_String = "{C48EBC1E-7AE9-4E77-9216-9946084859F7}";
                    public const string Abstract_String = "{45BC43B7-45FD-4646-BEFF-226C17638C15}";
                    public const string Body_String = "{53AA43B3-0BF4-461E-BABC-35F6F90464AC}";

                    public static readonly ID Title = new ID(Title_String);
                    public static readonly ID Abstract = new ID(Abstract_String);
                    public static readonly ID Body = new ID(Body_String);
                }
            }
        }

        public struct ContentFinder
        {
            public const string ID_String = "{8E07CC94-A0EE-456A-82A1-67856D6C7062}";
            public static readonly ID ID = new ID(ID_String);

            public struct Grouping
            {
                public const string ID_String = "{2CBC0F30-7BAE-479B-A24A-07CDE5908FC6}";
                public static readonly ID ID = new ID(ID_String);
            }

            public struct Target
            {
                public const string ID_String = "{7B48479C-4264-4E8B-A24B-66603C429E8B}";
                public static readonly ID ID = new ID(ID_String);

                public struct Fields
                {
                    public struct Content
                    {
                        public const string Link_String = "{62979221-4BA8-430B-B13B-2D12317D6597}";

                        public static readonly ID Link = new ID(Link_String);
                    }
                }
            }
        }

        public struct CarouselSlide
        {
            public const string ID_String = "{2F97817B-BD2F-457D-B440-0C1B096ECCD5}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public struct Content
                {
                    public const string Image_String = "{D81A778B-A8C5-4AFC-BD2D-178544053DB7}";
                    public const string Link_String = "{8DC0B649-2311-4199-95E6-A675745D3961}";

                    public static readonly ID Link = new ID(Link_String);
                    public static readonly ID Image = new ID(Image_String);
                }
            }
        }

        public struct Audio
        {
            public const string ID_String = "{28D30D37-8BBE-4C08-B2CF-063923D954FE}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public struct Content
                {
                    public const string Source_String = "{7F2D4BEB-0A18-4777-A9A9-EEB13FBE5A5A}";

                    public static readonly ID Source = new ID(Source_String);
                }
            }
        }

        public struct Quote
        {
            public const string ID_String = "{12EF9F67-27B1-4607-821E-4DF88BB44C8F}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public struct Content
                {
                    public const string Body_String = "{7897985D-84D8-4309-87AC-49C4F61A8657}";
                    public const string Author_String = "{3BDDEA41-D182-432F-B016-1989949AE582}";
                    public const string Title_String = "{F626E742-EA77-4D45-9A8F-84DD99F1A545}";

                    public static readonly ID Body = new ID(Body_String);
                    public static readonly ID Author = new ID(Author_String);
                    public static readonly ID Title = new ID(Title_String);
                }
            }
        }

        public struct Resource
        {
            public const string ID_String = "{7A8689A0-F155-449F-9C39-622D4AFB880B}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public struct Content
                {
                    public const string File_String = "{F24561D5-7421-4407-ADC9-49197A283841}";
                    public const string Title_String = "{F0F220CD-6365-4F35-BFFA-DA36B6A95B0C}";

                    public static readonly ID File = new ID(File_String);
                    public static readonly ID Title = new ID(Title_String);
                }
            }
        }

        public struct ResourceLink
        {
            public const string ID_String = "{FDCDB3DF-45AC-4C38-B58D-07FF57DD9549}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public struct Content
                {
                    public const string Link_String = "{6459CEDC-0CC8-4C39-84C9-F204B74BB635}";
                    public const string Title_String = "{CC3E69D0-7776-402D-A5E3-69579378C8D3}";

                    public static readonly ID Link = new ID(Link_String);
                    public static readonly ID Title = new ID(Title_String);
                }
            }
        }

        public struct Button
        {
            public const string ID_String = "{A10A278B-C458-4443-BB40-A5D3188C94D7}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public struct Content
                {
                    public const string Link_String = "{B083E2CE-4B80-418F-A736-C3C8540F569F}";
                    public const string Text_String = "{AFF8598E-1B28-42D6-A97C-D16DE6B0278F}";

                    public static readonly ID Link = new ID(Link_String);
                    public static readonly ID Text = new ID(Text_String);
                }
            }
        }

        public struct ContentSection
        {
            public const string ID_String = "{4EC1240D-B821-4C0D-9954-5E860D07030F}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public struct Content
                {
                    public const string SectionTitle_String = "{0E57DFB0-8811-4075-B4EE-4CE7180B077C}";

                    public static readonly ID SectionTitle = new ID(SectionTitle_String);
                }
            }
        }

        public struct DotContentItem
        {
            public const string ID_String = "{644304CA-B9CA-452D-86AB-C88590B65146}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public struct Content
                {
                    public const string DotColour_String = "{6D72AAF2-EB11-4FC3-B24E-9D7DB8201E7C}";
                    public const string Title_String = "{1A125988-696F-47C2-A82C-DE322ECD1451}";
                    public const string Text_String = "{BB7E34D6-BC53-466F-BF2E-5D6E9CA4572D}";

                    public static readonly ID DotColour = new ID(DotColour_String);
                    public static readonly ID Title = new ID(Title_String);
                    public static readonly ID Text = new ID(Text_String);
                }
            }
        }
    }
}
