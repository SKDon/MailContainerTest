using Domain.Entities;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Model
{
    public class LargeLetter : IMailType
    {
        
        public bool GetMailType(MailContainer mailContainer)
        {
            var result = new MakeMailTransferResult();
            if (mailContainer == null)
            {
                result.Success = false;
            }
            else if (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.StandardLetter))
            {
                result.Success = false;
            }
            return result.Success;
        }
    }
}
