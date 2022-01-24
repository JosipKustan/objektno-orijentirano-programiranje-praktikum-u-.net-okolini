
using DataLayer.Model;
using DataLayer.REST;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             try
            {
                FillDDL();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void FillDDL()
        {
            IList<TeamInfo> Teams = new List<TeamInfo>();

            try
            {
                Teams = await HttpFetch.FetchDataFromUrlAsync<IList<TeamInfo>>("http://worldcup.sfg.io/teams/results");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to Fetch from URL, trying to fetch from File");
                Teams = TeamInfo.FromJson(Properties.Resources.Man_matches);
            }
            
            

            foreach (var team in Teams)
            {
                ddlWomanTeams.Items.Add(team);
            }

            ddlWomanTeams.SelectedIndex = 0;

        }

   
    }
}
