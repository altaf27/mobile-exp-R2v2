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
    /// PartacctrelrsIssuedIdentType
    /// </summary>
    [DataContract(Name = "partacctrelrs_IssuedIdent_Type")]
    public partial class PartacctrelrsIssuedIdentType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartacctrelrsIssuedIdentType" /> class.
        /// </summary>
        /// <param name="issuedIdentType">issuedIdentType.</param>
        /// <param name="issuedIdentValue">issuedIdentValue.</param>
        public PartacctrelrsIssuedIdentType(string issuedIdentType = default(string), string issuedIdentValue = default(string))
        {
            this.IssuedIdentType = issuedIdentType;
            this.IssuedIdentValue = issuedIdentValue;
        }

        /// <summary>
        /// Gets or Sets IssuedIdentType
        /// </summary>
        [DataMember(Name = "IssuedIdentType", EmitDefaultValue = false)]
        public string IssuedIdentType { get; set; }

        /// <summary>
        /// Gets or Sets IssuedIdentValue
        /// </summary>
        [DataMember(Name = "IssuedIdentValue", EmitDefaultValue = false)]
        public string IssuedIdentValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartacctrelrsIssuedIdentType {\n");
            sb.Append("  IssuedIdentType: ").Append(IssuedIdentType).Append("\n");
            sb.Append("  IssuedIdentValue: ").Append(IssuedIdentValue).Append("\n");
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
