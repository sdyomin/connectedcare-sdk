﻿#region Copyright
//    Copyright 2016 SnapMD, Inc.
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        http://www.apache.org/licenses/LICENSE-2.0
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
#endregion

using System.Collections.Generic;
using System.Xml.Serialization;

namespace SnapMD.VirtualCare.ApiModels
{
    [XmlRoot("IntakeQuestionnaire", Namespace = "https://snap.md/api/v2/xml/encounters")]
    public class IntakeQuestionnaire : MedicalHistoryProfile, IIntakeQuestionnaire
    {
        public IntakeQuestionnaire()
        {
            MedicationAllergies = new List<CustomCode>();
            Surgeries = new List<SurgeryRecord>();
            MedicalConditions = new List<CustomCode>();
            Medications = new List<CustomCode>();
            InfantData = new NewbornRecord();
            Concerns = new List<EncounterConcern>();
            GuardiansRecords = new List<GuardianRecord>();
        }

        [XmlArray("EncounterConcerns")]
        [XmlArrayItem("Concern")]
        public List<EncounterConcern> Concerns { get; set; }

        public PatientRecord PatientRecord { get; set; }

        public DoctorRecord DoctorRecord { get; set; }

        public HospitalRecord HospitalRecord { get; set; }

        public List<GuardianRecord> GuardiansRecords { get; set; }

        /// <summary>
        /// Additional appointment notes
        /// </summary>
        public string AdditionalNotes { get; set; }
    }
}
