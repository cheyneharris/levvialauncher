using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LevviaLauncher
{
    public partial class Form1 : Form
    {
        private const string problemURL = "problem_url.txt";
        private const string snowURL = "snow_url.txt";
        private const string pbiURL = "pbi_url.txt";

        private Dictionary<string, string> urls = new Dictionary<string, string>
        {
            { "DLevvia", "https://dlevvia3.aaps.deloitte.com/portfolio" },
            { "QLevvia", "https://qlevvia3.aaps.deloitte.com/portfolio" },
        };

        public Form1()
        {
            InitializeComponent();
            LoadSavedUrls();
            problemBox.TextChanged += problemBox_TextChanged;
            snowBox.TextChanged += snowBox_TextChanged;
            pbiBox.TextChanged += pbiBox_TextChanged;

            environmentBox.Items.AddRange(urls.Keys.ToArray());
            environmentBox.SelectedIndex = 0;
            launchButton.Click += LaunchButton_Click;

            this.FormBorderStyle = FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.Manual;
           this.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width), 0);
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if (environmentBox.SelectedItem != null)
            {
                string value;
                bool hasValue = urls.TryGetValue(environmentBox.SelectedItem.ToString(), out value);

                var openLink = new ProcessStartInfo(value)
                {
                    UseShellExecute = true
                };

                try
                {
                    Process.Start(openLink);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to open URL: {ex.Message}");
                }
            }
        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }



        public void LoadSavedUrls()
        {
            if (File.Exists(problemURL))
            {
                string savedUrl = File.ReadAllText(problemURL);

                if (!string.IsNullOrEmpty(savedUrl))
                {
                    problemBox.Visible = false;
                    problemButton.Text = savedUrl;
                    problemButton.Visible = true;
                }
            }

            if (File.Exists(snowURL))
            {
                string savedUrl = File.ReadAllText(snowURL);

                if (!string.IsNullOrEmpty(savedUrl))
                {
                    snowBox.Visible = false;
                    snowButton.Text = savedUrl;
                    snowButton.Visible = true;
                }
            }

            if (File.Exists(pbiURL))
            {
                string savedUrl = File.ReadAllText(pbiURL);

                if (!string.IsNullOrEmpty(savedUrl))
                {
                    pbiBox.Visible = false;
                    pbiButton.Text = savedUrl;
                    pbiButton.Visible = true;
                }
            }

        }

        private void problemBox_TextChanged(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText() && problemBox.Text == Clipboard.GetText() && Uri.IsWellFormedUriString(problemBox.Text, UriKind.Absolute))
            {
                File.WriteAllText(problemURL, problemBox.Text);
                problemButton.Text = problemBox.Text;
                problemBox.Visible = false;
                problemButton.Visible = true;
            }
        }
        private void snowBox_TextChanged(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText() && snowBox.Text == Clipboard.GetText() && Uri.IsWellFormedUriString(problemBox.Text, UriKind.Absolute))
            {
                File.WriteAllText(snowURL, snowBox.Text);
                snowButton.Text = snowBox.Text;
                snowBox.Visible = false;
                snowButton.Visible = true;
            }
        }

        private void pbiBox_TextChanged(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText() && pbiBox.Text == Clipboard.GetText() && Uri.IsWellFormedUriString(pbiBox.Text, UriKind.Absolute))
            {
                File.WriteAllText(pbiURL, pbiBox.Text);
                pbiButton.Text = pbiBox.Text;
                pbiBox.Visible = false;
                pbiButton.Visible = true;
            }
        }

        private void resetButton_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(problemURL)) File.Delete(problemURL);
            problemBox.Text = string.Empty;
            problemBox.Visible = true;
            problemButton.Visible = false;

            if (File.Exists(snowURL)) File.Delete(snowURL);
            snowBox.Text = string.Empty;
            snowBox.Visible = true;
            snowButton.Visible = false;

            if (File.Exists(pbiURL)) File.Delete(pbiURL);
            pbiBox.Text = string.Empty;
            pbiBox.Visible = true;
            pbiButton.Visible = false;
        }

        private void problemButton_Click_1(object sender, EventArgs e)
        {
            var openLink = new ProcessStartInfo(problemButton.Text.Trim())
            {
                UseShellExecute = true
            };

            try
            {
                Process.Start(openLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open URL: {ex.Message}");
            }
        }

        private void snowButton_Click_1(object sender, EventArgs e)
        {
            var openLink = new ProcessStartInfo(snowButton.Text.Trim())
            {
                UseShellExecute = true
            };

            try
            {
                Process.Start(openLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open URL: {ex.Message}");
            }
        }

        private void pbiButton_Click_1(object sender, EventArgs e)
        {
            var openLink = new ProcessStartInfo(pbiButton.Text.Trim())
            {
                UseShellExecute = true
            };

            try
            {
                Process.Start(openLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open URL: {ex.Message}");
            }
        }

        private void ema2Button_Click(object sender, EventArgs e)
        {
            var openLink = new ProcessStartInfo("https://portal.azure.com/#@deloitte.onmicrosoft.com/resource/subscriptions/62c1dd5c-d918-4a4d-b0ee-18d5e7d5071b/resourceGroups/APP-VSAV2-EMA-PROD-RG/providers/Microsoft.Insights/components/pvsav2emaappinsights/logs")
            {
                UseShellExecute = true
            };

            try
            {
                Process.Start(openLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open URL: {ex.Message}");
            }
        }

        private void apa2Button_Click(object sender, EventArgs e)
        {
            var openLink = new ProcessStartInfo("https://portal.azure.com/#@deloitte.onmicrosoft.com/resource/subscriptions/b2fcc9cc-5757-42d3-980c-d92d66bab682/resourceGroups/APP-VSAV2-APA-PROD-RG/providers/Microsoft.Insights/components/pvsav2apaappinsights/logs")
            {
                UseShellExecute = true
            };

            try
            {
                Process.Start(openLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open URL: {ex.Message}");
            }
        }

        private void ema3Button_Click(object sender, EventArgs e)
        {
            var openLink = new ProcessStartInfo("https://portal.azure.com/#@deloitte.onmicrosoft.com/resource/subscriptions/011614fa-4a26-4eec-bc11-ce4bc98dbdd1/resourceGroups/AZRG-EUW-AUD-LEVVIA3-EMA-PROD-MONITOR/providers/Microsoft.Insights/components/plevvia3emaappinsights/overview")
            {
                UseShellExecute = true
            };

            try
            {
                Process.Start(openLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open URL: {ex.Message}");
            }
        }

        private void apa3Button_Click(object sender, EventArgs e)
        {
            var openLink = new ProcessStartInfo("https://portal.azure.com/#@deloitte.onmicrosoft.com/resource/subscriptions/b44e01f1-7839-408f-b458-e94555205e8c/resourceGroups/AZRG-JPE-AUD-LEVVIA3-APA-PROD-MONITOR/providers/Microsoft.Insights/components/plevvia3apaappinsights")
            {
                UseShellExecute = true
            };

            try
            {
                Process.Start(openLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open URL: {ex.Message}");
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            var openLink = new ProcessStartInfo("https://symphonyvsts.visualstudio.com/VSA/_queries/query/156dbf11-0df5-4b92-a068-6b3b44583dff")
            {
                UseShellExecute = true
            };

            try
            {
                Process.Start(openLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open URL: {ex.Message}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void launchButton_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}   
