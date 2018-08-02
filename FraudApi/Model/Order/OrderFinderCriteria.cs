using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FraudAPI.Model.Order {

  /// <summary>
  /// Criteria details to search orders. Order will have to match ALL provided fields in order to be in the result.
  /// </summary>
  [DataContract]
  public class OrderFinderCriteria {
    /// <summary>
    /// The Id of the Customer associated with the order
    /// </summary>
    /// <value>The Id of the Customer associated with the order</value>
    [DataMember(Name="customerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerId")]
    public string CustomerId { get; set; }

    /// <summary>
    /// Order was last updated on this date, or later
    /// </summary>
    /// <value>Order was last updated on this date, or later</value>
    [DataMember(Name="fromUpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromUpdatedDate")]
    public DateTime? FromUpdatedDate { get; set; }

    /// <summary>
    /// The Phone of the Customer associated with the order
    /// </summary>
    /// <value>The Phone of the Customer associated with the order</value>
    [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phoneNumber")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// The location in which the order was picked
    /// </summary>
    /// <value>The location in which the order was picked</value>
    [DataMember(Name="pickupLocationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickupLocationId")]
    public string PickupLocationId { get; set; }

    /// <summary>
    /// The order reference id
    /// </summary>
    /// <value>The order reference id</value>
    [DataMember(Name="referenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceId")]
    public string ReferenceId { get; set; }

    /// <summary>
    /// The order status
    /// </summary>
    /// <value>The order status</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Order was last updated on this date, or earlier
    /// </summary>
    /// <value>Order was last updated on this date, or earlier</value>
    [DataMember(Name="toUpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toUpdatedDate")]
    public DateTime? ToUpdatedDate { get; set; }

    /// <summary>
    /// The sort order for the paged find response
    /// </summary>
    /// <value>The sort order for the paged find response</value>
    [DataMember(Name="sort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort")]
    public OrderCriteriaSort Sort { get; set; }

    /// <summary>
    /// Boolean value to specify the content of the orders returned.
    /// </summary>
    /// <value>Boolean value to specify the content of the orders returned.</value>
    [DataMember(Name="returnFullOrders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "returnFullOrders")]
    public bool? ReturnFullOrders { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderFinderCriteria {\n");
      sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
      sb.Append("  FromUpdatedDate: ").Append(FromUpdatedDate).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
      sb.Append("  PickupLocationId: ").Append(PickupLocationId).Append("\n");
      sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ToUpdatedDate: ").Append(ToUpdatedDate).Append("\n");
      sb.Append("  Sort: ").Append(Sort).Append("\n");
      sb.Append("  ReturnFullOrders: ").Append(ReturnFullOrders).Append("\n");
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
