using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class FulfillmentAddressData {
    /// <summary>
    /// The type of address.
    /// </summary>
    /// <value>The type of address.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// If type is 'Other', optionally specify the address type.
    /// </summary>
    /// <value>If type is 'Other', optionally specify the address type.</value>
    [DataMember(Name="typeLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "typeLabel")]
    public string TypeLabel { get; set; }

    /// <summary>
    /// First line of the address.
    /// </summary>
    /// <value>First line of the address.</value>
    [DataMember(Name="line1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line1")]
    public string Line1 { get; set; }

    /// <summary>
    /// Second line of the address.
    /// </summary>
    /// <value>Second line of the address.</value>
    [DataMember(Name="line2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line2")]
    public string Line2 { get; set; }

    /// <summary>
    /// City of the address
    /// </summary>
    /// <value>City of the address</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// State or province of the address.
    /// </summary>
    /// <value>State or province of the address.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Country of the address.
    /// </summary>
    /// <value>Country of the address.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Postal code of the address.
    /// </summary>
    /// <value>Postal code of the address.</value>
    [DataMember(Name="postalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postalCode")]
    public string PostalCode { get; set; }

    /// <summary>
    /// Geolocation coordinates for the address
    /// </summary>
    /// <value>Geolocation coordinates for the address</value>
    [DataMember(Name="coordinates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "coordinates")]
    public GeolocationCoordinatesData Coordinates { get; set; }

    /// <summary>
    /// List of streets that intersect this address
    /// </summary>
    /// <value>List of streets that intersect this address</value>
    [DataMember(Name="crossStreets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "crossStreets")]
    public List<CrossStreetData> CrossStreets { get; set; }

    /// <summary>
    /// Delivery notes for the address (e.g. Use entrance on east side).
    /// </summary>
    /// <value>Delivery notes for the address (e.g. Use entrance on east side).</value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }

    /// <summary>
    /// Additional business data if this is a business address.
    /// </summary>
    /// <value>Additional business data if this is a business address.</value>
    [DataMember(Name="businessInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "businessInfo")]
    public FulfillmentAddressBusinessData BusinessInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FulfillmentAddressData {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TypeLabel: ").Append(TypeLabel).Append("\n");
      sb.Append("  Line1: ").Append(Line1).Append("\n");
      sb.Append("  Line2: ").Append(Line2).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
      sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
      sb.Append("  CrossStreets: ").Append(CrossStreets).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  BusinessInfo: ").Append(BusinessInfo).Append("\n");
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
