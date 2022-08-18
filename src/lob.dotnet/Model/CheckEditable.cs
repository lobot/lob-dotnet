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
    /// CheckEditable
    /// </summary>
    [DataContract(Name = "check_editable")]
    public partial class CheckEditable : IEquatable<CheckEditable>, IValidatableObject
    {
        /// <summary>
        /// Checks must be sent &#x60;usps_first_class&#x60;
        /// </summary>
        /// <value>Checks must be sent &#x60;usps_first_class&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MailTypeEnum
        {
            /// <summary>
            /// Enum UspsFirstClass for value: usps_first_class
            /// </summary>
            [EnumMember(Value = "usps_first_class")]
            UspsFirstClass = 1
            

        }


        /// <summary>
        /// Checks must be sent &#x60;usps_first_class&#x60;
        /// </summary>
        /// <value>Checks must be sent &#x60;usps_first_class&#x60;</value>
        [DataMember(Name = "mail_type", EmitDefaultValue = false)]
        private MailTypeEnum? mailType;
        public MailTypeEnum? getMailType() {
            return mailType;
        }
        public void setMailType(MailTypeEnum value) {
            mailType = value;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckEditable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public CheckEditable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckEditable" /> class.
        /// </summary>
        /// <param name="from">Must either be an address ID or an inline object with correct address parameters. (required).</param>
        /// <param name="to">Must either be an address ID or an inline object with correct address parameters. (required).</param>
        /// <param name="bankAccount">bankAccount (required).</param>
        /// <param name="amount">The payment amount to be sent in US dollars. (required).</param>
        /// <param name="logo">Accepts a remote URL or local file upload to an image to print (in grayscale) in the upper-left corner of your check..</param>
        /// <param name="checkBottom">The artwork to use on the bottom of the check page.  Notes: - HTML merge variables should not include delimiting whitespace. - PDF, PNG, and JPGs must be sized at 8.5\&quot;x11\&quot; at 300 DPI, while supplied HTML will be rendered and trimmed to fit on a 8.5\&quot;x11\&quot; page. - The check bottom will always be printed in black &amp; white. - Must conform to [this template](https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/check_bottom_template.pdf).  Need more help? Consult our [HTML examples](#section/HTML-Examples)..</param>
        /// <param name="attachment">A document to include with the check..</param>
        /// <param name="description">An internal description that identifies this resource. Must be no longer than 255 characters. .</param>
        /// <param name="metadata">Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information..</param>
        /// <param name="mergeVariables">You can input a merge variable payload object to your template to render dynamic content. For example, if you have a template like: &#x60;{{variable_name}}&#x60;, pass in &#x60;{\&quot;variable_name\&quot;: \&quot;Harry\&quot;}&#x60; to render &#x60;Harry&#x60;. &#x60;merge_variables&#x60; must be an object. Any type of value is accepted as long as the object is valid JSON; you can use &#x60;strings&#x60;, &#x60;numbers&#x60;, &#x60;booleans&#x60;, &#x60;arrays&#x60;, &#x60;objects&#x60;, or &#x60;null&#x60;. The max length of the object is 25,000 characters. If you call &#x60;JSON.stringify&#x60; on your object, it can be no longer than 25,000 characters. Your variable names cannot contain any whitespace or any of the following special characters: &#x60;!&#x60;, &#x60;\&quot;&#x60;, &#x60;#&#x60;, &#x60;%&#x60;, &#x60;&amp;&#x60;, &#x60;&#39;&#x60;, &#x60;(&#x60;, &#x60;)&#x60;, &#x60;*&#x60;, &#x60;+&#x60;, &#x60;,&#x60;, &#x60;/&#x60;, &#x60;;&#x60;, &#x60;&lt;&#x60;, &#x60;&#x3D;&#x60;, &#x60;&gt;&#x60;, &#x60;@&#x60;, &#x60;[&#x60;, &#x60;\\&#x60;, &#x60;]&#x60;, &#x60;^&#x60;, &#x60;&#x60; &#x60; &#x60;&#x60;, &#x60;{&#x60;, &#x60;|&#x60;, &#x60;}&#x60;, &#x60;~&#x60;. More instructions can be found in [our guide to using html and merge variables](https://lob.com/resources/guides/general/using-html-and-merge-variables). Depending on your [Merge Variable strictness](https://dashboard.lob.com/#/settings/account) setting, if you define variables in your HTML but do not pass them here, you will either receive an error or the variable will render as an empty string..</param>
        /// <param name="sendDate">A timestamp in ISO 8601 format which specifies a date after the current time and up to 180 days in the future to send the letter off for production. Setting a send date overrides the default [cancellation window](#section/Cancellation-Windows) applied to the mailpiece. Until the &#x60;send_date&#x60; has passed, the mailpiece can be canceled. If a date in the format &#x60;2017-11-01&#x60; is passed, it will evaluate to midnight UTC of that date (&#x60;2017-11-01T00:00:00.000Z&#x60;). If a datetime is passed, that exact time will be used. A &#x60;send_date&#x60; passed with no time zone will default to UTC, while a &#x60;send_date&#x60; passed with a time zone will be converted to UTC..</param>
        /// <param name="mailType">Checks must be sent &#x60;usps_first_class&#x60; (default to MailTypeEnum.UspsFirstClass).</param>
        /// <param name="memo">Text to include on the memo line of the check..</param>
        /// <param name="checkNumber">An integer that designates the check number..</param>
        /// <param name="message">Max of 400 characters to be included at the bottom of the check page..</param>
        /// <param name="billingGroupId">An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See [Billing Group API](https://lob.github.io/lob-openapi/#tag/Billing-Groups) for more information..</param>

        /// <summary>
        /// Must either be an address ID or an inline object with correct address parameters.
        /// </summary>
        /// <value>Must either be an address ID or an inline object with correct address parameters.</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = false)]
        private string from;
        public string getFrom() {
            return from;
        }
        public void setFrom(string value) {
            from = value;
        }
        public void setFrom(AddressDomestic value) {
            from = Newtonsoft.Json.JsonConvert.SerializeObject(value);
        }

        /// <summary>
        /// Must either be an address ID or an inline object with correct address parameters.
        /// </summary>
        /// <value>Must either be an address ID or an inline object with correct address parameters.</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = false)]
        private string to;
        public string getTo() {
            return to;
        }
        public void setTo(string value) {
            to = value;
        }
        public void setTo(AddressDomestic value) {
            to = Newtonsoft.Json.JsonConvert.SerializeObject(value);
        }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name = "bank_account", IsRequired = true, EmitDefaultValue = true)]
        private string bankAccount;
        public string getBankAccount() {
            return bankAccount;
        }
        public void setBankAccount(string value) {
            bankAccount = value;
        }

        /// <summary>
        /// The payment amount to be sent in US dollars.
        /// </summary>
        /// <value>The payment amount to be sent in US dollars.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        private float amount;
        public float getAmount() {
            return amount;
        }
        public void setAmount(float value) {
            amount = value;
        }

        /// <summary>
        /// Accepts a remote URL or local file upload to an image to print (in grayscale) in the upper-left corner of your check.
        /// </summary>
        /// <value>Accepts a remote URL or local file upload to an image to print (in grayscale) in the upper-left corner of your check.</value>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        private string logo;
        public string getLogo() {
            return logo;
        }
        public void setLogo(string value) {
            logo = value;
        }

        /// <summary>
        /// The artwork to use on the bottom of the check page.  Notes: - HTML merge variables should not include delimiting whitespace. - PDF, PNG, and JPGs must be sized at 8.5\&quot;x11\&quot; at 300 DPI, while supplied HTML will be rendered and trimmed to fit on a 8.5\&quot;x11\&quot; page. - The check bottom will always be printed in black &amp; white. - Must conform to [this template](https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/check_bottom_template.pdf).  Need more help? Consult our [HTML examples](#section/HTML-Examples).
        /// </summary>
        /// <value>The artwork to use on the bottom of the check page.  Notes: - HTML merge variables should not include delimiting whitespace. - PDF, PNG, and JPGs must be sized at 8.5\&quot;x11\&quot; at 300 DPI, while supplied HTML will be rendered and trimmed to fit on a 8.5\&quot;x11\&quot; page. - The check bottom will always be printed in black &amp; white. - Must conform to [this template](https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/check_bottom_template.pdf).  Need more help? Consult our [HTML examples](#section/HTML-Examples).</value>
        [DataMember(Name = "check_bottom", EmitDefaultValue = false)]
        private string checkBottom;
        public string getCheckBottom() {
            return checkBottom;
        }
        public void setCheckBottom(string value) {
            checkBottom = value;
        }

        /// <summary>
        /// A document to include with the check.
        /// </summary>
        /// <value>A document to include with the check.</value>
        [DataMember(Name = "attachment", EmitDefaultValue = false)]
        private string attachment;
        public string getAttachment() {
            return attachment;
        }
        public void setAttachment(string value) {
            attachment = value;
        }

        /// <summary>
        /// An internal description that identifies this resource. Must be no longer than 255 characters. 
        /// </summary>
        /// <value>An internal description that identifies this resource. Must be no longer than 255 characters. </value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        private string description;
        public string getDescription() {
            return description;
        }
        public void setDescription(string value) {
            description = value;
        }

        /// <summary>
        /// Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.
        /// </summary>
        /// <value>Use metadata to store custom information for tagging and labeling back to your internal systems. Must be an object with up to 20 key-value pairs. Keys must be at most 40 characters and values must be at most 500 characters. Neither can contain the characters &#x60;\&quot;&#x60; and &#x60;\\&#x60;. i.e. &#39;{\&quot;customer_id\&quot; : \&quot;NEWYORK2015\&quot;}&#39; Nested objects are not supported.  See [Metadata](#section/Metadata) for more information.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        private Dictionary<string, string> metadata;
        public Dictionary<string, string> getMetadata() {
            return metadata;
        }
        public void setMetadata(Dictionary<string, string> value) {
            metadata = value;
        }

        /// <summary>
        /// You can input a merge variable payload object to your template to render dynamic content. For example, if you have a template like: &#x60;{{variable_name}}&#x60;, pass in &#x60;{\&quot;variable_name\&quot;: \&quot;Harry\&quot;}&#x60; to render &#x60;Harry&#x60;. &#x60;merge_variables&#x60; must be an object. Any type of value is accepted as long as the object is valid JSON; you can use &#x60;strings&#x60;, &#x60;numbers&#x60;, &#x60;booleans&#x60;, &#x60;arrays&#x60;, &#x60;objects&#x60;, or &#x60;null&#x60;. The max length of the object is 25,000 characters. If you call &#x60;JSON.stringify&#x60; on your object, it can be no longer than 25,000 characters. Your variable names cannot contain any whitespace or any of the following special characters: &#x60;!&#x60;, &#x60;\&quot;&#x60;, &#x60;#&#x60;, &#x60;%&#x60;, &#x60;&amp;&#x60;, &#x60;&#39;&#x60;, &#x60;(&#x60;, &#x60;)&#x60;, &#x60;*&#x60;, &#x60;+&#x60;, &#x60;,&#x60;, &#x60;/&#x60;, &#x60;;&#x60;, &#x60;&lt;&#x60;, &#x60;&#x3D;&#x60;, &#x60;&gt;&#x60;, &#x60;@&#x60;, &#x60;[&#x60;, &#x60;\\&#x60;, &#x60;]&#x60;, &#x60;^&#x60;, &#x60;&#x60; &#x60; &#x60;&#x60;, &#x60;{&#x60;, &#x60;|&#x60;, &#x60;}&#x60;, &#x60;~&#x60;. More instructions can be found in [our guide to using html and merge variables](https://lob.com/resources/guides/general/using-html-and-merge-variables). Depending on your [Merge Variable strictness](https://dashboard.lob.com/#/settings/account) setting, if you define variables in your HTML but do not pass them here, you will either receive an error or the variable will render as an empty string.
        /// </summary>
        /// <value>You can input a merge variable payload object to your template to render dynamic content. For example, if you have a template like: &#x60;{{variable_name}}&#x60;, pass in &#x60;{\&quot;variable_name\&quot;: \&quot;Harry\&quot;}&#x60; to render &#x60;Harry&#x60;. &#x60;merge_variables&#x60; must be an object. Any type of value is accepted as long as the object is valid JSON; you can use &#x60;strings&#x60;, &#x60;numbers&#x60;, &#x60;booleans&#x60;, &#x60;arrays&#x60;, &#x60;objects&#x60;, or &#x60;null&#x60;. The max length of the object is 25,000 characters. If you call &#x60;JSON.stringify&#x60; on your object, it can be no longer than 25,000 characters. Your variable names cannot contain any whitespace or any of the following special characters: &#x60;!&#x60;, &#x60;\&quot;&#x60;, &#x60;#&#x60;, &#x60;%&#x60;, &#x60;&amp;&#x60;, &#x60;&#39;&#x60;, &#x60;(&#x60;, &#x60;)&#x60;, &#x60;*&#x60;, &#x60;+&#x60;, &#x60;,&#x60;, &#x60;/&#x60;, &#x60;;&#x60;, &#x60;&lt;&#x60;, &#x60;&#x3D;&#x60;, &#x60;&gt;&#x60;, &#x60;@&#x60;, &#x60;[&#x60;, &#x60;\\&#x60;, &#x60;]&#x60;, &#x60;^&#x60;, &#x60;&#x60; &#x60; &#x60;&#x60;, &#x60;{&#x60;, &#x60;|&#x60;, &#x60;}&#x60;, &#x60;~&#x60;. More instructions can be found in [our guide to using html and merge variables](https://lob.com/resources/guides/general/using-html-and-merge-variables). Depending on your [Merge Variable strictness](https://dashboard.lob.com/#/settings/account) setting, if you define variables in your HTML but do not pass them here, you will either receive an error or the variable will render as an empty string.</value>
        [DataMember(Name = "merge_variables", EmitDefaultValue = true)]
        private Object mergeVariables;
        public Object getMergeVariables() {
            return mergeVariables;
        }
        public void setMergeVariables(Object value) {
            mergeVariables = value;
        }

        /// <summary>
        /// A timestamp in ISO 8601 format which specifies a date after the current time and up to 180 days in the future to send the letter off for production. Setting a send date overrides the default [cancellation window](#section/Cancellation-Windows) applied to the mailpiece. Until the &#x60;send_date&#x60; has passed, the mailpiece can be canceled. If a date in the format &#x60;2017-11-01&#x60; is passed, it will evaluate to midnight UTC of that date (&#x60;2017-11-01T00:00:00.000Z&#x60;). If a datetime is passed, that exact time will be used. A &#x60;send_date&#x60; passed with no time zone will default to UTC, while a &#x60;send_date&#x60; passed with a time zone will be converted to UTC.
        /// </summary>
        /// <value>A timestamp in ISO 8601 format which specifies a date after the current time and up to 180 days in the future to send the letter off for production. Setting a send date overrides the default [cancellation window](#section/Cancellation-Windows) applied to the mailpiece. Until the &#x60;send_date&#x60; has passed, the mailpiece can be canceled. If a date in the format &#x60;2017-11-01&#x60; is passed, it will evaluate to midnight UTC of that date (&#x60;2017-11-01T00:00:00.000Z&#x60;). If a datetime is passed, that exact time will be used. A &#x60;send_date&#x60; passed with no time zone will default to UTC, while a &#x60;send_date&#x60; passed with a time zone will be converted to UTC.</value>
        [DataMember(Name = "send_date", EmitDefaultValue = false)]
        private DateTime sendDate;
        public DateTime getSendDate() {
            return sendDate;
        }
        public void setSendDate(DateTime value) {
            sendDate = value;
        }

        /// <summary>
        /// Text to include on the memo line of the check.
        /// </summary>
        /// <value>Text to include on the memo line of the check.</value>
        [DataMember(Name = "memo", EmitDefaultValue = true)]
        private string memo;
        public string getMemo() {
            return memo;
        }
        public void setMemo(string value) {
            memo = value;
        }

        /// <summary>
        /// An integer that designates the check number.
        /// </summary>
        /// <value>An integer that designates the check number.</value>
        [DataMember(Name = "check_number", EmitDefaultValue = false)]
        private int checkNumber;
        public int getCheckNumber() {
            return checkNumber;
        }
        public void setCheckNumber(int value) {
            checkNumber = value;
        }

        /// <summary>
        /// Max of 400 characters to be included at the bottom of the check page.
        /// </summary>
        /// <value>Max of 400 characters to be included at the bottom of the check page.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        private string message;
        public string getMessage() {
            return message;
        }
        public void setMessage(string value) {
            message = value;
        }

        /// <summary>
        /// An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See [Billing Group API](https://lob.github.io/lob-openapi/#tag/Billing-Groups) for more information.
        /// </summary>
        /// <value>An optional string with the billing group ID to tag your usage with. Is used for billing purposes. Requires special activation to use. See [Billing Group API](https://lob.github.io/lob-openapi/#tag/Billing-Groups) for more information.</value>
        [DataMember(Name = "billing_group_id", EmitDefaultValue = false)]
        private string billingGroupId;
        public string getBillingGroupId() {
            return billingGroupId;
        }
        public void setBillingGroupId(string value) {
            billingGroupId = value;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckEditable {\n");
            sb.Append("  from: ").Append(from).Append("\n");
            sb.Append("  to: ").Append(to).Append("\n");
            sb.Append("  bankAccount: ").Append(bankAccount).Append("\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
            sb.Append("  logo: ").Append(logo).Append("\n");
            sb.Append("  checkBottom: ").Append(checkBottom).Append("\n");
            sb.Append("  attachment: ").Append(attachment).Append("\n");
            sb.Append("  description: ").Append(description).Append("\n");
            sb.Append("  metadata: ").Append(metadata).Append("\n");
            sb.Append("  mergeVariables: ").Append(mergeVariables).Append("\n");
            sb.Append("  sendDate: ").Append(sendDate).Append("\n");
            sb.Append("  mailType: ").Append(mailType).Append("\n");
            sb.Append("  memo: ").Append(memo).Append("\n");
            sb.Append("  checkNumber: ").Append(checkNumber).Append("\n");
            sb.Append("  message: ").Append(message).Append("\n");
            sb.Append("  billingGroupId: ").Append(billingGroupId).Append("\n");
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
            return this.Equals(input as CheckEditable);
        }

        /// <summary>
        /// Returns true if CheckEditable instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckEditable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckEditable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.from == input.getFrom() ||
                    (this.from != null &&
                    this.from.Equals(input.getFrom()))
                ) && 
                (
                    this.to == input.getTo() ||
                    (this.to != null &&
                    this.to.Equals(input.getTo()))
                ) && 
                (
                    this.bankAccount == input.getBankAccount() ||
                    (this.bankAccount != null &&
                    this.bankAccount.Equals(input.getBankAccount()))
                ) && 
                (
                    this.amount == input.getAmount() ||
                    this.amount.Equals(input.getAmount())
                ) && 
                (
                    this.logo == input.getLogo() ||
                    (this.logo != null &&
                    this.logo.Equals(input.getLogo()))
                ) && 
                (
                    this.checkBottom == input.getCheckBottom() ||
                    (this.checkBottom != null &&
                    this.checkBottom.Equals(input.getCheckBottom()))
                ) && 
                (
                    this.attachment == input.getAttachment() ||
                    (this.attachment != null &&
                    this.attachment.Equals(input.getAttachment()))
                ) && 
                (
                    this.description == input.getDescription() ||
                    (this.description != null &&
                    this.description.Equals(input.getDescription()))
                ) && 
                (
                    this.metadata == input.getMetadata() ||
                    this.metadata != null &&
                    input.getMetadata() != null &&
                    this.metadata.SequenceEqual(input.getMetadata())
                ) && 
                (
                    this.mergeVariables == input.getMergeVariables() ||
                    (this.mergeVariables != null &&
                    this.mergeVariables.Equals(input.getMergeVariables()))
                ) && 
                (
                    this.sendDate == input.getSendDate() ||
                    (this.sendDate != null &&
                    this.sendDate.Equals(input.getSendDate()))
                ) && 
                (
                    this.mailType == input.getMailType() ||
                    this.mailType.Equals(input.getMailType())
                ) && 
                (
                    this.memo == input.getMemo() ||
                    (this.memo != null &&
                    this.memo.Equals(input.getMemo()))
                ) && 
                (
                    this.checkNumber == input.getCheckNumber() ||
                    this.checkNumber.Equals(input.getCheckNumber())
                ) && 
                (
                    this.message == input.getMessage() ||
                    (this.message != null &&
                    this.message.Equals(input.getMessage()))
                ) && 
                (
                    this.billingGroupId == input.getBillingGroupId() ||
                    (this.billingGroupId != null &&
                    this.billingGroupId.Equals(input.getBillingGroupId()))
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
                if (this.from != null)
                {
                    hashCode = (hashCode * 59) + this.from.GetHashCode();
                }
                if (this.to != null)
                {
                    hashCode = (hashCode * 59) + this.to.GetHashCode();
                }
                if (this.bankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.bankAccount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.amount.GetHashCode();
                if (this.logo != null)
                {
                    hashCode = (hashCode * 59) + this.logo.GetHashCode();
                }
                if (this.checkBottom != null)
                {
                    hashCode = (hashCode * 59) + this.checkBottom.GetHashCode();
                }
                if (this.attachment != null)
                {
                    hashCode = (hashCode * 59) + this.attachment.GetHashCode();
                }
                if (this.description != null)
                {
                    hashCode = (hashCode * 59) + this.description.GetHashCode();
                }
                if (this.metadata != null)
                {
                    hashCode = (hashCode * 59) + this.metadata.GetHashCode();
                }
                if (this.mergeVariables != null)
                {
                    hashCode = (hashCode * 59) + this.mergeVariables.GetHashCode();
                }
                if (this.sendDate != null)
                {
                    hashCode = (hashCode * 59) + this.sendDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.mailType.GetHashCode();
                if (this.memo != null)
                {
                    hashCode = (hashCode * 59) + this.memo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.checkNumber.GetHashCode();
                if (this.message != null)
                {
                    hashCode = (hashCode * 59) + this.message.GetHashCode();
                }
                if (this.billingGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.billingGroupId.GetHashCode();
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
            // amount (float) maximum
            if (this.amount > (float)999999.99)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for amount, must be a value less than or equal to 999999.99.", new [] { "amount" });
            }

            // description (string) maxLength
            if (this.description != null && this.description.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for description, length must be less than 255.", new [] { "description" });
            }

            // memo (string) maxLength
            if (this.memo != null && this.memo.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for memo, length must be less than 40.", new [] { "memo" });
            }

            // checkNumber (int) maximum
            if (this.checkNumber > (int)500000000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for checkNumber, must be a value less than or equal to 500000000.", new [] { "checkNumber" });
            }

            // checkNumber (int) minimum
            if (this.checkNumber < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for checkNumber, must be a value greater than or equal to 1.", new [] { "checkNumber" });
            }

            // message (string) maxLength
            if (this.message != null && this.message.Length > 400)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for message, length must be less than 400.", new [] { "message" });
            }

            yield break;
        }
    }

}
