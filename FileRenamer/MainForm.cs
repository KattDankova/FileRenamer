using System.Text.RegularExpressions;

namespace FileRenamer
{
    public partial class MainForm : Form
    {
        public FileInfo[] files;
        Dictionary<OwnFile, OwnFile> episodes = new();

        public class OwnFile
        {
            public string Path { get; set; } = "";
            public string Name { get; set; } = "";
        }

        public MainForm()
        {
            InitializeComponent();

        }


        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new();
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FolderPathInput.Text = openFileDialog.SelectedPath;
                DirectoryInfo directory = new(openFileDialog.SelectedPath);

                var validExtensions = new[] { ".mp4", ".mkv", ".avi", ".mov", ".wmv", ".flv", ".webm", ".mpeg", ".mpg", ".ogv", ".3gp",
                                              ".srt", ".sub", ".ass", ".ssa", ".vtt", ".ttml", ".idx", ".smi", ".mpl" };


                files = [.. directory.GetFiles().Where(f => validExtensions.Contains(f.Extension.ToLower()))];

                if (EpisodesTable.RowCount <= 0)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        EpisodesTable.Rows.Add(files[i].Name);
                        EpisodesTable.Rows[i].Resizable = DataGridViewTriState.False;
                    }
                }
                GenerateNamesButton.Enabled = SeriesNameInput.Text.Length > 0 && files.Length > 0;
            }
        }

        private void FolderPathInput_TextChanged(object sender, EventArgs e)
        {
            EpisodesTable.Rows.Clear();
            RenameButton.Enabled = false;
        }

        private void SeriesNameInput_TextChanged(object sender, EventArgs e)
        {
            GenerateNamesButton.Enabled = SeriesNameInput.Text.Length > 0 && files.Length > 0;
        }

        private void GenerateNamesButton_Click(object sender, EventArgs e)
        {
            if (SeriesNameInput.Text.Length > 0 && FolderPathInput.Text.Length > 0)
            {
                episodes.Clear();

                for (int i = 0; i < files.Length; i++)
                {
                    MatchCollection numbers = Regex.Matches(files[i].Name, @"\d{2,3}(?=[^a-zA-Z0-9])");

                    string ep = numbers.Count > 0 ? numbers[numbers.Count - 1].Value : string.Empty;

                    OwnFile f = new() { Name = GetNewName(SeriesNameInput.Text, ep, files[i]), Path = Path.Combine(FolderPathInput.Text, "") };
                    episodes.Add(new OwnFile() { Name = files[i].Name, Path = Path.Combine(files[i].DirectoryName, "") }, f);
                    EpisodesTable.Rows[i].Cells[1].Value = f.Name;
                }
            }

            RenameButton.Enabled = true;
        }

        public static string GetNewName(string newName, string episode, FileInfo file)
        {
            return $"{newName} - {episode}{file.Extension}";
        }

        private void EpisodesTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (episodes.Count > 0 && e.ColumnIndex > 0 && e.RowIndex >= 0)
            {
                var currentCell = episodes.FirstOrDefault(x => x.Value.Name == ((DataGridView)sender).CurrentCell.Value);
                ChangeNameForm editForm = new(currentCell);
                DialogResult response = editForm.ShowDialog();

                if (response == DialogResult.OK)
                {
                    currentCell.Value.Name = editForm.NewName;
                    EpisodesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = currentCell.Value.Name;
                }
            }
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Jste si jisti, že chcete tyto soubory pøejmenovat?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (var ep in episodes)
                {
                    string oldFilePath = Path.Combine(ep.Key.Path, ep.Key.Name);
                    string newFilePath = Path.Combine(ep.Value.Path, ep.Value.Name);

                    try
                    {
                        File.Move(oldFilePath, newFilePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Chyba pøi pøejmenování souboru: {ex.Message}");
                    }
                }
                MessageBox.Show("Soubory byly úspìšnì pøejmenovány!", "Dokonèeno");

                FolderPathInput.Text = string.Empty;
                SeriesNameInput.Text = string.Empty;
                EpisodesTable.Rows.Clear();
                episodes.Clear();
                GenerateNamesButton.Enabled = false;
                RenameButton.Enabled = false;
            }
        }
    }
}