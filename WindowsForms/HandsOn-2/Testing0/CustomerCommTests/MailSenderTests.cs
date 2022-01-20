using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using CustomerCommLib;



namespace CustomerCommTests
{
    [TestFixture]
     public class MailSenderTests
    {
        [Test]
        public void sendMailToCustomer()
        {
            var mailSender = new Mock<IMailSender>();
            mailSender.Setup(m => m.SendMail("cust123@abc.com", "Some Message")).Returns(true);
            CustomerComm cu = new CustomerComm(mailSender.Object);
            var res = cu.SendMailToCustomer();
            Assert.IsTrue(res);
        }



    }



}
