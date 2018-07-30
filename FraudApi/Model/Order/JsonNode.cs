using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Model.Order {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class JsonNode {
    /// <summary>
    /// Gets or Sets _Float
    /// </summary>
    [DataMember(Name="float", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "float")]
    public bool? _Float { get; set; }

    /// <summary>
    /// Gets or Sets MissingNode
    /// </summary>
    [DataMember(Name="missingNode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "missingNode")]
    public bool? MissingNode { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public bool? Number { get; set; }

    /// <summary>
    /// Gets or Sets _Object
    /// </summary>
    [DataMember(Name="object", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "object")]
    public bool? _Object { get; set; }

    /// <summary>
    /// Gets or Sets Pojo
    /// </summary>
    [DataMember(Name="pojo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pojo")]
    public bool? Pojo { get; set; }

    /// <summary>
    /// Gets or Sets _Short
    /// </summary>
    [DataMember(Name="short", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short")]
    public bool? _Short { get; set; }

    /// <summary>
    /// Gets or Sets Textual
    /// </summary>
    [DataMember(Name="textual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "textual")]
    public bool? Textual { get; set; }

    /// <summary>
    /// Gets or Sets ValueNode
    /// </summary>
    [DataMember(Name="valueNode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueNode")]
    public bool? ValueNode { get; set; }

    /// <summary>
    /// Gets or Sets NodeType
    /// </summary>
    [DataMember(Name="nodeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeType")]
    public string NodeType { get; set; }

    /// <summary>
    /// Gets or Sets BigDecimal
    /// </summary>
    [DataMember(Name="bigDecimal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bigDecimal")]
    public bool? BigDecimal { get; set; }

    /// <summary>
    /// Gets or Sets BigInteger
    /// </summary>
    [DataMember(Name="bigInteger", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bigInteger")]
    public bool? BigInteger { get; set; }

    /// <summary>
    /// Gets or Sets Binary
    /// </summary>
    [DataMember(Name="binary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "binary")]
    public bool? Binary { get; set; }

    /// <summary>
    /// Gets or Sets Boolean
    /// </summary>
    [DataMember(Name="boolean", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "boolean")]
    public bool? Boolean { get; set; }

    /// <summary>
    /// Gets or Sets ContainerNode
    /// </summary>
    [DataMember(Name="containerNode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerNode")]
    public bool? ContainerNode { get; set; }

    /// <summary>
    /// Gets or Sets _Double
    /// </summary>
    [DataMember(Name="double", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "double")]
    public bool? _Double { get; set; }

    /// <summary>
    /// Gets or Sets FloatingPointNumber
    /// </summary>
    [DataMember(Name="floatingPointNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "floatingPointNumber")]
    public bool? FloatingPointNumber { get; set; }

    /// <summary>
    /// Gets or Sets _Int
    /// </summary>
    [DataMember(Name="int", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "int")]
    public bool? _Int { get; set; }

    /// <summary>
    /// Gets or Sets IntegralNumber
    /// </summary>
    [DataMember(Name="integralNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "integralNumber")]
    public bool? IntegralNumber { get; set; }

    /// <summary>
    /// Gets or Sets _Long
    /// </summary>
    [DataMember(Name="long", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "long")]
    public bool? _Long { get; set; }

    /// <summary>
    /// Gets or Sets Array
    /// </summary>
    [DataMember(Name="array", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "array")]
    public bool? Array { get; set; }

    /// <summary>
    /// Gets or Sets _Null
    /// </summary>
    [DataMember(Name="null", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "null")]
    public bool? _Null { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JsonNode {\n");
      sb.Append("  _Float: ").Append(_Float).Append("\n");
      sb.Append("  MissingNode: ").Append(MissingNode).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  _Object: ").Append(_Object).Append("\n");
      sb.Append("  Pojo: ").Append(Pojo).Append("\n");
      sb.Append("  _Short: ").Append(_Short).Append("\n");
      sb.Append("  Textual: ").Append(Textual).Append("\n");
      sb.Append("  ValueNode: ").Append(ValueNode).Append("\n");
      sb.Append("  NodeType: ").Append(NodeType).Append("\n");
      sb.Append("  BigDecimal: ").Append(BigDecimal).Append("\n");
      sb.Append("  BigInteger: ").Append(BigInteger).Append("\n");
      sb.Append("  Binary: ").Append(Binary).Append("\n");
      sb.Append("  Boolean: ").Append(Boolean).Append("\n");
      sb.Append("  ContainerNode: ").Append(ContainerNode).Append("\n");
      sb.Append("  _Double: ").Append(_Double).Append("\n");
      sb.Append("  FloatingPointNumber: ").Append(FloatingPointNumber).Append("\n");
      sb.Append("  _Int: ").Append(_Int).Append("\n");
      sb.Append("  IntegralNumber: ").Append(IntegralNumber).Append("\n");
      sb.Append("  _Long: ").Append(_Long).Append("\n");
      sb.Append("  Array: ").Append(Array).Append("\n");
      sb.Append("  _Null: ").Append(_Null).Append("\n");
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
