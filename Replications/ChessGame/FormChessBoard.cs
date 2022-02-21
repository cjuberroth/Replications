using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ChessGame
{
    public partial class Form_ChessBoard : MetroForm
    {
        public Form_ChessBoard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Control containedControl in this.metroPanel1.Controls)
            {
                if(containedControl.GetType().ToString() == "MetroFramework.Controls.MetroTile")
                {
                    containedControl.Name = GetSpaceName(containedControl.Location);
                    containedControl.Text = containedControl.Name;
                }
            }
        }

        private string GetSpaceName(Point location)
        {
            //Get column value
            char columnID = (char)(location.X / 100 + 65);
            //Get row value
            int rowID = ((location.Y / 100) - 8) * -1;
            //Return space ID as string
            string spaceID = columnID.ToString() + rowID.ToString();
            return spaceID;
        }
    }
}
