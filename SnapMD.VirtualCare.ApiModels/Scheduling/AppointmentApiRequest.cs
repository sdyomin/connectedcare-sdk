﻿using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Appointment creation request model.
    /// </summary>
    public class AppointmentApiRequest
    {
        /// <summary>
        /// Availability block id.
        /// </summary>
        public Guid? AvailabilityBlockId { get; set; }

        /// <summary>
        /// Waive fee.
        /// </summary>
        public bool WaiveFee { get; set; }

        /// <summary>
        /// Appointment start time.
        /// </summary>
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// Appointment end time.
        /// </summary>
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// PatientQueue id.
        /// </summary>
        public Guid? PatientQueueId { get; set; }

        /// <summary>
        /// Appointment type.
        /// </summary>
        public AppointmentTypeCode AppointmentTypeCode { get; set; }

        /// <summary>
        /// Intake metadata (Concerns and additional notes).
        /// </summary>
        public AppointmentIntakeMetadata IntakeMetadata { get; set; }

        /// <summary>
        /// Appointment participants.
        /// </summary>
        public List<AppointmentParticipantRequest> Participants { get; set; }
    }
}
