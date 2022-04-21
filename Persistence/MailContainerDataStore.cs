using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class MailContainerDataStore
    {
        public MailContainer GetMailContainer(string mailContainerNumber)
        {
            // Access the database and return the retrieved mail container. Implementation not required for this exercise.
            return new MailContainer();
        }

        public void UpdateMailContainer(MailContainer mailContainer)
        {
            // Update mail container in the database. Implementation not required for this exercise.
        }

    }
}
