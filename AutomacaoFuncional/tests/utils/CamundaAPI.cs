using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System;
using Newtonsoft.Json.Linq;

namespace AutomacaoFuncional.tests.utils
{
    class CamundaApi
    {
        static string result = null;
        static HttpClient Client = new HttpClient();
        static string getInstance = "http://hml-camunda.fundacred.org.br:8080/engine-rest/process-instance/?businessKey=";
        static string deleteInstance = "http://hml-camunda.fundacred.org.br:8080/engine-rest/process-instance/";
        static string getVariables = "http://hml-camunda.fundacred.org.br:8080/engine-rest/process-instance/";
        static string getProcess = "http://hml-camunda.fundacred.org.br:8080/engine-rest/task?processInstanceBusinessKey=";

        public static string GetInstance(string BusinessKey)
        {
            string Path = getInstance + BusinessKey;

            var result = Client.GetStringAsync(new Uri(Path)).Result;

            string[] jSon = result.Split('\"');
            result = jSon[5];
            return result;
        }

        public static string DeleteInstance(string Id)
        {
            string status = null;
            try
            {
                string Path = deleteInstance + Id;
                string jsonString = "{\"skipCustomListeners\":\"true\",\"skipIoMappings\":\"true\"}";

                var result =
                    Client.SendAsync(
                    new HttpRequestMessage(HttpMethod.Delete, Path)
                    {
                        Content = new StringContent(jsonString, Encoding.UTF8, "application/json")
                    })
                    .Result;
                     status = result.ToString();
                     string[] StatusCode = status.Split(',');
                     status = StatusCode[0];
                    //result.RequestMessage.ToString();
            }
            catch
            {

            }
            return status;
        }

        public static string[] GetVariables(string Id)
        {
            string Url = getVariables + Id + "/variables";

            var response = Client.GetStringAsync(new Uri(Url)).Result;
            var data = response.Split('\"');
            string telefonelUsuarioWeb = data[9];
            string cpfUsuarioWeb = data[21];
            string emailUsuarioWeb = data[33];
            string idCurso = data[44];
            string idBolsa = data[54];
            string nomeUsuarioWeb = data[65];

            string[] Variables = {telefonelUsuarioWeb, cpfUsuarioWeb, emailUsuarioWeb, idCurso, idBolsa, nomeUsuarioWeb};

            return Variables;
        }

        public static (string, string) GetProcessActivities(string Id)
        {
            string Url = getProcess + Id;

            var response = Client.GetStringAsync(new Uri(Url)).Result;

            var data = response.Split('\"');
            string process01 = data[45];
            string process02 = data[99];

            return (process01, process02);
        }

        public static string GetProcessState(string Id)
        {
            string Url = getProcess + Id;

            var response = Client.GetStringAsync(new Uri(Url)).Result;

            var data = response.Split('\"');
            string process01 = data[45];

            return process01;
        }
        
    }
}