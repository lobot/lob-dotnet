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
    /// Suggestions
    /// </summary>
    [DataContract(Name = "suggestions")]
    public partial class Suggestions : IEquatable<Suggestions>, IValidatableObject
    {
        /// <summary>
        /// Value is resource type.
        /// </summary>
        /// <value>Value is resource type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum UsAutocompletion for value: us_autocompletion
            /// </summary>
            [EnumMember(Value = "us_autocompletion")]
            UsAutocompletion = 1

        }


        /// <summary>
        /// Value is resource type.
        /// </summary>
        /// <value>Value is resource type.</value>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public ObjectEnum? Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Suggestions" /> class.
        /// </summary>
        /// <param name="primaryLine">The primary delivery line (usually the street address) of the address. Combination of the following applicable &#x60;components&#x60; (primary number &amp; secondary information may be missing or inaccurate): * &#x60;primary_number&#x60; * &#x60;street_predirection&#x60; * &#x60;street_name&#x60; * &#x60;street_suffix&#x60; * &#x60;street_postdirection&#x60; * &#x60;secondary_designator&#x60; * &#x60;secondary_number&#x60; * &#x60;pmb_designator&#x60; * &#x60;pmb_number&#x60; .</param>
        /// <param name="city">city.</param>
        /// <param name="state">The [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) two letter code for the state. .</param>
        /// <param name="zipCode">A 5-digit zip code. Left empty if a test key is used..</param>
        /// <param name="_object">Value is resource type. (default to ObjectEnum.UsAutocompletion).</param>
        public Suggestions(string primaryLine = default(string), string city = default(string), string state = default(string), string zipCode = default(string), ObjectEnum? _object = ObjectEnum.UsAutocompletion)
        {
            this.PrimaryLine = primaryLine;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.Object = _object;
        }

        /// <summary>
        /// The primary delivery line (usually the street address) of the address. Combination of the following applicable &#x60;components&#x60; (primary number &amp; secondary information may be missing or inaccurate): * &#x60;primary_number&#x60; * &#x60;street_predirection&#x60; * &#x60;street_name&#x60; * &#x60;street_suffix&#x60; * &#x60;street_postdirection&#x60; * &#x60;secondary_designator&#x60; * &#x60;secondary_number&#x60; * &#x60;pmb_designator&#x60; * &#x60;pmb_number&#x60; 
        /// </summary>
        /// <value>The primary delivery line (usually the street address) of the address. Combination of the following applicable &#x60;components&#x60; (primary number &amp; secondary information may be missing or inaccurate): * &#x60;primary_number&#x60; * &#x60;street_predirection&#x60; * &#x60;street_name&#x60; * &#x60;street_suffix&#x60; * &#x60;street_postdirection&#x60; * &#x60;secondary_designator&#x60; * &#x60;secondary_number&#x60; * &#x60;pmb_designator&#x60; * &#x60;pmb_number&#x60; </value>
        [DataMember(Name = "primary_line", EmitDefaultValue = false)]
        public string PrimaryLine { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) two letter code for the state. 
        /// </summary>
        /// <value>The [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) two letter code for the state. </value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// A 5-digit zip code. Left empty if a test key is used.
        /// </summary>
        /// <value>A 5-digit zip code. Left empty if a test key is used.</value>
        [DataMember(Name = "zip_code", EmitDefaultValue = false)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Suggestions {\n");
            sb.Append("  PrimaryLine: ").Append(PrimaryLine).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
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
            return this.Equals(input as Suggestions);
        }

        /// <summary>
        /// Returns true if Suggestions instances are equal
        /// </summary>
        /// <param name="input">Instance of Suggestions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Suggestions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PrimaryLine == input.PrimaryLine ||
                    (this.PrimaryLine != null &&
                    this.PrimaryLine.Equals(input.PrimaryLine))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                    this.ZipCode.Equals(input.ZipCode))
                ) && 
                (
                    this.Object == input.Object ||
                    this.Object.Equals(input.Object)
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
                if (this.PrimaryLine != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryLine.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.ZipCode != null)
                {
                    hashCode = (hashCode * 59) + this.ZipCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Object.GetHashCode();
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
            // City (string) maxLength
            if (this.City != null && this.City.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 200.", new [] { "City" });
            }

            yield break;
        }
    }

}
