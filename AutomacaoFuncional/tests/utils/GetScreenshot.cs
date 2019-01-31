using OpenQA.Selenium;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.utils
{
    public class GetScreenShot
    {
        public static string Capture(IWebDriver driver, string dateTime)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string name = ScenarioStepContext.Current.StepInfo.Text.ToString();
            string SchreenshotName = name.Replace(" ", "_");
            SchreenshotName = dateTime + " " + SchreenshotName;
            string finalpth = Path.GetFullPath(@"C:\Users\leonardo.barcellos\Desktop\Fundacred\AutomacaoFuncional\Screenshots\") + SchreenshotName + ".png";
            string localpath = new Uri(finalpth).LocalPath;
            screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);

            byte[] imageData = screenshot.AsByteArray;

            Task<string> result = TesteAsync(imageData);
            string path = result.Result;
            return path;
        }

        //Post dos bytes do screenshot para a API: plataforma.fundacred.org.br/api/storage/files 
        public static async Task<string> TesteAsync(byte[] image)
        {
            var uri = "http://plataforma.fundacred.org.br/api/storage/files";
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "image/png");
            MultipartFormDataContent form = new MultipartFormDataContent();
            form.Add(new ByteArrayContent(image, 0, image.Length), "teste", "screenshot.png");
            HttpResponseMessage response = await httpClient.PostAsync(uri, form);
            response.EnsureSuccessStatusCode();
            httpClient.Dispose();

            string sd = response.Content.ReadAsStringAsync().Result;

            string[] items = sd.Split('"');
            string id = items[3];
            string path = "http://plataforma.fundacred.org.br/api/storage/files/" + id;

            return path;
        }
    }
}
