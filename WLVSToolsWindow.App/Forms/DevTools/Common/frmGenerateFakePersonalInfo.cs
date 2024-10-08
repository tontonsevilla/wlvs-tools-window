using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Web;
using WLVSToolsWindow.App.Infrastructure.Tools.Selenium;

namespace WLVSToolsWindow.App.Forms.DevTools.Common
{
    public partial class frmGenerateFakePersonalInfo : Form
    {
        public frmGenerateFakePersonalInfo()
        {
            InitializeComponent();
        }

        private void btnGenerateFakePersonalInfo_Click(object sender, EventArgs e)
        {
            GenerateFakePersonalInfoAutomation generateFakePersonalInfoAutomation = new GenerateFakePersonalInfoAutomation();
            var json = generateFakePersonalInfoAutomation.GetBasicInformationJson();
            richTextBox1.Text = json;
            richTextBox1.ReadOnly = true;

            var root = JToken.Parse(json);
            DisplayTreeView(root, "Root");
        }

        private void DisplayTreeView(JToken root, string rootName)
        {
            treeView1.BeginUpdate();
            try
            {
                treeView1.Nodes.Clear();
                var tNode = treeView1.Nodes[treeView1.Nodes.Add(new TreeNode(rootName))];
                tNode.Tag = root;

                AddNode(root, tNode);

                treeView1.ExpandAll();
            }
            finally
            {
                treeView1.EndUpdate();
            }
        }

        private void AddNode(JToken token, TreeNode inTreeNode)
        {
            if (token == null)
                return;
            if (token is JValue)
            {
                var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(token.ToString()))];
                childNode.Tag = token;
            }
            else if (token is JObject)
            {
                var obj = (JObject)token;
                foreach (var property in obj.Properties())
                {
                    var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(property.Name))];
                    childNode.Tag = property;
                    AddNode(property.Value, childNode);
                }
            }
            else if (token is JArray)
            {
                var array = (JArray)token;
                for (int i = 0; i < array.Count; i++)
                {
                    var childNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(i.ToString()))];
                    childNode.Tag = array[i];
                    AddNode(array[i], childNode);
                }
            }
            else
            {
                Debug.WriteLine(string.Format("{0} not implemented", token.Type)); // JConstructor, JRaw
            }
        }

        private string getFakeNameGeneratorCountry(string country)
        {
            country = HttpUtility.UrlDecode(country);

            return (new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("united states", ""),
                new KeyValuePair<string, string>("australia", "au-"),
                new KeyValuePair<string, string>("canada", "ca-"),
                new KeyValuePair<string, string>("united kingdom", "uk-"),
                new KeyValuePair<string, string>("brazil", "br-"),
                new KeyValuePair<string, string>("france", "fr-"),
                new KeyValuePair<string, string>("germany", "de-"),
                new KeyValuePair<string, string>("italy", "it-"),
                new KeyValuePair<string, string>("spain", "es-")

            }).Where(kv => kv.Key == country.ToLower())
            .Select(kv => kv.Value).FirstOrDefault();
        }
    }
}
