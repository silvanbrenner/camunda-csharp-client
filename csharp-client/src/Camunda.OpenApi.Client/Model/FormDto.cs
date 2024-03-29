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
    /// FormDto
    /// </summary>
    [DataContract(Name = "FormDto")]
    public partial class FormDto : IEquatable<FormDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormDto" /> class.
        /// </summary>
        /// <param name="key">The form key..</param>
        /// <param name="contextPath">The context path of the process application. If the task (or the process definition) does not belong to a process application deployment or a process definition at all, this property is not set..</param>
        public FormDto(string key = default(string), string contextPath = default(string))
        {
            this.Key = key;
            this.ContextPath = contextPath;
        }

        /// <summary>
        /// The form key.
        /// </summary>
        /// <value>The form key.</value>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The context path of the process application. If the task (or the process definition) does not belong to a process application deployment or a process definition at all, this property is not set.
        /// </summary>
        /// <value>The context path of the process application. If the task (or the process definition) does not belong to a process application deployment or a process definition at all, this property is not set.</value>
        [DataMember(Name = "contextPath", EmitDefaultValue = true)]
        public string ContextPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormDto {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  ContextPath: ").Append(ContextPath).Append("\n");
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
            return this.Equals(input as FormDto);
        }

        /// <summary>
        /// Returns true if FormDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FormDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.ContextPath == input.ContextPath ||
                    (this.ContextPath != null &&
                    this.ContextPath.Equals(input.ContextPath))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.ContextPath != null)
                    hashCode = hashCode * 59 + this.ContextPath.GetHashCode();
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
