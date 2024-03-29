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
    /// CleanableHistoricDecisionInstanceReportResultDto
    /// </summary>
    [DataContract(Name = "CleanableHistoricDecisionInstanceReportResultDto")]
    public partial class CleanableHistoricDecisionInstanceReportResultDto : IEquatable<CleanableHistoricDecisionInstanceReportResultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleanableHistoricDecisionInstanceReportResultDto" /> class.
        /// </summary>
        /// <param name="decisionDefinitionId">The id of the decision definition..</param>
        /// <param name="decisionDefinitionKey">The key of the decision definition..</param>
        /// <param name="decisionDefinitionName">The name of the decision definition..</param>
        /// <param name="decisionDefinitionVersion">The version of the decision definition..</param>
        /// <param name="historyTimeToLive">The history time to live of the decision definition..</param>
        /// <param name="finishedDecisionInstanceCount">The count of the finished historic decision instances..</param>
        /// <param name="cleanableDecisionInstanceCount">The count of the cleanable historic decision instances, referring to history time to live..</param>
        /// <param name="tenantId">The tenant id of the decision definition..</param>
        public CleanableHistoricDecisionInstanceReportResultDto(string decisionDefinitionId = default(string), string decisionDefinitionKey = default(string), string decisionDefinitionName = default(string), int? decisionDefinitionVersion = default(int?), int? historyTimeToLive = default(int?), long? finishedDecisionInstanceCount = default(long?), long? cleanableDecisionInstanceCount = default(long?), string tenantId = default(string))
        {
            this.DecisionDefinitionId = decisionDefinitionId;
            this.DecisionDefinitionKey = decisionDefinitionKey;
            this.DecisionDefinitionName = decisionDefinitionName;
            this.DecisionDefinitionVersion = decisionDefinitionVersion;
            this.HistoryTimeToLive = historyTimeToLive;
            this.FinishedDecisionInstanceCount = finishedDecisionInstanceCount;
            this.CleanableDecisionInstanceCount = cleanableDecisionInstanceCount;
            this.TenantId = tenantId;
        }

        /// <summary>
        /// The id of the decision definition.
        /// </summary>
        /// <value>The id of the decision definition.</value>
        [DataMember(Name = "decisionDefinitionId", EmitDefaultValue = true)]
        public string DecisionDefinitionId { get; set; }

        /// <summary>
        /// The key of the decision definition.
        /// </summary>
        /// <value>The key of the decision definition.</value>
        [DataMember(Name = "decisionDefinitionKey", EmitDefaultValue = true)]
        public string DecisionDefinitionKey { get; set; }

        /// <summary>
        /// The name of the decision definition.
        /// </summary>
        /// <value>The name of the decision definition.</value>
        [DataMember(Name = "decisionDefinitionName", EmitDefaultValue = true)]
        public string DecisionDefinitionName { get; set; }

        /// <summary>
        /// The version of the decision definition.
        /// </summary>
        /// <value>The version of the decision definition.</value>
        [DataMember(Name = "decisionDefinitionVersion", EmitDefaultValue = true)]
        public int? DecisionDefinitionVersion { get; set; }

        /// <summary>
        /// The history time to live of the decision definition.
        /// </summary>
        /// <value>The history time to live of the decision definition.</value>
        [DataMember(Name = "historyTimeToLive", EmitDefaultValue = true)]
        public int? HistoryTimeToLive { get; set; }

        /// <summary>
        /// The count of the finished historic decision instances.
        /// </summary>
        /// <value>The count of the finished historic decision instances.</value>
        [DataMember(Name = "finishedDecisionInstanceCount", EmitDefaultValue = true)]
        public long? FinishedDecisionInstanceCount { get; set; }

        /// <summary>
        /// The count of the cleanable historic decision instances, referring to history time to live.
        /// </summary>
        /// <value>The count of the cleanable historic decision instances, referring to history time to live.</value>
        [DataMember(Name = "cleanableDecisionInstanceCount", EmitDefaultValue = true)]
        public long? CleanableDecisionInstanceCount { get; set; }

        /// <summary>
        /// The tenant id of the decision definition.
        /// </summary>
        /// <value>The tenant id of the decision definition.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CleanableHistoricDecisionInstanceReportResultDto {\n");
            sb.Append("  DecisionDefinitionId: ").Append(DecisionDefinitionId).Append("\n");
            sb.Append("  DecisionDefinitionKey: ").Append(DecisionDefinitionKey).Append("\n");
            sb.Append("  DecisionDefinitionName: ").Append(DecisionDefinitionName).Append("\n");
            sb.Append("  DecisionDefinitionVersion: ").Append(DecisionDefinitionVersion).Append("\n");
            sb.Append("  HistoryTimeToLive: ").Append(HistoryTimeToLive).Append("\n");
            sb.Append("  FinishedDecisionInstanceCount: ").Append(FinishedDecisionInstanceCount).Append("\n");
            sb.Append("  CleanableDecisionInstanceCount: ").Append(CleanableDecisionInstanceCount).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as CleanableHistoricDecisionInstanceReportResultDto);
        }

        /// <summary>
        /// Returns true if CleanableHistoricDecisionInstanceReportResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CleanableHistoricDecisionInstanceReportResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleanableHistoricDecisionInstanceReportResultDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DecisionDefinitionId == input.DecisionDefinitionId ||
                    (this.DecisionDefinitionId != null &&
                    this.DecisionDefinitionId.Equals(input.DecisionDefinitionId))
                ) && 
                (
                    this.DecisionDefinitionKey == input.DecisionDefinitionKey ||
                    (this.DecisionDefinitionKey != null &&
                    this.DecisionDefinitionKey.Equals(input.DecisionDefinitionKey))
                ) && 
                (
                    this.DecisionDefinitionName == input.DecisionDefinitionName ||
                    (this.DecisionDefinitionName != null &&
                    this.DecisionDefinitionName.Equals(input.DecisionDefinitionName))
                ) && 
                (
                    this.DecisionDefinitionVersion == input.DecisionDefinitionVersion ||
                    (this.DecisionDefinitionVersion != null &&
                    this.DecisionDefinitionVersion.Equals(input.DecisionDefinitionVersion))
                ) && 
                (
                    this.HistoryTimeToLive == input.HistoryTimeToLive ||
                    (this.HistoryTimeToLive != null &&
                    this.HistoryTimeToLive.Equals(input.HistoryTimeToLive))
                ) && 
                (
                    this.FinishedDecisionInstanceCount == input.FinishedDecisionInstanceCount ||
                    (this.FinishedDecisionInstanceCount != null &&
                    this.FinishedDecisionInstanceCount.Equals(input.FinishedDecisionInstanceCount))
                ) && 
                (
                    this.CleanableDecisionInstanceCount == input.CleanableDecisionInstanceCount ||
                    (this.CleanableDecisionInstanceCount != null &&
                    this.CleanableDecisionInstanceCount.Equals(input.CleanableDecisionInstanceCount))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.DecisionDefinitionId != null)
                    hashCode = hashCode * 59 + this.DecisionDefinitionId.GetHashCode();
                if (this.DecisionDefinitionKey != null)
                    hashCode = hashCode * 59 + this.DecisionDefinitionKey.GetHashCode();
                if (this.DecisionDefinitionName != null)
                    hashCode = hashCode * 59 + this.DecisionDefinitionName.GetHashCode();
                if (this.DecisionDefinitionVersion != null)
                    hashCode = hashCode * 59 + this.DecisionDefinitionVersion.GetHashCode();
                if (this.HistoryTimeToLive != null)
                    hashCode = hashCode * 59 + this.HistoryTimeToLive.GetHashCode();
                if (this.FinishedDecisionInstanceCount != null)
                    hashCode = hashCode * 59 + this.FinishedDecisionInstanceCount.GetHashCode();
                if (this.CleanableDecisionInstanceCount != null)
                    hashCode = hashCode * 59 + this.CleanableDecisionInstanceCount.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
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
