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
    /// Postcard
    /// </summary>
    [DataContract(Name = "postcard")]
    public partial class Postcard : IEquatable<Postcard>, IValidatableObject
    {
        /// <summary>
        /// Defines Carrier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CarrierEnum
        {
            /// <summary>
            /// Enum USPS for value: USPS
            /// </summary>
            [EnumMember(Value = "USPS")]
            USPS = 1
            

        }


        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name = "carrier", EmitDefaultValue = false)]
        public CarrierEnum? Carrier { get; set; }
        /// <summary>
        /// Defines Object
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum Postcard for value: postcard
            /// </summary>
            [EnumMember(Value = "postcard")]
            Postcard = 1
            

        }


        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public ObjectEnum? Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Postcard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Postcard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Postcard" /> class.
        /// </summary>
        /// <param name="id">Unique identifier prefixed with &#x60;psc_&#x60;. (required).</param>
        /// <param name="to">to.</param>
        /// <param name="from">from.</param>
        /// <param name="carrier">carrier (default to CarrierEnum.USPS).</param>
        /// <param name="thumbnails">thumbnails.</param>
        /// <param name="size">size.</param>
        /// <param name="expectedDeliveryDate">A date in YYYY-MM-DD format of the mailpiece&#39;s expected delivery date based on its &#x60;send_date&#x60;..</param>
        /// <param name="dateCreated">A timestamp in ISO 8601 format of the date the resource was created..</param>
        /// <param name="dateModified">A timestamp in ISO 8601 format of the date the resource was last modified..</param>
        /// <param name="deleted">Only returned if the resource has been successfully deleted..</param>
        /// <param name="frontTemplateId">The unique ID of the HTML template used for the front of the postcard..</param>
        /// <param name="backTemplateId">The unique ID of the HTML template used for the back of the postcard..</param>
        /// <param name="frontTemplateVersionId">The unique ID of the specific version of the HTML template used for the front of the postcard..</param>
        /// <param name="backTemplateVersionId">The unique ID of the specific version of the HTML template used for the back of the postcard..</param>
        /// <param name="trackingEvents">An array of tracking_event objects ordered by ascending &#x60;time&#x60;. Will not be populated for postcards created in test mode..</param>
        /// <param name="_object">_object (default to ObjectEnum.Postcard).</param>
        /// <param name="url">A [signed link](#section/Asset-URLs) served over HTTPS. The link returned will expire in 30 days to prevent mis-sharing. Each time a GET request is initiated, a new signed URL will be generated. (required).</param>
        /// <param name="description">An internal description that identifies this resource. Must be no longer than 255 characters. .</param>
        /// <param name="metadata">Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="mailType">mailType.</param>
        /// <param name="mergeVariables">You can input a merge variable payload object to your template to render dynamic content. For example, if you have a template like: &#x60;{{variable_name}}&#x60;, pass in &#x60;{\&quot;variable_name\&quot;: \&quot;Harry\&quot;}&#x60; to render &#x60;Harry&#x60;. &#x60;merge_variables&#x60; must be an object. Any type of value is accepted as long as the object is valid JSON; you can use &#x60;strings&#x60;, &#x60;numbers&#x60;, &#x60;booleans&#x60;, &#x60;arrays&#x60;, &#x60;objects&#x60;, or &#x60;null&#x60;. The max length of the object is 25,000 characters. If you call &#x60;JSON.stringify&#x60; on your object, it can be no longer than 25,000 characters. Your variable names cannot contain any whitespace or any of the following special characters: &#x60;!&#x60;, &#x60;\&quot;&#x60;, &#x60;#&#x60;, &#x60;%&#x60;, &#x60;&amp;&#x60;, &#x60;&#39;&#x60;, &#x60;(&#x60;, &#x60;)&#x60;, &#x60;*&#x60;, &#x60;+&#x60;, &#x60;,&#x60;, &#x60;/&#x60;, &#x60;;&#x60;, &#x60;&lt;&#x60;, &#x60;&#x3D;&#x60;, &#x60;&gt;&#x60;, &#x60;@&#x60;, &#x60;[&#x60;, &#x60;\\&#x60;, &#x60;]&#x60;, &#x60;^&#x60;, &#x60;&#x60; &#x60; &#x60;&#x60;, &#x60;{&#x60;, &#x60;|&#x60;, &#x60;}&#x60;, &#x60;~&#x60;. More instructions can be found in [our guide to using html and merge variables](https://lob.com/resources/guides/general/using-html-and-merge-variables). Depending on your [Merge Variable strictness](https://dashboard.lob.com/#/settings/account) setting, if you define variables in your HTML but do not pass them here, you will either receive an error or the variable will render as an empty string..</param>
        /// <param name="sendDate">A timestamp in ISO 8601 format which specifies a date after the current time and up to 180 days in the future to send the letter off for production. Setting a send date overrides the default [cancellation window](#section/Cancellation-Windows) applied to the mailpiece. Until the &#x60;send_date&#x60; has passed, the mailpiece can be canceled. If a date in the format &#x60;2017-11-01&#x60; is passed, it will evaluate to midnight UTC of that date (&#x60;2017-11-01T00:00:00.000Z&#x60;). If a datetime is passed, that exact time will be used. A &#x60;send_date&#x60; passed with no time zone will default to UTC, while a &#x60;send_date&#x60; passed with a time zone will be converted to UTC..</param>
        public Postcard(string id = default(string), Address to = default(Address), AddressDomesticExpanded from = default(AddressDomesticExpanded), CarrierEnum? carrier = CarrierEnum.USPS, List<Thumbnail> thumbnails = default(List<Thumbnail>), PostcardSize size = default(PostcardSize), DateTime expectedDeliveryDate = default(DateTime), DateTime dateCreated = default(DateTime), DateTime dateModified = default(DateTime), bool deleted = default(bool), string frontTemplateId = default(string), string backTemplateId = default(string), string frontTemplateVersionId = default(string), string backTemplateVersionId = default(string), List<TrackingEventNormal> trackingEvents = default(List<TrackingEventNormal>), ObjectEnum? _object = ObjectEnum.Postcard, string url = default(string), string description = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), MailType mailType = default(MailType), Object mergeVariables = default(Object), DateTime sendDate = default(DateTime))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Postcard and cannot be null");
            }
            this.Id = id;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for Postcard and cannot be null");
            }
            this.Url = url;
            this.To = to;
            this.From = from;
            this.Carrier = carrier;
            this.Thumbnails = thumbnails;
            this.Size = size;
            this.ExpectedDeliveryDate = expectedDeliveryDate;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Deleted = deleted;
            this.FrontTemplateId = frontTemplateId;
            this.BackTemplateId = backTemplateId;
            this.FrontTemplateVersionId = frontTemplateVersionId;
            this.BackTemplateVersionId = backTemplateVersionId;
            this.TrackingEvents = trackingEvents;
            this.Object = _object;
            this.Description = description;
            this.Metadata = metadata;
            this.MailType = mailType;
            this.MergeVariables = mergeVariables;
            this.SendDate = sendDate;
        }

        /// <summary>
        /// Unique identifier prefixed with &#x60;psc_&#x60;.
        /// </summary>
        /// <value>Unique identifier prefixed with &#x60;psc_&#x60;.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public Address To { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public AddressDomesticExpanded From { get; set; }

        /// <summary>
        /// Gets or Sets Thumbnails
        /// </summary>
        [DataMember(Name = "thumbnails", EmitDefaultValue = false)]
        public List<Thumbnail> Thumbnails { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public PostcardSize Size { get; set; }

        /// <summary>
        /// A date in YYYY-MM-DD format of the mailpiece&#39;s expected delivery date based on its &#x60;send_date&#x60;.
        /// </summary>
        /// <value>A date in YYYY-MM-DD format of the mailpiece&#39;s expected delivery date based on its &#x60;send_date&#x60;.</value>
        [DataMember(Name = "expected_delivery_date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ExpectedDeliveryDate { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was created.
        /// </summary>
        /// <value>A timestamp in ISO 8601 format of the date the resource was created.</value>
        [DataMember(Name = "date_created", EmitDefaultValue = false)]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format of the date the resource was last modified.
        /// </summary>
        /// <value>A timestamp in ISO 8601 format of the date the resource was last modified.</value>
        [DataMember(Name = "date_modified", EmitDefaultValue = false)]
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Only returned if the resource has been successfully deleted.
        /// </summary>
        /// <value>Only returned if the resource has been successfully deleted.</value>
        [DataMember(Name = "deleted", EmitDefaultValue = false)]
        public bool Deleted { get; set; }

        /// <summary>
        /// The unique ID of the HTML template used for the front of the postcard.
        /// </summary>
        /// <value>The unique ID of the HTML template used for the front of the postcard.</value>
        [DataMember(Name = "front_template_id", EmitDefaultValue = false)]
        public string FrontTemplateId { get; set; }

        /// <summary>
        /// The unique ID of the HTML template used for the back of the postcard.
        /// </summary>
        /// <value>The unique ID of the HTML template used for the back of the postcard.</value>
        [DataMember(Name = "back_template_id", EmitDefaultValue = false)]
        public string BackTemplateId { get; set; }

        /// <summary>
        /// The unique ID of the specific version of the HTML template used for the front of the postcard.
        /// </summary>
        /// <value>The unique ID of the specific version of the HTML template used for the front of the postcard.</value>
        [DataMember(Name = "front_template_version_id", EmitDefaultValue = false)]
        public string FrontTemplateVersionId { get; set; }

        /// <summary>
        /// The unique ID of the specific version of the HTML template used for the back of the postcard.
        /// </summary>
        /// <value>The unique ID of the specific version of the HTML template used for the back of the postcard.</value>
        [DataMember(Name = "back_template_version_id", EmitDefaultValue = false)]
        public string BackTemplateVersionId { get; set; }

        /// <summary>
        /// An array of tracking_event objects ordered by ascending &#x60;time&#x60;. Will not be populated for postcards created in test mode.
        /// </summary>
        /// <value>An array of tracking_event objects ordered by ascending &#x60;time&#x60;. Will not be populated for postcards created in test mode.</value>
        [DataMember(Name = "tracking_events", EmitDefaultValue = false)]
        public List<TrackingEventNormal> TrackingEvents { get; set; }

        /// <summary>
        /// A [signed link](#section/Asset-URLs) served over HTTPS. The link returned will expire in 30 days to prevent mis-sharing. Each time a GET request is initiated, a new signed URL will be generated.
        /// </summary>
        /// <value>A [signed link](#section/Asset-URLs) served over HTTPS. The link returned will expire in 30 days to prevent mis-sharing. Each time a GET request is initiated, a new signed URL will be generated.</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// An internal description that identifies this resource. Must be no longer than 255 characters. 
        /// </summary>
        /// <value>An internal description that identifies this resource. Must be no longer than 255 characters. </value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        /// <value>Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets MailType
        /// </summary>
        [DataMember(Name = "mail_type", EmitDefaultValue = false)]
        public MailType MailType { get; set; }

        /// <summary>
        /// You can input a merge variable payload object to your template to render dynamic content. For example, if you have a template like: &#x60;{{variable_name}}&#x60;, pass in &#x60;{\&quot;variable_name\&quot;: \&quot;Harry\&quot;}&#x60; to render &#x60;Harry&#x60;. &#x60;merge_variables&#x60; must be an object. Any type of value is accepted as long as the object is valid JSON; you can use &#x60;strings&#x60;, &#x60;numbers&#x60;, &#x60;booleans&#x60;, &#x60;arrays&#x60;, &#x60;objects&#x60;, or &#x60;null&#x60;. The max length of the object is 25,000 characters. If you call &#x60;JSON.stringify&#x60; on your object, it can be no longer than 25,000 characters. Your variable names cannot contain any whitespace or any of the following special characters: &#x60;!&#x60;, &#x60;\&quot;&#x60;, &#x60;#&#x60;, &#x60;%&#x60;, &#x60;&amp;&#x60;, &#x60;&#39;&#x60;, &#x60;(&#x60;, &#x60;)&#x60;, &#x60;*&#x60;, &#x60;+&#x60;, &#x60;,&#x60;, &#x60;/&#x60;, &#x60;;&#x60;, &#x60;&lt;&#x60;, &#x60;&#x3D;&#x60;, &#x60;&gt;&#x60;, &#x60;@&#x60;, &#x60;[&#x60;, &#x60;\\&#x60;, &#x60;]&#x60;, &#x60;^&#x60;, &#x60;&#x60; &#x60; &#x60;&#x60;, &#x60;{&#x60;, &#x60;|&#x60;, &#x60;}&#x60;, &#x60;~&#x60;. More instructions can be found in [our guide to using html and merge variables](https://lob.com/resources/guides/general/using-html-and-merge-variables). Depending on your [Merge Variable strictness](https://dashboard.lob.com/#/settings/account) setting, if you define variables in your HTML but do not pass them here, you will either receive an error or the variable will render as an empty string.
        /// </summary>
        /// <value>You can input a merge variable payload object to your template to render dynamic content. For example, if you have a template like: &#x60;{{variable_name}}&#x60;, pass in &#x60;{\&quot;variable_name\&quot;: \&quot;Harry\&quot;}&#x60; to render &#x60;Harry&#x60;. &#x60;merge_variables&#x60; must be an object. Any type of value is accepted as long as the object is valid JSON; you can use &#x60;strings&#x60;, &#x60;numbers&#x60;, &#x60;booleans&#x60;, &#x60;arrays&#x60;, &#x60;objects&#x60;, or &#x60;null&#x60;. The max length of the object is 25,000 characters. If you call &#x60;JSON.stringify&#x60; on your object, it can be no longer than 25,000 characters. Your variable names cannot contain any whitespace or any of the following special characters: &#x60;!&#x60;, &#x60;\&quot;&#x60;, &#x60;#&#x60;, &#x60;%&#x60;, &#x60;&amp;&#x60;, &#x60;&#39;&#x60;, &#x60;(&#x60;, &#x60;)&#x60;, &#x60;*&#x60;, &#x60;+&#x60;, &#x60;,&#x60;, &#x60;/&#x60;, &#x60;;&#x60;, &#x60;&lt;&#x60;, &#x60;&#x3D;&#x60;, &#x60;&gt;&#x60;, &#x60;@&#x60;, &#x60;[&#x60;, &#x60;\\&#x60;, &#x60;]&#x60;, &#x60;^&#x60;, &#x60;&#x60; &#x60; &#x60;&#x60;, &#x60;{&#x60;, &#x60;|&#x60;, &#x60;}&#x60;, &#x60;~&#x60;. More instructions can be found in [our guide to using html and merge variables](https://lob.com/resources/guides/general/using-html-and-merge-variables). Depending on your [Merge Variable strictness](https://dashboard.lob.com/#/settings/account) setting, if you define variables in your HTML but do not pass them here, you will either receive an error or the variable will render as an empty string.</value>
        [DataMember(Name = "merge_variables", EmitDefaultValue = false)]
        public Object MergeVariables { get; set; }

        /// <summary>
        /// A timestamp in ISO 8601 format which specifies a date after the current time and up to 180 days in the future to send the letter off for production. Setting a send date overrides the default [cancellation window](#section/Cancellation-Windows) applied to the mailpiece. Until the &#x60;send_date&#x60; has passed, the mailpiece can be canceled. If a date in the format &#x60;2017-11-01&#x60; is passed, it will evaluate to midnight UTC of that date (&#x60;2017-11-01T00:00:00.000Z&#x60;). If a datetime is passed, that exact time will be used. A &#x60;send_date&#x60; passed with no time zone will default to UTC, while a &#x60;send_date&#x60; passed with a time zone will be converted to UTC.
        /// </summary>
        /// <value>A timestamp in ISO 8601 format which specifies a date after the current time and up to 180 days in the future to send the letter off for production. Setting a send date overrides the default [cancellation window](#section/Cancellation-Windows) applied to the mailpiece. Until the &#x60;send_date&#x60; has passed, the mailpiece can be canceled. If a date in the format &#x60;2017-11-01&#x60; is passed, it will evaluate to midnight UTC of that date (&#x60;2017-11-01T00:00:00.000Z&#x60;). If a datetime is passed, that exact time will be used. A &#x60;send_date&#x60; passed with no time zone will default to UTC, while a &#x60;send_date&#x60; passed with a time zone will be converted to UTC.</value>
        [DataMember(Name = "send_date", EmitDefaultValue = false)]
        public DateTime SendDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Postcard {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  Thumbnails: ").Append(Thumbnails).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  ExpectedDeliveryDate: ").Append(ExpectedDeliveryDate).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  FrontTemplateId: ").Append(FrontTemplateId).Append("\n");
            sb.Append("  BackTemplateId: ").Append(BackTemplateId).Append("\n");
            sb.Append("  FrontTemplateVersionId: ").Append(FrontTemplateVersionId).Append("\n");
            sb.Append("  BackTemplateVersionId: ").Append(BackTemplateVersionId).Append("\n");
            sb.Append("  TrackingEvents: ").Append(TrackingEvents).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  MailType: ").Append(MailType).Append("\n");
            sb.Append("  MergeVariables: ").Append(MergeVariables).Append("\n");
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
            return this.Equals(input as Postcard);
        }

        /// <summary>
        /// Returns true if Postcard instances are equal
        /// </summary>
        /// <param name="input">Instance of Postcard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Postcard input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Carrier == input.Carrier ||
                    this.Carrier.Equals(input.Carrier)
                ) && 
                (
                    this.Thumbnails == input.Thumbnails ||
                    this.Thumbnails != null &&
                    input.Thumbnails != null &&
                    this.Thumbnails.SequenceEqual(input.Thumbnails)
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.ExpectedDeliveryDate == input.ExpectedDeliveryDate ||
                    (this.ExpectedDeliveryDate != null &&
                    this.ExpectedDeliveryDate.Equals(input.ExpectedDeliveryDate))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.DateModified == input.DateModified ||
                    (this.DateModified != null &&
                    this.DateModified.Equals(input.DateModified))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) && 
                (
                    this.FrontTemplateId == input.FrontTemplateId ||
                    (this.FrontTemplateId != null &&
                    this.FrontTemplateId.Equals(input.FrontTemplateId))
                ) && 
                (
                    this.BackTemplateId == input.BackTemplateId ||
                    (this.BackTemplateId != null &&
                    this.BackTemplateId.Equals(input.BackTemplateId))
                ) && 
                (
                    this.FrontTemplateVersionId == input.FrontTemplateVersionId ||
                    (this.FrontTemplateVersionId != null &&
                    this.FrontTemplateVersionId.Equals(input.FrontTemplateVersionId))
                ) && 
                (
                    this.BackTemplateVersionId == input.BackTemplateVersionId ||
                    (this.BackTemplateVersionId != null &&
                    this.BackTemplateVersionId.Equals(input.BackTemplateVersionId))
                ) && 
                (
                    this.TrackingEvents == input.TrackingEvents ||
                    this.TrackingEvents != null &&
                    input.TrackingEvents != null &&
                    this.TrackingEvents.SequenceEqual(input.TrackingEvents)
                ) && 
                (
                    this.Object == input.Object ||
                    this.Object.Equals(input.Object)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.MailType == input.MailType ||
                    (this.MailType != null &&
                    this.MailType.Equals(input.MailType))
                ) && 
                (
                    this.MergeVariables == input.MergeVariables ||
                    (this.MergeVariables != null &&
                    this.MergeVariables.Equals(input.MergeVariables))
                ) && 
                (
                    this.SendDate == input.SendDate ||
                    (this.SendDate != null &&
                    this.SendDate.Equals(input.SendDate))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Carrier.GetHashCode();
                if (this.Thumbnails != null)
                {
                    hashCode = (hashCode * 59) + this.Thumbnails.GetHashCode();
                }
                if (this.Size != null)
                {
                    hashCode = (hashCode * 59) + this.Size.GetHashCode();
                }
                if (this.ExpectedDeliveryDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpectedDeliveryDate.GetHashCode();
                }
                if (this.DateCreated != null)
                {
                    hashCode = (hashCode * 59) + this.DateCreated.GetHashCode();
                }
                if (this.DateModified != null)
                {
                    hashCode = (hashCode * 59) + this.DateModified.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Deleted.GetHashCode();
                if (this.FrontTemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.FrontTemplateId.GetHashCode();
                }
                if (this.BackTemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.BackTemplateId.GetHashCode();
                }
                if (this.FrontTemplateVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.FrontTemplateVersionId.GetHashCode();
                }
                if (this.BackTemplateVersionId != null)
                {
                    hashCode = (hashCode * 59) + this.BackTemplateVersionId.GetHashCode();
                }
                if (this.TrackingEvents != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingEvents.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Object.GetHashCode();
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.MailType != null)
                {
                    hashCode = (hashCode * 59) + this.MailType.GetHashCode();
                }
                if (this.MergeVariables != null)
                {
                    hashCode = (hashCode * 59) + this.MergeVariables.GetHashCode();
                }
                if (this.SendDate != null)
                {
                    hashCode = (hashCode * 59) + this.SendDate.GetHashCode();
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
            // Id (string) pattern
            Regex regexId = new Regex(@"^psc_[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // FrontTemplateId (string) pattern
            Regex regexFrontTemplateId = new Regex(@"^tmpl_[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexFrontTemplateId.Match(this.FrontTemplateId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FrontTemplateId, must match a pattern of " + regexFrontTemplateId, new [] { "FrontTemplateId" });
            }

            // BackTemplateId (string) pattern
            Regex regexBackTemplateId = new Regex(@"^tmpl_[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexBackTemplateId.Match(this.BackTemplateId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BackTemplateId, must match a pattern of " + regexBackTemplateId, new [] { "BackTemplateId" });
            }

            // FrontTemplateVersionId (string) pattern
            Regex regexFrontTemplateVersionId = new Regex(@"^vrsn_[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexFrontTemplateVersionId.Match(this.FrontTemplateVersionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FrontTemplateVersionId, must match a pattern of " + regexFrontTemplateVersionId, new [] { "FrontTemplateVersionId" });
            }

            // BackTemplateVersionId (string) pattern
            Regex regexBackTemplateVersionId = new Regex(@"^vrsn_[a-zA-Z0-9]+$", RegexOptions.CultureInvariant);
            if (false == regexBackTemplateVersionId.Match(this.BackTemplateVersionId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BackTemplateVersionId, must match a pattern of " + regexBackTemplateVersionId, new [] { "BackTemplateVersionId" });
            }

            // Url (string) pattern
            Regex regexUrl = new Regex(@"^https:\/\/(lob-assets|lob-assets-staging)\\.com\/(letters|postcards|bank-accounts|checks|self-mailers|cards)\/[a-z]{3,4}_[a-z0-9]{15,16}(\\.pdf|_thumb_[a-z]+_[0-9]+\\.png)\\?(version=[a-z0-9-]*&)?expires=[0-9]{10}&signature=[a-zA-Z0-9-_]+$", RegexOptions.CultureInvariant);
            if (false == regexUrl.Match(this.Url).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, must match a pattern of " + regexUrl, new [] { "Url" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 255.", new [] { "Description" });
            }

            yield break;
        }
    }

}
