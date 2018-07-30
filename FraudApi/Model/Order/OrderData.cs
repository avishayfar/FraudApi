using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Model.Order
{

    /// <summary>
    /// Represents the order.
    /// </summary>
    [DataContract(Name = "orderData")]
    public class OrderData
    {
        /*
        /// <summary>
        /// Fees charged to this order, such as delivery or setup fees
        /// </summary>
        /// <value>Fees charged to this order, such as delivery or setup fees</value>
        [DataMember(Name = "fees", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fees")]
        public List<FeeData> Fees { get; set; }
        */

        /// <summary>
        /// The order line items
        /// </summary>
        /// <value>The order line items</value>
        [DataMember(Name = "orderLines", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orderLines", Required = Required.Always)]
        public List<OrderLineData> OrderLines { get; set; }

        
        /// <summary>
        /// Payments information assigned to the order
        /// </summary>
        /// <value>Payments information assigned to the order</value>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payments")]
        public List<PaymentData> Payments { get; set; }
        

        /*
        /// <summary>
        /// The taxes calculated for the order
        /// </summary>
        /// <value>The taxes calculated for the order</value>
        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "taxes")]
        public List<TaxData> Taxes { get; set; }

        /// <summary>
        /// Map of additional Reference ID strings for the order
        /// </summary>
        /// <value>Map of additional Reference ID strings for the order</value>
        [DataMember(Name = "additionalReferenceIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalReferenceIds")]
        public Dictionary<string, string> AdditionalReferenceIds { get; set; }
        */
        
        /*
        /// <summary>
        /// Indicates that this order should be tax exempt. The point of sale should verify the customer is qualified for the order to be exempted.
        /// </summary>
        /// <value>Indicates that this order should be tax exempt. The point of sale should verify the customer is qualified for the order to be exempted.</value>
        [DataMember(Name = "taxExempt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "taxExempt")]
        public bool? TaxExempt { get; set; }

        /// <summary>
        /// Tax Exemption Identifier to verify tax exempt status of an order
        /// </summary>
        /// <value>Tax Exemption Identifier to verify tax exempt status of an order</value>
        [DataMember(Name = "taxExemptId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "taxExemptId")]
        public string TaxExemptId { get; set; }
        */

        /*
        /// <summary>
        /// Modifiers on the orders' lines total
        /// </summary>
        /// <value>Modifiers on the orders' lines total</value>
        [DataMember(Name = "totalModifiers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totalModifiers")]
        public List<TicketTotalModifierData> TotalModifiers { get; set; }

        /// <summary>
        /// Party size for the order
        /// </summary>
        /// <value>Party size for the order</value>
        [DataMember(Name = "partySize", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "partySize")]
        public int? PartySize { get; set; }

        /// <summary>
        /// Pickup contact for the order
        /// </summary>
        /// <value>Pickup contact for the order</value>
        [DataMember(Name = "pickupContact", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pickupContact")]
        public PickupContactData PickupContact { get; set; }

        /// <summary>
        /// General comments for whole order
        /// </summary>
        /// <value>General comments for whole order</value>
        [DataMember(Name = "comments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }
        */

        /*
        /// <summary>
        /// Channel through which the Order was placed
        /// </summary>
        /// <value>Channel through which the Order was placed</value>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; set; }

        /// <summary>
        /// The currency of all money values in the order. This is the currency code as defined in ISO 4217
        /// </summary>
        /// <value>The currency of all money values in the order. This is the currency code as defined in ISO 4217</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }
        */

        /// <summary>
        /// The customer of this order
        /// </summary>
        /// <value>The customer of this order</value>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customer")]
        public CustomerData Customer { get; set; }

        /*
        /// <summary>
        /// List of group members for group ordering on line items
        /// </summary>
        /// <value>List of group members for group ordering on line items</value>
        [DataMember(Name = "groupMembers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "groupMembers")]
        public List<GroupMemberData> GroupMembers { get; set; }

        /// <summary>
        /// Description for an error
        /// </summary>
        /// <value>Description for an error</value>
        [DataMember(Name = "errorDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "errorDescription")]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Responsible party for this order, where party can be application, site, person
        /// </summary>
        /// <value>Responsible party for this order, where party can be application, site, person</value>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }

        /// <summary>
        /// External reference identifier
        /// </summary>
        /// <value>External reference identifier</value>
        [DataMember(Name = "referenceId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Retail origin of the order, such as an order aggregator or third party ordering system.
        /// </summary>
        /// <value>Retail origin of the order, such as an order aggregator or third party ordering system.</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Status this order is in
        /// </summary>
        /// <value>Status this order is in</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// List of customer order totals
        /// </summary>
        /// <value>List of customer order totals</value>
        [DataMember(Name = "totals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totals")]
        public List<TotalData> Totals { get; set; }
        */

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderData {\n");
            //sb.Append("  Fulfillment: ").Append(Fulfillment).Append("\n");
            //sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  OrderLines: ").Append(OrderLines).Append("\n");
            //sb.Append("  Payments: ").Append(Payments).Append("\n");
            //sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            //sb.Append("  AdditionalReferenceIds: ").Append(AdditionalReferenceIds).Append("\n");
            //sb.Append("  TaxExempt: ").Append(TaxExempt).Append("\n");
            //sb.Append("  TaxExemptId: ").Append(TaxExemptId).Append("\n");
            //sb.Append("  TotalModifiers: ").Append(TotalModifiers).Append("\n");
            //sb.Append("  PartySize: ").Append(PartySize).Append("\n");
            //sb.Append("  PickupContact: ").Append(PickupContact).Append("\n");
            //sb.Append("  Comments: ").Append(Comments).Append("\n");
            //sb.Append("  Channel: ").Append(Channel).Append("\n");
            //sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            //sb.Append("  GroupMembers: ").Append(GroupMembers).Append("\n");
            //sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
            //sb.Append("  Owner: ").Append(Owner).Append("\n");
            //sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            //sb.Append("  Source: ").Append(Source).Append("\n");
            //sb.Append("  Status: ").Append(Status).Append("\n");
            //sb.Append("  Totals: ").Append(Totals).Append("\n");
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
