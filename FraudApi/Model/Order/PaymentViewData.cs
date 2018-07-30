using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Model.Order
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class PaymentViewData
    {
        /// <summary>
        /// The amount paid
        /// </summary>
        /// <value>The amount paid</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// the payment usage in order 
        /// </summary>
        [DataMember(Name = "usage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "usage", NullValueHandling = NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PaymentUsage Usage { get; set; }

        /// <summary>
        /// The payment description
        /// </summary>
        /// <value>The payment description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The amount tipped
        /// </summary>
        /// <value>The amount tipped</value>
        [DataMember(Name = "gratuity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gratuity", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Gratuity { get; set; }

        /// <summary>
        /// External reference identifier, to relate the payment line to the payment system
        /// </summary>
        /// <value>External reference identifier, to relate the payment line to the payment system</value>
        [DataMember(Name = "referenceId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "referenceId", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The payment status. i.e. PreAuthorized, Authorized, Paid, PendingVerification
        /// </summary>
        /// <value>The payment status. i.e. PreAuthorized, Authorized, Paid, PendingVerification</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// The payments' type.
        /// </summary>
        /// <value>The payments' type.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// The payments' subType. Here subType is required for CreditDebit card type. Return error if subType is not given for CreditDebit card type input.
        /// </summary>
        /// <value>The payments' subType. Here subType is required for CreditDebit card type. Return error if subType is not given for CreditDebit card type input.</value>
        [DataMember(Name = "subType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "subType", NullValueHandling = NullValueHandling.Ignore)]
        public string SubType { get; set; }

        /// <summary>
        /// The payment tender id.
        /// </summary>
        /// <value>The payment tender id.</value>
        [DataMember(Name = "tenderId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tenderId", NullValueHandling = NullValueHandling.Ignore)]
        public string TenderId { get; set; }


        /// <summary>
        /// Masked Personal Account number
        /// </summary>
        /// <value>Masked Personal Account number</value>
        [DataMember(Name = "maskedPAN", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "maskedPAN", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskedPAN { get; set; }

        /// <summary>
        /// Token for payment validation
        /// </summary>
        /// <value>Token for payment validation</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// Indicates if remaining balance should be charged to the user
        /// </summary>
        /// <value>Indicates if remaining balance should be charged to the user</value>
        [DataMember(Name = "payBalance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payBalance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PayBalance { get; set; }

        /// <summary>
        /// An account number like house account or a customer number.
        /// </summary>
        /// <value>An account number like house account or a customer number.</value>
        [DataMember(Name = "accountNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Date of expiration of the payment method like Credit card or Gift card or Debit Card
        /// </summary>
        /// <value>Date of expiration of the payment method like Credit card or Gift card or Debit Card</value>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expiration", NullValueHandling = NullValueHandling.Ignore)]
        public ExpirationData Expiration { get; set; }

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
            sb.Append("class PaymentViewData {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Gratuity: ").Append(Gratuity).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  MaskedPAN: ").Append(MaskedPAN).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  PayBalance: ").Append(PayBalance).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
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
}
