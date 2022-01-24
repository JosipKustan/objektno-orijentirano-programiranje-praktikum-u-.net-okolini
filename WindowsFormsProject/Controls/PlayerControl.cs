using DataLayer.Constants;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProject.Utils;

namespace WindowsFormsProject.Controls
{
    public partial class PlayerControl : UserControl
    {

        public String storedImages = Path.GetTempPath() + UrlConstants.STORED_IMAGES;
        public bool IsSelected { get; set; }
        public Player player { get; set; }
        public PlayerControl(Player player)
        {
            this.player = player;

            InitializeComponent();

            IsSelected = false;

            ShowFavoriteIcon(player.Favorite);
            ShowCapetanIcon(player.Captain);

            lbPlayerName.Text = player.Name;
            lbPosition.Text = player.Position.ToString();
            lbShirtNumber.Text = player.ShirtNumber.ToString();

            if (player.PicturePath!=null && player.PicturePath.Length>0)
            {
                SetPicture(player.PicturePath);
            }

        }


        private void ShowFavoriteIcon(bool isFavorite)
        {
            //TODO LISTENER WHEN FAVORITE
            iconFavorite.Visible = isFavorite;
        }
        private void ShowCapetanIcon(bool isCapetan)
        {
            //TODO LISTENER WHEN FAVORITE
            iconCapetan.Visible = isCapetan;
        }

        private void StartDragging(object sender, MouseEventArgs e)
        {
            this.DoDragDrop(this, DragDropEffects.Move);
        }

        internal void SetFavoritePlayer(bool v)
        {
            player.Favorite = v;
            ShowFavoriteIcon(v);
        }

        private void pbPlayerPicture_Click(object sender, EventArgs e)
        {

        }

        private void UploadPicture(object sender, EventArgs e)
        {
            GetPlayerPicture();
        }

        private void GetPlayerPicture()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg)|*.jpg; *.jpeg";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                SetPicture(fileDialog.FileName);
                
            }
           
        }

        private void SetPicture(string fileName)
        {
            var i = Image.FromFile(fileName);
            if (!File.Exists(fileName))
            {
                return;
            }
            //String newImagePath =storedImages +'\\' + Guid.NewGuid().ToString() + StringManipulation.GetFileName(fileName);
            Bitmap bmp = new Bitmap(i);
            i.Dispose();
            //bmp.Save(newImagePath);
            player.PicturePath = fileName;
            pbPlayerPicture.Image = bmp;
        }

        public void ToggleSelected()
        {
            IsSelected = !IsSelected;
            if (IsSelected)
            {
                pbPlayerPicture.BorderStyle=BorderStyle.FixedSingle;
                lbPlayerName.ForeColor = SystemColors.Highlight;
            }
            else
            {
                pbPlayerPicture.BorderStyle=BorderStyle.None;
                lbPlayerName.ForeColor = SystemColors.Desktop;
            }

           
        }

        private void ToggleSelectedEvent(object sender, MouseEventArgs e)
        {
            ToggleSelected();
        }
    }
}
