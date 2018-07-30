using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Model.Order {

  /// <summary>
  /// Captures constraint violation information for an API request
  /// </summary>
  [DataContract]
  public class ConstraintViolationData {
    /// <summary>
    /// The value that failed validation
    /// </summary>
    /// <value>The value that failed validation</value>
    [DataMember(Name="invalidValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invalidValue")]
    public string InvalidValue { get; set; }

    /// <summary>
    /// Message describing the violation error
    /// </summary>
    /// <value>Message describing the violation error</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// The path of the property that failed validation
    /// </summary>
    /// <value>The path of the property that failed validation</value>
    [DataMember(Name="propertyPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertyPath")]
    public string PropertyPath { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConstraintViolationData {\n");
      sb.Append("  InvalidValue: ").Append(InvalidValue).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  PropertyPath: ").Append(PropertyPath).Append("\n");
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
