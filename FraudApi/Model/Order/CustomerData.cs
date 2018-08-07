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
    /// CustomerData
    /// </summary>
    [DataContract]
    public partial class CustomerData :  IEquatable<CustomerData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerData" /> class.
        /// </summary>
        /// <param name="Id">The customer identifier, referencing the NCR platform customer data.</param>
        /// <param name="ExternalIds">ExternalIds.</param>
        /// <param name="Name">The customer name is used for groups, organizations or usernames.  If specifying an individual’s name, use the first and last name fields..</param>
        /// <param name="FirstName">The customer&#39;s first name.</param>
        /// <param name="LastName">The customer&#39;s last name.</param>
        /// <param name="Phone">Phone number, for identification and contact purposes.</param>
        /// <param name="PhoneExtension">Phone extension, for contact purposes.</param>
        /// <param name="Email">Email address, for identification and contact purposes.</param>
        public CustomerData(string Id = default(string), List<CustomerIdData> ExternalIds = default(List<CustomerIdData>), string Name = default(string), string FirstName = default(string), string LastName = default(string), string Phone = default(string), string PhoneExtension = default(string), string Email = default(string))
        {
            this.Id = Id;
            this.ExternalIds = ExternalIds;
            this.Name = Name;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.PhoneExtension = PhoneExtension;
            this.Email = Email;
        }
        
        /// <summary>
        /// The customer identifier, referencing the NCR platform customer data
        /// </summary>
        /// <value>The customer identifier, referencing the NCR platform customer data</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ExternalIds
        /// </summary>
        [DataMember(Name="externalIds", EmitDefaultValue=false)]
        public List<CustomerIdData> ExternalIds { get; set; }

        /// <summary>
        /// The customer name is used for groups, organizations or usernames.  If specifying an individual’s name, use the first and last name fields.
        /// </summary>
        /// <value>The customer name is used for groups, organizations or usernames.  If specifying an individual’s name, use the first and last name fields.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The customer&#39;s first name
        /// </summary>
        /// <value>The customer&#39;s first name</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The customer&#39;s last name
        /// </summary>
        /// <value>The customer&#39;s last name</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Phone number, for identification and contact purposes
        /// </summary>
        /// <value>Phone number, for identification and contact purposes</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Phone extension, for contact purposes
        /// </summary>
        /// <value>Phone extension, for contact purposes</value>
        [DataMember(Name="phoneExtension", EmitDefaultValue=false)]
        public string PhoneExtension { get; set; }

        /// <summary>
        /// Email address, for identification and contact purposes
        /// </summary>
        /// <value>Email address, for identification and contact purposes</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalIds: ").Append(ExternalIds).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PhoneExtension: ").Append(PhoneExtension).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as CustomerData);
        }

        /// <summary>
        /// Returns true if CustomerData instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ExternalIds == input.ExternalIds ||
                    this.ExternalIds != null &&
                    this.ExternalIds.SequenceEqual(input.ExternalIds)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.PhoneExtension == input.PhoneExtension ||
                    (this.PhoneExtension != null &&
                    this.PhoneExtension.Equals(input.PhoneExtension))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ExternalIds != null)
                    hashCode = hashCode * 59 + this.ExternalIds.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.PhoneExtension != null)
                    hashCode = hashCode * 59 + this.PhoneExtension.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
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
