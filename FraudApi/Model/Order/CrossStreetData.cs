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
    /// CrossStreetData
    /// </summary>
    [DataContract]
    public partial class CrossStreetData :  IEquatable<CrossStreetData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossStreetData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CrossStreetData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossStreetData" /> class.
        /// </summary>
        /// <param name="Name">Near by or cross street name for address (required).</param>
        /// <param name="LineId">LineId.</param>
        public CrossStreetData(string Name = default(string), string LineId = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CrossStreetData and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.LineId = LineId;
        }
        
        /// <summary>
        /// Near by or cross street name for address
        /// </summary>
        /// <value>Near by or cross street name for address</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
            sb.Append("class CrossStreetData {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as CrossStreetData);
        }

        /// <summary>
        /// Returns true if CrossStreetData instances are equal
        /// </summary>
        /// <param name="input">Instance of CrossStreetData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrossStreetData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
