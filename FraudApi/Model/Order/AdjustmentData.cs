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
    /// AdjustmentData
    /// </summary>
    [DataContract]
    public partial class AdjustmentData :  IEquatable<AdjustmentData>, IValidatableObject
    {
        /// <summary>
        /// Identifies how the adjustment is applied to the order
        /// </summary>
        /// <value>Identifies how the adjustment is applied to the order</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LevelEnum
        {
            
            /// <summary>
            /// Enum ITEM for value: ITEM
            /// </summary>
            [EnumMember(Value = "ITEM")]
            ITEM = 1,
            
            /// <summary>
            /// Enum ORDER for value: ORDER
            /// </summary>
            [EnumMember(Value = "ORDER")]
            ORDER = 2
        }

        /// <summary>
        /// Identifies how the adjustment is applied to the order
        /// </summary>
        /// <value>Identifies how the adjustment is applied to the order</value>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public LevelEnum? Level { get; set; }
        /// <summary>
        /// Identifies the adjustment type
        /// </summary>
        /// <value>Identifies the adjustment type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum PROMO for value: PROMO
            /// </summary>
            [EnumMember(Value = "PROMO")]
            PROMO = 1,
            
            /// <summary>
            /// Enum COMP for value: COMP
            /// </summary>
            [EnumMember(Value = "COMP")]
            COMP = 2,
            
            /// <summary>
            /// Enum LOYALTY for value: LOYALTY
            /// </summary>
            [EnumMember(Value = "LOYALTY")]
            LOYALTY = 3
        }

        /// <summary>
        /// Identifies the adjustment type
        /// </summary>
        /// <value>Identifies the adjustment type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustmentData" /> class.
        /// </summary>
        /// <param name="Level">Identifies how the adjustment is applied to the order.</param>
        /// <param name="Type">Identifies the adjustment type.</param>
        public AdjustmentData(LevelEnum? Level = default(LevelEnum?), TypeEnum? Type = default(TypeEnum?))
        {
            this.Level = Level;
            this.Type = Type;
        }
        


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdjustmentData {\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as AdjustmentData);
        }

        /// <summary>
        /// Returns true if AdjustmentData instances are equal
        /// </summary>
        /// <param name="input">Instance of AdjustmentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdjustmentData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
