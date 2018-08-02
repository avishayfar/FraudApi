using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FraudAPI.Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CreateOrderSubscriptionRequest {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Indicates if payload should be delivered
    /// </summary>
    /// <value>Indicates if payload should be delivered</value>
    [DataMember(Name="payloadDelivered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payloadDelivered")]
    public bool? PayloadDelivered { get; set; }

    /// <summary>
    /// Description of the subscription
    /// </summary>
    /// <value>Description of the subscription</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Data to define the endpoint to which published messages should be sent for subscription
    /// </summary>
    /// <value>Data to define the endpoint to which published messages should be sent for subscription</value>
    [DataMember(Name="endpoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endpoint")]
    public UrlEndpointData Endpoint { get; set; }

    /// <summary>
    /// Authentication credentials needed for endpoint
    /// </summary>
    /// <value>Authentication credentials needed for endpoint</value>
    [DataMember(Name="authenticationCredentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationCredentials")]
    public AuthenticationData AuthenticationCredentials { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateOrderSubscriptionRequest {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PayloadDelivered: ").Append(PayloadDelivered).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
      sb.Append("  AuthenticationCredentials: ").Append(AuthenticationCredentials).Append("\n");
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
