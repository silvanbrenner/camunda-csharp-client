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
    /// AuthorizationUpdateDto
    /// </summary>
    [DataContract(Name = "AuthorizationUpdateDto")]
    public partial class AuthorizationUpdateDto : IEquatable<AuthorizationUpdateDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationUpdateDto" /> class.
        /// </summary>
        /// <param name="permissions">An array of Strings holding the permissions provided by this authorization..</param>
        /// <param name="userId">The id of the user this authorization has been created for. The value &#x60;*&#x60; represents a global authorization ranging over all users..</param>
        /// <param name="groupId">The id of the group this authorization has been created for..</param>
        /// <param name="resourceType">An integer representing the resource type. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/authorization-service/#resources) for a list of integer representations of resource types..</param>
        /// <param name="resourceId">The resource Id. The value &#x60;*&#x60; represents an authorization ranging over all instances of a resource..</param>
        public AuthorizationUpdateDto(List<string> permissions = default(List<string>), string userId = default(string), string groupId = default(string), int? resourceType = default(int?), string resourceId = default(string))
        {
            this.Permissions = permissions;
            this.UserId = userId;
            this.GroupId = groupId;
            this.ResourceType = resourceType;
            this.ResourceId = resourceId;
        }

        /// <summary>
        /// An array of Strings holding the permissions provided by this authorization.
        /// </summary>
        /// <value>An array of Strings holding the permissions provided by this authorization.</value>
        [DataMember(Name = "permissions", EmitDefaultValue = true)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// The id of the user this authorization has been created for. The value &#x60;*&#x60; represents a global authorization ranging over all users.
        /// </summary>
        /// <value>The id of the user this authorization has been created for. The value &#x60;*&#x60; represents a global authorization ranging over all users.</value>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// The id of the group this authorization has been created for.
        /// </summary>
        /// <value>The id of the group this authorization has been created for.</value>
        [DataMember(Name = "groupId", EmitDefaultValue = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// An integer representing the resource type. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/authorization-service/#resources) for a list of integer representations of resource types.
        /// </summary>
        /// <value>An integer representing the resource type. See the [User Guide](https://docs.camunda.org/manual/7.17/user-guide/process-engine/authorization-service/#resources) for a list of integer representations of resource types.</value>
        [DataMember(Name = "resourceType", EmitDefaultValue = true)]
        public int? ResourceType { get; set; }

        /// <summary>
        /// The resource Id. The value &#x60;*&#x60; represents an authorization ranging over all instances of a resource.
        /// </summary>
        /// <value>The resource Id. The value &#x60;*&#x60; represents an authorization ranging over all instances of a resource.</value>
        [DataMember(Name = "resourceId", EmitDefaultValue = true)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizationUpdateDto {\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
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
            return this.Equals(input as AuthorizationUpdateDto);
        }

        /// <summary>
        /// Returns true if AuthorizationUpdateDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizationUpdateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizationUpdateDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
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
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
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
