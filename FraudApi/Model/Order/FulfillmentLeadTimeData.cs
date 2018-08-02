using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FraudAPI.Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class FulfillmentLeadTimeData {
    /// <summary>
    /// The type of the lead time.
    /// </summary>
    /// <value>The type of the lead time.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// If the 'Other' type is used, then provide a label specifying the lead time.
    /// </summary>
    /// <value>If the 'Other' type is used, then provide a label specifying the lead time.</value>
    [DataMember(Name="typeLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "typeLabel")]
    public string TypeLabel { get; set; }

    /// <summary>
    /// The measure for the lead time.
    /// </summary>
    /// <value>The measure for the lead time.</value>
    [DataMember(Name="interval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interval")]
    public int? Interval { get; set; }

    /// <summary>
    /// The unit of measure for the lead time
    /// </summary>
    /// <value>The unit of measure for the lead time</value>
    [DataMember(Name="intervalUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intervalUnits")]
    public string IntervalUnits { get; set; }

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
      sb.Append("class FulfillmentLeadTimeData {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TypeLabel: ").Append(TypeLabel).Append("\n");
      sb.Append("  Interval: ").Append(Interval).Append("\n");
      sb.Append("  IntervalUnits: ").Append(IntervalUnits).Append("\n");
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
