﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Lpp.CNDS.DTO
{
    [DataContract]
    public class DomainReferenceDTO
    {
        /// <summary>
        /// The Identifier for the DataReference
        /// </summary>
        [DataMember]
        public Guid ID { get; set; }
        /// <summary>
        /// The Identifier of the Domain
        /// </summary>
        [DataMember]
        public Guid DomainID { get; set; }
        /// <summary>
        /// The Identifier of the Parent DomainReference
        /// </summary>
        [DataMember]
        public Guid? ParentDomainReferenceID { get; set; }
        /// <summary>
        /// The Title of the Domain Reference
        /// </summary>
        [DataMember,Required, MaxLength(255)]
        public string Title { get; set; }
        /// <summary>
        /// The Description of the Domain Reference
        /// </summary>
        [DataMember]
        public string Description { get; set; }
        /// <summary>
        /// The Value of the Domain Reference
        /// </summary>
        [DataMember]
        public string Value { get; set; }
    }
}
