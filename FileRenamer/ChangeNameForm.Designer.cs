namespace FileRenamer
{
    partial class ChangeNameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FolderInputLabel = new Label();
            SeriesNameLabel = new Label();
            DefaultNameText = new TextBox();
            EpisodeNameInput = new TextBox();
            SaveButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // FolderInputLabel
            // 
            FolderInputLabel.AutoSize = true;
            FolderInputLabel.Location = new Point(29, 48);
            FolderInputLabel.Name = "FolderInputLabel";
            FolderInputLabel.Size = new Size(84, 15);
            FolderInputLabel.TabIndex = 0;
            FolderInputLabel.Text = "Původní název";
            // 
            // SeriesNameLabel
            // 
            SeriesNameLabel.AutoSize = true;
            SeriesNameLabel.ImageAlign = ContentAlignment.MiddleRight;
            SeriesNameLabel.Location = new Point(29, 87);
            SeriesNameLabel.Name = "SeriesNameLabel";
            SeriesNameLabel.Size = new Size(68, 15);
            SeriesNameLabel.TabIndex = 1;
            SeriesNameLabel.Text = "Nový název";
            // 
            // DefaultNameText
            // 
            DefaultNameText.Location = new Point(119, 45);
            DefaultNameText.Name = "DefaultNameText";
            DefaultNameText.Size = new Size(455, 23);
            DefaultNameText.TabIndex = 2;
            // 
            // EpisodeNameInput
            // 
            EpisodeNameInput.Location = new Point(119, 84);
            EpisodeNameInput.Name = "EpisodeNameInput";
            EpisodeNameInput.Size = new Size(455, 23);
            EpisodeNameInput.TabIndex = 3;
            EpisodeNameInput.TextChanged += EpisodeNameInput_TextChanged;
            // 
            // SaveButton
            // 
            SaveButton.DialogResult = DialogResult.OK;
            SaveButton.Location = new Point(192, 163);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Uložit";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(359, 163);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Zrušit";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // ChangeNameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 234);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(EpisodeNameInput);
            Controls.Add(DefaultNameText);
            Controls.Add(SeriesNameLabel);
            Controls.Add(FolderInputLabel);
            Name = "ChangeNameForm";
            Text = "Přejmenovat soubor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FolderInputLabel;
        private Label SeriesNameLabel;
        private TextBox DefaultNameText;
        private TextBox EpisodeNameInput;
        private Button SaveButton;
        private Button CancelButton;
    }
}