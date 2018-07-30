using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class TotalData {
    /// <summary>
    /// The type of the total
    /// </summary>
    /// <value>The type of the total</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The value of the total
    /// </summary>
    /// <value>The value of the total</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public decimal? Value { get; set; }

    /*
    /// <summary>
    /// Gets or Sets LineId
    /// </summary>
    [DataMember(Name="lineId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineId", NullValueHandling = NullValueHandling.Ignore)]
    public string LineId { get; set; }
    */


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TotalData {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      //sb.Append("  LineId: ").Append(LineId).Append("\n");
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
