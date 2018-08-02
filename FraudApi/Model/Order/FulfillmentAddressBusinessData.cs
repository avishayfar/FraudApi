using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FraudAPI.Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class FulfillmentAddressBusinessData {
    /// <summary>
    /// Business name.
    /// </summary>
    /// <value>Business name.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Specific department name.
    /// </summary>
    /// <value>Specific department name.</value>
    [DataMember(Name="department", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "department")]
    public string Department { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FulfillmentAddressBusinessData {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Department: ").Append(Department).Append("\n");
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
