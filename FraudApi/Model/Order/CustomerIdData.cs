using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CustomerIdData {
    /// <summary>
    /// The type of customer ID
    /// </summary>
    /// <value>The type of customer ID</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    /// <summary>
    /// If the 'Other' type is used, then provide a label specifying the type
    /// </summary>
    /// <value>If the 'Other' type is used, then provide a label specifying the type</value>
    [DataMember(Name="typeLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "typeLabel", NullValueHandling = NullValueHandling.Ignore)]
    public string TypeLabel { get; set; }

    /// <summary>
    /// The customer id value
    /// </summary>
    /// <value>The customer id value</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Gets or Sets LineId
    /// </summary>
    [DataMember(Name="lineId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineId", NullValueHandling = NullValueHandling.Ignore)]
    public string LineId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CustomerIdData {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TypeLabel: ").Append(TypeLabel).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  LineId: ").Append(LineId).Append("\n");
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
