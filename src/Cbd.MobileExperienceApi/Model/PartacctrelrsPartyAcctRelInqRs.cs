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
    /// PartacctrelrsPartyAcctRelInqRs
    /// </summary>
    [DataContract(Name = "partacctrelrs_PartyAcctRelInqRs")]
    public partial class PartacctrelrsPartyAcctRelInqRs : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartacctrelrsPartyAcctRelInqRs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PartacctrelrsPartyAcctRelInqRs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartacctrelrsPartyAcctRelInqRs" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="rqUID">rqUID (required).</param>
        /// <param name="partyAcctRelRec">partyAcctRelRec.</param>
        public PartacctrelrsPartyAcctRelInqRs(PartyacctrelinqrsStatusType status = default(PartyacctrelinqrsStatusType), string rqUID = default(string), List<PartacctrelrsPartyAcctRelRecType> partyAcctRelRec = default(List<PartacctrelrsPartyAcctRelRecType>))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for PartacctrelrsPartyAcctRelInqRs and cannot be null");
            }
            this.Status = status;
            // to ensure "rqUID" is required (not null)
            if (rqUID == null)
            {
                throw new ArgumentNullException("rqUID is a required property for PartacctrelrsPartyAcctRelInqRs and cannot be null");
            }
            this.RqUID = rqUID;
            this.PartyAcctRelRec = partyAcctRelRec;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", IsRequired = true, EmitDefaultValue = true)]
        public PartyacctrelinqrsStatusType Status { get; set; }

        /// <summary>
        /// Gets or Sets RqUID
        /// </summary>
        [DataMember(Name = "RqUID", IsRequired = true, EmitDefaultValue = true)]
        public string RqUID { get; set; }

        /// <summary>
        /// Gets or Sets PartyAcctRelRec
        /// </summary>
        [DataMember(Name = "PartyAcctRelRec", EmitDefaultValue = false)]
        public List<PartacctrelrsPartyAcctRelRecType> PartyAcctRelRec { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartacctrelrsPartyAcctRelInqRs {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RqUID: ").Append(RqUID).Append("\n");
            sb.Append("  PartyAcctRelRec: ").Append(PartyAcctRelRec).Append("\n");
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
