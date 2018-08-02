using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FraudAPI.Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class LineTaxData {
    /// <summary>
    /// The tax amount
    /// </summary>
    /// <value>The tax amount</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount", NullValueHandling = NullValueHandling.Ignore)]
    public decimal? Amount { get; set; }

    /// <summary>
    /// The tax code
    /// </summary>
    /// <value>The tax code</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code", NullValueHandling = NullValueHandling.Ignore)]
    public string Code { get; set; }

    /// <summary>
    /// Indicate if the tax is included in the item price
    /// </summary>
    /// <value>Indicate if the tax is included in the item price</value>
    [DataMember(Name="isIncluded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isIncluded", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsIncluded { get; set; }

    /// <summary>
    /// Tax percentage for presentation purposes. May be null
    /// </summary>
    /// <value>Tax percentage for presentation purposes. May be null</value>
    [DataMember(Name="percentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "percentage", NullValueHandling = NullValueHandling.Ignore)]
    public decimal? Percentage { get; set; }

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
      sb.Append("class LineTaxData {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  IsIncluded: ").Append(IsIncluded).Append("\n");
      sb.Append("  Percentage: ").Append(Percentage).Append("\n");
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
