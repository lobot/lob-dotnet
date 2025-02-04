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
    /// TrackingEventDetails
    /// </summary>
    [DataContract(Name = "tracking_event_details")]
    public partial class TrackingEventDetails : IEquatable<TrackingEventDetails>, IValidatableObject
    {
        /// <summary>
        /// Find the full table [here](#tag/Tracking-Events). A detailed substatus about the event: * &#x60;package_accepted&#x60; - Package has been accepted into the carrier network for delivery. * &#x60;package_arrived&#x60; - Package has arrived at an intermediate location in the carrier network. * &#x60;package_departed&#x60; - Package has departed from an intermediate location in the carrier network. * &#x60;package_processing&#x60; - Package is processing at an intermediate location in the carrier network. * &#x60;package_processed&#x60; - Package has been processed at an intermediate location. * &#x60;package_in_local_area&#x60; - Package is at a location near the end destination. * &#x60;delivery_scheduled&#x60; - Package is scheduled for delivery. * &#x60;out_for_delivery&#x60; - Package is out for delivery. * &#x60;pickup_available&#x60; - Package is available for pickup at carrier location. * &#x60;delivered&#x60; - Package has been delivered. * &#x60;package_forwarded&#x60; - Package has been forwarded. * &#x60;returned_to_sender&#x60; - Package is to be returned to sender. * &#x60;address_issue&#x60; - Address information is incorrect. Contact carrier to ensure delivery. * &#x60;contact_carrier&#x60; - Contact the carrier for more information. * &#x60;delayed&#x60; - Delivery of package is delayed. * &#x60;delivery_attempted&#x60; - Delivery of package has been attempted. Contact carrier to ensure delivery. * &#x60;delivery_rescheduled&#x60; - Delivery of package has been rescheduled. * &#x60;location_inaccessible&#x60; - Delivery location inaccessible to carrier. Contact carrier to ensure delivery. * &#x60;notice_left&#x60; - Carrier left notice during attempted delivery. Follow carrier instructions on notice. * &#x60;package_damaged&#x60; - Package has been damaged. Contact carrier for more details. * &#x60;package_disposed&#x60; - Package has been disposed. * &#x60;package_held&#x60; - Package held at carrier location. Contact carrier for more details. * &#x60;package_lost&#x60; - Package has been lost. Contact carrier for more details. * &#x60;package_unclaimed&#x60; - Package is unclaimed. * &#x60;package_undeliverable&#x60; - Package is not able to be delivered. * &#x60;reschedule_delivery&#x60; - Contact carrier to reschedule delivery. * &#x60;other&#x60; - Unrecognized carrier status. 
        /// </summary>
        /// <value>Find the full table [here](#tag/Tracking-Events). A detailed substatus about the event: * &#x60;package_accepted&#x60; - Package has been accepted into the carrier network for delivery. * &#x60;package_arrived&#x60; - Package has arrived at an intermediate location in the carrier network. * &#x60;package_departed&#x60; - Package has departed from an intermediate location in the carrier network. * &#x60;package_processing&#x60; - Package is processing at an intermediate location in the carrier network. * &#x60;package_processed&#x60; - Package has been processed at an intermediate location. * &#x60;package_in_local_area&#x60; - Package is at a location near the end destination. * &#x60;delivery_scheduled&#x60; - Package is scheduled for delivery. * &#x60;out_for_delivery&#x60; - Package is out for delivery. * &#x60;pickup_available&#x60; - Package is available for pickup at carrier location. * &#x60;delivered&#x60; - Package has been delivered. * &#x60;package_forwarded&#x60; - Package has been forwarded. * &#x60;returned_to_sender&#x60; - Package is to be returned to sender. * &#x60;address_issue&#x60; - Address information is incorrect. Contact carrier to ensure delivery. * &#x60;contact_carrier&#x60; - Contact the carrier for more information. * &#x60;delayed&#x60; - Delivery of package is delayed. * &#x60;delivery_attempted&#x60; - Delivery of package has been attempted. Contact carrier to ensure delivery. * &#x60;delivery_rescheduled&#x60; - Delivery of package has been rescheduled. * &#x60;location_inaccessible&#x60; - Delivery location inaccessible to carrier. Contact carrier to ensure delivery. * &#x60;notice_left&#x60; - Carrier left notice during attempted delivery. Follow carrier instructions on notice. * &#x60;package_damaged&#x60; - Package has been damaged. Contact carrier for more details. * &#x60;package_disposed&#x60; - Package has been disposed. * &#x60;package_held&#x60; - Package held at carrier location. Contact carrier for more details. * &#x60;package_lost&#x60; - Package has been lost. Contact carrier for more details. * &#x60;package_unclaimed&#x60; - Package is unclaimed. * &#x60;package_undeliverable&#x60; - Package is not able to be delivered. * &#x60;reschedule_delivery&#x60; - Contact carrier to reschedule delivery. * &#x60;other&#x60; - Unrecognized carrier status. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventEnum
        {
            /// <summary>
            /// Enum PackageAccepted for value: package_accepted
            /// </summary>
            [EnumMember(Value = "package_accepted")]
            PackageAccepted = 1,
            

            /// <summary>
            /// Enum PackageArrived for value: package_arrived
            /// </summary>
            [EnumMember(Value = "package_arrived")]
            PackageArrived = 2,
            

            /// <summary>
            /// Enum PackageDeparted for value: package_departed
            /// </summary>
            [EnumMember(Value = "package_departed")]
            PackageDeparted = 3,
            

            /// <summary>
            /// Enum PackageProcessing for value: package_processing
            /// </summary>
            [EnumMember(Value = "package_processing")]
            PackageProcessing = 4,
            

            /// <summary>
            /// Enum PackageProcessed for value: package_processed
            /// </summary>
            [EnumMember(Value = "package_processed")]
            PackageProcessed = 5,
            

            /// <summary>
            /// Enum PackageInLocalArea for value: package_in_local_area
            /// </summary>
            [EnumMember(Value = "package_in_local_area")]
            PackageInLocalArea = 6,
            

            /// <summary>
            /// Enum DeliveryScheduled for value: delivery_scheduled
            /// </summary>
            [EnumMember(Value = "delivery_scheduled")]
            DeliveryScheduled = 7,
            

            /// <summary>
            /// Enum OutForDelivery for value: out_for_delivery
            /// </summary>
            [EnumMember(Value = "out_for_delivery")]
            OutForDelivery = 8,
            

            /// <summary>
            /// Enum PickupAvailable for value: pickup_available
            /// </summary>
            [EnumMember(Value = "pickup_available")]
            PickupAvailable = 9,
            

            /// <summary>
            /// Enum Delivered for value: delivered
            /// </summary>
            [EnumMember(Value = "delivered")]
            Delivered = 10,
            

            /// <summary>
            /// Enum PackageForwarded for value: package_forwarded
            /// </summary>
            [EnumMember(Value = "package_forwarded")]
            PackageForwarded = 11,
            

            /// <summary>
            /// Enum ReturnedToSender for value: returned_to_sender
            /// </summary>
            [EnumMember(Value = "returned_to_sender")]
            ReturnedToSender = 12,
            

            /// <summary>
            /// Enum AddressIssue for value: address_issue
            /// </summary>
            [EnumMember(Value = "address_issue")]
            AddressIssue = 13,
            

            /// <summary>
            /// Enum ContactCarrier for value: contact_carrier
            /// </summary>
            [EnumMember(Value = "contact_carrier")]
            ContactCarrier = 14,
            

            /// <summary>
            /// Enum Delayed for value: delayed
            /// </summary>
            [EnumMember(Value = "delayed")]
            Delayed = 15,
            

            /// <summary>
            /// Enum DeliveryAttempted for value: delivery_attempted
            /// </summary>
            [EnumMember(Value = "delivery_attempted")]
            DeliveryAttempted = 16,
            

            /// <summary>
            /// Enum DeliveryRescheduled for value: delivery_rescheduled
            /// </summary>
            [EnumMember(Value = "delivery_rescheduled")]
            DeliveryRescheduled = 17,
            

            /// <summary>
            /// Enum LocationInaccessible for value: location_inaccessible
            /// </summary>
            [EnumMember(Value = "location_inaccessible")]
            LocationInaccessible = 18,
            

            /// <summary>
            /// Enum NoticeLeft for value: notice_left
            /// </summary>
            [EnumMember(Value = "notice_left")]
            NoticeLeft = 19,
            

            /// <summary>
            /// Enum PackageDamaged for value: package_damaged
            /// </summary>
            [EnumMember(Value = "package_damaged")]
            PackageDamaged = 20,
            

            /// <summary>
            /// Enum PackageDisposed for value: package_disposed
            /// </summary>
            [EnumMember(Value = "package_disposed")]
            PackageDisposed = 21,
            

            /// <summary>
            /// Enum PackageHeld for value: package_held
            /// </summary>
            [EnumMember(Value = "package_held")]
            PackageHeld = 22,
            

            /// <summary>
            /// Enum PackageLost for value: package_lost
            /// </summary>
            [EnumMember(Value = "package_lost")]
            PackageLost = 23,
            

            /// <summary>
            /// Enum PackageUnclaimed for value: package_unclaimed
            /// </summary>
            [EnumMember(Value = "package_unclaimed")]
            PackageUnclaimed = 24,
            

            /// <summary>
            /// Enum PackageUndeliverable for value: package_undeliverable
            /// </summary>
            [EnumMember(Value = "package_undeliverable")]
            PackageUndeliverable = 25,
            

            /// <summary>
            /// Enum RescheduleDelivery for value: reschedule_delivery
            /// </summary>
            [EnumMember(Value = "reschedule_delivery")]
            RescheduleDelivery = 26,
            

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 27
            

        }


        /// <summary>
        /// Find the full table [here](#tag/Tracking-Events). A detailed substatus about the event: * &#x60;package_accepted&#x60; - Package has been accepted into the carrier network for delivery. * &#x60;package_arrived&#x60; - Package has arrived at an intermediate location in the carrier network. * &#x60;package_departed&#x60; - Package has departed from an intermediate location in the carrier network. * &#x60;package_processing&#x60; - Package is processing at an intermediate location in the carrier network. * &#x60;package_processed&#x60; - Package has been processed at an intermediate location. * &#x60;package_in_local_area&#x60; - Package is at a location near the end destination. * &#x60;delivery_scheduled&#x60; - Package is scheduled for delivery. * &#x60;out_for_delivery&#x60; - Package is out for delivery. * &#x60;pickup_available&#x60; - Package is available for pickup at carrier location. * &#x60;delivered&#x60; - Package has been delivered. * &#x60;package_forwarded&#x60; - Package has been forwarded. * &#x60;returned_to_sender&#x60; - Package is to be returned to sender. * &#x60;address_issue&#x60; - Address information is incorrect. Contact carrier to ensure delivery. * &#x60;contact_carrier&#x60; - Contact the carrier for more information. * &#x60;delayed&#x60; - Delivery of package is delayed. * &#x60;delivery_attempted&#x60; - Delivery of package has been attempted. Contact carrier to ensure delivery. * &#x60;delivery_rescheduled&#x60; - Delivery of package has been rescheduled. * &#x60;location_inaccessible&#x60; - Delivery location inaccessible to carrier. Contact carrier to ensure delivery. * &#x60;notice_left&#x60; - Carrier left notice during attempted delivery. Follow carrier instructions on notice. * &#x60;package_damaged&#x60; - Package has been damaged. Contact carrier for more details. * &#x60;package_disposed&#x60; - Package has been disposed. * &#x60;package_held&#x60; - Package held at carrier location. Contact carrier for more details. * &#x60;package_lost&#x60; - Package has been lost. Contact carrier for more details. * &#x60;package_unclaimed&#x60; - Package is unclaimed. * &#x60;package_undeliverable&#x60; - Package is not able to be delivered. * &#x60;reschedule_delivery&#x60; - Contact carrier to reschedule delivery. * &#x60;other&#x60; - Unrecognized carrier status. 
        /// </summary>
        /// <value>Find the full table [here](#tag/Tracking-Events). A detailed substatus about the event: * &#x60;package_accepted&#x60; - Package has been accepted into the carrier network for delivery. * &#x60;package_arrived&#x60; - Package has arrived at an intermediate location in the carrier network. * &#x60;package_departed&#x60; - Package has departed from an intermediate location in the carrier network. * &#x60;package_processing&#x60; - Package is processing at an intermediate location in the carrier network. * &#x60;package_processed&#x60; - Package has been processed at an intermediate location. * &#x60;package_in_local_area&#x60; - Package is at a location near the end destination. * &#x60;delivery_scheduled&#x60; - Package is scheduled for delivery. * &#x60;out_for_delivery&#x60; - Package is out for delivery. * &#x60;pickup_available&#x60; - Package is available for pickup at carrier location. * &#x60;delivered&#x60; - Package has been delivered. * &#x60;package_forwarded&#x60; - Package has been forwarded. * &#x60;returned_to_sender&#x60; - Package is to be returned to sender. * &#x60;address_issue&#x60; - Address information is incorrect. Contact carrier to ensure delivery. * &#x60;contact_carrier&#x60; - Contact the carrier for more information. * &#x60;delayed&#x60; - Delivery of package is delayed. * &#x60;delivery_attempted&#x60; - Delivery of package has been attempted. Contact carrier to ensure delivery. * &#x60;delivery_rescheduled&#x60; - Delivery of package has been rescheduled. * &#x60;location_inaccessible&#x60; - Delivery location inaccessible to carrier. Contact carrier to ensure delivery. * &#x60;notice_left&#x60; - Carrier left notice during attempted delivery. Follow carrier instructions on notice. * &#x60;package_damaged&#x60; - Package has been damaged. Contact carrier for more details. * &#x60;package_disposed&#x60; - Package has been disposed. * &#x60;package_held&#x60; - Package held at carrier location. Contact carrier for more details. * &#x60;package_lost&#x60; - Package has been lost. Contact carrier for more details. * &#x60;package_unclaimed&#x60; - Package is unclaimed. * &#x60;package_undeliverable&#x60; - Package is not able to be delivered. * &#x60;reschedule_delivery&#x60; - Contact carrier to reschedule delivery. * &#x60;other&#x60; - Unrecognized carrier status. </value>
        [DataMember(Name = "event", IsRequired = true, EmitDefaultValue = false)]
        public EventEnum Event { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingEventDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrackingEventDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingEventDetails" /> class.
        /// </summary>
        /// <param name="_event">Find the full table [here](#tag/Tracking-Events). A detailed substatus about the event: * &#x60;package_accepted&#x60; - Package has been accepted into the carrier network for delivery. * &#x60;package_arrived&#x60; - Package has arrived at an intermediate location in the carrier network. * &#x60;package_departed&#x60; - Package has departed from an intermediate location in the carrier network. * &#x60;package_processing&#x60; - Package is processing at an intermediate location in the carrier network. * &#x60;package_processed&#x60; - Package has been processed at an intermediate location. * &#x60;package_in_local_area&#x60; - Package is at a location near the end destination. * &#x60;delivery_scheduled&#x60; - Package is scheduled for delivery. * &#x60;out_for_delivery&#x60; - Package is out for delivery. * &#x60;pickup_available&#x60; - Package is available for pickup at carrier location. * &#x60;delivered&#x60; - Package has been delivered. * &#x60;package_forwarded&#x60; - Package has been forwarded. * &#x60;returned_to_sender&#x60; - Package is to be returned to sender. * &#x60;address_issue&#x60; - Address information is incorrect. Contact carrier to ensure delivery. * &#x60;contact_carrier&#x60; - Contact the carrier for more information. * &#x60;delayed&#x60; - Delivery of package is delayed. * &#x60;delivery_attempted&#x60; - Delivery of package has been attempted. Contact carrier to ensure delivery. * &#x60;delivery_rescheduled&#x60; - Delivery of package has been rescheduled. * &#x60;location_inaccessible&#x60; - Delivery location inaccessible to carrier. Contact carrier to ensure delivery. * &#x60;notice_left&#x60; - Carrier left notice during attempted delivery. Follow carrier instructions on notice. * &#x60;package_damaged&#x60; - Package has been damaged. Contact carrier for more details. * &#x60;package_disposed&#x60; - Package has been disposed. * &#x60;package_held&#x60; - Package held at carrier location. Contact carrier for more details. * &#x60;package_lost&#x60; - Package has been lost. Contact carrier for more details. * &#x60;package_unclaimed&#x60; - Package is unclaimed. * &#x60;package_undeliverable&#x60; - Package is not able to be delivered. * &#x60;reschedule_delivery&#x60; - Contact carrier to reschedule delivery. * &#x60;other&#x60; - Unrecognized carrier status.  (required).</param>
        /// <param name="description">The description as listed in the description for event. (required).</param>
        /// <param name="notes">Event-specific notes from USPS about the tracking event..</param>
        /// <param name="actionRequired">&#x60;true&#x60; if action is required by the end recipient, &#x60;false&#x60; otherwise.  (required).</param>
        public TrackingEventDetails(EventEnum _event = default(EventEnum), string description = default(string), string notes = default(string), bool actionRequired = default(bool))
        {
            this.Event = _event;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for TrackingEventDetails and cannot be null");
            }
            this.Description = description;
            this.ActionRequired = actionRequired;
            this.Notes = notes;
        }

        /// <summary>
        /// The description as listed in the description for event.
        /// </summary>
        /// <value>The description as listed in the description for event.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Event-specific notes from USPS about the tracking event.
        /// </summary>
        /// <value>Event-specific notes from USPS about the tracking event.</value>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// &#x60;true&#x60; if action is required by the end recipient, &#x60;false&#x60; otherwise. 
        /// </summary>
        /// <value>&#x60;true&#x60; if action is required by the end recipient, &#x60;false&#x60; otherwise. </value>
        [DataMember(Name = "action_required", IsRequired = true, EmitDefaultValue = false)]
        public bool ActionRequired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackingEventDetails {\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  ActionRequired: ").Append(ActionRequired).Append("\n");
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
            return this.Equals(input as TrackingEventDetails);
        }

        /// <summary>
        /// Returns true if TrackingEventDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackingEventDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingEventDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Event == input.Event ||
                    this.Event.Equals(input.Event)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.ActionRequired == input.ActionRequired ||
                    this.ActionRequired.Equals(input.ActionRequired)
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
                hashCode = (hashCode * 59) + this.Event.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ActionRequired.GetHashCode();
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
