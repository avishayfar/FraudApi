using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FraudAPI.Model.Order
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class QuantityData: IEquatable<QuantityData>
    {
        /// <summary>
        /// The unit of measure. Returns exceptions when this unit of measure contains invalid code.
        /// </summary>
        /// <value>The unit of measure. Returns exceptions when this unit of measure contains invalid code.</value>
        [DataMember(Name = "unitOfMeasure", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "unitOfMeasure", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public QuantityUnitOfMeasure UnitOfMeasure { get; set; }

        /*
        /// <summary>
        /// The unit of measure label. This field can be populated when unitOfMeasure  is selected/entered as other value.
        /// </summary>
        /// <value>The unit of measure label. This field can be populated when unitOfMeasure  is selected/entered as other value.</value>
        [DataMember(Name="unitOfMeasureLabel", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "unitOfMeasureLabel")]
        public string UnitOfMeasureLabel { get; set; }
        */

        /// <summary>
        /// The units value per unit-of-measure. Required field when unitOfMeasure is entered. Accepted decimal and positive/negative numerical value. 
        /// </summary>
        /// <value>The units value per unit-of-measure. Required field when unitOfMeasure is entered. Accepted decimal and positive/negative numerical value. </value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Value { get; set; }

        /// <summary>
        /// Indicates that Quantity includes a linked Item with the specified Tare weight
        /// </summary>
        [DataMember(Name = "linkedTare", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "linkedTare", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? LinkedTare { get; set; }

        /// <summary>
        /// Tare value included in this quantity.
        /// Required when UnitOfMeasure is weight units and Tare has to be reduced from sale
        /// </summary>
        [DataMember(Name = "tareValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tareValue", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TareValue { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuantityData {\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            //sb.Append("  UnitOfMeasureLabel: ").Append(UnitOfMeasureLabel).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public bool Equals(QuantityData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return UnitOfMeasure == other.UnitOfMeasure && Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((QuantityData) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int) UnitOfMeasure * 397) ^ Value.GetHashCode();
            }
        }
    }

    /// <summary>
    /// QuantityUnitOfMeasure
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QuantityUnitOfMeasure
    {
        /// <summary>
        /// EA
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "EA")] EA,
        /// <summary>
        /// GLI
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "GLI")] GLI,
        /// <summary>
        /// GLL
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "GLL")] GLL,
        /// <summary>
        /// LTR
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "LTR")] LTR,
        /// <summary>
        /// INH
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "INH")] INH,
        /// <summary>
        /// FOT
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "FOT")] FOT,
        /// <summary>
        /// MMT
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "MMT")] MMT,
        /// <summary>
        /// EA
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "CMQ")] CMQ,
        /// <summary>
        /// CMT
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "CMT")] CMT,
        /// <summary>
        /// MTR
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "MTR")] MTR,
        /// <summary>
        /// MTK
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "MTK")] MTK,
        /// <summary>
        /// MTQ
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "MTQ")] MTQ,
        /// <summary>
        /// GRM
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "GRM")] GRM,
        /// <summary>
        /// KGM
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "KGM")] KGM,
        /// <summary>
        /// LBR
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "LBR")] LBR,
        /// <summary>
        /// ANN
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "ANN")] ANN,
        /// <summary>
        /// CEL
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "CEL")] CEL,
        /// <summary>
        /// FAH
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "FAH")] FAH,
        /// <summary>
        /// OTHER
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "OTHER")] OTHER
    }
}
