//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HttpClientSample
{
    
    internal partial class Resources
    {
        private static System.Resources.ResourceManager manager;
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if ((Resources.manager == null))
                {
                    Resources.manager = new System.Resources.ResourceManager("HttpClientSample.Resources", typeof(Resources).Assembly);
                }
                return Resources.manager;
            }
        }
        internal static string GetString(Resources.StringResources id)
        {
            return ((string)(Microsoft.SPOT.ResourceUtility.GetObject(ResourceManager, id)));
        }
        internal static byte[] GetBytes(Resources.BinaryResources id)
        {
            return ((byte[])(Microsoft.SPOT.ResourceUtility.GetObject(ResourceManager, id)));
        }
        [System.SerializableAttribute()]
        internal enum StringResources : short
        {
            Soap = -30610,
        }
        [System.SerializableAttribute()]
        internal enum BinaryResources : short
        {
            VerisignCA = -25106,
            DigiCert = -5926,
        }
    }
}
