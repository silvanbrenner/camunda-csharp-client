/*
 * Camunda Platform REST API
 *
 * OpenApi Spec for Camunda Platform REST API.
 *
 * The version of the OpenAPI document: 7.17.0
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
using FileParameter = Camunda.OpenApi.Client.Client.FileParameter;
using OpenAPIDateConverter = Camunda.OpenApi.Client.Client.OpenAPIDateConverter;

namespace Camunda.OpenApi.Client.Model
{
    /// <summary>
    /// ProcessInstanceModificationInstructionDto
    /// </summary>
    [DataContract(Name = "ProcessInstanceModificationInstructionDto")]
    public partial class ProcessInstanceModificationInstructionDto : IEquatable<ProcessInstanceModificationInstructionDto>, IValidatableObject
    {
        /// <summary>
        /// **Mandatory**. One of the following values: &#x60;cancel&#x60;, &#x60;startBeforeActivity&#x60;, &#x60;startAfterActivity&#x60;, &#x60;startTransition&#x60;.  * A cancel instruction requests cancellation of a single activity instance or all instances of one activity. * A startBeforeActivity instruction requests to enter a given activity. * A startAfterActivity instruction requests to execute the single outgoing sequence flow of a given activity. * A startTransition instruction requests to execute a specific sequence flow.
        /// </summary>
        /// <value>**Mandatory**. One of the following values: &#x60;cancel&#x60;, &#x60;startBeforeActivity&#x60;, &#x60;startAfterActivity&#x60;, &#x60;startTransition&#x60;.  * A cancel instruction requests cancellation of a single activity instance or all instances of one activity. * A startBeforeActivity instruction requests to enter a given activity. * A startAfterActivity instruction requests to execute the single outgoing sequence flow of a given activity. * A startTransition instruction requests to execute a specific sequence flow.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Cancel for value: cancel
            /// </summary>
            [EnumMember(Value = "cancel")]
            Cancel = 1,

            /// <summary>
            /// Enum StartBeforeActivity for value: startBeforeActivity
            /// </summary>
            [EnumMember(Value = "startBeforeActivity")]
            StartBeforeActivity = 2,

            /// <summary>
            /// Enum StartAfterActivity for value: startAfterActivity
            /// </summary>
            [EnumMember(Value = "startAfterActivity")]
            StartAfterActivity = 3,

            /// <summary>
            /// Enum StartTransition for value: startTransition
            /// </summary>
            [EnumMember(Value = "startTransition")]
            StartTransition = 4

        }


        /// <summary>
        /// **Mandatory**. One of the following values: &#x60;cancel&#x60;, &#x60;startBeforeActivity&#x60;, &#x60;startAfterActivity&#x60;, &#x60;startTransition&#x60;.  * A cancel instruction requests cancellation of a single activity instance or all instances of one activity. * A startBeforeActivity instruction requests to enter a given activity. * A startAfterActivity instruction requests to execute the single outgoing sequence flow of a given activity. * A startTransition instruction requests to execute a specific sequence flow.
        /// </summary>
        /// <value>**Mandatory**. One of the following values: &#x60;cancel&#x60;, &#x60;startBeforeActivity&#x60;, &#x60;startAfterActivity&#x60;, &#x60;startTransition&#x60;.  * A cancel instruction requests cancellation of a single activity instance or all instances of one activity. * A startBeforeActivity instruction requests to enter a given activity. * A startAfterActivity instruction requests to execute the single outgoing sequence flow of a given activity. * A startTransition instruction requests to execute a specific sequence flow.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessInstanceModificationInstructionDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProcessInstanceModificationInstructionDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessInstanceModificationInstructionDto" /> class.
        /// </summary>
        /// <param name="type">**Mandatory**. One of the following values: &#x60;cancel&#x60;, &#x60;startBeforeActivity&#x60;, &#x60;startAfterActivity&#x60;, &#x60;startTransition&#x60;.  * A cancel instruction requests cancellation of a single activity instance or all instances of one activity. * A startBeforeActivity instruction requests to enter a given activity. * A startAfterActivity instruction requests to execute the single outgoing sequence flow of a given activity. * A startTransition instruction requests to execute a specific sequence flow. (required).</param>
        /// <param name="variables">variables.</param>
        /// <param name="activityId">Can be used with instructions of types &#x60;startTransition&#x60;. Specifies the sequence flow to start..</param>
        /// <param name="transitionId">Can be used with instructions of types &#x60;startTransition&#x60;. Specifies the sequence flow to start..</param>
        /// <param name="activityInstanceId">Can be used with instructions of type &#x60;cancel&#x60;. Specifies the activity instance to cancel. Valid values are the activity instance IDs supplied by the [Get Activity Instance request](https://docs.camunda.org/manual/7.17/reference/rest/process-instance/get-activity-instances/)..</param>
        /// <param name="transitionInstanceId">Can be used with instructions of type &#x60;cancel&#x60;. Specifies the transition instance to cancel. Valid values are the transition instance IDs supplied by the [Get Activity Instance request](https://docs.camunda.org/manual/7.17/reference/rest/process-instance/get-activity-instances/)..</param>
        /// <param name="ancestorActivityInstanceId">Can be used with instructions of type &#x60;startBeforeActivity&#x60;, &#x60;startAfterActivity&#x60;, and &#x60;startTransition&#x60;. Valid values are the activity instance IDs supplied by the Get Activity Instance request. If there are multiple parent activity instances of the targeted activity, this specifies the ancestor scope in which hierarchy the activity/transition is to be instantiated.  Example: When there are two instances of a subprocess and an activity contained in the subprocess is to be started, this parameter allows to specifiy under which subprocess instance the activity should be started..</param>
        /// <param name="cancelCurrentActiveActivityInstances">Can be used with instructions of type cancel. Prevents the deletion of new created activity instances..</param>
        public ProcessInstanceModificationInstructionDto(TypeEnum type = default(TypeEnum), TriggerVariableValueDto variables = default(TriggerVariableValueDto), string activityId = default(string), string transitionId = default(string), string activityInstanceId = default(string), string transitionInstanceId = default(string), string ancestorActivityInstanceId = default(string), bool? cancelCurrentActiveActivityInstances = default(bool?))
        {
            this.Type = type;
            this.Variables = variables;
            this.ActivityId = activityId;
            this.TransitionId = transitionId;
            this.ActivityInstanceId = activityInstanceId;
            this.TransitionInstanceId = transitionInstanceId;
            this.AncestorActivityInstanceId = ancestorActivityInstanceId;
            this.CancelCurrentActiveActivityInstances = cancelCurrentActiveActivityInstances;
        }

        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name = "variables", EmitDefaultValue = false)]
        public TriggerVariableValueDto Variables { get; set; }

        /// <summary>
        /// Can be used with instructions of types &#x60;startTransition&#x60;. Specifies the sequence flow to start.
        /// </summary>
        /// <value>Can be used with instructions of types &#x60;startTransition&#x60;. Specifies the sequence flow to start.</value>
        [DataMember(Name = "activityId", EmitDefaultValue = true)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Can be used with instructions of types &#x60;startTransition&#x60;. Specifies the sequence flow to start.
        /// </summary>
        /// <value>Can be used with instructions of types &#x60;startTransition&#x60;. Specifies the sequence flow to start.</value>
        [DataMember(Name = "transitionId", EmitDefaultValue = true)]
        public string TransitionId { get; set; }

        /// <summary>
        /// Can be used with instructions of type &#x60;cancel&#x60;. Specifies the activity instance to cancel. Valid values are the activity instance IDs supplied by the [Get Activity Instance request](https://docs.camunda.org/manual/7.17/reference/rest/process-instance/get-activity-instances/).
        /// </summary>
        /// <value>Can be used with instructions of type &#x60;cancel&#x60;. Specifies the activity instance to cancel. Valid values are the activity instance IDs supplied by the [Get Activity Instance request](https://docs.camunda.org/manual/7.17/reference/rest/process-instance/get-activity-instances/).</value>
        [DataMember(Name = "activityInstanceId", EmitDefaultValue = true)]
        public string ActivityInstanceId { get; set; }

        /// <summary>
        /// Can be used with instructions of type &#x60;cancel&#x60;. Specifies the transition instance to cancel. Valid values are the transition instance IDs supplied by the [Get Activity Instance request](https://docs.camunda.org/manual/7.17/reference/rest/process-instance/get-activity-instances/).
        /// </summary>
        /// <value>Can be used with instructions of type &#x60;cancel&#x60;. Specifies the transition instance to cancel. Valid values are the transition instance IDs supplied by the [Get Activity Instance request](https://docs.camunda.org/manual/7.17/reference/rest/process-instance/get-activity-instances/).</value>
        [DataMember(Name = "transitionInstanceId", EmitDefaultValue = true)]
        public string TransitionInstanceId { get; set; }

        /// <summary>
        /// Can be used with instructions of type &#x60;startBeforeActivity&#x60;, &#x60;startAfterActivity&#x60;, and &#x60;startTransition&#x60;. Valid values are the activity instance IDs supplied by the Get Activity Instance request. If there are multiple parent activity instances of the targeted activity, this specifies the ancestor scope in which hierarchy the activity/transition is to be instantiated.  Example: When there are two instances of a subprocess and an activity contained in the subprocess is to be started, this parameter allows to specifiy under which subprocess instance the activity should be started.
        /// </summary>
        /// <value>Can be used with instructions of type &#x60;startBeforeActivity&#x60;, &#x60;startAfterActivity&#x60;, and &#x60;startTransition&#x60;. Valid values are the activity instance IDs supplied by the Get Activity Instance request. If there are multiple parent activity instances of the targeted activity, this specifies the ancestor scope in which hierarchy the activity/transition is to be instantiated.  Example: When there are two instances of a subprocess and an activity contained in the subprocess is to be started, this parameter allows to specifiy under which subprocess instance the activity should be started.</value>
        [DataMember(Name = "ancestorActivityInstanceId", EmitDefaultValue = true)]
        public string AncestorActivityInstanceId { get; set; }

        /// <summary>
        /// Can be used with instructions of type cancel. Prevents the deletion of new created activity instances.
        /// </summary>
        /// <value>Can be used with instructions of type cancel. Prevents the deletion of new created activity instances.</value>
        [DataMember(Name = "cancelCurrentActiveActivityInstances", EmitDefaultValue = true)]
        public bool? CancelCurrentActiveActivityInstances { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessInstanceModificationInstructionDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  TransitionId: ").Append(TransitionId).Append("\n");
            sb.Append("  ActivityInstanceId: ").Append(ActivityInstanceId).Append("\n");
            sb.Append("  TransitionInstanceId: ").Append(TransitionInstanceId).Append("\n");
            sb.Append("  AncestorActivityInstanceId: ").Append(AncestorActivityInstanceId).Append("\n");
            sb.Append("  CancelCurrentActiveActivityInstances: ").Append(CancelCurrentActiveActivityInstances).Append("\n");
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
            return this.Equals(input as ProcessInstanceModificationInstructionDto);
        }

        /// <summary>
        /// Returns true if ProcessInstanceModificationInstructionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessInstanceModificationInstructionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessInstanceModificationInstructionDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Variables == input.Variables ||
                    (this.Variables != null &&
                    this.Variables.Equals(input.Variables))
                ) && 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.TransitionId == input.TransitionId ||
                    (this.TransitionId != null &&
                    this.TransitionId.Equals(input.TransitionId))
                ) && 
                (
                    this.ActivityInstanceId == input.ActivityInstanceId ||
                    (this.ActivityInstanceId != null &&
                    this.ActivityInstanceId.Equals(input.ActivityInstanceId))
                ) && 
                (
                    this.TransitionInstanceId == input.TransitionInstanceId ||
                    (this.TransitionInstanceId != null &&
                    this.TransitionInstanceId.Equals(input.TransitionInstanceId))
                ) && 
                (
                    this.AncestorActivityInstanceId == input.AncestorActivityInstanceId ||
                    (this.AncestorActivityInstanceId != null &&
                    this.AncestorActivityInstanceId.Equals(input.AncestorActivityInstanceId))
                ) && 
                (
                    this.CancelCurrentActiveActivityInstances == input.CancelCurrentActiveActivityInstances ||
                    (this.CancelCurrentActiveActivityInstances != null &&
                    this.CancelCurrentActiveActivityInstances.Equals(input.CancelCurrentActiveActivityInstances))
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.ActivityId != null)
                    hashCode = hashCode * 59 + this.ActivityId.GetHashCode();
                if (this.TransitionId != null)
                    hashCode = hashCode * 59 + this.TransitionId.GetHashCode();
                if (this.ActivityInstanceId != null)
                    hashCode = hashCode * 59 + this.ActivityInstanceId.GetHashCode();
                if (this.TransitionInstanceId != null)
                    hashCode = hashCode * 59 + this.TransitionInstanceId.GetHashCode();
                if (this.AncestorActivityInstanceId != null)
                    hashCode = hashCode * 59 + this.AncestorActivityInstanceId.GetHashCode();
                if (this.CancelCurrentActiveActivityInstances != null)
                    hashCode = hashCode * 59 + this.CancelCurrentActiveActivityInstances.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
