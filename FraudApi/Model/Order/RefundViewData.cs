using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Model.Order
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class RefundViewData: RefundData
    {
        /// <summary>
        /// The line identifier that payment line is effected by. Effected method is indicate by usage e.g. Voided.
        /// </summary>
        /// <value>The line identifier that payment line is effected by. Effected method is indicate by usage e.g. Voided.</value>
        [DataMember(Name = "effectedLineId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "effectedLineId", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectedLineId { get; set; }
    }
}