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
    /// CheckPasswordPolicyResultDto
    /// </summary>
    [DataContract(Name = "CheckPasswordPolicyResultDto")]
    public partial class CheckPasswordPolicyResultDto : IEquatable<CheckPasswordPolicyResultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckPasswordPolicyResultDto" /> class.
        /// </summary>
        /// <param name="valid">&#x60;true&#x60; if the password is compliant with the policy, otherwise &#x60;false&#x60;..</param>
        /// <param name="rules">An array of password policy rules. Each element of the array is representing one rule of the policy..</param>
        public CheckPasswordPolicyResultDto(bool? valid = default(bool?), List<PasswordPolicyRuleDto> rules = default(List<PasswordPolicyRuleDto>))
        {
            this.Valid = valid;
            this.Rules = rules;
        }

        /// <summary>
        /// &#x60;true&#x60; if the password is compliant with the policy, otherwise &#x60;false&#x60;.
        /// </summary>
        /// <value>&#x60;true&#x60; if the password is compliant with the policy, otherwise &#x60;false&#x60;.</value>
        [DataMember(Name = "valid", EmitDefaultValue = true)]
        public bool? Valid { get; set; }

        /// <summary>
        /// An array of password policy rules. Each element of the array is representing one rule of the policy.
        /// </summary>
        /// <value>An array of password policy rules. Each element of the array is representing one rule of the policy.</value>
        [DataMember(Name = "rules", EmitDefaultValue = true)]
        public List<PasswordPolicyRuleDto> Rules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckPasswordPolicyResultDto {\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
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
            return this.Equals(input as CheckPasswordPolicyResultDto);
        }

        /// <summary>
        /// Returns true if CheckPasswordPolicyResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckPasswordPolicyResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckPasswordPolicyResultDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Valid == input.Valid ||
                    (this.Valid != null &&
                    this.Valid.Equals(input.Valid))
                ) && 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
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
                if (this.Valid != null)
                    hashCode = hashCode * 59 + this.Valid.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
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
