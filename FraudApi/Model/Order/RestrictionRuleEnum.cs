using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Model.Order
{
    /// <summary>
    /// Restriction Rule type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RestrictionRuleEnum
    {
        /// <summary>
        /// Lock For Sale 
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "LockForSale")]  LockForSale,

        /// <summary>
        /// Price Verification Required
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "PriceVerifyRequired")] PriceVerifyRequired
    }
}