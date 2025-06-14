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
    /// XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRef
    /// </summary>
    [DataContract(Name = "XferAdd_request_XferAddRq_MsgRqHdr_FeeRqHdr_DebitRef_DebitInfo_AcctRef")]
    public partial class XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRef : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRef" /> class.
        /// </summary>
        /// <param name="acctKeys">acctKeys (required).</param>
        public XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRef(XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRefAcctKeys acctKeys = default(XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRefAcctKeys))
        {
            // to ensure "acctKeys" is required (not null)
            if (acctKeys == null)
            {
                throw new ArgumentNullException("acctKeys is a required property for XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRef and cannot be null");
            }
            this.AcctKeys = acctKeys;
        }

        /// <summary>
        /// Gets or Sets AcctKeys
        /// </summary>
        [DataMember(Name = "AcctKeys", IsRequired = true, EmitDefaultValue = true)]
        public XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRefAcctKeys AcctKeys { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRef {\n");
            sb.Append("  AcctKeys: ").Append(AcctKeys).Append("\n");
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
