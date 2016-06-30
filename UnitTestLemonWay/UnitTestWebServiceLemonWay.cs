using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLemonWay
{
    [TestClass]
    public class UnitTestWebServiceLemonWay
    {
        /// <summary>
        /// Test de la webmethode XmlToJson du webservice
        /// </summary>
        [TestMethod]
        public void TestWebServicesXmlToJson()
        {
            var target = new ServiceReferenceLemonWay.WebServiceTestTechniqueSoapClient();
            //Flux XML à parser
            var xml =
                    @"<Columns>
              <Column Name=""key1"" DataType=""Boolean"">True</Column>
              <Column Name=""key2"" DataType=""String"">Hello World</Column>
              <Column Name=""key3"" DataType=""Integer"">999</Column>
            </Columns>";
            string result = target.XmlToJson(xml);
            //Résultat attendu
            string resultToCompare = "{ \"key1\":\"True\",\"key2\":\"Hello World\",\"key3\":\"999\"}";
            Assert.AreEqual(resultToCompare, result);
        }

        /// <summary>
        /// Test de la webmethode Fibonacci du webservice 
        /// </summary>
        [TestMethod]
        public void TestWebServicesFibonacci()
        {
            var target = new ServiceReferenceLemonWay.WebServiceTestTechniqueSoapClient();
            int result = target.Fibonacci(10);
            Assert.AreEqual(55, result);
            result = target.Fibonacci(-10);
            Assert.AreEqual(-1, result);
            result = target.Fibonacci(110);
            Assert.AreEqual(-1, result);
            result = target.Fibonacci(1);
            Assert.AreEqual(1, result);
            result = target.Fibonacci(2);
            Assert.AreEqual(1, result);
        }
    }
}