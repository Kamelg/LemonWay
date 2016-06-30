using System;
using System.Linq;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Xml.Linq;

namespace LemonWayTestTechnique
{
    [WebService(Namespace = "http://localhost:11968/WebServiceTestTechnique.asmx/")]
    public class WebServiceTestTechnique : WebService
    {
        public WebServiceTestTechnique()
        {
        }

        [WebMethod]
        public int Fibonacci(int n)
        {
            try
            {
                //Cas particulier si n ne se trouve pas dans l'intervalle 1..100 on retourne -1
                if (n > 100 || n <= 0)
                    return -1;
                //si n=0 ou 1 on retourne 1
                if (n < 3)
                    return 1;
                //appel récursif de la suite de fibonacci
                return Fibo(n - 2) + Fibo(n - 1);
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return -1;
            }
        }

        /// <summary>
        /// Calcul de la suite de fibonacci dans le cas général n dans l'intervalle 1..100
        /// </summary>
        /// <param name="n">entier pour calcul de la suite de fibonacci</param>
        /// <returns></returns>
        public int Fibo(int n)
        {
            try
            {
                return (n < 3) ? 1 : Fibo(n - 2) + Fibo(n - 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Parse d'un flux xml en un flux json
        /// </summary>
        /// <param name="xml">flux xml à parser</param>
        /// <returns>flux json après parsage</returns>
        [WebMethod]
        public string XmlToJson(string xml)
        {
            try
            {
                var dic = XDocument
                    .Parse(xml)
                    .Descendants("Column")
                    .ToDictionary(
                        c => c.Attribute("Name").Value,
                        c => c.Value
                    );
                return new JavaScriptSerializer().Serialize(dic);
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                return "Bad Xml format";
            }
        }
    }
}