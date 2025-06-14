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
    /// XferAddRequestXferAddRqXferInfo
    /// </summary>
    [DataContract(Name = "XferAdd_request_XferAddRq_XferInfo")]
    public partial class XferAddRequestXferAddRqXferInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XferAddRequestXferAddRqXferInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected XferAddRequestXferAddRqXferInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XferAddRequestXferAddRqXferInfo" /> class.
        /// </summary>
        /// <param name="fromAcctRef">fromAcctRef (required).</param>
        /// <param name="toAcctRef">toAcctRef (required).</param>
        /// <param name="chkNum">chkNum.</param>
        /// <param name="curAmt">curAmt (required).</param>
        /// <param name="dueDt">dueDt.</param>
        /// <param name="expediteInd">expediteInd (required).</param>
        /// <param name="reversalInd">reversalInd (required).</param>
        /// <param name="debitInd">debitInd (required).</param>
        /// <param name="checkDupInd">checkDupInd.</param>
        /// <param name="forExDealRef">forExDealRef.</param>
        /// <param name="checkLimitInd">checkLimitInd.</param>
        /// <param name="userName">userName.</param>
        /// <param name="refData">refData (required).</param>
        public XferAddRequestXferAddRqXferInfo(XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRef fromAcctRef = default(XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRef), XferAddRequestXferAddRqXferInfoToAcctRef toAcctRef = default(XferAddRequestXferAddRqXferInfoToAcctRef), string chkNum = default(string), XferAddRequestXferAddRqXferInfoCurAmt curAmt = default(XferAddRequestXferAddRqXferInfoCurAmt), DateOnly dueDt = default(DateOnly), bool expediteInd = default(bool), bool reversalInd = default(bool), bool debitInd = default(bool), bool checkDupInd = default(bool), XferAddRequestXferAddRqXferInfoForExDealRef forExDealRef = default(XferAddRequestXferAddRqXferInfoForExDealRef), bool checkLimitInd = default(bool), Object userName = default(Object), XferAddRequestXferAddRqXferInfoRefData refData = default(XferAddRequestXferAddRqXferInfoRefData))
        {
            // to ensure "fromAcctRef" is required (not null)
            if (fromAcctRef == null)
            {
                throw new ArgumentNullException("fromAcctRef is a required property for XferAddRequestXferAddRqXferInfo and cannot be null");
            }
            this.FromAcctRef = fromAcctRef;
            // to ensure "toAcctRef" is required (not null)
            if (toAcctRef == null)
            {
                throw new ArgumentNullException("toAcctRef is a required property for XferAddRequestXferAddRqXferInfo and cannot be null");
            }
            this.ToAcctRef = toAcctRef;
            // to ensure "curAmt" is required (not null)
            if (curAmt == null)
            {
                throw new ArgumentNullException("curAmt is a required property for XferAddRequestXferAddRqXferInfo and cannot be null");
            }
            this.CurAmt = curAmt;
            this.ExpediteInd = expediteInd;
            this.ReversalInd = reversalInd;
            this.DebitInd = debitInd;
            // to ensure "refData" is required (not null)
            if (refData == null)
            {
                throw new ArgumentNullException("refData is a required property for XferAddRequestXferAddRqXferInfo and cannot be null");
            }
            this.RefData = refData;
            this.ChkNum = chkNum;
            this.DueDt = dueDt;
            this.CheckDupInd = checkDupInd;
            this.ForExDealRef = forExDealRef;
            this.CheckLimitInd = checkLimitInd;
            this.UserName = userName;
        }

        /// <summary>
        /// Gets or Sets FromAcctRef
        /// </summary>
        [DataMember(Name = "FromAcctRef", IsRequired = true, EmitDefaultValue = true)]
        public XferAddRequestXferAddRqMsgRqHdrFeeRqHdrDebitRefDebitInfoAcctRef FromAcctRef { get; set; }

        /// <summary>
        /// Gets or Sets ToAcctRef
        /// </summary>
        [DataMember(Name = "ToAcctRef", IsRequired = true, EmitDefaultValue = true)]
        public XferAddRequestXferAddRqXferInfoToAcctRef ToAcctRef { get; set; }

        /// <summary>
        /// Gets or Sets ChkNum
        /// </summary>
        [DataMember(Name = "ChkNum", EmitDefaultValue = false)]
        public string ChkNum { get; set; }

        /// <summary>
        /// Gets or Sets CurAmt
        /// </summary>
        [DataMember(Name = "CurAmt", IsRequired = true, EmitDefaultValue = true)]
        public XferAddRequestXferAddRqXferInfoCurAmt CurAmt { get; set; }

        /// <summary>
        /// Gets or Sets DueDt
        /// </summary>
        [DataMember(Name = "DueDt", EmitDefaultValue = false)]
        public DateOnly DueDt { get; set; }

        /// <summary>
        /// Gets or Sets ExpediteInd
        /// </summary>
        [DataMember(Name = "ExpediteInd", IsRequired = true, EmitDefaultValue = true)]
        public bool ExpediteInd { get; set; }

        /// <summary>
        /// Gets or Sets ReversalInd
        /// </summary>
        [DataMember(Name = "ReversalInd", IsRequired = true, EmitDefaultValue = true)]
        public bool ReversalInd { get; set; }

        /// <summary>
        /// Gets or Sets DebitInd
        /// </summary>
        [DataMember(Name = "DebitInd", IsRequired = true, EmitDefaultValue = true)]
        public bool DebitInd { get; set; }

        /// <summary>
        /// Gets or Sets CheckDupInd
        /// </summary>
        [DataMember(Name = "CheckDupInd", EmitDefaultValue = true)]
        public bool CheckDupInd { get; set; }

        /// <summary>
        /// Gets or Sets ForExDealRef
        /// </summary>
        [DataMember(Name = "ForExDealRef", EmitDefaultValue = false)]
        public XferAddRequestXferAddRqXferInfoForExDealRef ForExDealRef { get; set; }

        /// <summary>
        /// Gets or Sets CheckLimitInd
        /// </summary>
        [DataMember(Name = "CheckLimitInd", EmitDefaultValue = true)]
        public bool CheckLimitInd { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "UserName", EmitDefaultValue = false)]
        public Object UserName { get; set; }

        /// <summary>
        /// Gets or Sets RefData
        /// </summary>
        [DataMember(Name = "RefData", IsRequired = true, EmitDefaultValue = true)]
        public XferAddRequestXferAddRqXferInfoRefData RefData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class XferAddRequestXferAddRqXferInfo {\n");
            sb.Append("  FromAcctRef: ").Append(FromAcctRef).Append("\n");
            sb.Append("  ToAcctRef: ").Append(ToAcctRef).Append("\n");
            sb.Append("  ChkNum: ").Append(ChkNum).Append("\n");
            sb.Append("  CurAmt: ").Append(CurAmt).Append("\n");
            sb.Append("  DueDt: ").Append(DueDt).Append("\n");
            sb.Append("  ExpediteInd: ").Append(ExpediteInd).Append("\n");
            sb.Append("  ReversalInd: ").Append(ReversalInd).Append("\n");
            sb.Append("  DebitInd: ").Append(DebitInd).Append("\n");
            sb.Append("  CheckDupInd: ").Append(CheckDupInd).Append("\n");
            sb.Append("  ForExDealRef: ").Append(ForExDealRef).Append("\n");
            sb.Append("  CheckLimitInd: ").Append(CheckLimitInd).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  RefData: ").Append(RefData).Append("\n");
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
            // ChkNum (string) maxLength
            if (this.ChkNum != null && this.ChkNum.Length > 108)
            {
                yield return new ValidationResult("Invalid value for ChkNum, length must be less than 108.", new [] { "ChkNum" });
            }

            yield break;
        }
    }

}
