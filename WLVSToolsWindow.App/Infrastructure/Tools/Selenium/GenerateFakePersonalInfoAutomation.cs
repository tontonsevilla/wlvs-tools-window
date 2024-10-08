using HtmlAgilityPack;

namespace WLVSToolsWindow.App.Infrastructure.Tools.Selenium
{
    internal class GenerateFakePersonalInfoAutomation : SeleniumBase
    {
        public string GetHtml()
        {
            var driver = Navigate($"https://www.coolgenerator.com/fake-name-generator");
            var html = driver.PageSource;

            driver.Close();
            driver.Dispose();

            return html;
        }

        public string GetBasicInformationHtml() 
        { 
            var html = GetHtml();
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            
            htmlDocument.LoadHtml(html);
            
            var basicInfoHtml = htmlDocument.DocumentNode.SelectNodes("//b[.='Basic information']/ancestor-or-self::table")[0].OuterHtml;
            return basicInfoHtml;
        }

        public string GetBasicInformationJson()
        {
            var html = GetBasicInformationHtml();
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();

            htmlDocument.LoadHtml(html);

            var fullName = htmlDocument.DocumentNode.SelectNodes("//td[.='Full name']/following-sibling::td/span")[0].InnerHtml;

            return Newtonsoft.Json.JsonConvert.SerializeObject(new { 
                FullName = fullName
            });
        }
    }
}
