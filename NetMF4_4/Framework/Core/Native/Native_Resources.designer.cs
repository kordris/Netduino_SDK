//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50215.44
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.SPOT
{

    internal class Native_Resources
    {
        private static System.Resources.ResourceManager manager;
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if ((Native_Resources.manager == null))
                {
                    Native_Resources.manager = new System.Resources.ResourceManager("Microsoft.SPOT.Native_Resources", typeof(Native_Resources).Assembly);
                }

                return Native_Resources.manager;
            }
        }

        internal static string GetString(Native_Resources.StringResources id)
        {
            return ((string)(Microsoft.SPOT.ResourceUtility.GetObject(ResourceManager, id)));
        }

        [System.SerializableAttribute()]
        internal enum StringResources : short
        {
            TimeZoneNames_0 = -9555,
            TimeZoneNames_60 = 27640,
            TimeZoneNames_70 = 27641,
            TimeZoneNames_40 = 27642,
            TimeZoneNames_50 = 27643,
            TimeZoneNames_20 = 27644,
            TimeZoneNames_30 = 27645,
            TimeZoneNames_10 = 27647,
        }
    }
}


