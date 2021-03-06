/* 
 * order
 *
 * Enables omni-channel persistence and interaction for selling contexts.
 *
 * OpenAPI spec version: 3.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace FraudAPI.Model.Order
{
    /// <summary>
    /// Represents information of the order that is used for viewing purposes.
    /// </summary>
    [DataContract]
    public partial class OrderViewData :  IEquatable<OrderViewData>, IValidatableObject
    {
        /// <summary>
        /// Channel through which the Order was placed
        /// </summary>
        /// <value>Channel through which the Order was placed</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelEnum
        {
            
            /// <summary>
            /// Enum PhoneIn for value: PhoneIn
            /// </summary>
            [EnumMember(Value = "PhoneIn")]
            PhoneIn = 1,
            
            /// <summary>
            /// Enum WalkIn for value: WalkIn
            /// </summary>
            [EnumMember(Value = "WalkIn")]
            WalkIn = 2,
            
            /// <summary>
            /// Enum Web for value: Web
            /// </summary>
            [EnumMember(Value = "Web")]
            Web = 3,
            
            /// <summary>
            /// Enum EMail for value: eMail
            /// </summary>
            [EnumMember(Value = "eMail")]
            EMail = 4,
            
            /// <summary>
            /// Enum CallCenter for value: CallCenter
            /// </summary>
            [EnumMember(Value = "CallCenter")]
            CallCenter = 5,
            
            /// <summary>
            /// Enum Mobile for value: Mobile
            /// </summary>
            [EnumMember(Value = "Mobile")]
            Mobile = 6,
            
            /// <summary>
            /// Enum DriveThru for value: DriveThru
            /// </summary>
            [EnumMember(Value = "DriveThru")]
            DriveThru = 7
        }

        /// <summary>
        /// Channel through which the Order was placed
        /// </summary>
        /// <value>Channel through which the Order was placed</value>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public ChannelEnum? Channel { get; set; }
        /// <summary>
        /// Status this order is in
        /// </summary>
        /// <value>Status this order is in</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Canceled for value: Canceled
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled = 1,
            
            /// <summary>
            /// Enum Finished for value: Finished
            /// </summary>
            [EnumMember(Value = "Finished")]
            Finished = 2,
            
            /// <summary>
            /// Enum OrderPlaced for value: OrderPlaced
            /// </summary>
            [EnumMember(Value = "OrderPlaced")]
            OrderPlaced = 3,
            
            /// <summary>
            /// Enum ReadyForPickup for value: ReadyForPickup
            /// </summary>
            [EnumMember(Value = "ReadyForPickup")]
            ReadyForPickup = 4,
            
            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            [EnumMember(Value = "Error")]
            Error = 5,
            
            /// <summary>
            /// Enum InProgress for value: InProgress
            /// </summary>
            [EnumMember(Value = "InProgress")]
            InProgress = 6,
            
            /// <summary>
            /// Enum ReceivedForFulfillment for value: ReceivedForFulfillment
            /// </summary>
            [EnumMember(Value = "ReceivedForFulfillment")]
            ReceivedForFulfillment = 7,
            
            /// <summary>
            /// Enum InFulfillment for value: InFulfillment
            /// </summary>
            [EnumMember(Value = "InFulfillment")]
            InFulfillment = 8,
            
            /// <summary>
            /// Enum InTransit for value: InTransit
            /// </summary>
            [EnumMember(Value = "InTransit")]
            InTransit = 9,
            
            /// <summary>
            /// Enum Expired for value: Expired
            /// </summary>
            [EnumMember(Value = "Expired")]
            Expired = 10,
            
            /// <summary>
            /// Enum Abandoned for value: Abandoned
            /// </summary>
            [EnumMember(Value = "Abandoned")]
            Abandoned = 11,
            
            /// <summary>
            /// Enum ReadyForValidation for value: ReadyForValidation
            /// </summary>
            [EnumMember(Value = "ReadyForValidation")]
            ReadyForValidation = 12,
            
            /// <summary>
            /// Enum Validated for value: Validated
            /// </summary>
            [EnumMember(Value = "Validated")]
            Validated = 13,
            
            /// <summary>
            /// Enum OrderUpdated for value: OrderUpdated
            /// </summary>
            [EnumMember(Value = "OrderUpdated")]
            OrderUpdated = 14,
            
            /// <summary>
            /// Enum RejectedForFulfillment for value: RejectedForFulfillment
            /// </summary>
            [EnumMember(Value = "RejectedForFulfillment")]
            RejectedForFulfillment = 15
        }

        /// <summary>
        /// Status this order is in
        /// </summary>
        /// <value>Status this order is in</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderViewData" /> class.
        /// </summary>
        /// <param name="DateCreated">The date the order was created. A read only value that is handled internally, and will be disregarded if sent in a message.</param>
        /// <param name="DateUpdated">The last date the order was changed. A read only value that is handled internally, and will be disregarded if sent in a message.</param>
        /// <param name="Id">Unique identifier. A read only value that is handled internally, and will be disregarded if sent in a message.</param>
        /// <param name="_Lock">Orders&#39; owner locking information.</param>
        /// <param name="ExpireAt">The expiration date of the order. A read only value that is handled internally, and will be disregarded if sent in a message.</param>
        /// <param name="SourceOrganization">Order&#39;s source organization name. A read only value that is handled internally.</param>
        /// <param name="DateAcknowledged">The date and time that an order was acknowledged as received by an NEP Enterprise Unit. If null, order has not been acknowledged by the target NEP Enterprise Unit..</param>
        /// <param name="EnterpriseUnitId">Site for which order is placed..</param>
        /// <param name="Comments">General comments for whole order.</param>
        /// <param name="Channel">Channel through which the Order was placed.</param>
        /// <param name="Currency">The currency of all money values in the order. This is the currency code as defined in ISO 4217.</param>
        /// <param name="Customer">The customer of this order.</param>
        /// <param name="GroupMembers">List of group members for group ordering on line items.</param>
        /// <param name="ErrorDescription">Description for an error.</param>
        /// <param name="Owner">Responsible party for this order, where party can be application, site, person.</param>
        /// <param name="ReferenceId">External reference identifier.</param>
        /// <param name="Source">Retail origin of the order, such as an order aggregator or third party ordering system..</param>
        /// <param name="Status">Status this order is in.</param>
        /// <param name="Totals">List of customer order totals.</param>
        /// <param name="Fulfillment">Information needed to fulfill the order delivery.</param>
        /// <param name="Fees">Fees charged to this order, such as delivery or setup fees.</param>
        /// <param name="OrderLines">The order line items.</param>
        /// <param name="Payments">Payments information assigned to the order.</param>
        /// <param name="Taxes">The taxes calculated for the order.</param>
        /// <param name="Promotions">Promotions information assigned to the order.</param>
        /// <param name="AdditionalReferenceIds">Map of additional Reference ID strings for the order.</param>
        /// <param name="TaxExempt">Indicates that this order should be tax exempt. The point of sale should verify the customer is qualified for the order to be exempted..</param>
        /// <param name="TaxExemptId">Tax Exemption Identifier to verify tax exempt status of an order.</param>
        /// <param name="TotalModifiers">Modifiers on the orders&#39; lines total.</param>
        /// <param name="PartySize">Party size for the order.</param>
        /// <param name="PickupContact">Pickup contact for the order.</param>
        /// <param name="CheckInDetails">CheckIn details for the order.</param>
        /// <param name="Etag">Etag.</param>
        public OrderViewData(DateTime? DateCreated = default(DateTime?), DateTime? DateUpdated = default(DateTime?), string Id = default(string), LockData _Lock = default(LockData), DateTime? ExpireAt = default(DateTime?), string SourceOrganization = default(string), DateTime? DateAcknowledged = default(DateTime?), string EnterpriseUnitId = default(string), string Comments = default(string), ChannelEnum? Channel = default(ChannelEnum?), string Currency = default(string), CustomerData Customer = default(CustomerData), List<GroupMemberData> GroupMembers = default(List<GroupMemberData>), string ErrorDescription = default(string), string Owner = default(string), string ReferenceId = default(string), string Source = default(string), StatusEnum? Status = default(StatusEnum?), List<TotalData> Totals = default(List<TotalData>), FulfillmentData Fulfillment = default(FulfillmentData), List<FeeData> Fees = default(List<FeeData>), List<OrderLineData> OrderLines = default(List<OrderLineData>), List<PaymentData> Payments = default(List<PaymentData>), List<TaxData> Taxes = default(List<TaxData>), List<PromotionData> Promotions = default(List<PromotionData>), Dictionary<string, string> AdditionalReferenceIds = default(Dictionary<string, string>), bool? TaxExempt = default(bool?), string TaxExemptId = default(string), List<TicketTotalModifierData> TotalModifiers = default(List<TicketTotalModifierData>), int? PartySize = default(int?), PickupContactData PickupContact = default(PickupContactData), CheckInDetailsData CheckInDetails = default(CheckInDetailsData), string Etag = default(string))
        {
            this.DateCreated = DateCreated;
            this.DateUpdated = DateUpdated;
            this.Id = Id;
            this._Lock = _Lock;
            this.ExpireAt = ExpireAt;
            this.SourceOrganization = SourceOrganization;
            this.DateAcknowledged = DateAcknowledged;
            this.EnterpriseUnitId = EnterpriseUnitId;
            this.Comments = Comments;
            this.Channel = Channel;
            this.Currency = Currency;
            this.Customer = Customer;
            this.GroupMembers = GroupMembers;
            this.ErrorDescription = ErrorDescription;
            this.Owner = Owner;
            this.ReferenceId = ReferenceId;
            this.Source = Source;
            this.Status = Status;
            this.Totals = Totals;
            this.Fulfillment = Fulfillment;
            this.Fees = Fees;
            this.OrderLines = OrderLines;
            this.Payments = Payments;
            this.Taxes = Taxes;
            this.Promotions = Promotions;
            this.AdditionalReferenceIds = AdditionalReferenceIds;
            this.TaxExempt = TaxExempt;
            this.TaxExemptId = TaxExemptId;
            this.TotalModifiers = TotalModifiers;
            this.PartySize = PartySize;
            this.PickupContact = PickupContact;
            this.CheckInDetails = CheckInDetails;
            this.Etag = Etag;
        }
        
        /// <summary>
        /// The date the order was created. A read only value that is handled internally, and will be disregarded if sent in a message
        /// </summary>
        /// <value>The date the order was created. A read only value that is handled internally, and will be disregarded if sent in a message</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// The last date the order was changed. A read only value that is handled internally, and will be disregarded if sent in a message
        /// </summary>
        /// <value>The last date the order was changed. A read only value that is handled internally, and will be disregarded if sent in a message</value>
        [DataMember(Name="dateUpdated", EmitDefaultValue=false)]
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// Unique identifier. A read only value that is handled internally, and will be disregarded if sent in a message
        /// </summary>
        /// <value>Unique identifier. A read only value that is handled internally, and will be disregarded if sent in a message</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Orders&#39; owner locking information
        /// </summary>
        /// <value>Orders&#39; owner locking information</value>
        [DataMember(Name="lock", EmitDefaultValue=false)]
        public LockData _Lock { get; set; }

        /// <summary>
        /// The expiration date of the order. A read only value that is handled internally, and will be disregarded if sent in a message
        /// </summary>
        /// <value>The expiration date of the order. A read only value that is handled internally, and will be disregarded if sent in a message</value>
        [DataMember(Name="expireAt", EmitDefaultValue=false)]
        public DateTime? ExpireAt { get; set; }

        /// <summary>
        /// Order&#39;s source organization name. A read only value that is handled internally
        /// </summary>
        /// <value>Order&#39;s source organization name. A read only value that is handled internally</value>
        [DataMember(Name="sourceOrganization", EmitDefaultValue=false)]
        public string SourceOrganization { get; set; }

        /// <summary>
        /// The date and time that an order was acknowledged as received by an NEP Enterprise Unit. If null, order has not been acknowledged by the target NEP Enterprise Unit.
        /// </summary>
        /// <value>The date and time that an order was acknowledged as received by an NEP Enterprise Unit. If null, order has not been acknowledged by the target NEP Enterprise Unit.</value>
        [DataMember(Name="dateAcknowledged", EmitDefaultValue=false)]
        public DateTime? DateAcknowledged { get; set; }

        /// <summary>
        /// Site for which order is placed.
        /// </summary>
        /// <value>Site for which order is placed.</value>
        [DataMember(Name="enterpriseUnitId", EmitDefaultValue=false)]
        public string EnterpriseUnitId { get; set; }

        /// <summary>
        /// General comments for whole order
        /// </summary>
        /// <value>General comments for whole order</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }


        /// <summary>
        /// The currency of all money values in the order. This is the currency code as defined in ISO 4217
        /// </summary>
        /// <value>The currency of all money values in the order. This is the currency code as defined in ISO 4217</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The customer of this order
        /// </summary>
        /// <value>The customer of this order</value>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public CustomerData Customer { get; set; }

        /// <summary>
        /// List of group members for group ordering on line items
        /// </summary>
        /// <value>List of group members for group ordering on line items</value>
        [DataMember(Name="groupMembers", EmitDefaultValue=false)]
        public List<GroupMemberData> GroupMembers { get; set; }

        /// <summary>
        /// Description for an error
        /// </summary>
        /// <value>Description for an error</value>
        [DataMember(Name="errorDescription", EmitDefaultValue=false)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Responsible party for this order, where party can be application, site, person
        /// </summary>
        /// <value>Responsible party for this order, where party can be application, site, person</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public string Owner { get; set; }

        /// <summary>
        /// External reference identifier
        /// </summary>
        /// <value>External reference identifier</value>
        [DataMember(Name="referenceId", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Retail origin of the order, such as an order aggregator or third party ordering system.
        /// </summary>
        /// <value>Retail origin of the order, such as an order aggregator or third party ordering system.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }


        /// <summary>
        /// List of customer order totals
        /// </summary>
        /// <value>List of customer order totals</value>
        [DataMember(Name="totals", EmitDefaultValue=false)]
        public List<TotalData> Totals { get; set; }

        /// <summary>
        /// Information needed to fulfill the order delivery
        /// </summary>
        /// <value>Information needed to fulfill the order delivery</value>
        [DataMember(Name="fulfillment", EmitDefaultValue=false)]
        public FulfillmentData Fulfillment { get; set; }

        /// <summary>
        /// Fees charged to this order, such as delivery or setup fees
        /// </summary>
        /// <value>Fees charged to this order, such as delivery or setup fees</value>
        [DataMember(Name="fees", EmitDefaultValue=false)]
        public List<FeeData> Fees { get; set; }

        /// <summary>
        /// The order line items
        /// </summary>
        /// <value>The order line items</value>
        [DataMember(Name="orderLines", EmitDefaultValue=false)]
        public List<OrderLineData> OrderLines { get; set; }

        /// <summary>
        /// Payments information assigned to the order
        /// </summary>
        /// <value>Payments information assigned to the order</value>
        [DataMember(Name="payments", EmitDefaultValue=false)]
        public List<PaymentData> Payments { get; set; }

        /// <summary>
        /// The taxes calculated for the order
        /// </summary>
        /// <value>The taxes calculated for the order</value>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<TaxData> Taxes { get; set; }

        /// <summary>
        /// Promotions information assigned to the order
        /// </summary>
        /// <value>Promotions information assigned to the order</value>
        [DataMember(Name="promotions", EmitDefaultValue=false)]
        public List<PromotionData> Promotions { get; set; }

        /// <summary>
        /// Map of additional Reference ID strings for the order
        /// </summary>
        /// <value>Map of additional Reference ID strings for the order</value>
        [DataMember(Name="additionalReferenceIds", EmitDefaultValue=false)]
        public Dictionary<string, string> AdditionalReferenceIds { get; set; }

        /// <summary>
        /// Indicates that this order should be tax exempt. The point of sale should verify the customer is qualified for the order to be exempted.
        /// </summary>
        /// <value>Indicates that this order should be tax exempt. The point of sale should verify the customer is qualified for the order to be exempted.</value>
        [DataMember(Name="taxExempt", EmitDefaultValue=false)]
        public bool? TaxExempt { get; set; }

        /// <summary>
        /// Tax Exemption Identifier to verify tax exempt status of an order
        /// </summary>
        /// <value>Tax Exemption Identifier to verify tax exempt status of an order</value>
        [DataMember(Name="taxExemptId", EmitDefaultValue=false)]
        public string TaxExemptId { get; set; }

        /// <summary>
        /// Modifiers on the orders&#39; lines total
        /// </summary>
        /// <value>Modifiers on the orders&#39; lines total</value>
        [DataMember(Name="totalModifiers", EmitDefaultValue=false)]
        public List<TicketTotalModifierData> TotalModifiers { get; set; }

        /// <summary>
        /// Party size for the order
        /// </summary>
        /// <value>Party size for the order</value>
        [DataMember(Name="partySize", EmitDefaultValue=false)]
        public int? PartySize { get; set; }

        /// <summary>
        /// Pickup contact for the order
        /// </summary>
        /// <value>Pickup contact for the order</value>
        [DataMember(Name="pickupContact", EmitDefaultValue=false)]
        public PickupContactData PickupContact { get; set; }

        /// <summary>
        /// CheckIn details for the order
        /// </summary>
        /// <value>CheckIn details for the order</value>
        [DataMember(Name="checkInDetails", EmitDefaultValue=false)]
        public CheckInDetailsData CheckInDetails { get; set; }

        /// <summary>
        /// Gets or Sets Etag
        /// </summary>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderViewData {\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Lock: ").Append(_Lock).Append("\n");
            sb.Append("  ExpireAt: ").Append(ExpireAt).Append("\n");
            sb.Append("  SourceOrganization: ").Append(SourceOrganization).Append("\n");
            sb.Append("  DateAcknowledged: ").Append(DateAcknowledged).Append("\n");
            sb.Append("  EnterpriseUnitId: ").Append(EnterpriseUnitId).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  GroupMembers: ").Append(GroupMembers).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Totals: ").Append(Totals).Append("\n");
            sb.Append("  Fulfillment: ").Append(Fulfillment).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  OrderLines: ").Append(OrderLines).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Promotions: ").Append(Promotions).Append("\n");
            sb.Append("  AdditionalReferenceIds: ").Append(AdditionalReferenceIds).Append("\n");
            sb.Append("  TaxExempt: ").Append(TaxExempt).Append("\n");
            sb.Append("  TaxExemptId: ").Append(TaxExemptId).Append("\n");
            sb.Append("  TotalModifiers: ").Append(TotalModifiers).Append("\n");
            sb.Append("  PartySize: ").Append(PartySize).Append("\n");
            sb.Append("  PickupContact: ").Append(PickupContact).Append("\n");
            sb.Append("  CheckInDetails: ").Append(CheckInDetails).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrderViewData);
        }

        /// <summary>
        /// Returns true if OrderViewData instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderViewData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderViewData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.DateUpdated == input.DateUpdated ||
                    (this.DateUpdated != null &&
                    this.DateUpdated.Equals(input.DateUpdated))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this._Lock == input._Lock ||
                    (this._Lock != null &&
                    this._Lock.Equals(input._Lock))
                ) && 
                (
                    this.ExpireAt == input.ExpireAt ||
                    (this.ExpireAt != null &&
                    this.ExpireAt.Equals(input.ExpireAt))
                ) && 
                (
                    this.SourceOrganization == input.SourceOrganization ||
                    (this.SourceOrganization != null &&
                    this.SourceOrganization.Equals(input.SourceOrganization))
                ) && 
                (
                    this.DateAcknowledged == input.DateAcknowledged ||
                    (this.DateAcknowledged != null &&
                    this.DateAcknowledged.Equals(input.DateAcknowledged))
                ) && 
                (
                    this.EnterpriseUnitId == input.EnterpriseUnitId ||
                    (this.EnterpriseUnitId != null &&
                    this.EnterpriseUnitId.Equals(input.EnterpriseUnitId))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.GroupMembers == input.GroupMembers ||
                    this.GroupMembers != null &&
                    this.GroupMembers.SequenceEqual(input.GroupMembers)
                ) && 
                (
                    this.ErrorDescription == input.ErrorDescription ||
                    (this.ErrorDescription != null &&
                    this.ErrorDescription.Equals(input.ErrorDescription))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Totals == input.Totals ||
                    this.Totals != null &&
                    this.Totals.SequenceEqual(input.Totals)
                ) && 
                (
                    this.Fulfillment == input.Fulfillment ||
                    (this.Fulfillment != null &&
                    this.Fulfillment.Equals(input.Fulfillment))
                ) && 
                (
                    this.Fees == input.Fees ||
                    this.Fees != null &&
                    this.Fees.SequenceEqual(input.Fees)
                ) && 
                (
                    this.OrderLines == input.OrderLines ||
                    this.OrderLines != null &&
                    this.OrderLines.SequenceEqual(input.OrderLines)
                ) && 
                (
                    this.Payments == input.Payments ||
                    this.Payments != null &&
                    this.Payments.SequenceEqual(input.Payments)
                ) && 
                (
                    this.Taxes == input.Taxes ||
                    this.Taxes != null &&
                    this.Taxes.SequenceEqual(input.Taxes)
                ) && 
                (
                    this.Promotions == input.Promotions ||
                    this.Promotions != null &&
                    this.Promotions.SequenceEqual(input.Promotions)
                ) && 
                (
                    this.AdditionalReferenceIds == input.AdditionalReferenceIds ||
                    this.AdditionalReferenceIds != null &&
                    this.AdditionalReferenceIds.SequenceEqual(input.AdditionalReferenceIds)
                ) && 
                (
                    this.TaxExempt == input.TaxExempt ||
                    (this.TaxExempt != null &&
                    this.TaxExempt.Equals(input.TaxExempt))
                ) && 
                (
                    this.TaxExemptId == input.TaxExemptId ||
                    (this.TaxExemptId != null &&
                    this.TaxExemptId.Equals(input.TaxExemptId))
                ) && 
                (
                    this.TotalModifiers == input.TotalModifiers ||
                    this.TotalModifiers != null &&
                    this.TotalModifiers.SequenceEqual(input.TotalModifiers)
                ) && 
                (
                    this.PartySize == input.PartySize ||
                    (this.PartySize != null &&
                    this.PartySize.Equals(input.PartySize))
                ) && 
                (
                    this.PickupContact == input.PickupContact ||
                    (this.PickupContact != null &&
                    this.PickupContact.Equals(input.PickupContact))
                ) && 
                (
                    this.CheckInDetails == input.CheckInDetails ||
                    (this.CheckInDetails != null &&
                    this.CheckInDetails.Equals(input.CheckInDetails))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DateCreated != null)
                    hashCode = hashCode * 59 + this.DateCreated.GetHashCode();
                if (this.DateUpdated != null)
                    hashCode = hashCode * 59 + this.DateUpdated.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this._Lock != null)
                    hashCode = hashCode * 59 + this._Lock.GetHashCode();
                if (this.ExpireAt != null)
                    hashCode = hashCode * 59 + this.ExpireAt.GetHashCode();
                if (this.SourceOrganization != null)
                    hashCode = hashCode * 59 + this.SourceOrganization.GetHashCode();
                if (this.DateAcknowledged != null)
                    hashCode = hashCode * 59 + this.DateAcknowledged.GetHashCode();
                if (this.EnterpriseUnitId != null)
                    hashCode = hashCode * 59 + this.EnterpriseUnitId.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.GroupMembers != null)
                    hashCode = hashCode * 59 + this.GroupMembers.GetHashCode();
                if (this.ErrorDescription != null)
                    hashCode = hashCode * 59 + this.ErrorDescription.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.ReferenceId != null)
                    hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Totals != null)
                    hashCode = hashCode * 59 + this.Totals.GetHashCode();
                if (this.Fulfillment != null)
                    hashCode = hashCode * 59 + this.Fulfillment.GetHashCode();
                if (this.Fees != null)
                    hashCode = hashCode * 59 + this.Fees.GetHashCode();
                if (this.OrderLines != null)
                    hashCode = hashCode * 59 + this.OrderLines.GetHashCode();
                if (this.Payments != null)
                    hashCode = hashCode * 59 + this.Payments.GetHashCode();
                if (this.Taxes != null)
                    hashCode = hashCode * 59 + this.Taxes.GetHashCode();
                if (this.Promotions != null)
                    hashCode = hashCode * 59 + this.Promotions.GetHashCode();
                if (this.AdditionalReferenceIds != null)
                    hashCode = hashCode * 59 + this.AdditionalReferenceIds.GetHashCode();
                if (this.TaxExempt != null)
                    hashCode = hashCode * 59 + this.TaxExempt.GetHashCode();
                if (this.TaxExemptId != null)
                    hashCode = hashCode * 59 + this.TaxExemptId.GetHashCode();
                if (this.TotalModifiers != null)
                    hashCode = hashCode * 59 + this.TotalModifiers.GetHashCode();
                if (this.PartySize != null)
                    hashCode = hashCode * 59 + this.PartySize.GetHashCode();
                if (this.PickupContact != null)
                    hashCode = hashCode * 59 + this.PickupContact.GetHashCode();
                if (this.CheckInDetails != null)
                    hashCode = hashCode * 59 + this.CheckInDetails.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Comments (string) maxLength
            if(this.Comments != null && this.Comments.Length > 4000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Comments, length must be less than 4000.", new [] { "Comments" });
            }

            // Comments (string) minLength
            if(this.Comments != null && this.Comments.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Comments, length must be greater than 0.", new [] { "Comments" });
            }

            // ErrorDescription (string) maxLength
            if(this.ErrorDescription != null && this.ErrorDescription.Length > 4000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ErrorDescription, length must be less than 4000.", new [] { "ErrorDescription" });
            }

            // ErrorDescription (string) minLength
            if(this.ErrorDescription != null && this.ErrorDescription.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ErrorDescription, length must be greater than 0.", new [] { "ErrorDescription" });
            }

            // PartySize (int?) minimum
            if(this.PartySize < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PartySize, must be a value greater than or equal to 0.", new [] { "PartySize" });
            }

            yield break;
        }
    }

}
