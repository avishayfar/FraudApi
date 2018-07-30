using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class FeeData {
    /// <summary>
    /// The type of fee
    /// </summary>
    /// <value>The type of fee</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// If the 'Other' type is used, then provide a label specifying the type
    /// </summary>
    /// <value>If the 'Other' type is used, then provide a label specifying the type</value>
    [DataMember(Name="typeLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "typeLabel")]
    public string TypeLabel { get; set; }

    /// <summary>
    /// The service provider charging the fee
    /// </summary>
    /// <value>The service provider charging the fee</value>
    [DataMember(Name="provider", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "provider")]
    public string Provider { get; set; }

    /// <summary>
    /// Amount of the fee
    /// </summary>
    /// <value>Amount of the fee</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Indicates this fee amount should be used instead of a calculated fee
    /// </summary>
    /// <value>Indicates this fee amount should be used instead of a calculated fee</value>
    [DataMember(Name="override", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "override")]
    public bool? _Override { get; set; }

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
      sb.Append("class FeeData {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TypeLabel: ").Append(TypeLabel).Append("\n");
      sb.Append("  Provider: ").Append(Provider).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  _Override: ").Append(_Override).Append("\n");
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
