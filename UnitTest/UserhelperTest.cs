using EMS.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace EMSTest
{
    [TestClass]
    public class UserhelperTest
    {
        [TestMethod]
        public void GetAll()
        {
            var response = userhelper.GetAll();
            Assert.IsNotNull(response);
        }
        [TestMethod]
        public void GetById()
        {
            var response = userhelper.Get("659655");
            Assert.IsNotNull(response);
        }
        [TestMethod]
        public void GetByName()
        {
            var response = userhelper.GetByName("Jay Guneta");
            Assert.IsNotNull(response);
        }
        [TestMethod]
        public void Post()
        {    
            var response = userhelper.Post("Dipak", "d@mail.com", "male", "active");
            Assert.IsNotNull(response.Equals(201));
        }
        [TestMethod]
        public void Put()
        {
            var response = userhelper.Put("659656", "Dipak", "d@mail.com", "male", "active");
            Assert.IsNotNull(response.Equals(200));
        }
        [TestMethod]
        public void Delete()
        {
            var response = userhelper.Delete("659656");

            Assert.IsNotNull(response.Equals(204));
        }

    }
}
