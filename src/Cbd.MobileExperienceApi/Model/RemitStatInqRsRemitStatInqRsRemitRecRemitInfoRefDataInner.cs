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
    /// RemitStatInqRsRemitStatInqRsRemitRecRemitInfoRefDataInner
    /// </summary>
    [DataContract(Name = "RemitStatInq_rs_RemitStatInqRs_RemitRec_RemitInfo_RefData_inner")]
    public partial class RemitStatInqRsRemitStatInqRsRemitRecRemitInfoRefDataInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemitStatInqRsRemitStatInqRsRemitRecRemitInfoRefDataInner" /> class.
        /// </summary>
        /// <param name="refIdent">refIdent.</param>
        /// <param name="refDesc">refDesc.</param>
        public RemitStatInqRsRemitStatInqRsRemitRecRemitInfoRefDataInner(string refIdent = default(string), string refDesc = default(string))
        {
            this.RefIdent = refIdent;
            this.RefDesc = refDesc;
        }

        /// <summary>
        /// Gets or Sets RefIdent
        /// </summary>
        [DataMember(Name = "RefIdent", EmitDefaultValue = false)]
        public string RefIdent { get; set; }

        /// <summary>
        /// Gets or Sets RefDesc
        /// </summary>
        [DataMember(Name = "RefDesc", EmitDefaultValue = false)]
        public string RefDesc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RemitStatInqRsRemitStatInqRsRemitRecRemitInfoRefDataInner {\n");
            sb.Append("  RefIdent: ").Append(RefIdent).Append("\n");
            sb.Append("  RefDesc: ").Append(RefDesc).Append("\n");
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
            // RefIdent (string) maxLength
            if (this.RefIdent != null && this.RefIdent.Length > 30)
            {
                yield return new ValidationResult("Invalid value for RefIdent, length must be less than 30.", new [] { "RefIdent" });
            }

            // RefDesc (string) maxLength
            if (this.RefDesc != null && this.RefDesc.Length > 256)
            {
                yield return new ValidationResult("Invalid value for RefDesc, length must be less than 256.", new [] { "RefDesc" });
            }

            yield break;
        }
    }

}
