using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace FraudAPI.Model.Order
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class OrderLineData : IEquatable<OrderLineData>
    {
        /// <summary>
        /// Gets or Sets LineId
        /// </summary>
        [DataMember(Name = "lineId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lineId", Order = 1)]
        public string LineId { get; set; }

        /// <summary>
        /// The line identifier for the parent item. Parents are used to set up linkage between items, and to build a hierarchy of items.
        /// </summary>
        /// <value>The line identifier for the parent item. Parents are used to set up linkage between items, and to build a hierarchy of items.</value>
        [DataMember(Name = "parentLineId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parentLineId", NullValueHandling = NullValueHandling.Ignore, Order = 2)]
        public string ParentLineId { get; set; }

        /// <summary>
        /// The price modifiers for this line only
        /// </summary>
        /// <value>The price modifiers for this line only</value>
        [DataMember(Name = "priceModifiers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "priceModifiers", NullValueHandling = NullValueHandling.Ignore, Order = 10)]
        public List<LinePriceModifierData> PriceModifiers { get; set; }

        /// <summary>
        /// The identifier of the product used to create the order line.
        /// </summary>
        /// <value>The identifier of the product used to create the order line</value>
        [DataMember(Name = "productId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productId", NullValueHandling = NullValueHandling.Ignore, Order = 3)]
        public ProductIdData ProductId { get; set; }

        /// <summary>
        /// Applicable for POS where picker writes composite barcode instead of overwriting product ID field. Maximum allowable length is 2710 characters.
        /// </summary>
        /// <value>Applicable for POS where picker writes composite barcode instead of overwriting product ID field. Maximum allowable length is 2710 characters.</value>
        [DataMember(Name = "scanData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "scanData", NullValueHandling = NullValueHandling.Ignore, Order = 4)]
        public string ScanData { get; set; }

        /// <summary>
        /// The line quantity
        /// </summary>
        /// <value>The line quantity</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "quantity", NullValueHandling = NullValueHandling.Ignore, Order = 5)]
        public QuantityData Quantity { get; set; }


        /// <summary>
        /// Hospitality linkGroupCode, such as codes for 'toppings', 'sides', or Retail 'substitution'
        /// </summary>
        /// <value>Hospitality linkGroupCode, such as codes for 'toppings', 'sides', or Retail 'substitution'</value>
        [DataMember(Name = "linkGroupCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "linkGroupCode", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkGroupCode { get; set; }


        public bool Equals(OrderLineData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;



            return string.Equals(LineId, other.LineId)
                   && string.Equals(ParentLineId, other.ParentLineId)
                   //&& Equals(PriceModifiers, other.PriceModifiers) 
                   && Equals<LinePriceModifierData>(PriceModifiers, other.PriceModifiers)
                   && Equals(ProductId, other.ProductId)
                   && string.Equals(ScanData, other.ScanData)
                   && Equals(Quantity, other.Quantity);
        }

        private bool Equals<T>(List<T> x, List<T> y)
        {
            if (x == null && y == null) return true;
            if (x == null || y == null) return false;
            if (ReferenceEquals(x, y)) return true;

            return x.SequenceEqual(y);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((OrderLineData) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (LineId != null ? LineId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ParentLineId != null ? ParentLineId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PriceModifiers != null ? PriceModifiers.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ProductId != null ? ProductId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ScanData != null ? ScanData.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Quantity != null ? Quantity.GetHashCode() : 0);
                return hashCode;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class OrderLineViewData : OrderLineData
    {
        /// <summary>
        /// The line's description
        /// </summary>
        /// <value>The line's description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description", NullValueHandling = NullValueHandling.Ignore, Order = 8)]
        public string Description { get; set; }

        /// <summary>
        /// The Line extended amount. That is: Quantity X Unit price
        /// </summary>
        /// <value>The Line extended amount. That is: Quantity X Unit price</value>
        [DataMember(Name = "extendedAmount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "extendedAmount", NullValueHandling = NullValueHandling.Ignore, Order = 11)]
        public decimal? ExtendedAmount { get; set; }

        /// <summary>
        /// The order line item type. e.g. Fee, Tare, Fuel...
        /// </summary>
        /// <value>The order line item type. e.g. Fee, Tare, Fuel...</value>
        [DataMember(Name = "itemType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "itemType", NullValueHandling = NullValueHandling.Ignore, Order = 12)]
        public string ItemType { get; set; }
                                
        /// <summary>
        /// The taxes for this line only
        /// </summary>
        /// <value>The taxes for this line only</value>
        [DataMember(Name = "taxes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "taxes", NullValueHandling = NullValueHandling.Ignore, Order = 13)]
        public List<LineTaxData> Taxes { get; set; }

        /// <summary>
        /// The price per unit
        /// </summary>
        /// <value>The price per unit</value>
        [DataMember(Name = "unitPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "unitPrice", NullValueHandling = NullValueHandling.Ignore, Order = 9)]
        public decimal? UnitPrice { get; set; }      

        /*
        /// <summary>
        /// Use for capturing gift payment (track data), product serial number, IMEI. Maximum allowable length is 2710 characters.
        /// </summary>
        /// <value>Use for capturing gift payment (track data), product serial number, IMEI. Maximum allowable length is 2710 characters.</value>
        [DataMember(Name = "supplementalData", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "supplementalData")]
        public string SupplementalData { get; set; }
        */

        /*
        /// <summary>
        /// The modifier code associated with the item, typically as defined in the POS system, to indicate e.g. 'well done', 'extra ketchup'
        /// </summary>
        /// <value>The modifier code associated with the item, typically as defined in the POS system, to indicate e.g. 'well done', 'extra ketchup'</value>
        [DataMember(Name = "modifierCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "modifierCode")]
        public string ModifierCode { get; set; }
        */
       

        /*
        /// <summary>
        /// Gets or Sets LineReplaced
        /// </summary>
        [DataMember(Name = "lineReplaced", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lineReplaced")]
        public string LineReplaced { get; set; }

        /// <summary>
        /// Indicates the fulfillment result of line item
        /// </summary>
        /// <value>Indicates the fulfillment result of line item</value>
        [DataMember(Name = "fulfillmentResult", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fulfillmentResult")]
        public string FulfillmentResult { get; set; }

        /// <summary>
        /// ID of the group member to which this order line item belongs
        /// </summary>
        /// <value>ID of the group member to which this order line item belongs</value>
        [DataMember(Name = "groupMemberId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "groupMemberId")]
        public string GroupMemberId { get; set; }
        */

        /*
        /// <summary>
        /// Set to true to indicate that the item's current price should override any other local prices
        /// </summary>
        /// <value>Set to true to indicate that the item's current price should override any other local prices</value>
        [DataMember(Name = "overridePrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "overridePrice")]
        public bool? OverridePrice { get; set; }
        */

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLineData {\n");
            //sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExtendedAmount: ").Append(ExtendedAmount).Append("\n");
            //sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            //sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ParentLineId: ").Append(ParentLineId).Append("\n");
            //sb.Append("  PriceModifiers: ").Append(PriceModifiers).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            //sb.Append("  SubstitutionAllowed: ").Append(SubstitutionAllowed).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  ScanData: ").Append(ScanData).Append("\n");
            //sb.Append("  SupplementalData: ").Append(SupplementalData).Append("\n");
            //sb.Append("  ModifierCode: ").Append(ModifierCode).Append("\n");
            //sb.Append("  LinkGroupCode: ").Append(LinkGroupCode).Append("\n");
            //sb.Append("  LineReplaced: ").Append(LineReplaced).Append("\n");
            //sb.Append("  FulfillmentResult: ").Append(FulfillmentResult).Append("\n");
            //sb.Append("  GroupMemberId: ").Append(GroupMemberId).Append("\n");
            //sb.Append("  OverridePrice: ").Append(OverridePrice).Append("\n");
            sb.Append("  LineId: ").Append(LineId).Append("\n");
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

    }
}
