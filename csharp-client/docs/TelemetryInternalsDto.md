# Camunda.OpenApi.Client.Model.TelemetryInternalsDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Database** | [**Dictionary&lt;string, AbstractVendorVersionInformationDto&gt;**](AbstractVendorVersionInformationDto.md) | Vendor and version of the connected database. | [optional] 
**ApplicationServer** | [**Dictionary&lt;string, AbstractVendorVersionInformationDto&gt;**](AbstractVendorVersionInformationDto.md) | Vendor and version of the application server. | [optional] 
**LicenseKey** | [**Dictionary&lt;string, TelemetryLicenseKeyDto&gt;**](TelemetryLicenseKeyDto.md) | Information about the Camunda license key. | [optional] 
**CamundaIntegration** | **List&lt;string&gt;** | List of Camunda integrations used (e.g., Camunda Spring Boot Starter, Camunda Run, WildFly/JBoss subsystem, Camunda EJB). | [optional] 
**Commands** | [**Dictionary&lt;string, TelemetryCountDto&gt;**](TelemetryCountDto.md) | The count of executed commands after the last retrieved data. | [optional] 
**Metrics** | [**Dictionary&lt;string, TelemetryCountDto&gt;**](TelemetryCountDto.md) | The collected metrics are the number of root process instance executions started, the number of activity instances started or also known as flow node instances, and the number of executed decision instances and elements. | [optional] 
**Webapps** | **List&lt;string&gt;** | The webapps enabled in this installation of Camunda. | [optional] 
**Jdk** | [**Dictionary&lt;string, AbstractVendorVersionInformationDto&gt;**](AbstractVendorVersionInformationDto.md) | Vendor and version of the installed JDK. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

