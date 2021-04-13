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
    /// AttachmentDto
    /// </summary>
    [DataContract(Name = "AttachmentDto")]
    public partial class AttachmentDto : IEquatable<AttachmentDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentDto" /> class.
        /// </summary>
        /// <param name="id">The id of the task attachment..</param>
        /// <param name="name">The name of the task attachment..</param>
        /// <param name="description">The description of the task attachment..</param>
        /// <param name="taskId">The id of the task to which the attachment belongs..</param>
        /// <param name="type">Indication of the type of content that this attachment refers to. Can be MIME type or any other indication..</param>
        /// <param name="url">The url to the remote content of the task attachment..</param>
        /// <param name="createTime">The time the variable was inserted. [Default format](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="removalTime">The time after which the attachment should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..</param>
        /// <param name="rootProcessInstanceId">The process instance id of the root process instance that initiated the process containing the task..</param>
        /// <param name="links">The links associated to this resource, with &#x60;method&#x60;, &#x60;href&#x60; and &#x60;rel&#x60;..</param>
        public AttachmentDto(string id = default(string), string name = default(string), string description = default(string), string taskId = default(string), string type = default(string), string url = default(string), DateTime? createTime = default(DateTime?), DateTime? removalTime = default(DateTime?), string rootProcessInstanceId = default(string), List<AtomLink> links = default(List<AtomLink>))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.TaskId = taskId;
            this.Type = type;
            this.Url = url;
            this.CreateTime = createTime;
            this.RemovalTime = removalTime;
            this.RootProcessInstanceId = rootProcessInstanceId;
            this.Links = links;
        }

        /// <summary>
        /// The id of the task attachment.
        /// </summary>
        /// <value>The id of the task attachment.</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the task attachment.
        /// </summary>
        /// <value>The name of the task attachment.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the task attachment.
        /// </summary>
        /// <value>The description of the task attachment.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The id of the task to which the attachment belongs.
        /// </summary>
        /// <value>The id of the task to which the attachment belongs.</value>
        [DataMember(Name = "taskId", EmitDefaultValue = true)]
        public string TaskId { get; set; }

        /// <summary>
        /// Indication of the type of content that this attachment refers to. Can be MIME type or any other indication.
        /// </summary>
        /// <value>Indication of the type of content that this attachment refers to. Can be MIME type or any other indication.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The url to the remote content of the task attachment.
        /// </summary>
        /// <value>The url to the remote content of the task attachment.</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The time the variable was inserted. [Default format](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time the variable was inserted. [Default format](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "createTime", EmitDefaultValue = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// The time after which the attachment should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>The time after which the attachment should be removed by the History Cleanup job. [Default format](https://docs.camunda.org/manual/7.15/reference/rest/overview/date-format/) &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.</value>
        [DataMember(Name = "removalTime", EmitDefaultValue = true)]
        public DateTime? RemovalTime { get; set; }

        /// <summary>
        /// The process instance id of the root process instance that initiated the process containing the task.
        /// </summary>
        /// <value>The process instance id of the root process instance that initiated the process containing the task.</value>
        [DataMember(Name = "rootProcessInstanceId", EmitDefaultValue = true)]
        public string RootProcessInstanceId { get; set; }

        /// <summary>
        /// The links associated to this resource, with &#x60;method&#x60;, &#x60;href&#x60; and &#x60;rel&#x60;.
        /// </summary>
        /// <value>The links associated to this resource, with &#x60;method&#x60;, &#x60;href&#x60; and &#x60;rel&#x60;.</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<AtomLink> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  RemovalTime: ").Append(RemovalTime).Append("\n");
            sb.Append("  RootProcessInstanceId: ").Append(RootProcessInstanceId).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as AttachmentDto);
        }

        /// <summary>
        /// Returns true if AttachmentDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachmentDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.RemovalTime == input.RemovalTime ||
                    (this.RemovalTime != null &&
                    this.RemovalTime.Equals(input.RemovalTime))
                ) && 
                (
                    this.RootProcessInstanceId == input.RootProcessInstanceId ||
                    (this.RootProcessInstanceId != null &&
                    this.RootProcessInstanceId.Equals(input.RootProcessInstanceId))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.RemovalTime != null)
                    hashCode = hashCode * 59 + this.RemovalTime.GetHashCode();
                if (this.RootProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.RootProcessInstanceId.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
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
