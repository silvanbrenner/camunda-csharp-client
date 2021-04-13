/*
 * Camunda Platform REST API
 *
 * OpenApi Spec for Camunda Platform REST API.
 *
 * The version of the OpenAPI document: 7.15.0
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
using OpenAPIDateConverter = Camunda.OpenApi.Client.Client.OpenAPIDateConverter;

namespace Camunda.OpenApi.Client.Model
{
    /// <summary>
    /// StartProcessInstanceDto
    /// </summary>
    [DataContract(Name = "StartProcessInstanceDto")]
    public partial class StartProcessInstanceDto : IEquatable<StartProcessInstanceDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartProcessInstanceDto" /> class.
        /// </summary>
        /// <param name="businessKey">The business key of the process instance..</param>
        /// <param name="variables">variables.</param>
        /// <param name="caseInstanceId">The case instance id the process instance is to be initialized with..</param>
        /// <param name="startInstructions">**Optional**. A JSON array of instructions that specify which activities to start the process instance at. If this property is omitted, the process instance starts at its default blank start event..</param>
        /// <param name="skipCustomListeners">Skip execution listener invocation for activities that are started or ended as part of this request. **Note**: This option is currently only respected when start instructions are submitted via the &#x60;startInstructions&#x60; property..</param>
        /// <param name="skipIoMappings">Skip execution of [input/output variable mappings](https://docs.camunda.org/manual/7.15/user-guide/process-engine/variables/#input-output-variable-mapping) for activities that are started or ended as part of this request. **Note**: This option is currently only respected when start instructions are submitted via the &#x60;startInstructions&#x60; property..</param>
        /// <param name="withVariablesInReturn">Indicates if the variables, which was used by the process instance during execution, should be returned. Default value: &#x60;false&#x60;.</param>
        public StartProcessInstanceDto(string businessKey = default(string), Dictionary<string, VariableValueDto> variables = default(Dictionary<string, VariableValueDto>), string caseInstanceId = default(string), List<ProcessInstanceModificationInstructionDto> startInstructions = default(List<ProcessInstanceModificationInstructionDto>), bool? skipCustomListeners = default(bool?), bool? skipIoMappings = default(bool?), bool? withVariablesInReturn = default(bool?))
        {
            this.BusinessKey = businessKey;
            this.Variables = variables;
            this.CaseInstanceId = caseInstanceId;
            this.StartInstructions = startInstructions;
            this.SkipCustomListeners = skipCustomListeners;
            this.SkipIoMappings = skipIoMappings;
            this.WithVariablesInReturn = withVariablesInReturn;
        }

        /// <summary>
        /// The business key of the process instance.
        /// </summary>
        /// <value>The business key of the process instance.</value>
        [DataMember(Name = "businessKey", EmitDefaultValue = true)]
        public string BusinessKey { get; set; }

        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> Variables { get; set; }

        /// <summary>
        /// The case instance id the process instance is to be initialized with.
        /// </summary>
        /// <value>The case instance id the process instance is to be initialized with.</value>
        [DataMember(Name = "caseInstanceId", EmitDefaultValue = true)]
        public string CaseInstanceId { get; set; }

        /// <summary>
        /// **Optional**. A JSON array of instructions that specify which activities to start the process instance at. If this property is omitted, the process instance starts at its default blank start event.
        /// </summary>
        /// <value>**Optional**. A JSON array of instructions that specify which activities to start the process instance at. If this property is omitted, the process instance starts at its default blank start event.</value>
        [DataMember(Name = "startInstructions", EmitDefaultValue = true)]
        public List<ProcessInstanceModificationInstructionDto> StartInstructions { get; set; }

        /// <summary>
        /// Skip execution listener invocation for activities that are started or ended as part of this request. **Note**: This option is currently only respected when start instructions are submitted via the &#x60;startInstructions&#x60; property.
        /// </summary>
        /// <value>Skip execution listener invocation for activities that are started or ended as part of this request. **Note**: This option is currently only respected when start instructions are submitted via the &#x60;startInstructions&#x60; property.</value>
        [DataMember(Name = "skipCustomListeners", EmitDefaultValue = true)]
        public bool? SkipCustomListeners { get; set; }

        /// <summary>
        /// Skip execution of [input/output variable mappings](https://docs.camunda.org/manual/7.15/user-guide/process-engine/variables/#input-output-variable-mapping) for activities that are started or ended as part of this request. **Note**: This option is currently only respected when start instructions are submitted via the &#x60;startInstructions&#x60; property.
        /// </summary>
        /// <value>Skip execution of [input/output variable mappings](https://docs.camunda.org/manual/7.15/user-guide/process-engine/variables/#input-output-variable-mapping) for activities that are started or ended as part of this request. **Note**: This option is currently only respected when start instructions are submitted via the &#x60;startInstructions&#x60; property.</value>
        [DataMember(Name = "skipIoMappings", EmitDefaultValue = true)]
        public bool? SkipIoMappings { get; set; }

        /// <summary>
        /// Indicates if the variables, which was used by the process instance during execution, should be returned. Default value: &#x60;false&#x60;
        /// </summary>
        /// <value>Indicates if the variables, which was used by the process instance during execution, should be returned. Default value: &#x60;false&#x60;</value>
        [DataMember(Name = "withVariablesInReturn", EmitDefaultValue = true)]
        public bool? WithVariablesInReturn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartProcessInstanceDto {\n");
            sb.Append("  BusinessKey: ").Append(BusinessKey).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  CaseInstanceId: ").Append(CaseInstanceId).Append("\n");
            sb.Append("  StartInstructions: ").Append(StartInstructions).Append("\n");
            sb.Append("  SkipCustomListeners: ").Append(SkipCustomListeners).Append("\n");
            sb.Append("  SkipIoMappings: ").Append(SkipIoMappings).Append("\n");
            sb.Append("  WithVariablesInReturn: ").Append(WithVariablesInReturn).Append("\n");
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
            return this.Equals(input as StartProcessInstanceDto);
        }

        /// <summary>
        /// Returns true if StartProcessInstanceDto instances are equal
        /// </summary>
        /// <param name="input">Instance of StartProcessInstanceDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartProcessInstanceDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusinessKey == input.BusinessKey ||
                    (this.BusinessKey != null &&
                    this.BusinessKey.Equals(input.BusinessKey))
                ) && 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    input.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
                ) && 
                (
                    this.CaseInstanceId == input.CaseInstanceId ||
                    (this.CaseInstanceId != null &&
                    this.CaseInstanceId.Equals(input.CaseInstanceId))
                ) && 
                (
                    this.StartInstructions == input.StartInstructions ||
                    this.StartInstructions != null &&
                    input.StartInstructions != null &&
                    this.StartInstructions.SequenceEqual(input.StartInstructions)
                ) && 
                (
                    this.SkipCustomListeners == input.SkipCustomListeners ||
                    (this.SkipCustomListeners != null &&
                    this.SkipCustomListeners.Equals(input.SkipCustomListeners))
                ) && 
                (
                    this.SkipIoMappings == input.SkipIoMappings ||
                    (this.SkipIoMappings != null &&
                    this.SkipIoMappings.Equals(input.SkipIoMappings))
                ) && 
                (
                    this.WithVariablesInReturn == input.WithVariablesInReturn ||
                    (this.WithVariablesInReturn != null &&
                    this.WithVariablesInReturn.Equals(input.WithVariablesInReturn))
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
                if (this.BusinessKey != null)
                    hashCode = hashCode * 59 + this.BusinessKey.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.CaseInstanceId != null)
                    hashCode = hashCode * 59 + this.CaseInstanceId.GetHashCode();
                if (this.StartInstructions != null)
                    hashCode = hashCode * 59 + this.StartInstructions.GetHashCode();
                if (this.SkipCustomListeners != null)
                    hashCode = hashCode * 59 + this.SkipCustomListeners.GetHashCode();
                if (this.SkipIoMappings != null)
                    hashCode = hashCode * 59 + this.SkipIoMappings.GetHashCode();
                if (this.WithVariablesInReturn != null)
                    hashCode = hashCode * 59 + this.WithVariablesInReturn.GetHashCode();
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
