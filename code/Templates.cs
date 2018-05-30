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
                    public const string Video_String = "{9F829E30-31BE-4612-AE8B-C82AE485CE01}";
                    public const string PrimaryAction_String = "{D9B717F0-4E9C-4EF6-B0AC-02FF24EE86E9}";
                    public const string SecondaryAction_String = "{3991E59C-2CC9-4362-BCE7-52FC07A56980}";

                    public static readonly ID Title = new ID(Title_String);
                    public static readonly ID Subtitle = new ID(Subtitle_String);
                    public static readonly ID Image = new ID(Image_String);
                    public static readonly ID Video = new ID(Video_String);
                    public static readonly ID PrimaryAction = new ID(PrimaryAction_String);
                    public static readonly ID SecondaryAction = new ID(SecondaryAction_String);
                }
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
                    public const string VideoUrl_String = "{C61B72BA-ED69-48B8-8AFC-8FD1CBE42F9B}";

                    public static readonly ID VideoUrl = new ID(VideoUrl_String);
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
    }
}
