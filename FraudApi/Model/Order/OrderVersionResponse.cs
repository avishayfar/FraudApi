using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FraudAPI.Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class OrderVersionResponse {
    /// <summary>
    /// A generated unique identifier for the order version object
    /// </summary>
    /// <value>A generated unique identifier for the order version object</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The datetime this order update occurred
    /// </summary>
    /// <value>The datetime this order update occurred</value>
    [DataMember(Name="dateUpdated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateUpdated")]
    public DateTime? DateUpdated { get; set; }

    /// <summary>
    /// RFC 6902 JSON Patch Diff
    /// </summary>
    /// <value>RFC 6902 JSON Patch Diff</value>
    [DataMember(Name="diff", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "diff")]
    public JsonNode Diff { get; set; }

    /// <summary>
    /// The user that made the order update
    /// </summary>
    /// <value>The user that made the order update</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public string User { get; set; }

    /// <summary>
    /// The deviceId making the order update
    /// </summary>
    /// <value>The deviceId making the order update</value>
    [DataMember(Name="deviceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deviceId")]
    public string DeviceId { get; set; }

    /// <summary>
    /// The organization responsible for this version
    /// </summary>
    /// <value>The organization responsible for this version</value>
    [DataMember(Name="updatingOrganization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatingOrganization")]
    public string UpdatingOrganization { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderVersionResponse {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
      sb.Append("  Diff: ").Append(Diff).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
      sb.Append("  UpdatingOrganization: ").Append(UpdatingOrganization).Append("\n");
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
