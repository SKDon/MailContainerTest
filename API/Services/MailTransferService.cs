using API.Interface;
using Domain.Entities;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence;
using Domain.Enum;
using Application;

namespace API.Services
{
    public class MailTransferService : IMailTransferService
    {
        public MakeMailTransferResult MakeMailTransfer(MakeMailTransferRequest request)
        {
            var dataStoreType = ConfigurationManager.AppSettings["DataStoreType"];

            MailContainer mailContainer = null;

            if (dataStoreType == "Backup")
            {
                var mailContainerDataStore = new BackupMailContainerDataStore();
                mailContainer = mailContainerDataStore.GetMailContainer(request.SourceMailContainerNumber);

            }
            else
            {
                var mailContainerDataStore = new MailContainerDataStore();
                mailContainer = mailContainerDataStore.GetMailContainer(request.SourceMailContainerNumber);
            }

            var result = new MakeMailTransferResult();

            LetterContext sortingContext = new LetterContext();
            var data = sortingContext.GetMailType(request.MailType, mailContainer);
            result.Success = data;

            if (result.Success)
            {
                mailContainer.Capacity -= request.NumberOfMailItems;

                if (dataStoreType == "Backup")
                {
                    var mailContainerDataStore = new BackupMailContainerDataStore();
                    mailContainerDataStore.UpdateMailContainer(mailContainer);

                }
                else
                {
                    var mailContainerDataStore = new MailContainerDataStore();
                    mailContainerDataStore.UpdateMailContainer(mailContainer);
                }
            }

            return result;
        }
    }
}
