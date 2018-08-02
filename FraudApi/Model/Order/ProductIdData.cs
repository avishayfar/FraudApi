using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FraudAPI.Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ProductIdData: IEquatable<ProductIdData>
  {
    /// <summary>
    /// The identifier type. i.e. UPC, SKU, EAN
    /// </summary>
    /// <value>The identifier type. i.e. UPC, SKU, EAN</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    /// <summary>
    /// The identifier value
    /// </summary>
    /// <value>The identifier value</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore)]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductIdData {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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

      public bool Equals(ProductIdData other)
      {
          if (ReferenceEquals(null, other)) return false;
          if (ReferenceEquals(this, other)) return true;
          return string.Equals(Type, other.Type) && string.Equals(Value, other.Value);
      }

      public override bool Equals(object obj)
      {
          if (ReferenceEquals(null, obj)) return false;
          if (ReferenceEquals(this, obj)) return true;
          if (obj.GetType() != this.GetType()) return false;
          return Equals((ProductIdData) obj);
      }

      public override int GetHashCode()
      {
          unchecked
          {
              return ((Type != null ? Type.GetHashCode() : 0) * 397) ^ (Value != null ? Value.GetHashCode() : 0);
          }
      }
  }
}
