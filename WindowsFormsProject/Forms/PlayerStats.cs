using DataLayer.Model;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProject.Controls;
using WindowsFormsProject.Utils;
using PdfSharp.Drawing;
using DataLayer.Utils;

namespace WindowsFormsProject.Forms
{
    public partial class PlayerStats : Form
    {
        ScreenCapture capScreen = new ScreenCapture();


        private List<int> GoalsCards=new List<int>();
        private IDictionary<Player, List<int>> dicPlayerStats=new Dictionary<Player, List<int>>();
        private List<KeyValuePair<Player,List<int>>> playerStatPairs=new List<KeyValuePair<Player, List<int>>>();
        public List<Player> Players { get; set; }
        public List<TeamEvent> TeamEvents { get; set; }
        public PlayerStats(List<Player> players, List<TeamEvent> homeTeamEvents)
        {
            Players = players;
            TeamEvents = homeTeamEvents;
            InitializeComponent();
            Players = (List<Player>)StoredPlayers.ReplaceWithStoredPlayer(Players);
            InitPlayerStatList();
            InitPanel();
        }

        private void InitPlayerStatList()
        {
            //Ajoj ovaj code
            foreach (Player player in Players)
            {
                List<int> vs=new List<int>();
                vs.Add(0);
                vs.Add(0);
                foreach (TeamEvent teamEvent in TeamEvents)
                {
                   if(teamEvent.Player.Equals(player.Name))
                   {
                        if (teamEvent.TypeOfEvent == TypeOfEvent.Goal || teamEvent.TypeOfEvent == TypeOfEvent.GoalPenalty)
                        {
                            vs[0] += 1;
                        }
                        if (teamEvent.TypeOfEvent== TypeOfEvent.YellowCard)
                        {
                            vs[1] = 1;
                        }
                        if (teamEvent.TypeOfEvent== TypeOfEvent.YellowCardSecond)
                        {
                            vs[1] = 2;
                        }
                   }
                }
                //could just put in a key value in the first place..ehh
                //if (!(vs[0]==0 && vs[1] == 0))
                //{
                //     dicPlayerStats.Add(player, vs);   //retDIR
                //}
                dicPlayerStats.Add(player, vs);   //retDIR
            }
            playerStatPairs = dicPlayerStats.ToList();
            playerStatPairs.Sort((a, b) =>-a.Value.ToList()[0].CompareTo(b.Value.ToList()[0]));

        }

        private void InitPanel()
        {
            playerStatPairs.ForEach((playerInfo) => {
                Panel panel = new FlowLayoutPanel();
                panel.BackColor = SystemColors.Desktop;
                panel.ForeColor = SystemColors.ControlLight;
                panel.Size = new Size(220, 180);
                panel.Controls.Add(new PlayerControl(playerInfo.Key));
                panel.Controls.Add(new PlayerStatsControl(playerInfo.Value[0], playerInfo.Value[1]));
                flowLayoutPanel.Controls.Add(panel);
            });
        }

        private void printToPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pathToImage=captureScreen();
            if (pathToImage.Length<1)
            {
                return;
            }

            PdfDocument doc = new PdfDocument();
            PdfPage oPage = new PdfPage();

            // Add the page to the pdf document and add the captured image to it
            doc.Pages.Add(oPage);
            XGraphics xgr = XGraphics.FromPdfPage(oPage);
            XImage img = XImage.FromFile(pathToImage);
            xgr.DrawImage(img, 0, 0);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ("PDF File|*.pdf");
            DialogResult btnSave = saveFileDialog.ShowDialog();
            if (btnSave.Equals(DialogResult.OK))
            {
                doc.Save(saveFileDialog.FileName);
                doc.Close();
            }

            // I used the Dispose() function to be able to 
            // save the same form again, in case some values have changed.
            // When I didn't use the function, a GDI+ error occurred.
            img.Dispose();
        }

        private String captureScreen()
        {
            try
            {
                // Call the CaptureAndSave method from the ScreenCapture class 
                // And create a temporary file in C:\Temp
                capScreen.CaptureAndSave(Path.GetTempPath() + "test.png", this, ImageFormat.Png);
                return Path.GetTempPath() + "test.png";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return "";
            }
        }
    }
}
