﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VA.Gov.Artemis.Commands.Vpr.Data
{
    [Serializable]
    public class Clinician: CodeElement
    {
        [XmlAttribute("role")]
        public string Role { get; set; }

        // TODO: Make this vprdatetime ?
        [XmlAttribute("dateTime")]
        public string ClinicianDateTime { get; set; }

        [XmlAttribute("signature")]
        public string Signature { get; set; }
    }
}
