/*
 * Lob
 *
 * The Lob API is organized around REST. Our API is designed to have predictable, resource-oriented URLs and uses HTTP response codes to indicate any API errors. <p> Looking for our [previous documentation](https://lob.github.io/legacy-docs/)? 
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: lob-openapi@lob.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = lob.dotnet.Client.OpenAPIDateConverter;

namespace lob.dotnet.Model
{
    /// <summary>
    /// CardOrderEditable
    /// </summary>
    [DataContract(Name = "card_order_editable")]
    public partial class CardOrderEditable : IEquatable<CardOrderEditable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardOrderEditable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public CardOrderEditable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardOrderEditable" /> class.
        /// </summary>
        /// <param name="quantity">quantity (required).</param>

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = false)]
        private int quantity;
        public int getQuantity() {
            return quantity;
        }
        public void setQuantity(int value) {
            quantity = value;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardOrderEditable {\n");
            sb.Append("  quantity: ").Append(quantity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CardOrderEditable);
        }

        /// <summary>
        /// Returns true if CardOrderEditable instances are equal
        /// </summary>
        /// <param name="input">Instance of CardOrderEditable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardOrderEditable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.quantity == input.getQuantity() ||
                    this.quantity.Equals(input.getQuantity())
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.quantity.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // quantity (int) maximum
            if (this.quantity > (int)10000000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for quantity, must be a value less than or equal to 10000000.", new [] { "quantity" });
            }

            // quantity (int) minimum
            if (this.quantity < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for quantity, must be a value greater than or equal to 0.", new [] { "quantity" });
            }

            yield break;
        }
    }

}
