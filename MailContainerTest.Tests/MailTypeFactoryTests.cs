using Application;
using Domain.Entities;
using Domain.Enum;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailContainerTest.Tests
{
    [TestFixture]
    public class MailTypeFactoryTests
    {
        [Test]
        public void MailTypeFactory_Should_Return_false_When_Passed_GetMailType()
        {
            LetterContext sortingContext = new LetterContext();
            MailContainer mailContainer = null;
            var data = sortingContext.GetMailType(MailType.LargeLetter, mailContainer);
            Assert.AreEqual(0, data);
        }
    }
}
