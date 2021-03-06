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
    /// FulfillmentLeadTimeData
    /// </summary>
    [DataContract]
    public partial class FulfillmentLeadTimeData :  IEquatable<FulfillmentLeadTimeData>, IValidatableObject
    {
        /// <summary>
        /// The type of the lead time.
        /// </summary>
        /// <value>The type of the lead time.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Transit for value: Transit
            /// </summary>
            [EnumMember(Value = "Transit")]
            Transit = 1,
            
            /// <summary>
            /// Enum Setup for value: Setup
            /// </summary>
            [EnumMember(Value = "Setup")]
            Setup = 2,
            
            /// <summary>
            /// Enum Preparation for value: Preparation
            /// </summary>
            [EnumMember(Value = "Preparation")]
            Preparation = 3,
            
            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 4
        }

        /// <summary>
        /// The type of the lead time.
        /// </summary>
        /// <value>The type of the lead time.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The unit of measure for the lead time
        /// </summary>
        /// <value>The unit of measure for the lead time</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IntervalUnitsEnum
        {
            
            /// <summary>
            /// Enum Minutes for value: Minutes
            /// </summary>
            [EnumMember(Value = "Minutes")]
            Minutes = 1,
            
            /// <summary>
            /// Enum Hours for value: Hours
            /// </summary>
            [EnumMember(Value = "Hours")]
            Hours = 2,
            
            /// <summary>
            /// Enum Days for value: Days
            /// </summary>
            [EnumMember(Value = "Days")]
            Days = 3,
            
            /// <summary>
            /// Enum Months for value: Months
            /// </summary>
            [EnumMember(Value = "Months")]
            Months = 4
        }

        /// <summary>
        /// The unit of measure for the lead time
        /// </summary>
        /// <value>The unit of measure for the lead time</value>
        [DataMember(Name="intervalUnits", EmitDefaultValue=false)]
        public IntervalUnitsEnum? IntervalUnits { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentLeadTimeData" /> class.
        /// </summary>
        /// <param name="Type">The type of the lead time..</param>
        /// <param name="TypeLabel">If the &#39;Other&#39; type is used, then provide a label specifying the lead time..</param>
        /// <param name="Interval">The measure for the lead time..</param>
        /// <param name="IntervalUnits">The unit of measure for the lead time.</param>
        /// <param name="LineId">LineId.</param>
        public FulfillmentLeadTimeData(TypeEnum? Type = default(TypeEnum?), string TypeLabel = default(string), int? Interval = default(int?), IntervalUnitsEnum? IntervalUnits = default(IntervalUnitsEnum?), string LineId = default(string))
        {
            this.Type = Type;
            this.TypeLabel = TypeLabel;
            this.Interval = Interval;
            this.IntervalUnits = IntervalUnits;
            this.LineId = LineId;
        }
        

        /// <summary>
        /// If the &#39;Other&#39; type is used, then provide a label specifying the lead time.
        /// </summary>
        /// <value>If the &#39;Other&#39; type is used, then provide a label specifying the lead time.</value>
        [DataMember(Name="typeLabel", EmitDefaultValue=false)]
        public string TypeLabel { get; set; }

        /// <summary>
        /// The measure for the lead time.
        /// </summary>
        /// <value>The measure for the lead time.</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public int? Interval { get; set; }


        /// <summary>
        /// Gets or Sets LineId
        /// </summary>
        [DataMember(Name="lineId", EmitDefaultValue=false)]
        public string LineId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FulfillmentLeadTimeData {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeLabel: ").Append(TypeLabel).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  IntervalUnits: ").Append(IntervalUnits).Append("\n");
            sb.Append("  LineId: ").Append(LineId).Append("\n");
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
            return this.Equals(input as FulfillmentLeadTimeData);
        }

        /// <summary>
        /// Returns true if FulfillmentLeadTimeData instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentLeadTimeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentLeadTimeData input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.IntervalUnits == input.IntervalUnits ||
                    (this.IntervalUnits != null &&
                    this.IntervalUnits.Equals(input.IntervalUnits))
                ) && 
                (
                    this.LineId == input.LineId ||
                    (this.LineId != null &&
                    this.LineId.Equals(input.LineId))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TypeLabel != null)
                    hashCode = hashCode * 59 + this.TypeLabel.GetHashCode();
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.IntervalUnits != null)
                    hashCode = hashCode * 59 + this.IntervalUnits.GetHashCode();
                if (this.LineId != null)
                    hashCode = hashCode * 59 + this.LineId.GetHashCode();
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
