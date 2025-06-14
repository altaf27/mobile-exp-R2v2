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
    /// PartacctrelrsAcctClassType
    /// </summary>
    [DataContract(Name = "partacctrelrs_AcctClass_Type")]
    public partial class PartacctrelrsAcctClassType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartacctrelrsAcctClassType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PartacctrelrsAcctClassType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartacctrelrsAcctClassType" /> class.
        /// </summary>
        /// <param name="acctClassCode">acctClassCode (required).</param>
        /// <param name="acctClassDesc">acctClassDesc.</param>
        public PartacctrelrsAcctClassType(string acctClassCode = default(string), string acctClassDesc = default(string))
        {
            // to ensure "acctClassCode" is required (not null)
            if (acctClassCode == null)
            {
                throw new ArgumentNullException("acctClassCode is a required property for PartacctrelrsAcctClassType and cannot be null");
            }
            this.AcctClassCode = acctClassCode;
            this.AcctClassDesc = acctClassDesc;
        }

        /// <summary>
        /// Gets or Sets AcctClassCode
        /// </summary>
        [DataMember(Name = "AcctClassCode", IsRequired = true, EmitDefaultValue = true)]
        public string AcctClassCode { get; set; }

        /// <summary>
        /// Gets or Sets AcctClassDesc
        /// </summary>
        [DataMember(Name = "AcctClassDesc", EmitDefaultValue = false)]
        public string AcctClassDesc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartacctrelrsAcctClassType {\n");
            sb.Append("  AcctClassCode: ").Append(AcctClassCode).Append("\n");
            sb.Append("  AcctClassDesc: ").Append(AcctClassDesc).Append("\n");
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
