using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class LinePriceModifierData: IEquatable<LinePriceModifierData>
  {
    /// <summary>
    /// The discount or surcharge amount
    /// </summary>
    /// <value>The discount or surcharge amount</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount", NullValueHandling = NullValueHandling.Ignore)]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Description of the price change
    /// </summary>
    /// <value>Description of the price change</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /*
    /// <summary>
    /// The price change reference, like a promotion id
    /// </summary>
    /// <value>The price change reference, like a promotion id</value>
    [DataMember(Name="referenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceId")]
    public string ReferenceId { get; set; }
    */

    /// <summary>
    /// Gets or Sets LineId
    /// </summary>
    [DataMember(Name="lineId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineId", NullValueHandling = NullValueHandling.Ignore)]
    public string LineId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LinePriceModifierData {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      //sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
      sb.Append("  LineId: ").Append(LineId).Append("\n");
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

      public bool Equals(LinePriceModifierData other)
      {
          if (ReferenceEquals(null, other)) return false;
          if (ReferenceEquals(this, other)) return true;
          return Amount == other.Amount 
                 && string.Equals(Description, other.Description) 
                 && string.Equals(LineId, other.LineId);
      }

      public override bool Equals(object obj)
      {
          if (ReferenceEquals(null, obj)) return false;
          if (ReferenceEquals(this, obj)) return true;
          if (obj.GetType() != this.GetType()) return false;
          return Equals((LinePriceModifierData) obj);
      }

      public override int GetHashCode()
      {
          unchecked
          {
              var hashCode = Amount.GetHashCode();
              hashCode = (hashCode * 397) ^ (Description != null ? Description.GetHashCode() : 0);
              hashCode = (hashCode * 397) ^ (LineId != null ? LineId.GetHashCode() : 0);
              return hashCode;
          }
      }
  }
}
