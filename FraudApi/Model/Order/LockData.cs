using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FraudAPI.Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class LockData {
    /// <summary>
    /// The unique Id/Name of the touchpoint that locked the customer order
    /// </summary>
    /// <value>The unique Id/Name of the touchpoint that locked the customer order</value>
    [DataMember(Name="lockedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lockedBy")]
    public string LockedBy { get; set; }

    /// <summary>
    /// The Date/Time when the locked happened, in ISO 8601 format
    /// </summary>
    /// <value>The Date/Time when the locked happened, in ISO 8601 format</value>
    [DataMember(Name="lockedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lockedDate")]
    public DateTime? LockedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LockData {\n");
      sb.Append("  LockedBy: ").Append(LockedBy).Append("\n");
      sb.Append("  LockedDate: ").Append(LockedDate).Append("\n");
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
