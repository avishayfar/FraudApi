using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Model.Order
{

    /// <summary>
    /// Represents information of the order that is used for viewing purposes.
    /// </summary>
    [DataContract(Name = "orderViewData",Namespace = "")]
    public class OrderViewData
    {
        /*
        /// <summary>
        /// The date the order was created. A read only value that is handled internally, and will be disregarded if sent in a message
        /// </summary>
        /// <value>The date the order was created. A read only value that is handled internally, and will be disregarded if sent in a message</value>
        [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dateCreated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// The last date the order was changed. A read only value that is handled internally, and will be disregarded if sent in a message
        /// </summary>
        /// <value>The last date the order was changed. A read only value that is handled internally, and will be disregarded if sent in a message</value>
        [DataMember(Name = "dateUpdated", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dateUpdated")]
        public DateTime? DateUpdated { get; set; }
        */
        /// <summary>
        /// Unique identifier. A read only value that is handled internally, and will be disregarded if sent in a message
        /// </summary>
        /// <value>Unique identifier. A read only value that is handled internally, and will be disregarded if sent in a message</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /*
        /// <summary>
        /// Orders' owner locking information
        /// </summary>
        /// <value>Orders' owner locking information</value>
        [DataMember(Name = "lock", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lock")]
        public LockData _Lock { get; set; }

        /// <summary>
        /// The expiration date of the order. A read only value that is handled internally, and will be disregarded if sent in a message
        /// </summary>
        /// <value>The expiration date of the order. A read only value that is handled internally, and will be disregarded if sent in a message</value>
        [DataMember(Name = "expireAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expireAt")]
        public DateTime? ExpireAt { get; set; }

        /// <summary>
        /// Order's source organization name. A read only value that is handled internally
        /// </summary>
        /// <value>Order's source organization name. A read only value that is handled internally</value>
        [DataMember(Name = "sourceOrganization", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sourceOrganization")]
        public string SourceOrganization { get; set; }

        /// <summary>
        /// The date and time that an order was acknowledged as received by an NEP Enterprise Unit. If null, order has not been acknowledged by the target NEP Enterprise Unit.
        /// </summary>
        /// <value>The date and time that an order was acknowledged as received by an NEP Enterprise Unit. If null, order has not been acknowledged by the target NEP Enterprise Unit.</value>
        [DataMember(Name = "dateAcknowledged", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dateAcknowledged")]
        public DateTime? DateAcknowledged { get; set; }

        /// <summary>
        /// Site for which order is placed.
        /// </summary>
        /// <value>Site for which order is placed.</value>
        [DataMember(Name = "enterpriseUnitId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "enterpriseUnitId")]
        public string EnterpriseUnitId { get; set; }

        /// <summary>
        /// General comments for whole order
        /// </summary>
        /// <value>General comments for whole order</value>
        [DataMember(Name = "comments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }

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
        /// The order line items
        /// </summary>
        /// <value>The order line items</value>
        [DataMember(Name = "orderLines", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orderLines", NullValueHandling = NullValueHandling.Ignore, Order = 1)]
        public List<OrderLineViewData> OrderLines { get; set; }

        /// <summary>
        /// The customer of this order
        /// </summary>
        /// <value>The customer of this order</value>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customer", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        public CustomerViewData Customer { get; set; }

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
        */

        /*
        /// <summary>
        /// Information needed to fulfill the order delivery
        /// </summary>
        /// <value>Information needed to fulfill the order delivery</value>
        [DataMember(Name = "fulfillment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fulfillment")]
        public FulfillmentData Fulfillment { get; set; }

        /// <summary>
        /// Fees charged to this order, such as delivery or setup fees
        /// </summary>
        /// <value>Fees charged to this order, such as delivery or setup fees</value>
        [DataMember(Name = "fees", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fees")]
        public List<FeeData> Fees { get; set; }
        */

        
        /// <summary>
        /// Payments information assigned to the order
        /// </summary>
        /// <value>Payments information assigned to the order</value>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payments", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        public List<PaymentViewData> Payments { get; set; }

        /// <summary>
        /// Calculated Refunds information for order 
        /// </summary>
        /// <value>Calculated Refunds information for order</value>
        [DataMember(Name = "refunds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "refunds", NullValueHandling = NullValueHandling.Ignore, Order = 4)]
        public List<RefundViewData> Refunds { get; set; }


        /// <summary>
        /// The taxes calculated for the order
        /// </summary>
        /// <value>The taxes calculated for the order</value>
        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "taxes", NullValueHandling = NullValueHandling.Ignore, Order = 5)]
        public List<TaxData> Taxes { get; set; }

        /*
        /// <summary>
        /// Map of additional Reference ID strings for the order
        /// </summary>
        /// <value>Map of additional Reference ID strings for the order</value>
        [DataMember(Name = "additionalReferenceIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "additionalReferenceIds")]
        public Dictionary<string, string> AdditionalReferenceIds { get; set; }
        */

        /// <summary>
        /// Indicates that this order should be tax exempt. The point of sale should verify the customer is qualified for the order to be exempted.
        /// </summary>
        /// <value>Indicates that this order should be tax exempt. The point of sale should verify the customer is qualified for the order to be exempted.</value>
        [DataMember(Name = "taxExempt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "taxExempt", NullValueHandling = NullValueHandling.Ignore, Order = 5)]
        public bool? TaxExempt { get; set; }

        /// <summary>
        /// Tax Exemption Identifier to verify tax exempt status of an order
        /// </summary>
        /// <value>Tax Exemption Identifier to verify tax exempt status of an order</value>
        [DataMember(Name = "taxExemptId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "taxExemptId", NullValueHandling = NullValueHandling.Ignore, Order = 6)]
        public string TaxExemptId { get; set; }


        /// <summary>
        /// List of customer order totals
        /// </summary>
        /// <value>List of customer order totals</value>
        [DataMember(Name = "totals", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "totals", Order = 7)]
        public List<TotalData> Totals { get; set; }

        /// <summary>
        /// The Order Restrictions refer to order lines   
        /// </summary>
        /// The Order Restrictions refer to order lines   
        [DataMember(Name = "restrictions", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "restrictions", NullValueHandling = NullValueHandling.Ignore, Order = 8)]
        public List<RestrictionViewData> Restrictions { get; set; }

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
        /// Gets or Sets Etag
        /// </summary>
        [DataMember(Name = "etag", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }
        */

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderViewData {\n");
            //sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            //sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
            //sb.Append("  Id: ").Append(Id).Append("\n");
            //sb.Append("  _Lock: ").Append(_Lock).Append("\n");
            //sb.Append("  ExpireAt: ").Append(ExpireAt).Append("\n");
            //sb.Append("  SourceOrganization: ").Append(SourceOrganization).Append("\n");
            //sb.Append("  DateAcknowledged: ").Append(DateAcknowledged).Append("\n");
            //sb.Append("  EnterpriseUnitId: ").Append(EnterpriseUnitId).Append("\n");
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
            sb.Append("  Totals: ").Append(Totals).Append("\n");
            //sb.Append("  Fulfillment: ").Append(Fulfillment).Append("\n");
            //sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  OrderLines: ").Append(OrderLines).Append("\n");
            //sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            //sb.Append("  AdditionalReferenceIds: ").Append(AdditionalReferenceIds).Append("\n");
            sb.Append("  TaxExempt: ").Append(TaxExempt).Append("\n");
            sb.Append("  TaxExemptId: ").Append(TaxExemptId).Append("\n");
            //sb.Append("  TotalModifiers: ").Append(TotalModifiers).Append("\n");
            //sb.Append("  PartySize: ").Append(PartySize).Append("\n");
            //sb.Append("  PickupContact: ").Append(PickupContact).Append("\n");
            //sb.Append("  Etag: ").Append(Etag).Append("\n");
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
