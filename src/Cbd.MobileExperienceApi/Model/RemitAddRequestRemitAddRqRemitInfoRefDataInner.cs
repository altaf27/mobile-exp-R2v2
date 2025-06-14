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
    /// RemitAddRequestRemitAddRqRemitInfoRefDataInner
    /// </summary>
    [DataContract(Name = "RemitAdd_request_RemitAddRq_RemitInfo_RefData_inner")]
    public partial class RemitAddRequestRemitAddRqRemitInfoRefDataInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemitAddRequestRemitAddRqRemitInfoRefDataInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RemitAddRequestRemitAddRqRemitInfoRefDataInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemitAddRequestRemitAddRqRemitInfoRefDataInner" /> class.
        /// </summary>
        /// <param name="refIdent">refIdent (required).</param>
        /// <param name="refDesc">refDesc (required).</param>
        public RemitAddRequestRemitAddRqRemitInfoRefDataInner(Object refIdent = default(Object), Object refDesc = default(Object))
        {
            // to ensure "refIdent" is required (not null)
            if (refIdent == null)
            {
                throw new ArgumentNullException("refIdent is a required property for RemitAddRequestRemitAddRqRemitInfoRefDataInner and cannot be null");
            }
            this.RefIdent = refIdent;
            // to ensure "refDesc" is required (not null)
            if (refDesc == null)
            {
                throw new ArgumentNullException("refDesc is a required property for RemitAddRequestRemitAddRqRemitInfoRefDataInner and cannot be null");
            }
            this.RefDesc = refDesc;
        }

        /// <summary>
        /// Gets or Sets RefIdent
        /// </summary>
        [DataMember(Name = "RefIdent", IsRequired = true, EmitDefaultValue = true)]
        public Object RefIdent { get; set; }

        /// <summary>
        /// Gets or Sets RefDesc
        /// </summary>
        [DataMember(Name = "RefDesc", IsRequired = true, EmitDefaultValue = true)]
        public Object RefDesc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RemitAddRequestRemitAddRqRemitInfoRefDataInner {\n");
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
            yield break;
        }
    }

}
