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
    }
}
