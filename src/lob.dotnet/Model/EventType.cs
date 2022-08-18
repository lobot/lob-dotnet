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
    /// EventType
    /// </summary>
    [DataContract(Name = "event_type")]
    public partial class EventType : IEquatable<EventType>, IValidatableObject
    {
        /// <summary>
        /// Defines Resource
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResourceEnum
        {
            /// <summary>
            /// Enum Postcards for value: postcards
            /// </summary>
            [EnumMember(Value = "postcards")]
            Postcards = 1,
            

            /// <summary>
            /// Enum SelfMailers for value: self mailers
            /// </summary>
            [EnumMember(Value = "self mailers")]
            SelfMailers = 2,
            

            /// <summary>
            /// Enum Letters for value: letters
            /// </summary>
            [EnumMember(Value = "letters")]
            Letters = 3,
            

            /// <summary>
            /// Enum Checks for value: checks
            /// </summary>
            [EnumMember(Value = "checks")]
            Checks = 4,
            

            /// <summary>
            /// Enum Addresses for value: addresses
            /// </summary>
            [EnumMember(Value = "addresses")]
            Addresses = 5,
            

            /// <summary>
            /// Enum BankAccounts for value: bank accounts
            /// </summary>
            [EnumMember(Value = "bank accounts")]
            BankAccounts = 6
            

        }


        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", IsRequired = true, EmitDefaultValue = false)]
        private ResourceEnum resource;
        public ResourceEnum getResource() {
            return resource;
        }
        public void setResource(ResourceEnum value) {
            resource = value;
        }
        /// <summary>
        /// Value is resource type.
        /// </summary>
        /// <value>Value is resource type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum EventType for value: event_type
            /// </summary>
            [EnumMember(Value = "event_type")]
            EventType = 1
            

        }


        /// <summary>
        /// Value is resource type.
        /// </summary>
        /// <value>Value is resource type.</value>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = false)]
        private ObjectEnum _object;
        public ObjectEnum getObject() {
            return _object;
        }
        public void setObject(ObjectEnum value) {
            _object = value;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public EventType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventType" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="enabledForTest">Value is &#x60;true&#x60; if the event type is enabled in both the test and live environments. (required).</param>
        /// <param name="resource">resource (required).</param>
        /// <param name="_object">Value is resource type. (required) (default to ObjectEnum.EventType).</param>

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        private string id;
        public string getId() {
            return id;
        }
        public void setId(string value) {
            id = value;
        }

        /// <summary>
        /// Value is &#x60;true&#x60; if the event type is enabled in both the test and live environments.
        /// </summary>
        /// <value>Value is &#x60;true&#x60; if the event type is enabled in both the test and live environments.</value>
        [DataMember(Name = "enabled_for_test", IsRequired = true, EmitDefaultValue = true)]
        private bool enabledForTest;
        public bool getEnabledForTest() {
            return enabledForTest;
        }
        public void setEnabledForTest(bool value) {
            enabledForTest = value;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventType {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  enabledForTest: ").Append(enabledForTest).Append("\n");
            sb.Append("  resource: ").Append(resource).Append("\n");
            sb.Append("  _object: ").Append(_object).Append("\n");
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
            return this.Equals(input as EventType);
        }

        /// <summary>
        /// Returns true if EventType instances are equal
        /// </summary>
        /// <param name="input">Instance of EventType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventType input)
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
                    this.enabledForTest == input.getEnabledForTest() ||
                    this.enabledForTest.Equals(input.getEnabledForTest())
                ) && 
                (
                    this.resource == input.getResource() ||
                    this.resource.Equals(input.getResource())
                ) && 
                (
                    this._object == input.getObject() ||
                    this._object.Equals(input.getObject())
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
                hashCode = (hashCode * 59) + this.enabledForTest.GetHashCode();
                hashCode = (hashCode * 59) + this.resource.GetHashCode();
                hashCode = (hashCode * 59) + this._object.GetHashCode();
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
