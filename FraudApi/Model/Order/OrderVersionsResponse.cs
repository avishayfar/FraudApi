using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FraudAPI.Model.Order {

  /// <summary>
  /// Response containing all versions of the specified order
  /// </summary>
  [DataContract]
  public class OrderVersionsResponse {
    /// <summary>
    /// Order ID
    /// </summary>
    /// <value>Order ID</value>
    [DataMember(Name="orderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderId")]
    public string OrderId { get; set; }

    /// <summary>
    /// List of order version objects
    /// </summary>
    /// <value>List of order version objects</value>
    [DataMember(Name="versions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versions")]
    public List<OrderVersionResponse> Versions { get; set; }

    /// <summary>
    /// The total count of unacknowledged orders for the specified enterprise unit id
    /// </summary>
    /// <value>The total count of unacknowledged orders for the specified enterprise unit id</value>
    [DataMember(Name="totalResults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalResults")]
    public long? TotalResults { get; set; }

    /// <summary>
    /// The total number of pages
    /// </summary>
    /// <value>The total number of pages</value>
    [DataMember(Name="totalPages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalPages")]
    public int? TotalPages { get; set; }

    /// <summary>
    /// The page number of the response
    /// </summary>
    /// <value>The page number of the response</value>
    [DataMember(Name="pageNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageNumber")]
    public int? PageNumber { get; set; }

    /// <summary>
    /// Last page indicator
    /// </summary>
    /// <value>Last page indicator</value>
    [DataMember(Name="lastPage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastPage")]
    public bool? LastPage { get; set; }

    /// <summary>
    /// The organization that originally created the order
    /// </summary>
    /// <value>The organization that originally created the order</value>
    [DataMember(Name="sourceOrganization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceOrganization")]
    public string SourceOrganization { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderVersionsResponse {\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  Versions: ").Append(Versions).Append("\n");
      sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
      sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
      sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
      sb.Append("  LastPage: ").Append(LastPage).Append("\n");
      sb.Append("  SourceOrganization: ").Append(SourceOrganization).Append("\n");
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
