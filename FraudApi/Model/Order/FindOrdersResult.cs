using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Model.Order {

  /// <summary>
  /// The result of a find operation on the orders resource.
  /// </summary>
  [DataContract]
  public class FindOrdersResult {
    /// <summary>
    /// List of orders that matches the find criteria, limited to the request skip and limit. By default the limit is 20
    /// </summary>
    /// <value>List of orders that matches the find criteria, limited to the request skip and limit. By default the limit is 20</value>
    [DataMember(Name="orders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orders")]
    public List<OrderViewData> Orders { get; set; }

    /// <summary>
    /// The total count of the orders that match the find criteria
    /// </summary>
    /// <value>The total count of the orders that match the find criteria</value>
    [DataMember(Name="totalResults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalResults")]
    public long? TotalResults { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FindOrdersResult {\n");
      sb.Append("  Orders: ").Append(Orders).Append("\n");
      sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
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
