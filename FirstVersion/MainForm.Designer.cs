namespace FirstVersion
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripOptions = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewForResults = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbsoluteFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelativeFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelName = new System.Windows.Forms.Label();
            this.labelForNumber = new System.Windows.Forms.Label();
            this.richTextBoxForUserInput = new System.Windows.Forms.RichTextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.menuStripOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForResults)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripOptions
            // 
            this.menuStripOptions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStripOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStripOptions.Location = new System.Drawing.Point(0, 0);
            this.menuStripOptions.Name = "menuStripOptions";
            this.menuStripOptions.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripOptions.Size = new System.Drawing.Size(880, 28);
            this.menuStripOptions.TabIndex = 9;
            this.menuStripOptions.Text = "menuStripOptions";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.InformationToolStripMenuItem_Click);
            // 
            // dataGridViewForResults
            // 
            this.dataGridViewForResults.AllowUserToAddRows = false;
            this.dataGridViewForResults.AllowUserToDeleteRows = false;
            this.dataGridViewForResults.AllowUserToResizeColumns = false;
            this.dataGridViewForResults.AllowUserToResizeRows = false;
            this.dataGridViewForResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewForResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewForResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.AbsoluteFrequency,
            this.RelativeFrequency});
            this.dataGridViewForResults.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewForResults.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewForResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewForResults.Location = new System.Drawing.Point(439, 59);
            this.dataGridViewForResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewForResults.Name = "dataGridViewForResults";
            this.dataGridViewForResults.RowHeadersVisible = false;
            this.dataGridViewForResults.RowHeadersWidth = 51;
            this.dataGridViewForResults.RowTemplate.Height = 24;
            this.dataGridViewForResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewForResults.Size = new System.Drawing.Size(431, 370);
            this.dataGridViewForResults.TabIndex = 2;
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Символ";
            this.Symbol.MinimumWidth = 6;
            this.Symbol.Name = "Symbol";
            // 
            // AbsoluteFrequency
            // 
            this.AbsoluteFrequency.HeaderText = "Абсолютная частота встречаемости";
            this.AbsoluteFrequency.MinimumWidth = 6;
            this.AbsoluteFrequency.Name = "AbsoluteFrequency";
            // 
            // RelativeFrequency
            // 
            this.RelativeFrequency.HeaderText = "Относительная частота встречаемости";
            this.RelativeFrequency.MinimumWidth = 6;
            this.RelativeFrequency.Name = "RelativeFrequency";
            this.RelativeFrequency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(517, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(220, 16);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Общее число символов в тексте:";
            // 
            // labelForNumber
            // 
            this.labelForNumber.AutoSize = true;
            this.labelForNumber.Location = new System.Drawing.Point(760, 39);
            this.labelForNumber.Name = "labelForNumber";
            this.labelForNumber.Size = new System.Drawing.Size(103, 16);
            this.labelForNumber.TabIndex = 4;
            this.labelForNumber.Text = "не рассчитано";
            // 
            // richTextBoxForUserInput
            // 
            this.richTextBoxForUserInput.AcceptsTab = true;
            this.richTextBoxForUserInput.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.richTextBoxForUserInput.Location = new System.Drawing.Point(12, 38);
            this.richTextBoxForUserInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxForUserInput.Name = "richTextBoxForUserInput";
            this.richTextBoxForUserInput.Size = new System.Drawing.Size(421, 390);
            this.richTextBoxForUserInput.TabIndex = 11;
            this.richTextBoxForUserInput.Text = "";
            // 
            // buttonCount
            // 
            this.buttonCount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonCount.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCount.Location = new System.Drawing.Point(307, 434);
            this.buttonCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(269, 31);
            this.buttonCount.TabIndex = 17;
            this.buttonCount.Text = "Рассчитать";
            this.buttonCount.UseVisualStyleBackColor = false;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 471);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.richTextBoxForUserInput);
            this.Controls.Add(this.labelForNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridViewForResults);
            this.Controls.Add(this.menuStripOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStripOptions;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(898, 518);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Символьный анализ текста";
            this.menuStripOptions.ResumeLayout(false);
            this.menuStripOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelForNumber;
        private System.Windows.Forms.DataGridView dataGridViewForResults;
        private System.Windows.Forms.RichTextBox richTextBoxForUserInput;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbsoluteFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelativeFrequency;
    }
}

