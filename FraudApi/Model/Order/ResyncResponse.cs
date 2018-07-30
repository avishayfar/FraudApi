using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Model.Order {

  /// <summary>
  /// Response containing all unacknowledged orders for the specified enterprise unit id
  /// </summary>
  [DataContract]
  public class ResyncResponse {
    /// <summary>
    /// List of unacknowledged orders for the specified enterprise unit id
    /// </summary>
    /// <value>List of unacknowledged orders for the specified enterprise unit id</value>
    [DataMember(Name="orders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orders")]
    public List<OrderViewData> Orders { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResyncResponse {\n");
      sb.Append("  Orders: ").Append(Orders).Append("\n");
      sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
      sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
      sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
      sb.Append("  LastPage: ").Append(LastPage).Append("\n");
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
