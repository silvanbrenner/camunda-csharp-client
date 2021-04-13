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
    /// CaseDefinitionDto
    /// </summary>
    [DataContract(Name = "CaseDefinitionDto")]
    public partial class CaseDefinitionDto : IEquatable<CaseDefinitionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseDefinitionDto" /> class.
        /// </summary>
        /// <param name="id">The id of the case definition.</param>
        /// <param name="key">The key of the case definition, i.e., the id of the CMMN 2.0 XML case definition..</param>
        /// <param name="category">The category of the case definition..</param>
        /// <param name="name">The name of the case definition..</param>
        /// <param name="version">The version of the case definition that the engine assigned to it..</param>
        /// <param name="resource">The file name of the case definition..</param>
        /// <param name="deploymentId">The deployment id of the case definition..</param>
        /// <param name="tenantId">The tenant id of the case definition..</param>
        /// <param name="historyTimeToLive">History time to live value of the case definition. Is used within [History cleanup](https://docs.camunda.org/manual/7.15/user-guide/process-engine/history/#history-cleanup)..</param>
        public CaseDefinitionDto(string id = default(string), string key = default(string), string category = default(string), string name = default(string), int? version = default(int?), string resource = default(string), string deploymentId = default(string), string tenantId = default(string), int? historyTimeToLive = default(int?))
        {
            this.Id = id;
            this.Key = key;
            this.Category = category;
            this.Name = name;
            this.Version = version;
            this.Resource = resource;
            this.DeploymentId = deploymentId;
            this.TenantId = tenantId;
            this.HistoryTimeToLive = historyTimeToLive;
        }

        /// <summary>
        /// The id of the case definition
        /// </summary>
        /// <value>The id of the case definition</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The key of the case definition, i.e., the id of the CMMN 2.0 XML case definition.
        /// </summary>
        /// <value>The key of the case definition, i.e., the id of the CMMN 2.0 XML case definition.</value>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The category of the case definition.
        /// </summary>
        /// <value>The category of the case definition.</value>
        [DataMember(Name = "category", EmitDefaultValue = true)]
        public string Category { get; set; }

        /// <summary>
        /// The name of the case definition.
        /// </summary>
        /// <value>The name of the case definition.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The version of the case definition that the engine assigned to it.
        /// </summary>
        /// <value>The version of the case definition that the engine assigned to it.</value>
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public int? Version { get; set; }

        /// <summary>
        /// The file name of the case definition.
        /// </summary>
        /// <value>The file name of the case definition.</value>
        [DataMember(Name = "resource", EmitDefaultValue = true)]
        public string Resource { get; set; }

        /// <summary>
        /// The deployment id of the case definition.
        /// </summary>
        /// <value>The deployment id of the case definition.</value>
        [DataMember(Name = "deploymentId", EmitDefaultValue = true)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// The tenant id of the case definition.
        /// </summary>
        /// <value>The tenant id of the case definition.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// History time to live value of the case definition. Is used within [History cleanup](https://docs.camunda.org/manual/7.15/user-guide/process-engine/history/#history-cleanup).
        /// </summary>
        /// <value>History time to live value of the case definition. Is used within [History cleanup](https://docs.camunda.org/manual/7.15/user-guide/process-engine/history/#history-cleanup).</value>
        [DataMember(Name = "historyTimeToLive", EmitDefaultValue = true)]
        public int? HistoryTimeToLive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseDefinitionDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  HistoryTimeToLive: ").Append(HistoryTimeToLive).Append("\n");
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
            return this.Equals(input as CaseDefinitionDto);
        }

        /// <summary>
        /// Returns true if CaseDefinitionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CaseDefinitionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseDefinitionDto input)
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
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.DeploymentId == input.DeploymentId ||
                    (this.DeploymentId != null &&
                    this.DeploymentId.Equals(input.DeploymentId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.HistoryTimeToLive == input.HistoryTimeToLive ||
                    (this.HistoryTimeToLive != null &&
                    this.HistoryTimeToLive.Equals(input.HistoryTimeToLive))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.DeploymentId != null)
                    hashCode = hashCode * 59 + this.DeploymentId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.HistoryTimeToLive != null)
                    hashCode = hashCode * 59 + this.HistoryTimeToLive.GetHashCode();
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
            // HistoryTimeToLive (int?) minimum
            if(this.HistoryTimeToLive < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HistoryTimeToLive, must be a value greater than or equal to 0.", new [] { "HistoryTimeToLive" });
            }

            yield break;
        }
    }

}
