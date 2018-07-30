using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Model.Order
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class RefundData
    {
        /// <summary>
        /// The amount refunded
        /// </summary>
        /// <value>The amount paid</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// the refund usage in order 
        /// </summary>
        [DataMember(Name = "usage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "usage", NullValueHandling = NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RefundUsage Usage { get; set; }

        /// <summary>
        /// The refund description
        /// </summary>
        /// <value>The payment description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The refunds' type.
        /// </summary>
        /// <value>The refunds' type.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// The refunds' subType. Here subType is required for CreditDebit card type. Return error if subType is not given for CreditDebit card type input.
        /// </summary>
        /// <value>The refunds' subType. Here subType is required for CreditDebit card type. Return error if subType is not given for CreditDebit card type input.</value>
        [DataMember(Name = "subType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "subType", NullValueHandling = NullValueHandling.Ignore)]
        public string SubType { get; set; }

        /// <summary>
        /// The refund tender id.
        /// </summary>
        /// <value>The payment tender id.</value>
        [DataMember(Name = "tenderId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tenderId", NullValueHandling = NullValueHandling.Ignore)]
        public string TenderId { get; set; }

        /// <summary>
        /// Gets or Sets LineId
        /// </summary>
        [DataMember(Name = "lineId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lineId", NullValueHandling = NullValueHandling.Ignore)]
        public string LineId { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentData {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  LineId: ").Append(LineId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }


    /// <summary>
    /// Refund Usage type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RefundUsage
    {
        /// <summary>
        /// Refund
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "Refund")]
        Refund = 1,
        /// <summary>
        /// Change
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "Change")]
        Change = 2,
        /// <summary>
        /// Exchange Pay
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "ExchangePay")]
        ExchangePay = 3,
        /// <summary>
        /// Exchange Receive
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "ExchangeReceive")]
        ExchangeReceive = 4,
        /// <summary>
        /// Rounding
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "Rounding")]
        Rounding = 5,
        /// <summary>
        /// Voided
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "Voided")]
        Voided = 7
    }
}