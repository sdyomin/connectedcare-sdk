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
namespace SnapMD.VirtualCare.ApiModels
{

    public struct GetPatientsResponse
    {
        public string PatientName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string ProfileImagePath { get; set; }
        public string HomePhone { get; set; }
        public string PrimaryPhysician { get; set; }
        public string PrimaryPhysicianContact { get; set; }
        public string PhysicianSpecialist { get; set; }
        public string PhysicianSpecialistContact { get; set; }
        public string Organization { get; set; }
        public string Location { get; set; }
        public int? OrganizationId { get; set; }
        public int? LocationId { get; set; }

    }
}