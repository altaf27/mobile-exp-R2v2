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
    /// PartacctrelrsPersonPartyInfoType
    /// </summary>
    [DataContract(Name = "partacctrelrs_PersonPartyInfo_Type")]
    public partial class PartacctrelrsPersonPartyInfoType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartacctrelrsPersonPartyInfoType" /> class.
        /// </summary>
        /// <param name="personData">personData.</param>
        public PartacctrelrsPersonPartyInfoType(PartacctrelrsPersonDataType personData = default(PartacctrelrsPersonDataType))
        {
            this.PersonData = personData;
        }

        /// <summary>
        /// Gets or Sets PersonData
        /// </summary>
        [DataMember(Name = "PersonData", EmitDefaultValue = false)]
        public PartacctrelrsPersonDataType PersonData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartacctrelrsPersonPartyInfoType {\n");
            sb.Append("  PersonData: ").Append(PersonData).Append("\n");
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
