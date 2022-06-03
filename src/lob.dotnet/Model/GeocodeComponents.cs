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
    /// A nested object containing a breakdown of each component of a reverse geocoded response.
    /// </summary>
    [DataContract(Name = "geocode_components")]
    public partial class GeocodeComponents : IEquatable<GeocodeComponents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeocodeComponents" /> class.
        /// </summary>
        /// <param name="zipCode">The 5-digit ZIP code.</param>
        /// <param name="zipCodePlus4">zipCodePlus4.</param>
        public GeocodeComponents(string zipCode = default(string), string zipCodePlus4 = default(string))
        {
            this.ZipCode = zipCode;
            this.ZipCodePlus4 = zipCodePlus4;
        }

        /// <summary>
        /// The 5-digit ZIP code
        /// </summary>
        /// <value>The 5-digit ZIP code</value>
        [DataMember(Name = "zip_code", EmitDefaultValue = false)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or Sets ZipCodePlus4
        /// </summary>
        [DataMember(Name = "zip_code_plus_4", EmitDefaultValue = false)]
        public string ZipCodePlus4 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GeocodeComponents {\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  ZipCodePlus4: ").Append(ZipCodePlus4).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GeocodeComponents);
        }

        /// <summary>
        /// Returns true if GeocodeComponents instances are equal
        /// </summary>
        /// <param name="input">Instance of GeocodeComponents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeocodeComponents input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                    this.ZipCode.Equals(input.ZipCode))
                ) && 
                (
                    this.ZipCodePlus4 == input.ZipCodePlus4 ||
                    (this.ZipCodePlus4 != null &&
                    this.ZipCodePlus4.Equals(input.ZipCodePlus4))
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
                if (this.ZipCode != null)
                {
                    hashCode = (hashCode * 59) + this.ZipCode.GetHashCode();
                }
                if (this.ZipCodePlus4 != null)
                {
                    hashCode = (hashCode * 59) + this.ZipCodePlus4.GetHashCode();
                }
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
            // ZipCode (string) pattern
            Regex regexZipCode = new Regex(@"^\\d{5}$", RegexOptions.CultureInvariant);
            if (false == regexZipCode.Match(this.ZipCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ZipCode, must match a pattern of " + regexZipCode, new [] { "ZipCode" });
            }

            // ZipCodePlus4 (string) pattern
            Regex regexZipCodePlus4 = new Regex(@"^\\d{4}$", RegexOptions.CultureInvariant);
            if (false == regexZipCodePlus4.Match(this.ZipCodePlus4).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ZipCodePlus4, must match a pattern of " + regexZipCodePlus4, new [] { "ZipCodePlus4" });
            }

            yield break;
        }
    }

}
