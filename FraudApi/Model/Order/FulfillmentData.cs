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
    /// FulfillmentData
    /// </summary>
    [DataContract]
    public partial class FulfillmentData :  IEquatable<FulfillmentData>, IValidatableObject
    {
        /// <summary>
        /// The type of fulfillment needed for this order
        /// </summary>
        /// <value>The type of fulfillment needed for this order</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Delivery for value: Delivery
            /// </summary>
            [EnumMember(Value = "Delivery")]
            Delivery = 1,
            
            /// <summary>
            /// Enum Pickup for value: Pickup
            /// </summary>
            [EnumMember(Value = "Pickup")]
            Pickup = 2,
            
            /// <summary>
            /// Enum Notification for value: Notification
            /// </summary>
            [EnumMember(Value = "Notification")]
            Notification = 3,
            
            /// <summary>
            /// Enum CurbSide for value: CurbSide
            /// </summary>
            [EnumMember(Value = "CurbSide")]
            CurbSide = 4,
            
            /// <summary>
            /// Enum DriveThru for value: DriveThru
            /// </summary>
            [EnumMember(Value = "DriveThru")]
            DriveThru = 5,
            
            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 6
        }

        /// <summary>
        /// The type of fulfillment needed for this order
        /// </summary>
        /// <value>The type of fulfillment needed for this order</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentData" /> class.
        /// </summary>
        /// <param name="Address">Address information used in fulfillment (e.g. a delivery address).</param>
        /// <param name="LeadTimes">Fulfillment lead time expected for the order, such as delivery time or preparation time.</param>
        /// <param name="Notes">Notes added to aid in fulfillment (e.g. customer delivery instructions).</param>
        /// <param name="PickupDate">The date when the customer is due to collect the order.</param>
        /// <param name="PickupLocation">The store where the customer will collect his order.</param>
        /// <param name="FulfillmentTime">Indicates the time at which an order should be fulfilled.</param>
        /// <param name="Type">The type of fulfillment needed for this order.</param>
        /// <param name="TypeLabel">If &#39;Other&#39; is the declared type, use typeLabel to specify the actual type.</param>
        /// <param name="AutoRelease">Indicates if the order should be auto released for fulfillment.</param>
        public FulfillmentData(FulfillmentAddressData Address = default(FulfillmentAddressData), List<FulfillmentLeadTimeData> LeadTimes = default(List<FulfillmentLeadTimeData>), string Notes = default(string), DateTime? PickupDate = default(DateTime?), string PickupLocation = default(string), DateTime? FulfillmentTime = default(DateTime?), TypeEnum? Type = default(TypeEnum?), string TypeLabel = default(string), bool? AutoRelease = default(bool?))
        {
            this.Address = Address;
            this.LeadTimes = LeadTimes;
            this.Notes = Notes;
            this.PickupDate = PickupDate;
            this.PickupLocation = PickupLocation;
            this.FulfillmentTime = FulfillmentTime;
            this.Type = Type;
            this.TypeLabel = TypeLabel;
            this.AutoRelease = AutoRelease;
        }
        
        /// <summary>
        /// Address information used in fulfillment (e.g. a delivery address)
        /// </summary>
        /// <value>Address information used in fulfillment (e.g. a delivery address)</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public FulfillmentAddressData Address { get; set; }

        /// <summary>
        /// Fulfillment lead time expected for the order, such as delivery time or preparation time
        /// </summary>
        /// <value>Fulfillment lead time expected for the order, such as delivery time or preparation time</value>
        [DataMember(Name="leadTimes", EmitDefaultValue=false)]
        public List<FulfillmentLeadTimeData> LeadTimes { get; set; }

        /// <summary>
        /// Notes added to aid in fulfillment (e.g. customer delivery instructions)
        /// </summary>
        /// <value>Notes added to aid in fulfillment (e.g. customer delivery instructions)</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// The date when the customer is due to collect the order
        /// </summary>
        /// <value>The date when the customer is due to collect the order</value>
        [DataMember(Name="pickupDate", EmitDefaultValue=false)]
        public DateTime? PickupDate { get; set; }

        /// <summary>
        /// The store where the customer will collect his order
        /// </summary>
        /// <value>The store where the customer will collect his order</value>
        [DataMember(Name="pickupLocation", EmitDefaultValue=false)]
        public string PickupLocation { get; set; }

        /// <summary>
        /// Indicates the time at which an order should be fulfilled
        /// </summary>
        /// <value>Indicates the time at which an order should be fulfilled</value>
        [DataMember(Name="fulfillmentTime", EmitDefaultValue=false)]
        public DateTime? FulfillmentTime { get; set; }


        /// <summary>
        /// If &#39;Other&#39; is the declared type, use typeLabel to specify the actual type
        /// </summary>
        /// <value>If &#39;Other&#39; is the declared type, use typeLabel to specify the actual type</value>
        [DataMember(Name="typeLabel", EmitDefaultValue=false)]
        public string TypeLabel { get; set; }

        /// <summary>
        /// Indicates if the order should be auto released for fulfillment
        /// </summary>
        /// <value>Indicates if the order should be auto released for fulfillment</value>
        [DataMember(Name="autoRelease", EmitDefaultValue=false)]
        public bool? AutoRelease { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentData {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  LeadTimes: ").Append(LeadTimes).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  PickupDate: ").Append(PickupDate).Append("\n");
            sb.Append("  PickupLocation: ").Append(PickupLocation).Append("\n");
            sb.Append("  FulfillmentTime: ").Append(FulfillmentTime).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeLabel: ").Append(TypeLabel).Append("\n");
            sb.Append("  AutoRelease: ").Append(AutoRelease).Append("\n");
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
            return this.Equals(input as FulfillmentData);
        }

        /// <summary>
        /// Returns true if FulfillmentData instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.LeadTimes == input.LeadTimes ||
                    this.LeadTimes != null &&
                    this.LeadTimes.SequenceEqual(input.LeadTimes)
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.PickupDate == input.PickupDate ||
                    (this.PickupDate != null &&
                    this.PickupDate.Equals(input.PickupDate))
                ) && 
                (
                    this.PickupLocation == input.PickupLocation ||
                    (this.PickupLocation != null &&
                    this.PickupLocation.Equals(input.PickupLocation))
                ) && 
                (
                    this.FulfillmentTime == input.FulfillmentTime ||
                    (this.FulfillmentTime != null &&
                    this.FulfillmentTime.Equals(input.FulfillmentTime))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TypeLabel == input.TypeLabel ||
                    (this.TypeLabel != null &&
                    this.TypeLabel.Equals(input.TypeLabel))
                ) && 
                (
                    this.AutoRelease == input.AutoRelease ||
                    (this.AutoRelease != null &&
                    this.AutoRelease.Equals(input.AutoRelease))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.LeadTimes != null)
                    hashCode = hashCode * 59 + this.LeadTimes.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.PickupDate != null)
                    hashCode = hashCode * 59 + this.PickupDate.GetHashCode();
                if (this.PickupLocation != null)
                    hashCode = hashCode * 59 + this.PickupLocation.GetHashCode();
                if (this.FulfillmentTime != null)
                    hashCode = hashCode * 59 + this.FulfillmentTime.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TypeLabel != null)
                    hashCode = hashCode * 59 + this.TypeLabel.GetHashCode();
                if (this.AutoRelease != null)
                    hashCode = hashCode * 59 + this.AutoRelease.GetHashCode();
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
            yield break;
        }
    }

}
