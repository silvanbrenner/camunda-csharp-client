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
    /// TriggerVariableValueDto
    /// </summary>
    [DataContract(Name = "TriggerVariableValueDto")]
    public partial class TriggerVariableValueDto : IEquatable<TriggerVariableValueDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerVariableValueDto" /> class.
        /// </summary>
        /// <param name="local">Indicates whether the variable should be a local variable or not. If set to true, the variable becomes a local variable of the execution entering the target activity..</param>
        /// <param name="value">The variable&#39;s value. Value differs depending on the variable&#39;s type and on the deserializeValues parameter..</param>
        /// <param name="type">The value type of the variable..</param>
        /// <param name="valueInfo">A JSON object containing additional, value-type-dependent properties. For serialized variables of type Object, the following properties can be provided:  * &#x60;objectTypeName&#x60;: A string representation of the object&#39;s type name. * &#x60;serializationDataFormat&#x60;: The serialization format used to store the variable.  For serialized variables of type File, the following properties can be provided:  * &#x60;filename&#x60;: The name of the file. This is not the variable name but the name that will be used when downloading the file again. * &#x60;mimetype&#x60;: The MIME type of the file that is being uploaded. * &#x60;encoding&#x60;: The encoding of the file that is being uploaded.  The following property can be provided for all value types:  * &#x60;transient&#x60;: Indicates whether the variable should be transient or not. See [documentation](https://docs.camunda.org/manual/7.15/user-guide/process-engine/variables#transient-variables) for more informations. (Not applicable for &#x60;decision-definition&#x60; and &#x60; /process-instance/variables-async&#x60; endpoints).</param>
        public TriggerVariableValueDto(bool? local = default(bool?), Object value = default(Object), string type = default(string), Dictionary<string, Object> valueInfo = default(Dictionary<string, Object>))
        {
            this.Local = local;
            this.Value = value;
            this.Type = type;
            this.ValueInfo = valueInfo;
        }

        /// <summary>
        /// Indicates whether the variable should be a local variable or not. If set to true, the variable becomes a local variable of the execution entering the target activity.
        /// </summary>
        /// <value>Indicates whether the variable should be a local variable or not. If set to true, the variable becomes a local variable of the execution entering the target activity.</value>
        [DataMember(Name = "local", EmitDefaultValue = true)]
        public bool? Local { get; set; }

        /// <summary>
        /// The variable&#39;s value. Value differs depending on the variable&#39;s type and on the deserializeValues parameter.
        /// </summary>
        /// <value>The variable&#39;s value. Value differs depending on the variable&#39;s type and on the deserializeValues parameter.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public Object Value { get; set; }

        /// <summary>
        /// The value type of the variable.
        /// </summary>
        /// <value>The value type of the variable.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// A JSON object containing additional, value-type-dependent properties. For serialized variables of type Object, the following properties can be provided:  * &#x60;objectTypeName&#x60;: A string representation of the object&#39;s type name. * &#x60;serializationDataFormat&#x60;: The serialization format used to store the variable.  For serialized variables of type File, the following properties can be provided:  * &#x60;filename&#x60;: The name of the file. This is not the variable name but the name that will be used when downloading the file again. * &#x60;mimetype&#x60;: The MIME type of the file that is being uploaded. * &#x60;encoding&#x60;: The encoding of the file that is being uploaded.  The following property can be provided for all value types:  * &#x60;transient&#x60;: Indicates whether the variable should be transient or not. See [documentation](https://docs.camunda.org/manual/7.15/user-guide/process-engine/variables#transient-variables) for more informations. (Not applicable for &#x60;decision-definition&#x60; and &#x60; /process-instance/variables-async&#x60; endpoints)
        /// </summary>
        /// <value>A JSON object containing additional, value-type-dependent properties. For serialized variables of type Object, the following properties can be provided:  * &#x60;objectTypeName&#x60;: A string representation of the object&#39;s type name. * &#x60;serializationDataFormat&#x60;: The serialization format used to store the variable.  For serialized variables of type File, the following properties can be provided:  * &#x60;filename&#x60;: The name of the file. This is not the variable name but the name that will be used when downloading the file again. * &#x60;mimetype&#x60;: The MIME type of the file that is being uploaded. * &#x60;encoding&#x60;: The encoding of the file that is being uploaded.  The following property can be provided for all value types:  * &#x60;transient&#x60;: Indicates whether the variable should be transient or not. See [documentation](https://docs.camunda.org/manual/7.15/user-guide/process-engine/variables#transient-variables) for more informations. (Not applicable for &#x60;decision-definition&#x60; and &#x60; /process-instance/variables-async&#x60; endpoints)</value>
        [DataMember(Name = "valueInfo", EmitDefaultValue = false)]
        public Dictionary<string, Object> ValueInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TriggerVariableValueDto {\n");
            sb.Append("  Local: ").Append(Local).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValueInfo: ").Append(ValueInfo).Append("\n");
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
            return this.Equals(input as TriggerVariableValueDto);
        }

        /// <summary>
        /// Returns true if TriggerVariableValueDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TriggerVariableValueDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TriggerVariableValueDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Local == input.Local ||
                    (this.Local != null &&
                    this.Local.Equals(input.Local))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ValueInfo == input.ValueInfo ||
                    this.ValueInfo != null &&
                    input.ValueInfo != null &&
                    this.ValueInfo.SequenceEqual(input.ValueInfo)
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
                if (this.Local != null)
                    hashCode = hashCode * 59 + this.Local.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ValueInfo != null)
                    hashCode = hashCode * 59 + this.ValueInfo.GetHashCode();
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
