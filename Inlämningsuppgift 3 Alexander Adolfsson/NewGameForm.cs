using Inlämningsuppgift_3_Alexander_Adolfsson.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift_3_Alexander_Adolfsson
{
    public partial class New_Game : Form
    {
        public New_Game()
        {
            InitializeComponent();
            
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            
            game.StartGame(NameText.Text.ToString());
            this.Close();
            MessageBox.Show("Tryck på starta spelet när du är redo att börja");
        }


        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
