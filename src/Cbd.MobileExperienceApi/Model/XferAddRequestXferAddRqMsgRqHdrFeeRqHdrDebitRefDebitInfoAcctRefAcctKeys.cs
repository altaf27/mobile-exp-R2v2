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
    /// XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRefAcctKeys
    /// </summary>
    [DataContract(Name = "XferAdd_request_XferAddRq_MsgRqHdr_FeeRqHdr_DebitRef_DebitInfo_AcctRef_AcctKeys")]
    public partial class XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRefAcctKeys : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRefAcctKeys" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRefAcctKeys() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRefAcctKeys" /> class.
        /// </summary>
        /// <param name="acctId">acctId (required).</param>
        /// <param name="acctType">acctType.</param>
        /// <param name="curCode">curCode.</param>
        public XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRefAcctKeys(string acctId = default(string), string acctType = default(string), XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoCompositeCurAmtCurAmtCurCode curCode = default(XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoCompositeCurAmtCurAmtCurCode))
        {
            // to ensure "acctId" is required (not null)
            if (acctId == null)
            {
                throw new ArgumentNullException("acctId is a required property for XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRefAcctKeys and cannot be null");
            }
            this.AcctId = acctId;
            this.AcctType = acctType;
            this.CurCode = curCode;
        }

        /// <summary>
        /// Gets or Sets AcctId
        /// </summary>
        [DataMember(Name = "AcctId", IsRequired = true, EmitDefaultValue = true)]
        public string AcctId { get; set; }

        /// <summary>
        /// Gets or Sets AcctType
        /// </summary>
        [DataMember(Name = "AcctType", EmitDefaultValue = false)]
        public string AcctType { get; set; }

        /// <summary>
        /// Gets or Sets CurCode
        /// </summary>
        [DataMember(Name = "CurCode", EmitDefaultValue = false)]
        public XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoCompositeCurAmtCurAmtCurCode CurCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRefAcctKeys {\n");
            sb.Append("  AcctId: ").Append(AcctId).Append("\n");
            sb.Append("  AcctType: ").Append(AcctType).Append("\n");
            sb.Append("  CurCode: ").Append(CurCode).Append("\n");
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
            // AcctType (string) maxLength
            if (this.AcctType != null && this.AcctType.Length > 200)
            {
                yield return new ValidationResult("Invalid value for AcctType, length must be less than 200.", new [] { "AcctType" });
            }

            yield break;
        }
    }

}
