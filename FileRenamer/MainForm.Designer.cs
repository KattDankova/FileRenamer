namespace FileRenamer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);

            SelectFolderButton = new Button();
            FolderPathInput = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            FolderInputLabel = new Label();
            SeriesNameLabel = new Label();
            SeriesNameInput = new TextBox();
            GenerateNamesButton = new Button();
            EpisodesTable = new DataGridView();
            OldNameColumn = new DataGridViewTextBoxColumn();
            NewNameColumn = new DataGridViewTextBoxColumn();
            RenameButton = new Button();
            ((System.ComponentModel.ISupportInitialize)EpisodesTable).BeginInit();
            SuspendLayout();
            // 
            // SelectFolderButton
            // 
            SelectFolderButton.Location = new Point(654, 30);
            SelectFolderButton.Name = "SelectFolderButton";
            SelectFolderButton.Size = new Size(112, 23);
            SelectFolderButton.TabIndex = 0;
            SelectFolderButton.Text = "Vybrat složku...";
            SelectFolderButton.UseVisualStyleBackColor = true;
            SelectFolderButton.Click += SelectFolderButton_Click;
            // 
            // FolderPathInput
            // 
            FolderPathInput.Location = new Point(152, 30);
            FolderPathInput.Name = "FolderPathInput";
            FolderPathInput.ReadOnly = true;
            FolderPathInput.Size = new Size(485, 23);
            FolderPathInput.TabIndex = 1;
            FolderPathInput.TextChanged += FolderPathInput_TextChanged;
            // 
            // FolderInputLabel
            // 
            FolderInputLabel.AutoSize = true;
            FolderInputLabel.Location = new Point(31, 33);
            FolderInputLabel.Name = "FolderInputLabel";
            FolderInputLabel.Size = new Size(100, 15);
            FolderInputLabel.TabIndex = 2;
            FolderInputLabel.Text = "Složka se soubory";
            // 
            // SeriesNameLabel
            // 
            SeriesNameLabel.AutoSize = true;
            SeriesNameLabel.Location = new Point(31, 68);
            SeriesNameLabel.Name = "SeriesNameLabel";
            SeriesNameLabel.Size = new Size(115, 15);
            SeriesNameLabel.TabIndex = 3;
            SeriesNameLabel.Text = "Nový název souborů";
            // 
            // SeriesNameInput
            // 
            SeriesNameInput.Location = new Point(152, 64);
            SeriesNameInput.Name = "SeriesNameInput";
            SeriesNameInput.Size = new Size(487, 23);
            SeriesNameInput.TabIndex = 4;
            SeriesNameInput.TextChanged += SeriesNameInput_TextChanged;
            // 
            // GenerateNamesButton
            // 
            GenerateNamesButton.Enabled = false;
            GenerateNamesButton.ImageAlign = ContentAlignment.MiddleRight;
            GenerateNamesButton.Location = new Point(654, 64);
            GenerateNamesButton.Name = "GenerateNamesButton";
            GenerateNamesButton.Size = new Size(75, 23);
            GenerateNamesButton.TabIndex = 7;
            GenerateNamesButton.Text = "Generovat";
            GenerateNamesButton.UseVisualStyleBackColor = true;
            GenerateNamesButton.Click += GenerateNamesButton_Click;
            // 
            // EpisodesTable
            // 
            EpisodesTable.AllowUserToAddRows = false;
            EpisodesTable.AllowUserToDeleteRows = false;
            EpisodesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EpisodesTable.Columns.AddRange(new DataGridViewColumn[] { OldNameColumn, NewNameColumn });
            EpisodesTable.Location = new Point(16, 125);
            EpisodesTable.Name = "EpisodesTable";
            EpisodesTable.ReadOnly = true;
            EpisodesTable.RowHeadersVisible = false;
            EpisodesTable.Size = new Size(1200, 400);
            EpisodesTable.TabIndex = 8;
            EpisodesTable.CellDoubleClick += EpisodesTable_CellDoubleClick;
            // 
            // OldNameColumn
            // 
            OldNameColumn.Frozen = true;
            OldNameColumn.HeaderText = "Původní název";
            OldNameColumn.Name = "OldNameColumn";
            OldNameColumn.ReadOnly = true;
            OldNameColumn.Resizable = DataGridViewTriState.False;
            OldNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            OldNameColumn.Width = 600;
            // 
            // NewNameColumn
            // 
            NewNameColumn.Frozen = true;
            NewNameColumn.HeaderText = "Nový název";
            NewNameColumn.Name = "NewNameColumn";
            NewNameColumn.ReadOnly = true;
            NewNameColumn.Resizable = DataGridViewTriState.False;
            NewNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            NewNameColumn.Width = 600;
            // 
            // RenameButton
            // 
            RenameButton.Enabled = false;
            RenameButton.Location = new Point(1120, 566);
            RenameButton.Name = "RenameButton";
            RenameButton.Size = new Size(96, 23);
            RenameButton.TabIndex = 9;
            RenameButton.Text = "Přejmenovat";
            RenameButton.UseVisualStyleBackColor = true;
            RenameButton.Click += RenameButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 615);
            Controls.Add(RenameButton);
            Controls.Add(EpisodesTable);
            Controls.Add(GenerateNamesButton);
            Controls.Add(SeriesNameInput);
            Controls.Add(SeriesNameLabel);
            Controls.Add(FolderInputLabel);
            Controls.Add(FolderPathInput);
            Controls.Add(SelectFolderButton);
            Name = "MainForm";
            Text = "Renamer";
            ((System.ComponentModel.ISupportInitialize)EpisodesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SelectFolderButton;
        private TextBox FolderPathInput;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label FolderInputLabel;
        private Label SeriesNameLabel;
        private TextBox SeriesNameInput;
        private Button GenerateNamesButton;
        private DataGridView EpisodesTable;
        private DataGridViewTextBoxColumn OldNameColumn;
        private DataGridViewTextBoxColumn NewNameColumn;
        private Button RenameButton;
    }
}
