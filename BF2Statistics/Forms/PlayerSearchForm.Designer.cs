﻿namespace BF2Statistics
{
    partial class PlayerSearchForm
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
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clantag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LimitSelect = new System.Windows.Forms.ComboBox();
            this.RowCountDesc = new System.Windows.Forms.Label();
            this.FirstBtn = new System.Windows.Forms.Button();
            this.LastBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.PageNumber = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.AllowUserToOrderColumns = true;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.clantag,
            this.rank,
            this.score,
            this.country,
            this.permban});
            this.DataTable.Location = new System.Drawing.Point(25, 84);
            this.DataTable.MultiSelect = false;
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataTable.Size = new System.Drawing.Size(744, 432);
            this.DataTable.TabIndex = 0;
            this.DataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellDoubleClick);
            this.DataTable.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataTable_ColumnHeaderMouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "Player ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.id.Width = 75;
            // 
            // name
            // 
            this.name.HeaderText = "Player Nick";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.name.Width = 175;
            // 
            // clantag
            // 
            this.clantag.HeaderText = "Clan";
            this.clantag.Name = "clantag";
            this.clantag.ReadOnly = true;
            this.clantag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // rank
            // 
            this.rank.HeaderText = "Rank";
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            this.rank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.rank.Width = 125;
            // 
            // score
            // 
            this.score.HeaderText = "Score";
            this.score.Name = "score";
            this.score.ReadOnly = true;
            this.score.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // country
            // 
            this.country.HeaderText = "Country";
            this.country.Name = "country";
            this.country.ReadOnly = true;
            this.country.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.country.Width = 50;
            // 
            // permban
            // 
            this.permban.HeaderText = "PermBan";
            this.permban.Name = "permban";
            this.permban.ReadOnly = true;
            this.permban.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.permban.Width = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By Name:";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(569, 54);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(200, 20);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Records Per Page: ";
            // 
            // LimitSelect
            // 
            this.LimitSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LimitSelect.FormattingEnabled = true;
            this.LimitSelect.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100",
            "150",
            "250"});
            this.LimitSelect.Location = new System.Drawing.Point(132, 54);
            this.LimitSelect.Name = "LimitSelect";
            this.LimitSelect.Size = new System.Drawing.Size(150, 21);
            this.LimitSelect.TabIndex = 4;
            this.LimitSelect.SelectedIndexChanged += new System.EventHandler(this.LimitSelect_SelectedIndexChanged);
            // 
            // RowCountDesc
            // 
            this.RowCountDesc.AutoSize = true;
            this.RowCountDesc.Location = new System.Drawing.Point(26, 532);
            this.RowCountDesc.Name = "RowCountDesc";
            this.RowCountDesc.Size = new System.Drawing.Size(65, 13);
            this.RowCountDesc.TabIndex = 5;
            this.RowCountDesc.Text = "PlaceHolder";
            // 
            // FirstBtn
            // 
            this.FirstBtn.Location = new System.Drawing.Point(385, 527);
            this.FirstBtn.Name = "FirstBtn";
            this.FirstBtn.Size = new System.Drawing.Size(70, 25);
            this.FirstBtn.TabIndex = 6;
            this.FirstBtn.Text = "First";
            this.FirstBtn.UseVisualStyleBackColor = true;
            this.FirstBtn.Click += new System.EventHandler(this.FirstBtn_Click);
            // 
            // LastBtn
            // 
            this.LastBtn.Location = new System.Drawing.Point(690, 526);
            this.LastBtn.Name = "LastBtn";
            this.LastBtn.Size = new System.Drawing.Size(70, 25);
            this.LastBtn.TabIndex = 7;
            this.LastBtn.Text = "Last";
            this.LastBtn.UseVisualStyleBackColor = true;
            this.LastBtn.Click += new System.EventHandler(this.LastBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(614, 526);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(70, 25);
            this.NextBtn.TabIndex = 9;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Location = new System.Drawing.Point(461, 527);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(70, 25);
            this.PreviousBtn.TabIndex = 8;
            this.PreviousBtn.Text = "Previous";
            this.PreviousBtn.UseVisualStyleBackColor = true;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // PageNumber
            // 
            this.PageNumber.Location = new System.Drawing.Point(538, 530);
            this.PageNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PageNumber.Name = "PageNumber";
            this.PageNumber.ReadOnly = true;
            this.PageNumber.Size = new System.Drawing.Size(70, 20);
            this.PageNumber.TabIndex = 10;
            this.PageNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PageNumber.ValueChanged += new System.EventHandler(this.PageNumber_ValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(29, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(739, 24);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "Below is a list of all the players in your stats database. Select a player to edi" +
                "t or view by double clicking on a player below";
            // 
            // PlayerSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.PageNumber);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PreviousBtn);
            this.Controls.Add(this.LastBtn);
            this.Controls.Add(this.FirstBtn);
            this.Controls.Add(this.RowCountDesc);
            this.Controls.Add(this.LimitSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayerSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Player Search";
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LimitSelect;
        private System.Windows.Forms.Label RowCountDesc;
        private System.Windows.Forms.Button FirstBtn;
        private System.Windows.Forms.Button LastBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.NumericUpDown PageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clantag;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn permban;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}