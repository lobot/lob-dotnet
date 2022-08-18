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
    /// A model used to represent an entry in a result list where the entry can either be a intl_verification or an Error. The SDK will perform necessary casting into the correct corresponding type. 
    /// </summary>
    [DataContract(Name = "intl_verification_or_error")]
    public partial class IntlVerificationOrError : IEquatable<IntlVerificationOrError>, IValidatableObject
    {
        /// <summary>
        /// Defines Coverage
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CoverageEnum
        {
            /// <summary>
            /// Enum SUBBUILDING for value: SUBBUILDING
            /// </summary>
            [EnumMember(Value = "SUBBUILDING")]
            SUBBUILDING = 1,
            

            /// <summary>
            /// Enum HOUSENUMBERBUILDING for value: HOUSENUMBER/BUILDING
            /// </summary>
            [EnumMember(Value = "HOUSENUMBER/BUILDING")]
            HOUSENUMBERBUILDING = 2,
            

            /// <summary>
            /// Enum STREET for value: STREET
            /// </summary>
            [EnumMember(Value = "STREET")]
            STREET = 3,
            

            /// <summary>
            /// Enum LOCALITY for value: LOCALITY
            /// </summary>
            [EnumMember(Value = "LOCALITY")]
            LOCALITY = 4,
            

            /// <summary>
            /// Enum SPARSE for value: SPARSE
            /// </summary>
            [EnumMember(Value = "SPARSE")]
            SPARSE = 5
            

        }


        /// <summary>
        /// Gets or Sets Coverage
        /// </summary>
        [DataMember(Name = "coverage", EmitDefaultValue = false)]
        private CoverageEnum? coverage;
        public CoverageEnum? getCoverage() {
            return coverage;
        }
        public void setCoverage(CoverageEnum value) {
            coverage = value;
        }
        /// <summary>
        /// Defines Deliverability
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliverabilityEnum
        {
            /// <summary>
            /// Enum Deliverable for value: deliverable
            /// </summary>
            [EnumMember(Value = "deliverable")]
            Deliverable = 1,
            

            /// <summary>
            /// Enum DeliverableMissingInfo for value: deliverable_missing_info
            /// </summary>
            [EnumMember(Value = "deliverable_missing_info")]
            DeliverableMissingInfo = 2,
            

            /// <summary>
            /// Enum Undeliverable for value: undeliverable
            /// </summary>
            [EnumMember(Value = "undeliverable")]
            Undeliverable = 3,
            

            /// <summary>
            /// Enum NoMatch for value: no_match
            /// </summary>
            [EnumMember(Value = "no_match")]
            NoMatch = 4
            

        }


        /// <summary>
        /// Gets or Sets Deliverability
        /// </summary>
        [DataMember(Name = "deliverability", EmitDefaultValue = false)]
        private DeliverabilityEnum? deliverability;
        public DeliverabilityEnum? getDeliverability() {
            return deliverability;
        }
        public void setDeliverability(DeliverabilityEnum value) {
            deliverability = value;
        }
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum LV4 for value: LV4
            /// </summary>
            [EnumMember(Value = "LV4")]
            LV4 = 1,
            

            /// <summary>
            /// Enum LV3 for value: LV3
            /// </summary>
            [EnumMember(Value = "LV3")]
            LV3 = 2,
            

            /// <summary>
            /// Enum LV2 for value: LV2
            /// </summary>
            [EnumMember(Value = "LV2")]
            LV2 = 3,
            

            /// <summary>
            /// Enum LV1 for value: LV1
            /// </summary>
            [EnumMember(Value = "LV1")]
            LV1 = 4,
            

            /// <summary>
            /// Enum LF4 for value: LF4
            /// </summary>
            [EnumMember(Value = "LF4")]
            LF4 = 5,
            

            /// <summary>
            /// Enum LF3 for value: LF3
            /// </summary>
            [EnumMember(Value = "LF3")]
            LF3 = 6,
            

            /// <summary>
            /// Enum LF2 for value: LF2
            /// </summary>
            [EnumMember(Value = "LF2")]
            LF2 = 7,
            

            /// <summary>
            /// Enum LF1 for value: LF1
            /// </summary>
            [EnumMember(Value = "LF1")]
            LF1 = 8,
            

            /// <summary>
            /// Enum LM4 for value: LM4
            /// </summary>
            [EnumMember(Value = "LM4")]
            LM4 = 9,
            

            /// <summary>
            /// Enum LM3 for value: LM3
            /// </summary>
            [EnumMember(Value = "LM3")]
            LM3 = 10,
            

            /// <summary>
            /// Enum LM2 for value: LM2
            /// </summary>
            [EnumMember(Value = "LM2")]
            LM2 = 11,
            

            /// <summary>
            /// Enum LU1 for value: LU1
            /// </summary>
            [EnumMember(Value = "LU1")]
            LU1 = 12
            

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        private StatusEnum? status;
        public StatusEnum? getStatus() {
            return status;
        }
        public void setStatus(StatusEnum value) {
            status = value;
        }
        /// <summary>
        /// Defines Object
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum IntlVerification for value: intl_verification
            /// </summary>
            [EnumMember(Value = "intl_verification")]
            IntlVerification = 1
            

        }


        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        private ObjectEnum? _object;
        public ObjectEnum? getObject() {
            return _object;
        }
        public void setObject(ObjectEnum value) {
            _object = value;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntlVerificationOrError" /> class.
        /// </summary>
        /// <param name="id">Unique identifier prefixed with &#x60;intl_ver_&#x60;..</param>
        /// <param name="recipient">The intended recipient, typically a person&#39;s or firm&#39;s name..</param>
        /// <param name="primaryLine">primaryLine.</param>
        /// <param name="secondaryLine">The secondary delivery line of the address. This field is typically empty but may contain information if &#x60;primary_line&#x60; is too long. .</param>
        /// <param name="lastLine">lastLine.</param>
        /// <param name="country">country.</param>
        /// <param name="coverage">coverage.</param>
        /// <param name="deliverability">deliverability.</param>
        /// <param name="status">status.</param>
        /// <param name="components">components.</param>
        /// <param name="_object">_object (default to ObjectEnum.IntlVerification).</param>
        /// <param name="error">error.</param>

        /// <summary>
        /// Unique identifier prefixed with &#x60;intl_ver_&#x60;.
        /// </summary>
        /// <value>Unique identifier prefixed with &#x60;intl_ver_&#x60;.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        private string id;
        public string getId() {
            return id;
        }
        public void setId(string value) {
            id = value;
        }

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
        /// Gets or Sets PrimaryLine
        /// </summary>
        [DataMember(Name = "primary_line", EmitDefaultValue = false)]
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
        /// Gets or Sets LastLine
        /// </summary>
        [DataMember(Name = "last_line", EmitDefaultValue = false)]
        private string lastLine;
        public string getLastLine() {
            return lastLine;
        }
        public void setLastLine(string value) {
            lastLine = value;
        }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        private string country;
        public string getCountry() {
            return country;
        }
        public void setCountry(string value) {
            country = value;
        }

        /// <summary>
        /// Gets or Sets Components
        /// </summary>
        [DataMember(Name = "components", EmitDefaultValue = false)]
        private IntlComponents components;
        public IntlComponents getComponents() {
            return components;
        }
        public void setComponents(IntlComponents value) {
            components = value;
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        private BulkError error;
        public BulkError getError() {
            return error;
        }
        public void setError(BulkError value) {
            error = value;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntlVerificationOrError {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  recipient: ").Append(recipient).Append("\n");
            sb.Append("  primaryLine: ").Append(primaryLine).Append("\n");
            sb.Append("  secondaryLine: ").Append(secondaryLine).Append("\n");
            sb.Append("  lastLine: ").Append(lastLine).Append("\n");
            sb.Append("  country: ").Append(country).Append("\n");
            sb.Append("  coverage: ").Append(coverage).Append("\n");
            sb.Append("  deliverability: ").Append(deliverability).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  components: ").Append(components).Append("\n");
            sb.Append("  _object: ").Append(_object).Append("\n");
            sb.Append("  error: ").Append(error).Append("\n");
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
            return this.Equals(input as IntlVerificationOrError);
        }

        /// <summary>
        /// Returns true if IntlVerificationOrError instances are equal
        /// </summary>
        /// <param name="input">Instance of IntlVerificationOrError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntlVerificationOrError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.id == input.getId() ||
                    (this.id != null &&
                    this.id.Equals(input.getId()))
                ) && 
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
                    this.lastLine == input.getLastLine() ||
                    (this.lastLine != null &&
                    this.lastLine.Equals(input.getLastLine()))
                ) && 
                (
                    this.country == input.getCountry() ||
                    (this.country != null &&
                    this.country.Equals(input.getCountry()))
                ) && 
                (
                    this.coverage == input.getCoverage() ||
                    this.coverage.Equals(input.getCoverage())
                ) && 
                (
                    this.deliverability == input.getDeliverability() ||
                    this.deliverability.Equals(input.getDeliverability())
                ) && 
                (
                    this.status == input.getStatus() ||
                    this.status.Equals(input.getStatus())
                ) && 
                (
                    this.components == input.getComponents() ||
                    (this.components != null &&
                    this.components.Equals(input.getComponents()))
                ) && 
                (
                    this._object == input.getObject() ||
                    this._object.Equals(input.getObject())
                ) && 
                (
                    this.error == input.getError() ||
                    (this.error != null &&
                    this.error.Equals(input.getError()))
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
                if (this.id != null)
                {
                    hashCode = (hashCode * 59) + this.id.GetHashCode();
                }
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
                if (this.lastLine != null)
                {
                    hashCode = (hashCode * 59) + this.lastLine.GetHashCode();
                }
                if (this.country != null)
                {
                    hashCode = (hashCode * 59) + this.country.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.coverage.GetHashCode();
                hashCode = (hashCode * 59) + this.deliverability.GetHashCode();
                hashCode = (hashCode * 59) + this.status.GetHashCode();
                if (this.components != null)
                {
                    hashCode = (hashCode * 59) + this.components.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._object.GetHashCode();
                if (this.error != null)
                {
                    hashCode = (hashCode * 59) + this.error.GetHashCode();
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
            // id (string) pattern
            Regex regexid = new Regex(@"^intl_ver_[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexid.Match(this.id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for id, must match a pattern of " + regexid, new [] { "id" });
            }

            // recipient (string) maxLength
            if (this.recipient != null && this.recipient.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for recipient, length must be less than 500.", new [] { "recipient" });
            }

            // primaryLine (string) maxLength
            if (this.primaryLine != null && this.primaryLine.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for primaryLine, length must be less than 200.", new [] { "primaryLine" });
            }

            // secondaryLine (string) maxLength
            if (this.secondaryLine != null && this.secondaryLine.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for secondaryLine, length must be less than 500.", new [] { "secondaryLine" });
            }

            yield break;
        }
    }

}
