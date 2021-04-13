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
    /// A Job instance query which defines a list of Job instances
    /// </summary>
    [DataContract(Name = "JobQueryDto")]
    public partial class JobQueryDto : IEquatable<JobQueryDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobQueryDto" /> class.
        /// </summary>
        /// <param name="jobId">Filter by job id..</param>
        /// <param name="jobIds">Filter by a  list of job ids..</param>
        /// <param name="jobDefinitionId">Only select jobs which exist for the given job definition..</param>
        /// <param name="processInstanceId">Only select jobs which exist for the given process instance..</param>
        /// <param name="processInstanceIds">Only select jobs which exist for the given  list of process instance ids..</param>
        /// <param name="executionId">Only select jobs which exist for the given execution..</param>
        /// <param name="processDefinitionId">Filter by the id of the process definition the jobs run on..</param>
        /// <param name="processDefinitionKey">Filter by the key of the process definition the jobs run on..</param>
        /// <param name="activityId">Only select jobs which exist for an activity with the given id..</param>
        /// <param name="withRetriesLeft">Only select jobs which have retries left. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="executable">Only select jobs which are executable, i.e., retries &gt; 0 and due date is &#x60;null&#x60; or due date is in the past. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="timers">Only select jobs that are timers. Cannot be used together with &#x60;messages&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="messages">Only select jobs that are messages. Cannot be used together with &#x60;timers&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="dueDates">Only select jobs where the due date is lower or higher than the given date. .</param>
        /// <param name="createTimes">Only select jobs created before or after the given date. .</param>
        /// <param name="withException">Only select jobs that failed due to an exception. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="exceptionMessage">Only select jobs that failed due to an exception with the given message..</param>
        /// <param name="failedActivityId">Only select jobs that failed due to an exception at an activity with the given id..</param>
        /// <param name="noRetriesLeft">Only select jobs which have no retries left. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="active">Only include active jobs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="suspended">Only include suspended jobs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="priorityLowerThanOrEquals">Only include jobs with a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value..</param>
        /// <param name="priorityHigherThanOrEquals">Only include jobs with a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value..</param>
        /// <param name="tenantIdIn">Only include jobs which belong to one of the passed  tenant ids..</param>
        /// <param name="withoutTenantId">Only include jobs which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="includeJobsWithoutTenantId">Include jobs which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="sorting">An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Does not have an effect for the &#x60;count&#x60; endpoint..</param>
        public JobQueryDto(string jobId = default(string), List<string> jobIds = default(List<string>), string jobDefinitionId = default(string), string processInstanceId = default(string), List<string> processInstanceIds = default(List<string>), string executionId = default(string), string processDefinitionId = default(string), string processDefinitionKey = default(string), string activityId = default(string), bool? withRetriesLeft = default(bool?), bool? executable = default(bool?), bool? timers = default(bool?), bool? messages = default(bool?), List<JobConditionQueryParameterDto> dueDates = default(List<JobConditionQueryParameterDto>), List<JobConditionQueryParameterDto> createTimes = default(List<JobConditionQueryParameterDto>), bool? withException = default(bool?), string exceptionMessage = default(string), string failedActivityId = default(string), bool? noRetriesLeft = default(bool?), bool? active = default(bool?), bool? suspended = default(bool?), long? priorityLowerThanOrEquals = default(long?), long? priorityHigherThanOrEquals = default(long?), List<string> tenantIdIn = default(List<string>), bool? withoutTenantId = default(bool?), bool? includeJobsWithoutTenantId = default(bool?), List<JobQueryDtoSorting> sorting = default(List<JobQueryDtoSorting>))
        {
            this.JobId = jobId;
            this.JobIds = jobIds;
            this.JobDefinitionId = jobDefinitionId;
            this.ProcessInstanceId = processInstanceId;
            this.ProcessInstanceIds = processInstanceIds;
            this.ExecutionId = executionId;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.ActivityId = activityId;
            this.WithRetriesLeft = withRetriesLeft;
            this.Executable = executable;
            this.Timers = timers;
            this.Messages = messages;
            this.DueDates = dueDates;
            this.CreateTimes = createTimes;
            this.WithException = withException;
            this.ExceptionMessage = exceptionMessage;
            this.FailedActivityId = failedActivityId;
            this.NoRetriesLeft = noRetriesLeft;
            this.Active = active;
            this.Suspended = suspended;
            this.PriorityLowerThanOrEquals = priorityLowerThanOrEquals;
            this.PriorityHigherThanOrEquals = priorityHigherThanOrEquals;
            this.TenantIdIn = tenantIdIn;
            this.WithoutTenantId = withoutTenantId;
            this.IncludeJobsWithoutTenantId = includeJobsWithoutTenantId;
            this.Sorting = sorting;
        }

        /// <summary>
        /// Filter by job id.
        /// </summary>
        /// <value>Filter by job id.</value>
        [DataMember(Name = "jobId", EmitDefaultValue = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Filter by a  list of job ids.
        /// </summary>
        /// <value>Filter by a  list of job ids.</value>
        [DataMember(Name = "jobIds", EmitDefaultValue = true)]
        public List<string> JobIds { get; set; }

        /// <summary>
        /// Only select jobs which exist for the given job definition.
        /// </summary>
        /// <value>Only select jobs which exist for the given job definition.</value>
        [DataMember(Name = "jobDefinitionId", EmitDefaultValue = true)]
        public string JobDefinitionId { get; set; }

        /// <summary>
        /// Only select jobs which exist for the given process instance.
        /// </summary>
        /// <value>Only select jobs which exist for the given process instance.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// Only select jobs which exist for the given  list of process instance ids.
        /// </summary>
        /// <value>Only select jobs which exist for the given  list of process instance ids.</value>
        [DataMember(Name = "processInstanceIds", EmitDefaultValue = true)]
        public List<string> ProcessInstanceIds { get; set; }

        /// <summary>
        /// Only select jobs which exist for the given execution.
        /// </summary>
        /// <value>Only select jobs which exist for the given execution.</value>
        [DataMember(Name = "executionId", EmitDefaultValue = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Filter by the id of the process definition the jobs run on.
        /// </summary>
        /// <value>Filter by the id of the process definition the jobs run on.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// Filter by the key of the process definition the jobs run on.
        /// </summary>
        /// <value>Filter by the key of the process definition the jobs run on.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// Only select jobs which exist for an activity with the given id.
        /// </summary>
        /// <value>Only select jobs which exist for an activity with the given id.</value>
        [DataMember(Name = "activityId", EmitDefaultValue = true)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Only select jobs which have retries left. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only select jobs which have retries left. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "withRetriesLeft", EmitDefaultValue = true)]
        public bool? WithRetriesLeft { get; set; }

        /// <summary>
        /// Only select jobs which are executable, i.e., retries &gt; 0 and due date is &#x60;null&#x60; or due date is in the past. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only select jobs which are executable, i.e., retries &gt; 0 and due date is &#x60;null&#x60; or due date is in the past. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "executable", EmitDefaultValue = true)]
        public bool? Executable { get; set; }

        /// <summary>
        /// Only select jobs that are timers. Cannot be used together with &#x60;messages&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only select jobs that are timers. Cannot be used together with &#x60;messages&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "timers", EmitDefaultValue = true)]
        public bool? Timers { get; set; }

        /// <summary>
        /// Only select jobs that are messages. Cannot be used together with &#x60;timers&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only select jobs that are messages. Cannot be used together with &#x60;timers&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "messages", EmitDefaultValue = true)]
        public bool? Messages { get; set; }

        /// <summary>
        /// Only select jobs where the due date is lower or higher than the given date. 
        /// </summary>
        /// <value>Only select jobs where the due date is lower or higher than the given date. </value>
        [DataMember(Name = "dueDates", EmitDefaultValue = true)]
        public List<JobConditionQueryParameterDto> DueDates { get; set; }

        /// <summary>
        /// Only select jobs created before or after the given date. 
        /// </summary>
        /// <value>Only select jobs created before or after the given date. </value>
        [DataMember(Name = "createTimes", EmitDefaultValue = true)]
        public List<JobConditionQueryParameterDto> CreateTimes { get; set; }

        /// <summary>
        /// Only select jobs that failed due to an exception. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only select jobs that failed due to an exception. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "withException", EmitDefaultValue = true)]
        public bool? WithException { get; set; }

        /// <summary>
        /// Only select jobs that failed due to an exception with the given message.
        /// </summary>
        /// <value>Only select jobs that failed due to an exception with the given message.</value>
        [DataMember(Name = "exceptionMessage", EmitDefaultValue = true)]
        public string ExceptionMessage { get; set; }

        /// <summary>
        /// Only select jobs that failed due to an exception at an activity with the given id.
        /// </summary>
        /// <value>Only select jobs that failed due to an exception at an activity with the given id.</value>
        [DataMember(Name = "failedActivityId", EmitDefaultValue = true)]
        public string FailedActivityId { get; set; }

        /// <summary>
        /// Only select jobs which have no retries left. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only select jobs which have no retries left. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "noRetriesLeft", EmitDefaultValue = true)]
        public bool? NoRetriesLeft { get; set; }

        /// <summary>
        /// Only include active jobs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only include active jobs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool? Active { get; set; }

        /// <summary>
        /// Only include suspended jobs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only include suspended jobs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "suspended", EmitDefaultValue = true)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// Only include jobs with a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value.
        /// </summary>
        /// <value>Only include jobs with a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value.</value>
        [DataMember(Name = "priorityLowerThanOrEquals", EmitDefaultValue = true)]
        public long? PriorityLowerThanOrEquals { get; set; }

        /// <summary>
        /// Only include jobs with a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value.
        /// </summary>
        /// <value>Only include jobs with a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value.</value>
        [DataMember(Name = "priorityHigherThanOrEquals", EmitDefaultValue = true)]
        public long? PriorityHigherThanOrEquals { get; set; }

        /// <summary>
        /// Only include jobs which belong to one of the passed  tenant ids.
        /// </summary>
        /// <value>Only include jobs which belong to one of the passed  tenant ids.</value>
        [DataMember(Name = "tenantIdIn", EmitDefaultValue = true)]
        public List<string> TenantIdIn { get; set; }

        /// <summary>
        /// Only include jobs which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only include jobs which belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "withoutTenantId", EmitDefaultValue = true)]
        public bool? WithoutTenantId { get; set; }

        /// <summary>
        /// Include jobs which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Include jobs which belong to no tenant. Can be used in combination with &#x60;tenantIdIn&#x60;. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "includeJobsWithoutTenantId", EmitDefaultValue = true)]
        public bool? IncludeJobsWithoutTenantId { get; set; }

        /// <summary>
        /// An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Does not have an effect for the &#x60;count&#x60; endpoint.
        /// </summary>
        /// <value>An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Does not have an effect for the &#x60;count&#x60; endpoint.</value>
        [DataMember(Name = "sorting", EmitDefaultValue = false)]
        public List<JobQueryDtoSorting> Sorting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobQueryDto {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  JobIds: ").Append(JobIds).Append("\n");
            sb.Append("  JobDefinitionId: ").Append(JobDefinitionId).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ProcessInstanceIds: ").Append(ProcessInstanceIds).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  WithRetriesLeft: ").Append(WithRetriesLeft).Append("\n");
            sb.Append("  Executable: ").Append(Executable).Append("\n");
            sb.Append("  Timers: ").Append(Timers).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  DueDates: ").Append(DueDates).Append("\n");
            sb.Append("  CreateTimes: ").Append(CreateTimes).Append("\n");
            sb.Append("  WithException: ").Append(WithException).Append("\n");
            sb.Append("  ExceptionMessage: ").Append(ExceptionMessage).Append("\n");
            sb.Append("  FailedActivityId: ").Append(FailedActivityId).Append("\n");
            sb.Append("  NoRetriesLeft: ").Append(NoRetriesLeft).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Suspended: ").Append(Suspended).Append("\n");
            sb.Append("  PriorityLowerThanOrEquals: ").Append(PriorityLowerThanOrEquals).Append("\n");
            sb.Append("  PriorityHigherThanOrEquals: ").Append(PriorityHigherThanOrEquals).Append("\n");
            sb.Append("  TenantIdIn: ").Append(TenantIdIn).Append("\n");
            sb.Append("  WithoutTenantId: ").Append(WithoutTenantId).Append("\n");
            sb.Append("  IncludeJobsWithoutTenantId: ").Append(IncludeJobsWithoutTenantId).Append("\n");
            sb.Append("  Sorting: ").Append(Sorting).Append("\n");
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
            return this.Equals(input as JobQueryDto);
        }

        /// <summary>
        /// Returns true if JobQueryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of JobQueryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobQueryDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobIds == input.JobIds ||
                    this.JobIds != null &&
                    input.JobIds != null &&
                    this.JobIds.SequenceEqual(input.JobIds)
                ) && 
                (
                    this.JobDefinitionId == input.JobDefinitionId ||
                    (this.JobDefinitionId != null &&
                    this.JobDefinitionId.Equals(input.JobDefinitionId))
                ) && 
                (
                    this.ProcessInstanceId == input.ProcessInstanceId ||
                    (this.ProcessInstanceId != null &&
                    this.ProcessInstanceId.Equals(input.ProcessInstanceId))
                ) && 
                (
                    this.ProcessInstanceIds == input.ProcessInstanceIds ||
                    this.ProcessInstanceIds != null &&
                    input.ProcessInstanceIds != null &&
                    this.ProcessInstanceIds.SequenceEqual(input.ProcessInstanceIds)
                ) && 
                (
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.ProcessDefinitionId == input.ProcessDefinitionId ||
                    (this.ProcessDefinitionId != null &&
                    this.ProcessDefinitionId.Equals(input.ProcessDefinitionId))
                ) && 
                (
                    this.ProcessDefinitionKey == input.ProcessDefinitionKey ||
                    (this.ProcessDefinitionKey != null &&
                    this.ProcessDefinitionKey.Equals(input.ProcessDefinitionKey))
                ) && 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.WithRetriesLeft == input.WithRetriesLeft ||
                    (this.WithRetriesLeft != null &&
                    this.WithRetriesLeft.Equals(input.WithRetriesLeft))
                ) && 
                (
                    this.Executable == input.Executable ||
                    (this.Executable != null &&
                    this.Executable.Equals(input.Executable))
                ) && 
                (
                    this.Timers == input.Timers ||
                    (this.Timers != null &&
                    this.Timers.Equals(input.Timers))
                ) && 
                (
                    this.Messages == input.Messages ||
                    (this.Messages != null &&
                    this.Messages.Equals(input.Messages))
                ) && 
                (
                    this.DueDates == input.DueDates ||
                    this.DueDates != null &&
                    input.DueDates != null &&
                    this.DueDates.SequenceEqual(input.DueDates)
                ) && 
                (
                    this.CreateTimes == input.CreateTimes ||
                    this.CreateTimes != null &&
                    input.CreateTimes != null &&
                    this.CreateTimes.SequenceEqual(input.CreateTimes)
                ) && 
                (
                    this.WithException == input.WithException ||
                    (this.WithException != null &&
                    this.WithException.Equals(input.WithException))
                ) && 
                (
                    this.ExceptionMessage == input.ExceptionMessage ||
                    (this.ExceptionMessage != null &&
                    this.ExceptionMessage.Equals(input.ExceptionMessage))
                ) && 
                (
                    this.FailedActivityId == input.FailedActivityId ||
                    (this.FailedActivityId != null &&
                    this.FailedActivityId.Equals(input.FailedActivityId))
                ) && 
                (
                    this.NoRetriesLeft == input.NoRetriesLeft ||
                    (this.NoRetriesLeft != null &&
                    this.NoRetriesLeft.Equals(input.NoRetriesLeft))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Suspended == input.Suspended ||
                    (this.Suspended != null &&
                    this.Suspended.Equals(input.Suspended))
                ) && 
                (
                    this.PriorityLowerThanOrEquals == input.PriorityLowerThanOrEquals ||
                    (this.PriorityLowerThanOrEquals != null &&
                    this.PriorityLowerThanOrEquals.Equals(input.PriorityLowerThanOrEquals))
                ) && 
                (
                    this.PriorityHigherThanOrEquals == input.PriorityHigherThanOrEquals ||
                    (this.PriorityHigherThanOrEquals != null &&
                    this.PriorityHigherThanOrEquals.Equals(input.PriorityHigherThanOrEquals))
                ) && 
                (
                    this.TenantIdIn == input.TenantIdIn ||
                    this.TenantIdIn != null &&
                    input.TenantIdIn != null &&
                    this.TenantIdIn.SequenceEqual(input.TenantIdIn)
                ) && 
                (
                    this.WithoutTenantId == input.WithoutTenantId ||
                    (this.WithoutTenantId != null &&
                    this.WithoutTenantId.Equals(input.WithoutTenantId))
                ) && 
                (
                    this.IncludeJobsWithoutTenantId == input.IncludeJobsWithoutTenantId ||
                    (this.IncludeJobsWithoutTenantId != null &&
                    this.IncludeJobsWithoutTenantId.Equals(input.IncludeJobsWithoutTenantId))
                ) && 
                (
                    this.Sorting == input.Sorting ||
                    this.Sorting != null &&
                    input.Sorting != null &&
                    this.Sorting.SequenceEqual(input.Sorting)
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobIds != null)
                    hashCode = hashCode * 59 + this.JobIds.GetHashCode();
                if (this.JobDefinitionId != null)
                    hashCode = hashCode * 59 + this.JobDefinitionId.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ProcessInstanceIds != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceIds.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.ActivityId != null)
                    hashCode = hashCode * 59 + this.ActivityId.GetHashCode();
                if (this.WithRetriesLeft != null)
                    hashCode = hashCode * 59 + this.WithRetriesLeft.GetHashCode();
                if (this.Executable != null)
                    hashCode = hashCode * 59 + this.Executable.GetHashCode();
                if (this.Timers != null)
                    hashCode = hashCode * 59 + this.Timers.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.DueDates != null)
                    hashCode = hashCode * 59 + this.DueDates.GetHashCode();
                if (this.CreateTimes != null)
                    hashCode = hashCode * 59 + this.CreateTimes.GetHashCode();
                if (this.WithException != null)
                    hashCode = hashCode * 59 + this.WithException.GetHashCode();
                if (this.ExceptionMessage != null)
                    hashCode = hashCode * 59 + this.ExceptionMessage.GetHashCode();
                if (this.FailedActivityId != null)
                    hashCode = hashCode * 59 + this.FailedActivityId.GetHashCode();
                if (this.NoRetriesLeft != null)
                    hashCode = hashCode * 59 + this.NoRetriesLeft.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Suspended != null)
                    hashCode = hashCode * 59 + this.Suspended.GetHashCode();
                if (this.PriorityLowerThanOrEquals != null)
                    hashCode = hashCode * 59 + this.PriorityLowerThanOrEquals.GetHashCode();
                if (this.PriorityHigherThanOrEquals != null)
                    hashCode = hashCode * 59 + this.PriorityHigherThanOrEquals.GetHashCode();
                if (this.TenantIdIn != null)
                    hashCode = hashCode * 59 + this.TenantIdIn.GetHashCode();
                if (this.WithoutTenantId != null)
                    hashCode = hashCode * 59 + this.WithoutTenantId.GetHashCode();
                if (this.IncludeJobsWithoutTenantId != null)
                    hashCode = hashCode * 59 + this.IncludeJobsWithoutTenantId.GetHashCode();
                if (this.Sorting != null)
                    hashCode = hashCode * 59 + this.Sorting.GetHashCode();
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
