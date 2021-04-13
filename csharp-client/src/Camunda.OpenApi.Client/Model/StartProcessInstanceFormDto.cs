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
    /// StartProcessInstanceFormDto
    /// </summary>
    [DataContract(Name = "StartProcessInstanceFormDto")]
    public partial class StartProcessInstanceFormDto : IEquatable<StartProcessInstanceFormDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartProcessInstanceFormDto" /> class.
        /// </summary>
        /// <param name="variables">variables.</param>
        /// <param name="businessKey">The business key the process instance is to be initialized with. The business key uniquely identifies the process instance in the context of the given process definition..</param>
        public StartProcessInstanceFormDto(Dictionary<string, VariableValueDto> variables = default(Dictionary<string, VariableValueDto>), string businessKey = default(string))
        {
            this.Variables = variables;
            this.BusinessKey = businessKey;
        }

        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> Variables { get; set; }

        /// <summary>
        /// The business key the process instance is to be initialized with. The business key uniquely identifies the process instance in the context of the given process definition.
        /// </summary>
        /// <value>The business key the process instance is to be initialized with. The business key uniquely identifies the process instance in the context of the given process definition.</value>
        [DataMember(Name = "businessKey", EmitDefaultValue = true)]
        public string BusinessKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartProcessInstanceFormDto {\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  BusinessKey: ").Append(BusinessKey).Append("\n");
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
            return this.Equals(input as StartProcessInstanceFormDto);
        }

        /// <summary>
        /// Returns true if StartProcessInstanceFormDto instances are equal
        /// </summary>
        /// <param name="input">Instance of StartProcessInstanceFormDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartProcessInstanceFormDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    input.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
                ) && 
                (
                    this.BusinessKey == input.BusinessKey ||
                    (this.BusinessKey != null &&
                    this.BusinessKey.Equals(input.BusinessKey))
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
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.BusinessKey != null)
                    hashCode = hashCode * 59 + this.BusinessKey.GetHashCode();
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
