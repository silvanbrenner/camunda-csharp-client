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
    /// CreateIncidentDto
    /// </summary>
    [DataContract(Name = "CreateIncidentDto")]
    public partial class CreateIncidentDto : IEquatable<CreateIncidentDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIncidentDto" /> class.
        /// </summary>
        /// <param name="incidentType">A type of the new incident..</param>
        /// <param name="configuration">A configuration for the new incident..</param>
        /// <param name="message">A message for the new incident..</param>
        public CreateIncidentDto(string incidentType = default(string), string configuration = default(string), string message = default(string))
        {
            this.IncidentType = incidentType;
            this._Configuration = configuration;
            this.Message = message;
        }

        /// <summary>
        /// A type of the new incident.
        /// </summary>
        /// <value>A type of the new incident.</value>
        [DataMember(Name = "incidentType", EmitDefaultValue = true)]
        public string IncidentType { get; set; }

        /// <summary>
        /// A configuration for the new incident.
        /// </summary>
        /// <value>A configuration for the new incident.</value>
        [DataMember(Name = "configuration", EmitDefaultValue = true)]
        public string _Configuration { get; set; }

        /// <summary>
        /// A message for the new incident.
        /// </summary>
        /// <value>A message for the new incident.</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateIncidentDto {\n");
            sb.Append("  IncidentType: ").Append(IncidentType).Append("\n");
            sb.Append("  _Configuration: ").Append(_Configuration).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as CreateIncidentDto);
        }

        /// <summary>
        /// Returns true if CreateIncidentDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateIncidentDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateIncidentDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncidentType == input.IncidentType ||
                    (this.IncidentType != null &&
                    this.IncidentType.Equals(input.IncidentType))
                ) && 
                (
                    this._Configuration == input._Configuration ||
                    (this._Configuration != null &&
                    this._Configuration.Equals(input._Configuration))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.IncidentType != null)
                    hashCode = hashCode * 59 + this.IncidentType.GetHashCode();
                if (this._Configuration != null)
                    hashCode = hashCode * 59 + this._Configuration.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
