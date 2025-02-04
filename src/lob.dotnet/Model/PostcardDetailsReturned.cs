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
    /// Properties that the postcards in your Creative should have.
    /// </summary>
    [DataContract(Name = "postcard_details_returned")]
    public partial class PostcardDetailsReturned : IEquatable<PostcardDetailsReturned>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostcardDetailsReturned" /> class.
        /// </summary>
        /// <param name="mailType">mailType.</param>
        /// <param name="size">size.</param>
        /// <param name="setting">setting (default to 1001).</param>
        /// <param name="frontOriginalUrl">The original URL of the front template..</param>
        /// <param name="backOriginalUrl">The original URL of the back template..</param>
        public PostcardDetailsReturned(MailType mailType = default(MailType), PostcardSize size = default(PostcardSize), int setting = 1001, string frontOriginalUrl = default(string), string backOriginalUrl = default(string))
        {
            this.MailType = mailType;
            this.Size = size;
            this.Setting = setting;
            this.FrontOriginalUrl = frontOriginalUrl;
            this.BackOriginalUrl = backOriginalUrl;
        }

        /// <summary>
        /// Gets or Sets MailType
        /// </summary>
        [DataMember(Name = "mail_type", EmitDefaultValue = false)]
        public MailType MailType { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public PostcardSize Size { get; set; }

        /// <summary>
        /// Gets or Sets Setting
        /// </summary>
        [DataMember(Name = "setting", EmitDefaultValue = false)]
        public int Setting { get; set; }

        /// <summary>
        /// The original URL of the front template.
        /// </summary>
        /// <value>The original URL of the front template.</value>
        [DataMember(Name = "front_original_url", EmitDefaultValue = false)]
        public string FrontOriginalUrl { get; set; }

        /// <summary>
        /// The original URL of the back template.
        /// </summary>
        /// <value>The original URL of the back template.</value>
        [DataMember(Name = "back_original_url", EmitDefaultValue = false)]
        public string BackOriginalUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostcardDetailsReturned {\n");
            sb.Append("  MailType: ").Append(MailType).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Setting: ").Append(Setting).Append("\n");
            sb.Append("  FrontOriginalUrl: ").Append(FrontOriginalUrl).Append("\n");
            sb.Append("  BackOriginalUrl: ").Append(BackOriginalUrl).Append("\n");
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
            return this.Equals(input as PostcardDetailsReturned);
        }

        /// <summary>
        /// Returns true if PostcardDetailsReturned instances are equal
        /// </summary>
        /// <param name="input">Instance of PostcardDetailsReturned to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostcardDetailsReturned input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MailType == input.MailType ||
                    (this.MailType != null &&
                    this.MailType.Equals(input.MailType))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Setting == input.Setting ||
                    this.Setting.Equals(input.Setting)
                ) && 
                (
                    this.FrontOriginalUrl == input.FrontOriginalUrl ||
                    (this.FrontOriginalUrl != null &&
                    this.FrontOriginalUrl.Equals(input.FrontOriginalUrl))
                ) && 
                (
                    this.BackOriginalUrl == input.BackOriginalUrl ||
                    (this.BackOriginalUrl != null &&
                    this.BackOriginalUrl.Equals(input.BackOriginalUrl))
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
                if (this.MailType != null)
                {
                    hashCode = (hashCode * 59) + this.MailType.GetHashCode();
                }
                if (this.Size != null)
                {
                    hashCode = (hashCode * 59) + this.Size.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Setting.GetHashCode();
                if (this.FrontOriginalUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FrontOriginalUrl.GetHashCode();
                }
                if (this.BackOriginalUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BackOriginalUrl.GetHashCode();
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
            // FrontOriginalUrl (string) maxLength
            if (this.FrontOriginalUrl != null && this.FrontOriginalUrl.Length > 2083)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FrontOriginalUrl, length must be less than 2083.", new [] { "FrontOriginalUrl" });
            }

            // FrontOriginalUrl (string) minLength
            if (this.FrontOriginalUrl != null && this.FrontOriginalUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FrontOriginalUrl, length must be greater than 1.", new [] { "FrontOriginalUrl" });
            }

            // BackOriginalUrl (string) maxLength
            if (this.BackOriginalUrl != null && this.BackOriginalUrl.Length > 2083)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BackOriginalUrl, length must be less than 2083.", new [] { "BackOriginalUrl" });
            }

            // BackOriginalUrl (string) minLength
            if (this.BackOriginalUrl != null && this.BackOriginalUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BackOriginalUrl, length must be greater than 1.", new [] { "BackOriginalUrl" });
            }

            yield break;
        }
    }

}
