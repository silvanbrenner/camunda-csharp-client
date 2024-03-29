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
    /// A variable instance query which defines a list of variable instances
    /// </summary>
    [DataContract(Name = "VariableInstanceQueryDto")]
    public partial class VariableInstanceQueryDto : IEquatable<VariableInstanceQueryDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableInstanceQueryDto" /> class.
        /// </summary>
        /// <param name="variableName">Filter by variable instance name..</param>
        /// <param name="variableNameLike">Filter by the variable instance name. The parameter can include the wildcard &#x60;%&#x60; to express like-strategy such as: starts with (&#x60;%&#x60;name), ends with (name&#x60;%&#x60;) or contains (&#x60;%&#x60;name&#x60;%&#x60;)..</param>
        /// <param name="processInstanceIdIn">Only include variable instances which belong to one of the passed  process instance ids..</param>
        /// <param name="executionIdIn">Only include variable instances which belong to one of the passed  execution ids..</param>
        /// <param name="caseInstanceIdIn">Only include variable instances which belong to one of the passed  case instance ids..</param>
        /// <param name="caseExecutionIdIn">Only include variable instances which belong to one of the passed  case execution ids..</param>
        /// <param name="taskIdIn">Only include variable instances which belong to one of the passed  task ids..</param>
        /// <param name="batchIdIn">Only include variable instances which belong to one of the passed  batch ids..</param>
        /// <param name="activityInstanceIdIn">Only include variable instances which belong to one of the passed  activity instance ids..</param>
        /// <param name="tenantIdIn">Only include variable instances which belong to one of the passed  tenant ids..</param>
        /// <param name="variableValues">An array to only include variable instances that have the certain values. The array consists of objects with the three properties &#x60;name&#x60;, &#x60;operator&#x60; and &#x60;value&#x60;. &#x60;name (String)&#x60; is the variable name, &#x60;operator (String)&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. &#x60;value&#x60; may be &#x60;String&#x60;, &#x60;Number&#x60; or &#x60;Boolean&#x60;.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;.</param>
        /// <param name="variableNamesIgnoreCase">Match all variable names provided in &#x60;variableValues&#x60; case-insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal..</param>
        /// <param name="variableValuesIgnoreCase">Match all variable values provided in &#x60;variableValues&#x60; case-insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal..</param>
        /// <param name="variableScopeIdIn">Only include variable instances which belong to one of passed scope ids..</param>
        /// <param name="sorting">An array of criteria to sort the result by. Each element of the array is an object that specifies one ordering.                       The position in the array identifies the rank of an ordering, i.e., whether it is primary, secondary, etc.                       Sorting has no effect for &#x60;count&#x60; endpoints.</param>
        public VariableInstanceQueryDto(string variableName = default(string), string variableNameLike = default(string), List<string> processInstanceIdIn = default(List<string>), List<string> executionIdIn = default(List<string>), List<string> caseInstanceIdIn = default(List<string>), List<string> caseExecutionIdIn = default(List<string>), List<string> taskIdIn = default(List<string>), List<string> batchIdIn = default(List<string>), List<string> activityInstanceIdIn = default(List<string>), List<string> tenantIdIn = default(List<string>), List<VariableQueryParameterDto> variableValues = default(List<VariableQueryParameterDto>), bool? variableNamesIgnoreCase = default(bool?), bool? variableValuesIgnoreCase = default(bool?), List<string> variableScopeIdIn = default(List<string>), List<VariableInstanceQueryDtoSorting> sorting = default(List<VariableInstanceQueryDtoSorting>))
        {
            this.VariableName = variableName;
            this.VariableNameLike = variableNameLike;
            this.ProcessInstanceIdIn = processInstanceIdIn;
            this.ExecutionIdIn = executionIdIn;
            this.CaseInstanceIdIn = caseInstanceIdIn;
            this.CaseExecutionIdIn = caseExecutionIdIn;
            this.TaskIdIn = taskIdIn;
            this.BatchIdIn = batchIdIn;
            this.ActivityInstanceIdIn = activityInstanceIdIn;
            this.TenantIdIn = tenantIdIn;
            this.VariableValues = variableValues;
            this.VariableNamesIgnoreCase = variableNamesIgnoreCase;
            this.VariableValuesIgnoreCase = variableValuesIgnoreCase;
            this.VariableScopeIdIn = variableScopeIdIn;
            this.Sorting = sorting;
        }

        /// <summary>
        /// Filter by variable instance name.
        /// </summary>
        /// <value>Filter by variable instance name.</value>
        [DataMember(Name = "variableName", EmitDefaultValue = true)]
        public string VariableName { get; set; }

        /// <summary>
        /// Filter by the variable instance name. The parameter can include the wildcard &#x60;%&#x60; to express like-strategy such as: starts with (&#x60;%&#x60;name), ends with (name&#x60;%&#x60;) or contains (&#x60;%&#x60;name&#x60;%&#x60;).
        /// </summary>
        /// <value>Filter by the variable instance name. The parameter can include the wildcard &#x60;%&#x60; to express like-strategy such as: starts with (&#x60;%&#x60;name), ends with (name&#x60;%&#x60;) or contains (&#x60;%&#x60;name&#x60;%&#x60;).</value>
        [DataMember(Name = "variableNameLike", EmitDefaultValue = true)]
        public string VariableNameLike { get; set; }

        /// <summary>
        /// Only include variable instances which belong to one of the passed  process instance ids.
        /// </summary>
        /// <value>Only include variable instances which belong to one of the passed  process instance ids.</value>
        [DataMember(Name = "processInstanceIdIn", EmitDefaultValue = true)]
        public List<string> ProcessInstanceIdIn { get; set; }

        /// <summary>
        /// Only include variable instances which belong to one of the passed  execution ids.
        /// </summary>
        /// <value>Only include variable instances which belong to one of the passed  execution ids.</value>
        [DataMember(Name = "executionIdIn", EmitDefaultValue = true)]
        public List<string> ExecutionIdIn { get; set; }

        /// <summary>
        /// Only include variable instances which belong to one of the passed  case instance ids.
        /// </summary>
        /// <value>Only include variable instances which belong to one of the passed  case instance ids.</value>
        [DataMember(Name = "caseInstanceIdIn", EmitDefaultValue = true)]
        public List<string> CaseInstanceIdIn { get; set; }

        /// <summary>
        /// Only include variable instances which belong to one of the passed  case execution ids.
        /// </summary>
        /// <value>Only include variable instances which belong to one of the passed  case execution ids.</value>
        [DataMember(Name = "caseExecutionIdIn", EmitDefaultValue = true)]
        public List<string> CaseExecutionIdIn { get; set; }

        /// <summary>
        /// Only include variable instances which belong to one of the passed  task ids.
        /// </summary>
        /// <value>Only include variable instances which belong to one of the passed  task ids.</value>
        [DataMember(Name = "taskIdIn", EmitDefaultValue = true)]
        public List<string> TaskIdIn { get; set; }

        /// <summary>
        /// Only include variable instances which belong to one of the passed  batch ids.
        /// </summary>
        /// <value>Only include variable instances which belong to one of the passed  batch ids.</value>
        [DataMember(Name = "batchIdIn", EmitDefaultValue = true)]
        public List<string> BatchIdIn { get; set; }

        /// <summary>
        /// Only include variable instances which belong to one of the passed  activity instance ids.
        /// </summary>
        /// <value>Only include variable instances which belong to one of the passed  activity instance ids.</value>
        [DataMember(Name = "activityInstanceIdIn", EmitDefaultValue = true)]
        public List<string> ActivityInstanceIdIn { get; set; }

        /// <summary>
        /// Only include variable instances which belong to one of the passed  tenant ids.
        /// </summary>
        /// <value>Only include variable instances which belong to one of the passed  tenant ids.</value>
        [DataMember(Name = "tenantIdIn", EmitDefaultValue = true)]
        public List<string> TenantIdIn { get; set; }

        /// <summary>
        /// An array to only include variable instances that have the certain values. The array consists of objects with the three properties &#x60;name&#x60;, &#x60;operator&#x60; and &#x60;value&#x60;. &#x60;name (String)&#x60; is the variable name, &#x60;operator (String)&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. &#x60;value&#x60; may be &#x60;String&#x60;, &#x60;Number&#x60; or &#x60;Boolean&#x60;.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;
        /// </summary>
        /// <value>An array to only include variable instances that have the certain values. The array consists of objects with the three properties &#x60;name&#x60;, &#x60;operator&#x60; and &#x60;value&#x60;. &#x60;name (String)&#x60; is the variable name, &#x60;operator (String)&#x60; is the comparison operator to be used and &#x60;value&#x60; the variable value. &#x60;value&#x60; may be &#x60;String&#x60;, &#x60;Number&#x60; or &#x60;Boolean&#x60;.  Valid operator values are: &#x60;eq&#x60; - equal to; &#x60;neq&#x60; - not equal to; &#x60;gt&#x60; - greater than; &#x60;gteq&#x60; - greater than or equal to; &#x60;lt&#x60; - lower than; &#x60;lteq&#x60; - lower than or equal to; &#x60;like&#x60;</value>
        [DataMember(Name = "variableValues", EmitDefaultValue = true)]
        public List<VariableQueryParameterDto> VariableValues { get; set; }

        /// <summary>
        /// Match all variable names provided in &#x60;variableValues&#x60; case-insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal.
        /// </summary>
        /// <value>Match all variable names provided in &#x60;variableValues&#x60; case-insensitively. If set to &#x60;true&#x60; **variableName** and **variablename** are treated as equal.</value>
        [DataMember(Name = "variableNamesIgnoreCase", EmitDefaultValue = true)]
        public bool? VariableNamesIgnoreCase { get; set; }

        /// <summary>
        /// Match all variable values provided in &#x60;variableValues&#x60; case-insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal.
        /// </summary>
        /// <value>Match all variable values provided in &#x60;variableValues&#x60; case-insensitively. If set to &#x60;true&#x60; **variableValue** and **variablevalue** are treated as equal.</value>
        [DataMember(Name = "variableValuesIgnoreCase", EmitDefaultValue = true)]
        public bool? VariableValuesIgnoreCase { get; set; }

        /// <summary>
        /// Only include variable instances which belong to one of passed scope ids.
        /// </summary>
        /// <value>Only include variable instances which belong to one of passed scope ids.</value>
        [DataMember(Name = "variableScopeIdIn", EmitDefaultValue = true)]
        public List<string> VariableScopeIdIn { get; set; }

        /// <summary>
        /// An array of criteria to sort the result by. Each element of the array is an object that specifies one ordering.                       The position in the array identifies the rank of an ordering, i.e., whether it is primary, secondary, etc.                       Sorting has no effect for &#x60;count&#x60; endpoints
        /// </summary>
        /// <value>An array of criteria to sort the result by. Each element of the array is an object that specifies one ordering.                       The position in the array identifies the rank of an ordering, i.e., whether it is primary, secondary, etc.                       Sorting has no effect for &#x60;count&#x60; endpoints</value>
        [DataMember(Name = "sorting", EmitDefaultValue = true)]
        public List<VariableInstanceQueryDtoSorting> Sorting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableInstanceQueryDto {\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
            sb.Append("  VariableNameLike: ").Append(VariableNameLike).Append("\n");
            sb.Append("  ProcessInstanceIdIn: ").Append(ProcessInstanceIdIn).Append("\n");
            sb.Append("  ExecutionIdIn: ").Append(ExecutionIdIn).Append("\n");
            sb.Append("  CaseInstanceIdIn: ").Append(CaseInstanceIdIn).Append("\n");
            sb.Append("  CaseExecutionIdIn: ").Append(CaseExecutionIdIn).Append("\n");
            sb.Append("  TaskIdIn: ").Append(TaskIdIn).Append("\n");
            sb.Append("  BatchIdIn: ").Append(BatchIdIn).Append("\n");
            sb.Append("  ActivityInstanceIdIn: ").Append(ActivityInstanceIdIn).Append("\n");
            sb.Append("  TenantIdIn: ").Append(TenantIdIn).Append("\n");
            sb.Append("  VariableValues: ").Append(VariableValues).Append("\n");
            sb.Append("  VariableNamesIgnoreCase: ").Append(VariableNamesIgnoreCase).Append("\n");
            sb.Append("  VariableValuesIgnoreCase: ").Append(VariableValuesIgnoreCase).Append("\n");
            sb.Append("  VariableScopeIdIn: ").Append(VariableScopeIdIn).Append("\n");
            sb.Append("  Sorting: ").Append(Sorting).Append("\n");
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
            return this.Equals(input as VariableInstanceQueryDto);
        }

        /// <summary>
        /// Returns true if VariableInstanceQueryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableInstanceQueryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableInstanceQueryDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VariableName == input.VariableName ||
                    (this.VariableName != null &&
                    this.VariableName.Equals(input.VariableName))
                ) && 
                (
                    this.VariableNameLike == input.VariableNameLike ||
                    (this.VariableNameLike != null &&
                    this.VariableNameLike.Equals(input.VariableNameLike))
                ) && 
                (
                    this.ProcessInstanceIdIn == input.ProcessInstanceIdIn ||
                    this.ProcessInstanceIdIn != null &&
                    input.ProcessInstanceIdIn != null &&
                    this.ProcessInstanceIdIn.SequenceEqual(input.ProcessInstanceIdIn)
                ) && 
                (
                    this.ExecutionIdIn == input.ExecutionIdIn ||
                    this.ExecutionIdIn != null &&
                    input.ExecutionIdIn != null &&
                    this.ExecutionIdIn.SequenceEqual(input.ExecutionIdIn)
                ) && 
                (
                    this.CaseInstanceIdIn == input.CaseInstanceIdIn ||
                    this.CaseInstanceIdIn != null &&
                    input.CaseInstanceIdIn != null &&
                    this.CaseInstanceIdIn.SequenceEqual(input.CaseInstanceIdIn)
                ) && 
                (
                    this.CaseExecutionIdIn == input.CaseExecutionIdIn ||
                    this.CaseExecutionIdIn != null &&
                    input.CaseExecutionIdIn != null &&
                    this.CaseExecutionIdIn.SequenceEqual(input.CaseExecutionIdIn)
                ) && 
                (
                    this.TaskIdIn == input.TaskIdIn ||
                    this.TaskIdIn != null &&
                    input.TaskIdIn != null &&
                    this.TaskIdIn.SequenceEqual(input.TaskIdIn)
                ) && 
                (
                    this.BatchIdIn == input.BatchIdIn ||
                    this.BatchIdIn != null &&
                    input.BatchIdIn != null &&
                    this.BatchIdIn.SequenceEqual(input.BatchIdIn)
                ) && 
                (
                    this.ActivityInstanceIdIn == input.ActivityInstanceIdIn ||
                    this.ActivityInstanceIdIn != null &&
                    input.ActivityInstanceIdIn != null &&
                    this.ActivityInstanceIdIn.SequenceEqual(input.ActivityInstanceIdIn)
                ) && 
                (
                    this.TenantIdIn == input.TenantIdIn ||
                    this.TenantIdIn != null &&
                    input.TenantIdIn != null &&
                    this.TenantIdIn.SequenceEqual(input.TenantIdIn)
                ) && 
                (
                    this.VariableValues == input.VariableValues ||
                    this.VariableValues != null &&
                    input.VariableValues != null &&
                    this.VariableValues.SequenceEqual(input.VariableValues)
                ) && 
                (
                    this.VariableNamesIgnoreCase == input.VariableNamesIgnoreCase ||
                    (this.VariableNamesIgnoreCase != null &&
                    this.VariableNamesIgnoreCase.Equals(input.VariableNamesIgnoreCase))
                ) && 
                (
                    this.VariableValuesIgnoreCase == input.VariableValuesIgnoreCase ||
                    (this.VariableValuesIgnoreCase != null &&
                    this.VariableValuesIgnoreCase.Equals(input.VariableValuesIgnoreCase))
                ) && 
                (
                    this.VariableScopeIdIn == input.VariableScopeIdIn ||
                    this.VariableScopeIdIn != null &&
                    input.VariableScopeIdIn != null &&
                    this.VariableScopeIdIn.SequenceEqual(input.VariableScopeIdIn)
                ) && 
                (
                    this.Sorting == input.Sorting ||
                    this.Sorting != null &&
                    input.Sorting != null &&
                    this.Sorting.SequenceEqual(input.Sorting)
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
                if (this.VariableName != null)
                    hashCode = hashCode * 59 + this.VariableName.GetHashCode();
                if (this.VariableNameLike != null)
                    hashCode = hashCode * 59 + this.VariableNameLike.GetHashCode();
                if (this.ProcessInstanceIdIn != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceIdIn.GetHashCode();
                if (this.ExecutionIdIn != null)
                    hashCode = hashCode * 59 + this.ExecutionIdIn.GetHashCode();
                if (this.CaseInstanceIdIn != null)
                    hashCode = hashCode * 59 + this.CaseInstanceIdIn.GetHashCode();
                if (this.CaseExecutionIdIn != null)
                    hashCode = hashCode * 59 + this.CaseExecutionIdIn.GetHashCode();
                if (this.TaskIdIn != null)
                    hashCode = hashCode * 59 + this.TaskIdIn.GetHashCode();
                if (this.BatchIdIn != null)
                    hashCode = hashCode * 59 + this.BatchIdIn.GetHashCode();
                if (this.ActivityInstanceIdIn != null)
                    hashCode = hashCode * 59 + this.ActivityInstanceIdIn.GetHashCode();
                if (this.TenantIdIn != null)
                    hashCode = hashCode * 59 + this.TenantIdIn.GetHashCode();
                if (this.VariableValues != null)
                    hashCode = hashCode * 59 + this.VariableValues.GetHashCode();
                if (this.VariableNamesIgnoreCase != null)
                    hashCode = hashCode * 59 + this.VariableNamesIgnoreCase.GetHashCode();
                if (this.VariableValuesIgnoreCase != null)
                    hashCode = hashCode * 59 + this.VariableValuesIgnoreCase.GetHashCode();
                if (this.VariableScopeIdIn != null)
                    hashCode = hashCode * 59 + this.VariableScopeIdIn.GetHashCode();
                if (this.Sorting != null)
                    hashCode = hashCode * 59 + this.Sorting.GetHashCode();
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
