using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class MailContainer
    {
        public string MailContainerNumber { get; set; }
        public int Capacity { get; set; }
        public MailContainerStatus Status { get; set; }
        public AllowedMailType AllowedMailType { get; set; }

    }
}
