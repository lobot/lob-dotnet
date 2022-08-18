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
    /// TemplateList
    /// </summary>
    [DataContract(Name = "template_list")]
    public partial class TemplateList : IEquatable<TemplateList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateList" /> class.
        /// </summary>
        /// <param name="data">list of templates.</param>
        /// <param name="_object">Value is type of resource..</param>
        /// <param name="nextUrl">url of next page of items in list..</param>
        /// <param name="previousUrl">url of previous page of items in list..</param>
        /// <param name="count">number of resources in a set.</param>
        /// <param name="totalCount">indicates the total number of records. Provided when the request specifies an \&quot;include\&quot; query parameter.</param>

        /// <summary>
        /// list of templates
        /// </summary>
        /// <value>list of templates</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        private List<Template> data;
        public List<Template> getData() {
            return data;
        }
        public void setData(List<Template> value) {
            data = value;
        }

        /// <summary>
        /// Value is type of resource.
        /// </summary>
        /// <value>Value is type of resource.</value>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        private string _object;
        public string getObject() {
            return _object;
        }
        public void setObject(string value) {
            _object = value;
        }

        /// <summary>
        /// url of next page of items in list.
        /// </summary>
        /// <value>url of next page of items in list.</value>
        [DataMember(Name = "next_url", EmitDefaultValue = true)]
        private string nextUrl;
        public string getNextUrl() {
            return nextUrl;
        }
        public void setNextUrl(string value) {
            nextUrl = value;
        }

        /// <summary>
        /// url of previous page of items in list.
        /// </summary>
        /// <value>url of previous page of items in list.</value>
        [DataMember(Name = "previous_url", EmitDefaultValue = true)]
        private string previousUrl;
        public string getPreviousUrl() {
            return previousUrl;
        }
        public void setPreviousUrl(string value) {
            previousUrl = value;
        }

        /// <summary>
        /// number of resources in a set
        /// </summary>
        /// <value>number of resources in a set</value>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        private int count;
        public int getCount() {
            return count;
        }
        public void setCount(int value) {
            count = value;
        }

        /// <summary>
        /// indicates the total number of records. Provided when the request specifies an \&quot;include\&quot; query parameter
        /// </summary>
        /// <value>indicates the total number of records. Provided when the request specifies an \&quot;include\&quot; query parameter</value>
        [DataMember(Name = "total_count", EmitDefaultValue = false)]
        private int totalCount;
        public int getTotalCount() {
            return totalCount;
        }
        public void setTotalCount(int value) {
            totalCount = value;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateList {\n");
            sb.Append("  data: ").Append(data).Append("\n");
            sb.Append("  _object: ").Append(_object).Append("\n");
            sb.Append("  nextUrl: ").Append(nextUrl).Append("\n");
            sb.Append("  previousUrl: ").Append(previousUrl).Append("\n");
            sb.Append("  count: ").Append(count).Append("\n");
            sb.Append("  totalCount: ").Append(totalCount).Append("\n");
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
            return this.Equals(input as TemplateList);
        }

        /// <summary>
        /// Returns true if TemplateList instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.data == input.getData() ||
                    this.data != null &&
                    input.getData() != null &&
                    this.data.SequenceEqual(input.getData())
                ) && 
                (
                    this._object == input.getObject() ||
                    (this._object != null &&
                    this._object.Equals(input.getObject()))
                ) && 
                (
                    this.nextUrl == input.getNextUrl() ||
                    (this.nextUrl != null &&
                    this.nextUrl.Equals(input.getNextUrl()))
                ) && 
                (
                    this.previousUrl == input.getPreviousUrl() ||
                    (this.previousUrl != null &&
                    this.previousUrl.Equals(input.getPreviousUrl()))
                ) && 
                (
                    this.count == input.getCount() ||
                    this.count.Equals(input.getCount())
                ) && 
                (
                    this.totalCount == input.getTotalCount() ||
                    this.totalCount.Equals(input.getTotalCount())
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
                if (this.data != null)
                {
                    hashCode = (hashCode * 59) + this.data.GetHashCode();
                }
                if (this._object != null)
                {
                    hashCode = (hashCode * 59) + this._object.GetHashCode();
                }
                if (this.nextUrl != null)
                {
                    hashCode = (hashCode * 59) + this.nextUrl.GetHashCode();
                }
                if (this.previousUrl != null)
                {
                    hashCode = (hashCode * 59) + this.previousUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.count.GetHashCode();
                hashCode = (hashCode * 59) + this.totalCount.GetHashCode();
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
