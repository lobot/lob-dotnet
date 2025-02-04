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
    /// UsAutocompletionsWritable
    /// </summary>
    [DataContract(Name = "us_autocompletions_writable")]
    public partial class UsAutocompletionsWritable : IEquatable<UsAutocompletionsWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsAutocompletionsWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UsAutocompletionsWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UsAutocompletionsWritable" /> class.
        /// </summary>
        /// <param name="addressPrefix">Only accepts numbers and street names in an alphanumeric format.  (required).</param>
        /// <param name="city">An optional city input used to filter suggestions. Case insensitive and does not match partial abbreviations. .</param>
        /// <param name="state">An optional state input used to filter suggestions. Case insensitive and does not match partial abbreviations. .</param>
        /// <param name="zipCode">An optional ZIP Code input used to filter suggestions. Matches partial entries. .</param>
        /// <param name="geoIpSort">If &#x60;true&#x60;, sort suggestions by proximity to the IP set in the &#x60;X-Forwarded-For&#x60; header. .</param>
        public UsAutocompletionsWritable(string addressPrefix = default(string), string city = default(string), string state = default(string), string zipCode = default(string), bool geoIpSort = default(bool))
        {
            // to ensure "addressPrefix" is required (not null)
            if (addressPrefix == null)
            {
                throw new ArgumentNullException("addressPrefix is a required property for UsAutocompletionsWritable and cannot be null");
            }
            this.AddressPrefix = addressPrefix;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.GeoIpSort = geoIpSort;
        }

        /// <summary>
        /// Only accepts numbers and street names in an alphanumeric format. 
        /// </summary>
        /// <value>Only accepts numbers and street names in an alphanumeric format. </value>
        [DataMember(Name = "address_prefix", IsRequired = true, EmitDefaultValue = false)]
        public string AddressPrefix { get; set; }

        /// <summary>
        /// An optional city input used to filter suggestions. Case insensitive and does not match partial abbreviations. 
        /// </summary>
        /// <value>An optional city input used to filter suggestions. Case insensitive and does not match partial abbreviations. </value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// An optional state input used to filter suggestions. Case insensitive and does not match partial abbreviations. 
        /// </summary>
        /// <value>An optional state input used to filter suggestions. Case insensitive and does not match partial abbreviations. </value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// An optional ZIP Code input used to filter suggestions. Matches partial entries. 
        /// </summary>
        /// <value>An optional ZIP Code input used to filter suggestions. Matches partial entries. </value>
        [DataMember(Name = "zip_code", EmitDefaultValue = false)]
        public string ZipCode { get; set; }

        /// <summary>
        /// If &#x60;true&#x60;, sort suggestions by proximity to the IP set in the &#x60;X-Forwarded-For&#x60; header. 
        /// </summary>
        /// <value>If &#x60;true&#x60;, sort suggestions by proximity to the IP set in the &#x60;X-Forwarded-For&#x60; header. </value>
        [DataMember(Name = "geo_ip_sort", EmitDefaultValue = false)]
        public bool GeoIpSort { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsAutocompletionsWritable {\n");
            sb.Append("  AddressPrefix: ").Append(AddressPrefix).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  GeoIpSort: ").Append(GeoIpSort).Append("\n");
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
            return this.Equals(input as UsAutocompletionsWritable);
        }

        /// <summary>
        /// Returns true if UsAutocompletionsWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of UsAutocompletionsWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsAutocompletionsWritable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AddressPrefix == input.AddressPrefix ||
                    (this.AddressPrefix != null &&
                    this.AddressPrefix.Equals(input.AddressPrefix))
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
                    this.GeoIpSort == input.GeoIpSort ||
                    this.GeoIpSort.Equals(input.GeoIpSort)
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
                if (this.AddressPrefix != null)
                {
                    hashCode = (hashCode * 59) + this.AddressPrefix.GetHashCode();
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
                hashCode = (hashCode * 59) + this.GeoIpSort.GetHashCode();
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
            yield break;
        }
    }

}
