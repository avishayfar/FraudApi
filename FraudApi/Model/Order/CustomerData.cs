using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Model.Order
{

    [DataContract]
    public class CustomerData
    {
        /// <summary>
        /// The customer identifier, referencing the NCR platform customer data
        /// </summary>
        /// <value>The customer identifier, referencing the NCR platform customer data</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ExternalIds
        /// </summary>
        [DataMember(Name = "externalIds", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "externalIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomerIdData> ExternalIds { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CustomerViewData : CustomerData
    {
        /// <summary>
        /// The customer name is used for groups, organizations or usernames.  If specifying an individual’s name, use the first and last name fields.
        /// </summary>
        /// <value>The customer name is used for groups, organizations or usernames.  If specifying an individual’s name, use the first and last name fields.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The customer's first name
        /// </summary>
        /// <value>The customer's first name</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstName", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// The customer's last name
        /// </summary>
        /// <value>The customer's last name</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastName", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /*
        /// <summary>
        /// Phone number, for identification and contact purposes
        /// </summary>
        /// <value>Phone number, for identification and contact purposes</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// Phone extension, for contact purposes
        /// </summary>
        /// <value>Phone extension, for contact purposes</value>
        [DataMember(Name = "phoneExtension", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "phoneExtension", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneExtension { get; set; }

        /// <summary>
        /// Email address, for identification and contact purposes
        /// </summary>
        /// <value>Email address, for identification and contact purposes</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }
        */

        /// <summary>
        /// Get the string presentation of the object
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
            //sb.Append("  Phone: ").Append(Phone).Append("\n");
            //sb.Append("  PhoneExtension: ").Append(PhoneExtension).Append("\n");
            //sb.Append("  Email: ").Append(Email).Append("\n");
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
