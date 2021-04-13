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
    /// Mandatory when &#x60;sortBy&#x60; is one of the following values: &#x60;processVariable&#x60;, &#x60;executionVariable&#x60;, &#x60;taskVariable&#x60;, &#x60;caseExecutionVariable&#x60; or &#x60;caseInstanceVariable&#x60;. Must be a JSON object with the properties &#x60;variable&#x60; and &#x60;type&#x60; where &#x60;variable&#x60; is a variable name and &#x60;type&#x60; is the name of a variable value type.
    /// </summary>
    [DataContract(Name = "SortTaskQueryParametersDto")]
    public partial class SortTaskQueryParametersDto : IEquatable<SortTaskQueryParametersDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortTaskQueryParametersDto" /> class.
        /// </summary>
        /// <param name="variable">The name of the variable to sort by..</param>
        /// <param name="type">The name of the type of the variable value..</param>
        public SortTaskQueryParametersDto(string variable = default(string), string type = default(string))
        {
            this.Variable = variable;
            this.Type = type;
        }

        /// <summary>
        /// The name of the variable to sort by.
        /// </summary>
        /// <value>The name of the variable to sort by.</value>
        [DataMember(Name = "variable", EmitDefaultValue = true)]
        public string Variable { get; set; }

        /// <summary>
        /// The name of the type of the variable value.
        /// </summary>
        /// <value>The name of the type of the variable value.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SortTaskQueryParametersDto {\n");
            sb.Append("  Variable: ").Append(Variable).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as SortTaskQueryParametersDto);
        }

        /// <summary>
        /// Returns true if SortTaskQueryParametersDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SortTaskQueryParametersDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SortTaskQueryParametersDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Variable == input.Variable ||
                    (this.Variable != null &&
                    this.Variable.Equals(input.Variable))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Variable != null)
                    hashCode = hashCode * 59 + this.Variable.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
