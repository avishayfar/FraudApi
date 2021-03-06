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
    /// The user does not have access to the organization specified in the request
    /// </summary>
    [DataContract]
    public partial class TenantAccessDeniedException :  IEquatable<TenantAccessDeniedException>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantAccessDeniedException" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TenantAccessDeniedException() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantAccessDeniedException" /> class.
        /// </summary>
        /// <param name="Message">The error message (required).</param>
        /// <param name="ErrorType">Unique ID identifying the type of error (required) (default to &quot;com.ncr.nep.common.exception.TenantAccessDeniedException&quot;).</param>
        /// <param name="Details">Error-specific values that provide more information on the error, such as the reason for failure or error code.</param>
        public TenantAccessDeniedException(string Message = default(string), string ErrorType = "com.ncr.nep.common.exception.TenantAccessDeniedException", List<string> Details = default(List<string>))
        {
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for TenantAccessDeniedException and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            // to ensure "ErrorType" is required (not null)
            if (ErrorType == null)
            {
                throw new InvalidDataException("ErrorType is a required property for TenantAccessDeniedException and cannot be null");
            }
            else
            {
                this.ErrorType = ErrorType;
            }
            this.Details = Details;
        }
        
        /// <summary>
        /// The error message
        /// </summary>
        /// <value>The error message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Unique ID identifying the type of error
        /// </summary>
        /// <value>Unique ID identifying the type of error</value>
        [DataMember(Name="errorType", EmitDefaultValue=false)]
        public string ErrorType { get; set; }

        /// <summary>
        /// Error-specific values that provide more information on the error, such as the reason for failure or error code
        /// </summary>
        /// <value>Error-specific values that provide more information on the error, such as the reason for failure or error code</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<string> Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantAccessDeniedException {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as TenantAccessDeniedException);
        }

        /// <summary>
        /// Returns true if TenantAccessDeniedException instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantAccessDeniedException to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantAccessDeniedException input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ErrorType == input.ErrorType ||
                    (this.ErrorType != null &&
                    this.ErrorType.Equals(input.ErrorType))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ErrorType != null)
                    hashCode = hashCode * 59 + this.ErrorType.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
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
