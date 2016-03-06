using Octokit;
using System.Windows;
using System.Windows.Controls;


namespace NASA_Pump_Control
{
    /// <summary>
    /// Interaction logic for Main_RUN.xaml
    /// </summary>
    public partial class Main_RUN : UserControl
    {
        public Main_RUN()
        {
            InitializeComponent();
        }

        private async void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var client = new GitHubClient(new ProductHeaderValue("Nasa_Csharp"));
            var basicAuth = new Credentials("rahutchinson", "Geakyboy11"); // NOTE: not real credentials
            client.Credentials = basicAuth;

            Issue_face OP = new Issue_face();
            var host = new Window();
            host.Content = OP;
            host.Show();

            var createIssue = new NewIssue("this thing doesn't work");
            var issue = await client.Issue.Create("octokit", "octokit.net", createIssue);
        }
    }
}
