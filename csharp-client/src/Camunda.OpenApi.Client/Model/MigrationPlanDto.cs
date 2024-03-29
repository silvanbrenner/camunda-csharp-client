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
    /// MigrationPlanDto
    /// </summary>
    [DataContract(Name = "MigrationPlanDto")]
    public partial class MigrationPlanDto : IEquatable<MigrationPlanDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationPlanDto" /> class.
        /// </summary>
        /// <param name="sourceProcessDefinitionId">The id of the source process definition for the migration..</param>
        /// <param name="targetProcessDefinitionId">The id of the target process definition for the migration..</param>
        /// <param name="instructions">A list of migration instructions which map equal activities. Each migration instruction is a JSON object with the following properties:.</param>
        /// <param name="variables">A map of variables which will be set into the process instances&#39; scope. Each key is a variable name and each value a JSON variable value object..</param>
        public MigrationPlanDto(string sourceProcessDefinitionId = default(string), string targetProcessDefinitionId = default(string), List<MigrationInstructionDto> instructions = default(List<MigrationInstructionDto>), Dictionary<string, VariableValueDto> variables = default(Dictionary<string, VariableValueDto>))
        {
            this.SourceProcessDefinitionId = sourceProcessDefinitionId;
            this.TargetProcessDefinitionId = targetProcessDefinitionId;
            this.Instructions = instructions;
            this.Variables = variables;
        }

        /// <summary>
        /// The id of the source process definition for the migration.
        /// </summary>
        /// <value>The id of the source process definition for the migration.</value>
        [DataMember(Name = "sourceProcessDefinitionId", EmitDefaultValue = true)]
        public string SourceProcessDefinitionId { get; set; }

        /// <summary>
        /// The id of the target process definition for the migration.
        /// </summary>
        /// <value>The id of the target process definition for the migration.</value>
        [DataMember(Name = "targetProcessDefinitionId", EmitDefaultValue = true)]
        public string TargetProcessDefinitionId { get; set; }

        /// <summary>
        /// A list of migration instructions which map equal activities. Each migration instruction is a JSON object with the following properties:
        /// </summary>
        /// <value>A list of migration instructions which map equal activities. Each migration instruction is a JSON object with the following properties:</value>
        [DataMember(Name = "instructions", EmitDefaultValue = true)]
        public List<MigrationInstructionDto> Instructions { get; set; }

        /// <summary>
        /// A map of variables which will be set into the process instances&#39; scope. Each key is a variable name and each value a JSON variable value object.
        /// </summary>
        /// <value>A map of variables which will be set into the process instances&#39; scope. Each key is a variable name and each value a JSON variable value object.</value>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> Variables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationPlanDto {\n");
            sb.Append("  SourceProcessDefinitionId: ").Append(SourceProcessDefinitionId).Append("\n");
            sb.Append("  TargetProcessDefinitionId: ").Append(TargetProcessDefinitionId).Append("\n");
            sb.Append("  Instructions: ").Append(Instructions).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
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
            return this.Equals(input as MigrationPlanDto);
        }

        /// <summary>
        /// Returns true if MigrationPlanDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MigrationPlanDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MigrationPlanDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceProcessDefinitionId == input.SourceProcessDefinitionId ||
                    (this.SourceProcessDefinitionId != null &&
                    this.SourceProcessDefinitionId.Equals(input.SourceProcessDefinitionId))
                ) && 
                (
                    this.TargetProcessDefinitionId == input.TargetProcessDefinitionId ||
                    (this.TargetProcessDefinitionId != null &&
                    this.TargetProcessDefinitionId.Equals(input.TargetProcessDefinitionId))
                ) && 
                (
                    this.Instructions == input.Instructions ||
                    this.Instructions != null &&
                    input.Instructions != null &&
                    this.Instructions.SequenceEqual(input.Instructions)
                ) && 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    input.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
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
                if (this.SourceProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.SourceProcessDefinitionId.GetHashCode();
                if (this.TargetProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.TargetProcessDefinitionId.GetHashCode();
                if (this.Instructions != null)
                    hashCode = hashCode * 59 + this.Instructions.GetHashCode();
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
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
