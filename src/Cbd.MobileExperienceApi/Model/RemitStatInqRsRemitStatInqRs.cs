/*
 * exp-openfinance-api
 *
 * Ex  perience API for OpenFinance
 *
 * The version of the OpenAPI document: 1.0
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
using FileParameter = Cbd.MobileExperienceApi.Client.FileParameter;
using OpenAPIDateConverter = Cbd.MobileExperienceApi.Client.OpenAPIDateConverter;

namespace Cbd.MobileExperienceApi.Model
{
    /// <summary>
    /// RemitStatInqRsRemitStatInqRs
    /// </summary>
    [DataContract(Name = "RemitStatInq_rs_RemitStatInqRs")]
    public partial class RemitStatInqRsRemitStatInqRs : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemitStatInqRsRemitStatInqRs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RemitStatInqRsRemitStatInqRs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemitStatInqRsRemitStatInqRs" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="rqUID">rqUID (required).</param>
        /// <param name="remitRec">remitRec.</param>
        /// <param name="remitStatusRec">remitStatusRec.</param>
        public RemitStatInqRsRemitStatInqRs(RemitStatInqRsRemitStatInqRsStatus status = default(RemitStatInqRsRemitStatInqRsStatus), string rqUID = default(string), RemitStatInqRsRemitStatInqRsRemitRec remitRec = default(RemitStatInqRsRemitStatInqRsRemitRec), RemitStatInqRsRemitStatInqRsRemitStatusRec remitStatusRec = default(RemitStatInqRsRemitStatInqRsRemitStatusRec))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for RemitStatInqRsRemitStatInqRs and cannot be null");
            }
            this.Status = status;
            // to ensure "rqUID" is required (not null)
            if (rqUID == null)
            {
                throw new ArgumentNullException("rqUID is a required property for RemitStatInqRsRemitStatInqRs and cannot be null");
            }
            this.RqUID = rqUID;
            this.RemitRec = remitRec;
            this.RemitStatusRec = remitStatusRec;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", IsRequired = true, EmitDefaultValue = true)]
        public RemitStatInqRsRemitStatInqRsStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets RqUID
        /// </summary>
        [DataMember(Name = "RqUID", IsRequired = true, EmitDefaultValue = true)]
        public string RqUID { get; set; }

        /// <summary>
        /// Gets or Sets RemitRec
        /// </summary>
        [DataMember(Name = "RemitRec", EmitDefaultValue = false)]
        public RemitStatInqRsRemitStatInqRsRemitRec RemitRec { get; set; }

        /// <summary>
        /// Gets or Sets RemitStatusRec
        /// </summary>
        [DataMember(Name = "RemitStatusRec", EmitDefaultValue = false)]
        public RemitStatInqRsRemitStatInqRsRemitStatusRec RemitStatusRec { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RemitStatInqRsRemitStatInqRs {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RqUID: ").Append(RqUID).Append("\n");
            sb.Append("  RemitRec: ").Append(RemitRec).Append("\n");
            sb.Append("  RemitStatusRec: ").Append(RemitStatusRec).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // RqUID (string) maxLength
            if (this.RqUID != null && this.RqUID.Length > 36)
            {
                yield return new ValidationResult("Invalid value for RqUID, length must be less than 36.", new [] { "RqUID" });
            }

            if (this.RqUID != null) {
                // RqUID (string) pattern
                Regex regexRqUID = new Regex(@"^([0-9]|[a-f]|[A-F]){8}(-([0-9]|[a-f]|[A-F]){4})(-([0-9]|[a-f]|[A-F]){4})(-([0-9]|[a-f]|[A-F]){4})(-([0-9]|[a-f]|[A-F]){12})$", RegexOptions.CultureInvariant);
                if (!regexRqUID.Match(this.RqUID).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RqUID, must match a pattern of " + regexRqUID, new [] { "RqUID" });
                }
            }

            yield break;
        }
    }

}
