using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NASA_Pump_Control
{
    /// <summary>
    /// Interaction logic for UserControl3.xaml
    /// </summary>
    public partial class Issue_face : UserControl
    {
        Window _me = new Window();
        public Issue_face(Window me)
        {
            _me = me;
            InitializeComponent();
        }

        private async void btn_issue_submit_Click(object sender, RoutedEventArgs e)
        {
            var client = new GitHubClient(new ProductHeaderValue("Nasa_Csharp"));
            var basicAuth = new Credentials("rahutchinson", "Geakyboy11"); // TODO: Fix this
            client.Credentials = basicAuth;

            string issue_text = txt_name.Text.ToString();
            string issue_detials = txt_detials.Text.ToString();

            var createIssue = new NewIssue(issue_text);
            createIssue.Body = issue_detials;
            createIssue.Assignee = "rahutchinson";
            var issue = await client.Issue.Create("rahutchinson", "Nasa_Csharp", createIssue);

            _me.Close();
        }
       
    }
}
