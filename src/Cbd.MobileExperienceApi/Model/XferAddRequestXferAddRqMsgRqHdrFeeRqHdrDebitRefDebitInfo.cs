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
    /// XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfo
    /// </summary>
    [DataContract(Name = "XferAdd_request_XferAddRq_MsgRqHdr_FeeRqHdr_DebitRef_DebitInfo")]
    public partial class XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfo" /> class.
        /// </summary>
        /// <param name="debitType">debitType.</param>
        /// <param name="debitDesc">debitDesc.</param>
        /// <param name="compositeCurAmt">compositeCurAmt.</param>
        /// <param name="acctRef">acctRef (required).</param>
        public XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfo(string debitType = default(string), string debitDesc = default(string), XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoCompositeCurAmt compositeCurAmt = default(XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoCompositeCurAmt), XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRef acctRef = default(XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRef))
        {
            // to ensure "acctRef" is required (not null)
            if (acctRef == null)
            {
                throw new ArgumentNullException("acctRef is a required property for XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfo and cannot be null");
            }
            this.AcctRef = acctRef;
            this.DebitType = debitType;
            this.DebitDesc = debitDesc;
            this.CompositeCurAmt = compositeCurAmt;
        }

        /// <summary>
        /// Gets or Sets DebitType
        /// </summary>
        [DataMember(Name = "DebitType", EmitDefaultValue = false)]
        public string DebitType { get; set; }

        /// <summary>
        /// Gets or Sets DebitDesc
        /// </summary>
        [DataMember(Name = "DebitDesc", EmitDefaultValue = false)]
        public string DebitDesc { get; set; }

        /// <summary>
        /// Gets or Sets CompositeCurAmt
        /// </summary>
        [DataMember(Name = "CompositeCurAmt", EmitDefaultValue = false)]
        public XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoCompositeCurAmt CompositeCurAmt { get; set; }

        /// <summary>
        /// Gets or Sets AcctRef
        /// </summary>
        [DataMember(Name = "AcctRef", IsRequired = true, EmitDefaultValue = true)]
        public XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRef AcctRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfo {\n");
            sb.Append("  DebitType: ").Append(DebitType).Append("\n");
            sb.Append("  DebitDesc: ").Append(DebitDesc).Append("\n");
            sb.Append("  CompositeCurAmt: ").Append(CompositeCurAmt).Append("\n");
            sb.Append("  AcctRef: ").Append(AcctRef).Append("\n");
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
            // DebitType (string) maxLength
            if (this.DebitType != null && this.DebitType.Length > 200)
            {
                yield return new ValidationResult("Invalid value for DebitType, length must be less than 200.", new [] { "DebitType" });
            }

            // DebitDesc (string) maxLength
            if (this.DebitDesc != null && this.DebitDesc.Length > 200)
            {
                yield return new ValidationResult("Invalid value for DebitDesc, length must be less than 200.", new [] { "DebitDesc" });
            }

            yield break;
        }
    }

}
