using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class MakeMailTransferRequest
    {
        public string SourceMailContainerNumber { get; set; }
        public string DestinationMailContainerNumber { get; set; }
        public int NumberOfMailItems { get; set; }
        public DateTime TransferDate { get; set; }
        public MailType MailType { get; set; }
    }
}
