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
    /// RemitAddRequestRemitAddRqRemitInfoPmtInstructionPartyInfo
    /// </summary>
    [DataContract(Name = "RemitAdd_request_RemitAddRq_RemitInfo_PmtInstruction_PartyInfo")]
    public partial class RemitAddRequestRemitAddRqRemitInfoPmtInstructionPartyInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemitAddRequestRemitAddRqRemitInfoPmtInstructionPartyInfo" /> class.
        /// </summary>
        /// <param name="partyIdType">partyIdType.</param>
        /// <param name="partyIdStatus">partyIdStatus.</param>
        /// <param name="loginIdent">loginIdent.</param>
        /// <param name="serviceLevelCode">serviceLevelCode.</param>
        /// <param name="serviceLevelDesc">serviceLevelDesc.</param>
        /// <param name="classCode">classCode.</param>
        /// <param name="classCodeDesc">classCodeDesc.</param>
        /// <param name="partyStatus">partyStatus.</param>
        /// <param name="personData">personData.</param>
        public RemitAddRequestRemitAddRqRemitInfoPmtInstructionPartyInfo(Object partyIdType = default(Object), Object partyIdStatus = default(Object), RemitAddRequestRemitAddRqMsgRqHdrCredentialsRqHdrLoginIdent loginIdent = default(RemitAddRequestRemitAddRqMsgRqHdrCredentialsRqHdrLoginIdent), Object serviceLevelCode = default(Object), Object serviceLevelDesc = default(Object), Object classCode = default(Object), Object classCodeDesc = default(Object), Object partyStatus = default(Object), RemitAddRequestRemitAddRqRemitInfoPmtInstructionPartyInfoPersonData personData = default(RemitAddRequestRemitAddRqRemitInfoPmtInstructionPartyInfoPersonData))
        {
            this.PartyIdType = partyIdType;
            this.PartyIdStatus = partyIdStatus;
            this.LoginIdent = loginIdent;
            this.ServiceLevelCode = serviceLevelCode;
            this.ServiceLevelDesc = serviceLevelDesc;
            this.ClassCode = classCode;
            this.ClassCodeDesc = classCodeDesc;
            this.PartyStatus = partyStatus;
            this.PersonData = personData;
        }

        /// <summary>
        /// Gets or Sets PartyIdType
        /// </summary>
        [DataMember(Name = "PartyIdType", EmitDefaultValue = false)]
        public Object PartyIdType { get; set; }

        /// <summary>
        /// Gets or Sets PartyIdStatus
        /// </summary>
        [DataMember(Name = "PartyIdStatus", EmitDefaultValue = false)]
        public Object PartyIdStatus { get; set; }

        /// <summary>
        /// Gets or Sets LoginIdent
        /// </summary>
        [DataMember(Name = "LoginIdent", EmitDefaultValue = false)]
        public RemitAddRequestRemitAddRqMsgRqHdrCredentialsRqHdrLoginIdent LoginIdent { get; set; }

        /// <summary>
        /// Gets or Sets ServiceLevelCode
        /// </summary>
        [DataMember(Name = "ServiceLevelCode", EmitDefaultValue = false)]
        public Object ServiceLevelCode { get; set; }

        /// <summary>
        /// Gets or Sets ServiceLevelDesc
        /// </summary>
        [DataMember(Name = "ServiceLevelDesc", EmitDefaultValue = false)]
        public Object ServiceLevelDesc { get; set; }

        /// <summary>
        /// Gets or Sets ClassCode
        /// </summary>
        [DataMember(Name = "ClassCode", EmitDefaultValue = false)]
        public Object ClassCode { get; set; }

        /// <summary>
        /// Gets or Sets ClassCodeDesc
        /// </summary>
        [DataMember(Name = "ClassCodeDesc", EmitDefaultValue = false)]
        public Object ClassCodeDesc { get; set; }

        /// <summary>
        /// Gets or Sets PartyStatus
        /// </summary>
        [DataMember(Name = "PartyStatus", EmitDefaultValue = false)]
        public Object PartyStatus { get; set; }

        /// <summary>
        /// Gets or Sets PersonData
        /// </summary>
        [DataMember(Name = "PersonData", EmitDefaultValue = false)]
        public RemitAddRequestRemitAddRqRemitInfoPmtInstructionPartyInfoPersonData PersonData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RemitAddRequestRemitAddRqRemitInfoPmtInstructionPartyInfo {\n");
            sb.Append("  PartyIdType: ").Append(PartyIdType).Append("\n");
            sb.Append("  PartyIdStatus: ").Append(PartyIdStatus).Append("\n");
            sb.Append("  LoginIdent: ").Append(LoginIdent).Append("\n");
            sb.Append("  ServiceLevelCode: ").Append(ServiceLevelCode).Append("\n");
            sb.Append("  ServiceLevelDesc: ").Append(ServiceLevelDesc).Append("\n");
            sb.Append("  ClassCode: ").Append(ClassCode).Append("\n");
            sb.Append("  ClassCodeDesc: ").Append(ClassCodeDesc).Append("\n");
            sb.Append("  PartyStatus: ").Append(PartyStatus).Append("\n");
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
