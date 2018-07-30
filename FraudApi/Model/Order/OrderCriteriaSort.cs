using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class OrderCriteriaSort {
    /// <summary>
    /// The column to sort the results by
    /// </summary>
    /// <value>The column to sort the results by</value>
    [DataMember(Name="column", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "column")]
    public string Column { get; set; }

    /// <summary>
    /// The direction to sort the results
    /// </summary>
    /// <value>The direction to sort the results</value>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderCriteriaSort {\n");
      sb.Append("  Column: ").Append(Column).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
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
