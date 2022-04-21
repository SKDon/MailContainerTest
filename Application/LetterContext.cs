using Application.Model;
using Domain.Entities;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class LetterContext
    {
        private Dictionary<MailType, IMailType> sortStrategy = new Dictionary<MailType, IMailType>();

        public LetterContext()
        {
            sortStrategy.Add(MailType.StandardLetter, new StandardLetter());
            sortStrategy.Add(MailType.LargeLetter, new LargeLetter());
            sortStrategy.Add(MailType.SmallParcel, new SmallParcel());
        }

        public bool GetMailType(MailType searchType, MailContainer mailContainer)
        {
            return sortStrategy[searchType].GetMailType(mailContainer);
        }

    }
}
