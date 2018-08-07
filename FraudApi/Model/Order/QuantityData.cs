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
    /// QuantityData
    /// </summary>
    [DataContract]
    public partial class QuantityData :  IEquatable<QuantityData>, IValidatableObject
    {
        /// <summary>
        /// The unit of measure. Returns exceptions when this unit of measure contains invalid code.
        /// </summary>
        /// <value>The unit of measure. Returns exceptions when this unit of measure contains invalid code.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitOfMeasureEnum
        {
            
            /// <summary>
            /// Enum EA for value: EA
            /// </summary>
            [EnumMember(Value = "EA")]
            EA = 1,
            
            /// <summary>
            /// Enum GLI for value: GLI
            /// </summary>
            [EnumMember(Value = "GLI")]
            GLI = 2,
            
            /// <summary>
            /// Enum GLL for value: GLL
            /// </summary>
            [EnumMember(Value = "GLL")]
            GLL = 3,
            
            /// <summary>
            /// Enum LTR for value: LTR
            /// </summary>
            [EnumMember(Value = "LTR")]
            LTR = 4,
            
            /// <summary>
            /// Enum INH for value: INH
            /// </summary>
            [EnumMember(Value = "INH")]
            INH = 5,
            
            /// <summary>
            /// Enum FOT for value: FOT
            /// </summary>
            [EnumMember(Value = "FOT")]
            FOT = 6,
            
            /// <summary>
            /// Enum MMT for value: MMT
            /// </summary>
            [EnumMember(Value = "MMT")]
            MMT = 7,
            
            /// <summary>
            /// Enum CMQ for value: CMQ
            /// </summary>
            [EnumMember(Value = "CMQ")]
            CMQ = 8,
            
            /// <summary>
            /// Enum CMT for value: CMT
            /// </summary>
            [EnumMember(Value = "CMT")]
            CMT = 9,
            
            /// <summary>
            /// Enum MTR for value: MTR
            /// </summary>
            [EnumMember(Value = "MTR")]
            MTR = 10,
            
            /// <summary>
            /// Enum MTK for value: MTK
            /// </summary>
            [EnumMember(Value = "MTK")]
            MTK = 11,
            
            /// <summary>
            /// Enum MTQ for value: MTQ
            /// </summary>
            [EnumMember(Value = "MTQ")]
            MTQ = 12,
            
            /// <summary>
            /// Enum GRM for value: GRM
            /// </summary>
            [EnumMember(Value = "GRM")]
            GRM = 13,
            
            /// <summary>
            /// Enum KGM for value: KGM
            /// </summary>
            [EnumMember(Value = "KGM")]
            KGM = 14,
            
            /// <summary>
            /// Enum LBR for value: LBR
            /// </summary>
            [EnumMember(Value = "LBR")]
            LBR = 15,
            
            /// <summary>
            /// Enum ANN for value: ANN
            /// </summary>
            [EnumMember(Value = "ANN")]
            ANN = 16,
            
            /// <summary>
            /// Enum CEL for value: CEL
            /// </summary>
            [EnumMember(Value = "CEL")]
            CEL = 17,
            
            /// <summary>
            /// Enum FAH for value: FAH
            /// </summary>
            [EnumMember(Value = "FAH")]
            FAH = 18,
            
            /// <summary>
            /// Enum OTHER for value: OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER = 19
        }

        /// <summary>
        /// The unit of measure. Returns exceptions when this unit of measure contains invalid code.
        /// </summary>
        /// <value>The unit of measure. Returns exceptions when this unit of measure contains invalid code.</value>
        [DataMember(Name="unitOfMeasure", EmitDefaultValue=false)]
        public UnitOfMeasureEnum? UnitOfMeasure { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuantityData" /> class.
        /// </summary>
        /// <param name="UnitOfMeasure">The unit of measure. Returns exceptions when this unit of measure contains invalid code..</param>
        /// <param name="UnitOfMeasureLabel">The unit of measure label. This field can be populated when unitOfMeasure  is selected/entered as other value..</param>
        /// <param name="Value">The units value per unit-of-measure. Required field when unitOfMeasure is entered. Accepted decimal and positive/negative numerical value. .</param>
        public QuantityData(UnitOfMeasureEnum? UnitOfMeasure = default(UnitOfMeasureEnum?), string UnitOfMeasureLabel = default(string), decimal? Value = default(decimal?))
        {
            this.UnitOfMeasure = UnitOfMeasure;
            this.UnitOfMeasureLabel = UnitOfMeasureLabel;
            this.Value = Value;
        }
        

        /// <summary>
        /// The unit of measure label. This field can be populated when unitOfMeasure  is selected/entered as other value.
        /// </summary>
        /// <value>The unit of measure label. This field can be populated when unitOfMeasure  is selected/entered as other value.</value>
        [DataMember(Name="unitOfMeasureLabel", EmitDefaultValue=false)]
        public string UnitOfMeasureLabel { get; set; }

        /// <summary>
        /// The units value per unit-of-measure. Required field when unitOfMeasure is entered. Accepted decimal and positive/negative numerical value. 
        /// </summary>
        /// <value>The units value per unit-of-measure. Required field when unitOfMeasure is entered. Accepted decimal and positive/negative numerical value. </value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuantityData {\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  UnitOfMeasureLabel: ").Append(UnitOfMeasureLabel).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as QuantityData);
        }

        /// <summary>
        /// Returns true if QuantityData instances are equal
        /// </summary>
        /// <param name="input">Instance of QuantityData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuantityData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnitOfMeasure == input.UnitOfMeasure ||
                    (this.UnitOfMeasure != null &&
                    this.UnitOfMeasure.Equals(input.UnitOfMeasure))
                ) && 
                (
                    this.UnitOfMeasureLabel == input.UnitOfMeasureLabel ||
                    (this.UnitOfMeasureLabel != null &&
                    this.UnitOfMeasureLabel.Equals(input.UnitOfMeasureLabel))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.UnitOfMeasure != null)
                    hashCode = hashCode * 59 + this.UnitOfMeasure.GetHashCode();
                if (this.UnitOfMeasureLabel != null)
                    hashCode = hashCode * 59 + this.UnitOfMeasureLabel.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
