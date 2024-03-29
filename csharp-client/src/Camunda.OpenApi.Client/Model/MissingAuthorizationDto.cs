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
    /// MissingAuthorizationDto
    /// </summary>
    [DataContract(Name = "MissingAuthorizationDto")]
    public partial class MissingAuthorizationDto : IEquatable<MissingAuthorizationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissingAuthorizationDto" /> class.
        /// </summary>
        /// <param name="permissionName">The permission name that the user is missing..</param>
        /// <param name="resourceName">The name of the resource that the user is missing permission for..</param>
        /// <param name="resourceId">The id of the resource that the user is missing permission for..</param>
        public MissingAuthorizationDto(string permissionName = default(string), string resourceName = default(string), string resourceId = default(string))
        {
            this.PermissionName = permissionName;
            this.ResourceName = resourceName;
            this.ResourceId = resourceId;
        }

        /// <summary>
        /// The permission name that the user is missing.
        /// </summary>
        /// <value>The permission name that the user is missing.</value>
        [DataMember(Name = "permissionName", EmitDefaultValue = true)]
        public string PermissionName { get; set; }

        /// <summary>
        /// The name of the resource that the user is missing permission for.
        /// </summary>
        /// <value>The name of the resource that the user is missing permission for.</value>
        [DataMember(Name = "resourceName", EmitDefaultValue = true)]
        public string ResourceName { get; set; }

        /// <summary>
        /// The id of the resource that the user is missing permission for.
        /// </summary>
        /// <value>The id of the resource that the user is missing permission for.</value>
        [DataMember(Name = "resourceId", EmitDefaultValue = true)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MissingAuthorizationDto {\n");
            sb.Append("  PermissionName: ").Append(PermissionName).Append("\n");
            sb.Append("  ResourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
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
            return this.Equals(input as MissingAuthorizationDto);
        }

        /// <summary>
        /// Returns true if MissingAuthorizationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MissingAuthorizationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MissingAuthorizationDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PermissionName == input.PermissionName ||
                    (this.PermissionName != null &&
                    this.PermissionName.Equals(input.PermissionName))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
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
                if (this.PermissionName != null)
                    hashCode = hashCode * 59 + this.PermissionName.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
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
