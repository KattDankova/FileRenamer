using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FileRenamer.MainForm;

namespace FileRenamer
{
    public partial class ChangeNameForm : Form
    {
        string newName;

        public string NewName
        {
            get
            {
                return newName;
            }
        }

        public ChangeNameForm(KeyValuePair<OwnFile, OwnFile> cell)
        {
            InitializeComponent();
            DefaultNameText.Text = cell.Key.Name;
            DefaultNameText.ReadOnly = true;
            EpisodeNameInput.Text = cell.Value.Name;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            newName = EpisodeNameInput.Text;
        }

        private void EpisodeNameInput_TextChanged(object sender, EventArgs e)
        {
            if (EpisodeNameInput.Text.Length > 0)
            {
                SaveButton.Enabled = true;
            }
            else
            {
                SaveButton.Enabled = false;
            }
        }
    }
}
