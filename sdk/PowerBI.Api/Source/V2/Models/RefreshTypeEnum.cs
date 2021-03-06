// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{

    /// <summary>
    /// Defines values for RefreshTypeEnum.
    /// </summary>
    public static class RefreshTypeEnum
    {
        /// <summary>
        /// Refresh was triggered by the dataset refresh schedule setting
        /// </summary>
        public const string Scheduled = "Scheduled";
        /// <summary>
        /// Refresh was triggered interactively threw Power BI portal
        /// </summary>
        public const string OnDemand = "OnDemand";
        /// <summary>
        /// Refresh was triggered by an Api call
        /// </summary>
        public const string ViaApi = "ViaApi";
    }
}
