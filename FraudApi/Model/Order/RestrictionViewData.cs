using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Model.Order
{   
    /// <summary>
    /// Represents information of the calculated selling Restriction on given order .
    /// </summary>
    [DataContract]
    public class RestrictionViewData
    {
        /// <summary>
        /// Gets or Sets LineId
        /// </summary>
        [DataMember(Name = "lineId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lineId", Required = Required.Always)]
        public string LineId { get; set; }

        //TODO chnage to enum
        /// <summary>
        /// Gets or Sets Restriction Rule type
        /// </summary>
        [DataMember(Name = "restrictionRule", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "restrictionRule", Required = Required.Always, ItemConverterType = typeof(StringEnumConverter))]
        public RestrictionRuleEnum RestrictionRule { get; set; }
        
      
        /// <summary>
        /// The restricted order lines  
        /// </summary>
        [DataMember(Name = "restrictedOrderLines", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "restrictedOrderLines", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RestrictedOrderLines { get; set; }

        /// <summary>
        /// The restricted order lines  
        /// </summary>
        [DataMember(Name = "restrictedPaymentLines", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "restrictedPaymentLines", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RestrictedPaymentLines { get; set; }

    }
}