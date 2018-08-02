using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FraudAPI.Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class FulfillmentData {
    /// <summary>
    /// Address information used in fulfillment (e.g. a delivery address)
    /// </summary>
    /// <value>Address information used in fulfillment (e.g. a delivery address)</value>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public FulfillmentAddressData Address { get; set; }

    /// <summary>
    /// Fulfillment lead time expected for the order, such as delivery time or preparation time
    /// </summary>
    /// <value>Fulfillment lead time expected for the order, such as delivery time or preparation time</value>
    [DataMember(Name="leadTimes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leadTimes")]
    public List<FulfillmentLeadTimeData> LeadTimes { get; set; }

    /// <summary>
    /// Notes added to aid in fulfillment (e.g. customer delivery instructions)
    /// </summary>
    /// <value>Notes added to aid in fulfillment (e.g. customer delivery instructions)</value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// The date when the customer is due to collect the order
    /// </summary>
    /// <value>The date when the customer is due to collect the order</value>
    [DataMember(Name="pickupDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickupDate")]
    public DateTime? PickupDate { get; set; }

    /// <summary>
    /// The store where the customer will collect his order
    /// </summary>
    /// <value>The store where the customer will collect his order</value>
    [DataMember(Name="pickupLocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickupLocation")]
    public string PickupLocation { get; set; }

    /// <summary>
    /// Indicates the time at which an order should be fulfilled
    /// </summary>
    /// <value>Indicates the time at which an order should be fulfilled</value>
    [DataMember(Name="fulfillmentTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fulfillmentTime")]
    public DateTime? FulfillmentTime { get; set; }

    /// <summary>
    /// The type of fulfillment needed for this order
    /// </summary>
    /// <value>The type of fulfillment needed for this order</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// If 'Other' is the declared type, use typeLabel to specify the actual type
    /// </summary>
    /// <value>If 'Other' is the declared type, use typeLabel to specify the actual type</value>
    [DataMember(Name="typeLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "typeLabel")]
    public string TypeLabel { get; set; }

    /// <summary>
    /// Indicates if the order should be auto released for fulfillment
    /// </summary>
    /// <value>Indicates if the order should be auto released for fulfillment</value>
    [DataMember(Name="autoRelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoRelease")]
    public bool? AutoRelease { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FulfillmentData {\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  LeadTimes: ").Append(LeadTimes).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  PickupDate: ").Append(PickupDate).Append("\n");
      sb.Append("  PickupLocation: ").Append(PickupLocation).Append("\n");
      sb.Append("  FulfillmentTime: ").Append(FulfillmentTime).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TypeLabel: ").Append(TypeLabel).Append("\n");
      sb.Append("  AutoRelease: ").Append(AutoRelease).Append("\n");
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
