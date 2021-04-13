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
    /// AnnotationDto
    /// </summary>
    [DataContract(Name = "AnnotationDto")]
    public partial class AnnotationDto : IEquatable<AnnotationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationDto" /> class.
        /// </summary>
        /// <param name="annotation">The annotation value to put..</param>
        public AnnotationDto(string annotation = default(string))
        {
            this.Annotation = annotation;
        }

        /// <summary>
        /// The annotation value to put.
        /// </summary>
        /// <value>The annotation value to put.</value>
        [DataMember(Name = "annotation", EmitDefaultValue = true)]
        public string Annotation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnnotationDto {\n");
            sb.Append("  Annotation: ").Append(Annotation).Append("\n");
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
            return this.Equals(input as AnnotationDto);
        }

        /// <summary>
        /// Returns true if AnnotationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AnnotationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnnotationDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Annotation == input.Annotation ||
                    (this.Annotation != null &&
                    this.Annotation.Equals(input.Annotation))
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
                if (this.Annotation != null)
                    hashCode = hashCode * 59 + this.Annotation.GetHashCode();
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
