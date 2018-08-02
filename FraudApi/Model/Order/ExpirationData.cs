using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FraudAPI.Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ExpirationData {
    /// <summary>
    /// Expiration month.
    /// </summary>
    /// <value>Expiration month.</value>
    [DataMember(Name="month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "month")]
    public int? Month { get; set; }

    /// <summary>
    /// Expiration year.
    /// </summary>
    /// <value>Expiration year.</value>
    [DataMember(Name="year", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "year")]
    public int? Year { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExpirationData {\n");
      sb.Append("  Month: ").Append(Month).Append("\n");
      sb.Append("  Year: ").Append(Year).Append("\n");
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
