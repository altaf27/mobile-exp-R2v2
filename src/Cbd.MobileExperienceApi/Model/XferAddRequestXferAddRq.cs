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
    /// XferAddRequestXferAddRq
    /// </summary>
    [DataContract(Name = "XferAdd_request_XferAddRq")]
    public partial class XferAddRequestXferAddRq : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XferAddRequestXferAddRq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected XferAddRequestXferAddRq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XferAddRequestXferAddRq" /> class.
        /// </summary>
        /// <param name="rqUID">rqUID (required).</param>
        /// <param name="msgRqHdr">msgRqHdr (required).</param>
        /// <param name="xferInfo">xferInfo (required).</param>
        public XferAddRequestXferAddRq(string rqUID = default(string), XferAddRequestXferAddRqMsgRqHdr msgRqHdr = default(XferAddRequestXferAddRqMsgRqHdr), XferAddRequestXferAddRqXferInfo xferInfo = default(XferAddRequestXferAddRqXferInfo))
        {
            // to ensure "rqUID" is required (not null)
            if (rqUID == null)
            {
                throw new ArgumentNullException("rqUID is a required property for XferAddRequestXferAddRq and cannot be null");
            }
            this.RqUID = rqUID;
            // to ensure "msgRqHdr" is required (not null)
            if (msgRqHdr == null)
            {
                throw new ArgumentNullException("msgRqHdr is a required property for XferAddRequestXferAddRq and cannot be null");
            }
            this.MsgRqHdr = msgRqHdr;
            // to ensure "xferInfo" is required (not null)
            if (xferInfo == null)
            {
                throw new ArgumentNullException("xferInfo is a required property for XferAddRequestXferAddRq and cannot be null");
            }
            this.XferInfo = xferInfo;
        }

        /// <summary>
        /// Gets or Sets RqUID
        /// </summary>
        [DataMember(Name = "RqUID", IsRequired = true, EmitDefaultValue = true)]
        public string RqUID { get; set; }

        /// <summary>
        /// Gets or Sets MsgRqHdr
        /// </summary>
        [DataMember(Name = "MsgRqHdr", IsRequired = true, EmitDefaultValue = true)]
        public XferAddRequestXferAddRqMsgRqHdr MsgRqHdr { get; set; }

        /// <summary>
        /// Gets or Sets XferInfo
        /// </summary>
        [DataMember(Name = "XferInfo", IsRequired = true, EmitDefaultValue = true)]
        public XferAddRequestXferAddRqXferInfo XferInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class XferAddRequestXferAddRq {\n");
            sb.Append("  RqUID: ").Append(RqUID).Append("\n");
            sb.Append("  MsgRqHdr: ").Append(MsgRqHdr).Append("\n");
            sb.Append("  XferInfo: ").Append(XferInfo).Append("\n");
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
