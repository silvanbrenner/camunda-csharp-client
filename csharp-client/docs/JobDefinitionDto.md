# Camunda.OpenApi.Client.Model.JobDefinitionDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the job definition. | [optional] 
**ProcessDefinitionId** | **string** | The id of the process definition this job definition is associated with. | [optional] 
**ProcessDefinitionKey** | **string** | The key of the process definition this job definition is associated with. | [optional] 
**ActivityId** | **string** | The id of the activity this job definition is associated with. | [optional] 
**JobType** | **string** | The type of the job which is running for this job definition. See the [User Guide](https://docs.camunda.org/manual/7.16/user-guide/process-engine/the-job-executor/#job-creation) for more information about job types. | [optional] 
**JobConfiguration** | **string** | The configuration of a job definition provides details about the jobs which will be created. For example: for timer jobs it is the timer configuration. | [optional] 
**OverridingJobPriority** | **long?** | The execution priority defined for jobs that are created based on this definition. May be &#x60;null&#x60; when the priority has not been overridden on the job definition level. | [optional] 
**Suspended** | **bool?** | Indicates whether this job definition is suspended or not. | [optional] 
**TenantId** | **string** | The id of the tenant this job definition is associated with. | [optional] 
**DeploymentId** | **string** | The id of the deployment this job definition is related to. In a deployment-aware setup, this leads to all jobs of the same definition being executed on the same node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

