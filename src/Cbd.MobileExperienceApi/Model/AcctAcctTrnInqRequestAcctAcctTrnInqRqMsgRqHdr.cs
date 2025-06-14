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
    /// AcctAcctTrnInqRequestAcctAcctTrnInqRqMsgRqHdr
    /// </summary>
    [DataContract(Name = "AcctAcctTrnInq_request_AcctAcctTrnInqRq_MsgRqHdr")]
    public partial class AcctAcctTrnInqRequestAcctAcctTrnInqRqMsgRqHdr : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcctAcctTrnInqRequestAcctAcctTrnInqRqMsgRqHdr" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AcctAcctTrnInqRequestAcctAcctTrnInqRqMsgRqHdr() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AcctAcctTrnInqRequestAcctAcctTrnInqRqMsgRqHdr" /> class.
        /// </summary>
        /// <param name="svcIdent">svcIdent (required).</param>
        public AcctAcctTrnInqRequestAcctAcctTrnInqRqMsgRqHdr(AcctAcctTrnInqRequestAcctAcctTrnInqRqMsgRqHdrSvcIdent svcIdent = default(AcctAcctTrnInqRequestAcctAcctTrnInqRqMsgRqHdrSvcIdent))
        {
            // to ensure "svcIdent" is required (not null)
            if (svcIdent == null)
            {
                throw new ArgumentNullException("svcIdent is a required property for AcctAcctTrnInqRequestAcctAcctTrnInqRqMsgRqHdr and cannot be null");
            }
            this.SvcIdent = svcIdent;
        }

        /// <summary>
        /// Gets or Sets SvcIdent
        /// </summary>
        [DataMember(Name = "SvcIdent", IsRequired = true, EmitDefaultValue = true)]
        public AcctAcctTrnInqRequestAcctAcctTrnInqRqMsgRqHdrSvcIdent SvcIdent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AcctAcctTrnInqRequestAcctAcctTrnInqRqMsgRqHdr {\n");
            sb.Append("  SvcIdent: ").Append(SvcIdent).Append("\n");
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
            yield break;
        }
    }

}
