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
    /// XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRef
    /// </summary>
    [DataContract(Name = "XferAdd_request_XferAddRq_MsgRqHdr_FeeRqHdr_DebitRef")]
    public partial class XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRef : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRef" /> class.
        /// </summary>
        /// <param name="debitInfo">debitInfo.</param>
        /// <param name="addDebitInfo">addDebitInfo.</param>
        public XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRef(XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfo debitInfo = default(XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfo), List<XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfo> addDebitInfo = default(List<XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfo>))
        {
            this.DebitInfo = debitInfo;
            this.AddDebitInfo = addDebitInfo;
        }

        /// <summary>
        /// Gets or Sets DebitInfo
        /// </summary>
        [DataMember(Name = "DebitInfo", EmitDefaultValue = false)]
        public XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfo DebitInfo { get; set; }

        /// <summary>
        /// Gets or Sets AddDebitInfo
        /// </summary>
        [DataMember(Name = "AddDebitInfo", EmitDefaultValue = false)]
        public List<XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfo> AddDebitInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRef {\n");
            sb.Append("  DebitInfo: ").Append(DebitInfo).Append("\n");
            sb.Append("  AddDebitInfo: ").Append(AddDebitInfo).Append("\n");
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
