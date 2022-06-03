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
    /// SortBy1
    /// </summary>
    [DataContract(Name = "sort_by_1")]
    public partial class SortBy1 : IEquatable<SortBy1>, IValidatableObject
    {
        /// <summary>
        /// Defines DateCreated
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DateCreatedEnum
        {
            /// <summary>
            /// Enum Asc for value: asc
            /// </summary>
            [EnumMember(Value = "asc")]
            Asc = 1,

            /// <summary>
            /// Enum Desc for value: desc
            /// </summary>
            [EnumMember(Value = "desc")]
            Desc = 2

        }


        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name = "date_created", EmitDefaultValue = false)]
        public DateCreatedEnum? DateCreated { get; set; }
        /// <summary>
        /// Defines SendDate
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SendDateEnum
        {
            /// <summary>
            /// Enum Asc for value: asc
            /// </summary>
            [EnumMember(Value = "asc")]
            Asc = 1,

            /// <summary>
            /// Enum Desc for value: desc
            /// </summary>
            [EnumMember(Value = "desc")]
            Desc = 2

        }


        /// <summary>
        /// Gets or Sets SendDate
        /// </summary>
        [DataMember(Name = "send_date", EmitDefaultValue = false)]
        public SendDateEnum? SendDate { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SortBy1" /> class.
        /// </summary>
        /// <param name="dateCreated">dateCreated.</param>
        /// <param name="sendDate">sendDate.</param>
        public SortBy1(DateCreatedEnum? dateCreated = default(DateCreatedEnum?), SendDateEnum? sendDate = default(SendDateEnum?))
        {
            this.DateCreated = dateCreated;
            this.SendDate = sendDate;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SortBy1 {\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  SendDate: ").Append(SendDate).Append("\n");
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
            return this.Equals(input as SortBy1);
        }

        /// <summary>
        /// Returns true if SortBy1 instances are equal
        /// </summary>
        /// <param name="input">Instance of SortBy1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SortBy1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DateCreated == input.DateCreated ||
                    this.DateCreated.Equals(input.DateCreated)
                ) && 
                (
                    this.SendDate == input.SendDate ||
                    this.SendDate.Equals(input.SendDate)
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
                hashCode = (hashCode * 59) + this.DateCreated.GetHashCode();
                hashCode = (hashCode * 59) + this.SendDate.GetHashCode();
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
