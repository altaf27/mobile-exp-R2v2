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
    /// AcctAcctTrnInqResponseAcctAcctTrnInqRs
    /// </summary>
    [DataContract(Name = "AcctAcctTrnInq_response_AcctAcctTrnInqRs")]
    public partial class AcctAcctTrnInqResponseAcctAcctTrnInqRs : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcctAcctTrnInqResponseAcctAcctTrnInqRs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AcctAcctTrnInqResponseAcctAcctTrnInqRs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AcctAcctTrnInqResponseAcctAcctTrnInqRs" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="additionalStatus">additionalStatus.</param>
        /// <param name="rqUID">rqUID.</param>
        /// <param name="acctStmtHdr">acctStmtHdr.</param>
        /// <param name="acctTrnRec">acctTrnRec.</param>
        public AcctAcctTrnInqResponseAcctAcctTrnInqRs(AcctAcctTrnInqResponseAcctAcctTrnInqRsStatus status = default(AcctAcctTrnInqResponseAcctAcctTrnInqRsStatus), AcctAcctTrnInqResponseAcctAcctTrnInqRsStatus additionalStatus = default(AcctAcctTrnInqResponseAcctAcctTrnInqRsStatus), string rqUID = default(string), AcctAcctTrnInqResponseAcctAcctTrnInqRsAcctStmtHdr acctStmtHdr = default(AcctAcctTrnInqResponseAcctAcctTrnInqRsAcctStmtHdr), List<AcctAcctTrnInqResponseAcctAcctTrnInqRsAcctTrnRecInner> acctTrnRec = default(List<AcctAcctTrnInqResponseAcctAcctTrnInqRsAcctTrnRecInner>))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for AcctAcctTrnInqResponseAcctAcctTrnInqRs and cannot be null");
            }
            this.Status = status;
            this.AdditionalStatus = additionalStatus;
            this.RqUID = rqUID;
            this.AcctStmtHdr = acctStmtHdr;
            this.AcctTrnRec = acctTrnRec;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", IsRequired = true, EmitDefaultValue = true)]
        public AcctAcctTrnInqResponseAcctAcctTrnInqRsStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalStatus
        /// </summary>
        [DataMember(Name = "AdditionalStatus", EmitDefaultValue = false)]
        public AcctAcctTrnInqResponseAcctAcctTrnInqRsStatus AdditionalStatus { get; set; }

        /// <summary>
        /// Gets or Sets RqUID
        /// </summary>
        [DataMember(Name = "RqUID", EmitDefaultValue = false)]
        public string RqUID { get; set; }

        /// <summary>
        /// Gets or Sets AcctStmtHdr
        /// </summary>
        [DataMember(Name = "AcctStmtHdr", EmitDefaultValue = false)]
        public AcctAcctTrnInqResponseAcctAcctTrnInqRsAcctStmtHdr AcctStmtHdr { get; set; }

        /// <summary>
        /// Gets or Sets AcctTrnRec
        /// </summary>
        [DataMember(Name = "AcctTrnRec", EmitDefaultValue = false)]
        public List<AcctAcctTrnInqResponseAcctAcctTrnInqRsAcctTrnRecInner> AcctTrnRec { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AcctAcctTrnInqResponseAcctAcctTrnInqRs {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  AdditionalStatus: ").Append(AdditionalStatus).Append("\n");
            sb.Append("  RqUID: ").Append(RqUID).Append("\n");
            sb.Append("  AcctStmtHdr: ").Append(AcctStmtHdr).Append("\n");
            sb.Append("  AcctTrnRec: ").Append(AcctTrnRec).Append("\n");
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
