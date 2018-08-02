using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FraudAPI.Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PickupContactData {
    /// <summary>
    /// Name for the pickup contact
    /// </summary>
    /// <value>Name for the pickup contact</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Company associated with pickup contact
    /// </summary>
    /// <value>Company associated with pickup contact</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// Link to an image of the pickup contact
    /// </summary>
    /// <value>Link to an image of the pickup contact</value>
    [DataMember(Name="imageLink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imageLink")]
    public string ImageLink { get; set; }

    /// <summary>
    /// Phone number for the pickup contact
    /// </summary>
    /// <value>Phone number for the pickup contact</value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Indicates if the pickup contact has arrived at the site
    /// </summary>
    /// <value>Indicates if the pickup contact has arrived at the site</value>
    [DataMember(Name="hasArrived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasArrived")]
    public bool? HasArrived { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PickupContactData {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  ImageLink: ").Append(ImageLink).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  HasArrived: ").Append(HasArrived).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
