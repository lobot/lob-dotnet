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
    /// MultipleComponents
    /// </summary>
    [DataContract(Name = "multiple_components")]
    public partial class MultipleComponents : IEquatable<MultipleComponents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleComponents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public MultipleComponents() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleComponents" /> class.
        /// </summary>
        /// <param name="recipient">The intended recipient, typically a person&#39;s or firm&#39;s name..</param>
        /// <param name="primaryLine">The primary delivery line (usually the street address) of the address. Combination of the following applicable &#x60;components&#x60;: * &#x60;primary_number&#x60; * &#x60;street_predirection&#x60; * &#x60;street_name&#x60; * &#x60;street_suffix&#x60; * &#x60;street_postdirection&#x60; * &#x60;secondary_designator&#x60; * &#x60;secondary_number&#x60; * &#x60;pmb_designator&#x60; * &#x60;pmb_number&#x60;  (required).</param>
        /// <param name="secondaryLine">The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long. .</param>
        /// <param name="urbanization">Only present for addresses in Puerto Rico. An urbanization refers to an area, sector, or development within a city. See [USPS documentation](https://pe.usps.com/text/pub28/28api_008.htm#:~:text&#x3D;I51.,-4%20Urbanizations&amp;text&#x3D;In%20Puerto%20Rico%2C%20identical%20street,placed%20before%20the%20urbanization%20name.) for clarification. .</param>
        /// <param name="city">city.</param>
        /// <param name="state">The [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2:US) two letter code or subdivision name for the state. &#x60;city&#x60; and &#x60;state&#x60; are required if no &#x60;zip_code&#x60; is passed..</param>
        /// <param name="zipCode">Required if &#x60;city&#x60; and &#x60;state&#x60; are not passed in. If included, must be formatted as a US ZIP or ZIP+4 (e.g. &#x60;94107&#x60;, &#x60;941072282&#x60;, &#x60;94107-2282&#x60;)..</param>

        /// <summary>
        /// The intended recipient, typically a person&#39;s or firm&#39;s name.
        /// </summary>
        /// <value>The intended recipient, typically a person&#39;s or firm&#39;s name.</value>
        [DataMember(Name = "recipient", EmitDefaultValue = true)]
        private string recipient;
        public string getRecipient() {
            return recipient;
        }
        public void setRecipient(string value) {
            recipient = value;
        }

        /// <summary>
        /// The primary delivery line (usually the street address) of the address. Combination of the following applicable &#x60;components&#x60;: * &#x60;primary_number&#x60; * &#x60;street_predirection&#x60; * &#x60;street_name&#x60; * &#x60;street_suffix&#x60; * &#x60;street_postdirection&#x60; * &#x60;secondary_designator&#x60; * &#x60;secondary_number&#x60; * &#x60;pmb_designator&#x60; * &#x60;pmb_number&#x60; 
        /// </summary>
        /// <value>The primary delivery line (usually the street address) of the address. Combination of the following applicable &#x60;components&#x60;: * &#x60;primary_number&#x60; * &#x60;street_predirection&#x60; * &#x60;street_name&#x60; * &#x60;street_suffix&#x60; * &#x60;street_postdirection&#x60; * &#x60;secondary_designator&#x60; * &#x60;secondary_number&#x60; * &#x60;pmb_designator&#x60; * &#x60;pmb_number&#x60; </value>
        [DataMember(Name = "primary_line", IsRequired = true, EmitDefaultValue = false)]
        private string primaryLine;
        public string getPrimaryLine() {
            return primaryLine;
        }
        public void setPrimaryLine(string value) {
            primaryLine = value;
        }

        /// <summary>
        /// The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long. 
        /// </summary>
        /// <value>The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long. </value>
        [DataMember(Name = "secondary_line", EmitDefaultValue = false)]
        private string secondaryLine;
        public string getSecondaryLine() {
            return secondaryLine;
        }
        public void setSecondaryLine(string value) {
            secondaryLine = value;
        }

        /// <summary>
        /// Only present for addresses in Puerto Rico. An urbanization refers to an area, sector, or development within a city. See [USPS documentation](https://pe.usps.com/text/pub28/28api_008.htm#:~:text&#x3D;I51.,-4%20Urbanizations&amp;text&#x3D;In%20Puerto%20Rico%2C%20identical%20street,placed%20before%20the%20urbanization%20name.) for clarification. 
        /// </summary>
        /// <value>Only present for addresses in Puerto Rico. An urbanization refers to an area, sector, or development within a city. See [USPS documentation](https://pe.usps.com/text/pub28/28api_008.htm#:~:text&#x3D;I51.,-4%20Urbanizations&amp;text&#x3D;In%20Puerto%20Rico%2C%20identical%20street,placed%20before%20the%20urbanization%20name.) for clarification. </value>
        [DataMember(Name = "urbanization", EmitDefaultValue = false)]
        private string urbanization;
        public string getUrbanization() {
            return urbanization;
        }
        public void setUrbanization(string value) {
            urbanization = value;
        }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        private string city;
        public string getCity() {
            return city;
        }
        public void setCity(string value) {
            city = value;
        }

        /// <summary>
        /// The [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2:US) two letter code or subdivision name for the state. &#x60;city&#x60; and &#x60;state&#x60; are required if no &#x60;zip_code&#x60; is passed.
        /// </summary>
        /// <value>The [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2:US) two letter code or subdivision name for the state. &#x60;city&#x60; and &#x60;state&#x60; are required if no &#x60;zip_code&#x60; is passed.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        private string state;
        public string getState() {
            return state;
        }
        public void setState(string value) {
            state = value;
        }

        /// <summary>
        /// Required if &#x60;city&#x60; and &#x60;state&#x60; are not passed in. If included, must be formatted as a US ZIP or ZIP+4 (e.g. &#x60;94107&#x60;, &#x60;941072282&#x60;, &#x60;94107-2282&#x60;).
        /// </summary>
        /// <value>Required if &#x60;city&#x60; and &#x60;state&#x60; are not passed in. If included, must be formatted as a US ZIP or ZIP+4 (e.g. &#x60;94107&#x60;, &#x60;941072282&#x60;, &#x60;94107-2282&#x60;).</value>
        [DataMember(Name = "zip_code", EmitDefaultValue = false)]
        private string zipCode;
        public string getZipCode() {
            return zipCode;
        }
        public void setZipCode(string value) {
            zipCode = value;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MultipleComponents {\n");
            sb.Append("  recipient: ").Append(recipient).Append("\n");
            sb.Append("  primaryLine: ").Append(primaryLine).Append("\n");
            sb.Append("  secondaryLine: ").Append(secondaryLine).Append("\n");
            sb.Append("  urbanization: ").Append(urbanization).Append("\n");
            sb.Append("  city: ").Append(city).Append("\n");
            sb.Append("  state: ").Append(state).Append("\n");
            sb.Append("  zipCode: ").Append(zipCode).Append("\n");
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
            return this.Equals(input as MultipleComponents);
        }

        /// <summary>
        /// Returns true if MultipleComponents instances are equal
        /// </summary>
        /// <param name="input">Instance of MultipleComponents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultipleComponents input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.recipient == input.getRecipient() ||
                    (this.recipient != null &&
                    this.recipient.Equals(input.getRecipient()))
                ) && 
                (
                    this.primaryLine == input.getPrimaryLine() ||
                    (this.primaryLine != null &&
                    this.primaryLine.Equals(input.getPrimaryLine()))
                ) && 
                (
                    this.secondaryLine == input.getSecondaryLine() ||
                    (this.secondaryLine != null &&
                    this.secondaryLine.Equals(input.getSecondaryLine()))
                ) && 
                (
                    this.urbanization == input.getUrbanization() ||
                    (this.urbanization != null &&
                    this.urbanization.Equals(input.getUrbanization()))
                ) && 
                (
                    this.city == input.getCity() ||
                    (this.city != null &&
                    this.city.Equals(input.getCity()))
                ) && 
                (
                    this.state == input.getState() ||
                    (this.state != null &&
                    this.state.Equals(input.getState()))
                ) && 
                (
                    this.zipCode == input.getZipCode() ||
                    (this.zipCode != null &&
                    this.zipCode.Equals(input.getZipCode()))
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
                if (this.recipient != null)
                {
                    hashCode = (hashCode * 59) + this.recipient.GetHashCode();
                }
                if (this.primaryLine != null)
                {
                    hashCode = (hashCode * 59) + this.primaryLine.GetHashCode();
                }
                if (this.secondaryLine != null)
                {
                    hashCode = (hashCode * 59) + this.secondaryLine.GetHashCode();
                }
                if (this.urbanization != null)
                {
                    hashCode = (hashCode * 59) + this.urbanization.GetHashCode();
                }
                if (this.city != null)
                {
                    hashCode = (hashCode * 59) + this.city.GetHashCode();
                }
                if (this.state != null)
                {
                    hashCode = (hashCode * 59) + this.state.GetHashCode();
                }
                if (this.zipCode != null)
                {
                    hashCode = (hashCode * 59) + this.zipCode.GetHashCode();
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
            // recipient (string) maxLength
            if (this.recipient != null && this.recipient.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for recipient, length must be less than 500.", new [] { "recipient" });
            }

            // primaryLine (string) maxLength
            if (this.primaryLine != null && this.primaryLine.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for primaryLine, length must be less than 500.", new [] { "primaryLine" });
            }

            // secondaryLine (string) maxLength
            if (this.secondaryLine != null && this.secondaryLine.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for secondaryLine, length must be less than 500.", new [] { "secondaryLine" });
            }

            // urbanization (string) maxLength
            if (this.urbanization != null && this.urbanization.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for urbanization, length must be less than 500.", new [] { "urbanization" });
            }

            // city (string) maxLength
            if (this.city != null && this.city.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for city, length must be less than 200.", new [] { "city" });
            }

            // state (string) maxLength
            if (this.state != null && this.state.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for state, length must be less than 50.", new [] { "state" });
            }

            // zipCode (string) pattern
            Regex regexzipCode = new Regex(@"^\\d{5}((-)?\\d{4})?$", RegexOptions.CultureInvariant);
            if (false == regexzipCode.Match(this.zipCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for zipCode, must match a pattern of " + regexzipCode, new [] { "zipCode" });
            }

            yield break;
        }
    }

}
