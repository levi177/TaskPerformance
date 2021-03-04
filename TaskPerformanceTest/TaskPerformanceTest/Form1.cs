using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskPerformanceTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            int numOfGroups = 8;  // 8*5 = 40 elements
            // lists contain the uri objects made of the same 40 web pages
            List<Uri> urisOne = MakeListOfUris(numOfGroups);
            List<Uri> urisTwo = MakeListOfUris(numOfGroups);

            Test testOne = new Test();
            Test testTwo = new Test();

            /*
            // one task activated
            var result = await testOne.Get(urisOne);
            TextBoxOneIndividual.Text = String.Join(Environment.NewLine, result.GetRange(0, result.Count() - 2).ToArray());
            TextBoxOneOverall.Text = result.ToArray()[result.Count() - 1];
            */

            // two tasks activated
            var result = await Task.WhenAll(testOne.Get(urisOne), testTwo.Get(urisTwo));

            TextBoxOneIndividual.Text = String.Join(Environment.NewLine, result[0].GetRange(0, result[0].Count() - 2).ToArray());
            TextBoxOneOverall.Text = result[0].ToArray()[result.Length - 1];

            TextBoxTwoIndividual.Text = String.Join(Environment.NewLine, result[1].GetRange(0, result[1].Count() - 2).ToArray());
            TextBoxTwoOverall.Text = result[1].ToArray()[result.Length - 1];
        }

        private List<Uri> MakeListOfUris(int numOfGroups)
        {
            List<Uri> uris = new List<Uri>();
            for (int i = 0; i < numOfGroups; i++)
            {
                uris.Add(new Uri("https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/"));
                uris.Add(new Uri("https://www.youtube.com/watch?v=2moh18sh5p4&t=2028s"));
                uris.Add(new Uri("https://www.google.com/"));
                uris.Add(new Uri("https://en.wikipedia.org/wiki/Niagara_Falls"));
                uris.Add(new Uri("https://www.youtube.com/watch?v=jiwuQ6UHMQg"));
            }

            return uris;
        }
    }
}
