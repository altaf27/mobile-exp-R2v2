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
    /// PartacctrelrsAcctBalType
    /// </summary>
    [DataContract(Name = "partacctrelrs_AcctBal_Type")]
    public partial class PartacctrelrsAcctBalType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartacctrelrsAcctBalType" /> class.
        /// </summary>
        /// <param name="balType">balType.</param>
        /// <param name="curAmt">curAmt.</param>
        public PartacctrelrsAcctBalType(string balType = default(string), PartacctrelrsCurAmtType curAmt = default(PartacctrelrsCurAmtType))
        {
            this.BalType = balType;
            this.CurAmt = curAmt;
        }

        /// <summary>
        /// Gets or Sets BalType
        /// </summary>
        [DataMember(Name = "BalType", EmitDefaultValue = false)]
        public string BalType { get; set; }

        /// <summary>
        /// Gets or Sets CurAmt
        /// </summary>
        [DataMember(Name = "CurAmt", EmitDefaultValue = false)]
        public PartacctrelrsCurAmtType CurAmt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartacctrelrsAcctBalType {\n");
            sb.Append("  BalType: ").Append(BalType).Append("\n");
            sb.Append("  CurAmt: ").Append(CurAmt).Append("\n");
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
