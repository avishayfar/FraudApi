using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UrlSubscriptionViewData {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets TopicId
    /// </summary>
    [DataMember(Name="topicId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topicId", NullValueHandling = NullValueHandling.Ignore)]
    public TopicIdData TopicId { get; set; }

    /// <summary>
    /// Gets or Sets MessageAttributePatterns
    /// </summary>
    [DataMember(Name="messageAttributePatterns", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "messageAttributePatterns", NullValueHandling = NullValueHandling.Ignore)]
    public List<KeyValueData> MessageAttributePatterns { get; set; }

    /// <summary>
    /// Gets or Sets PayloadDelivered
    /// </summary>
    [DataMember(Name="payloadDelivered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payloadDelivered", NullValueHandling = NullValueHandling.Ignore)]
    public bool? PayloadDelivered { get; set; }

    /// <summary>
    /// Gets or Sets Endpoint
    /// </summary>
    [DataMember(Name="endpoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endpoint", NullValueHandling = NullValueHandling.Ignore)]
    public UrlEndpointData Endpoint { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UrlSubscriptionViewData {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  TopicId: ").Append(TopicId).Append("\n");
      sb.Append("  MessageAttributePatterns: ").Append(MessageAttributePatterns).Append("\n");
      sb.Append("  PayloadDelivered: ").Append(PayloadDelivered).Append("\n");
      sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
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
