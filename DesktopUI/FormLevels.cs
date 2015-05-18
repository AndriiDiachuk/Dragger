using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using GameEngine;

namespace DesktopUI
{
    public class FormLevels : System.Windows.Forms.Form
    {
        #region Private fields
        private System.Windows.Forms.ListBox lstLevelSets;
        private System.Windows.Forms.Button btnSelect;

        private ArrayList levelSets = new ArrayList();
        private string filenameLevelSet = string.Empty;
        private Label lblChoose;
        private Button btnExit;
        private Button btnRules;
        private string nameLevelSet = string.Empty;
        #endregion

        #region Constructor
        public FormLevels()
        {
            InitializeComponent();

            // Loads the information of all level sets
            levelSets = LevelSet.GetAllLevelSetInfos();

            // Adds the title of each level set to the listbox
            foreach (LevelSet levelSet in levelSets)
                lstLevelSets.Items.Add(levelSet.Title);

            lstLevelSets.SelectedIndex = 0;
        }

        private void btnSelect_Click(object sender, System.EventArgs e)
        {
            nameLevelSet = lstLevelSets.SelectedItem.ToString();

            foreach (LevelSet levelSet in levelSets)
            {
                if (levelSet.Title == nameLevelSet)
                {
                    filenameLevelSet = levelSet.Filename;
                    break;
                }
            }
            this.Close();
        }
        #endregion

        #region Properties
        public string FilenameLevelSet
        {
            get { return filenameLevelSet; }
        }
        #endregion

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLevels));
            this.lstLevelSets = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLevelSets
            // 
            this.lstLevelSets.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLevelSets.Location = new System.Drawing.Point(1, 97);
            this.lstLevelSets.Name = "lstLevelSets";
            this.lstLevelSets.Size = new System.Drawing.Size(123, 69);
            this.lstLevelSets.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelect.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(-1, 184);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(125, 35);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Start game";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.BackColor = System.Drawing.Color.Transparent;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(9, 9);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(293, 72);
            this.lblChoose.TabIndex = 13;
            this.lblChoose.Text = "Welcome to Dragger!\r\nChoose the level set you want to play!\r\nPlease, enjoy!\r\n\r\n";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(-1, 261);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 35);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.Transparent;
            this.btnRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.Location = new System.Drawing.Point(-1, 222);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(125, 35);
            this.btnRules.TabIndex = 16;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // FormLevels
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::DesktopUI.Properties.Resources.hqdefault;
            this.ClientSize = new System.Drawing.Size(485, 327);
            this.ControlBox = false;
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstLevelSets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLevels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Levels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnRules_Click(object sender, EventArgs e)
        {
            RulesForm about = new RulesForm();
            about.Show();
        }
        #endregion
    }
}

