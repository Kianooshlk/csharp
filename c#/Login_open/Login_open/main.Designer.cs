namespace Login_open
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtgame = new System.Windows.Forms.TextBox();
            this.txtstart = new System.Windows.Forms.TextBox();
            this.txtfinish = new System.Windows.Forms.TextBox();
            this.txtpa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnGame,
            this.btnStart,
            this.btnFinish,
            this.btnPayment});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 273);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnGame
            // 
            this.btnGame.DataPropertyName = "Game";
            this.btnGame.HeaderText = "Game";
            this.btnGame.MinimumWidth = 6;
            this.btnGame.Name = "btnGame";
            this.btnGame.ReadOnly = true;
            this.btnGame.Width = 125;
            // 
            // btnStart
            // 
            this.btnStart.DataPropertyName = "Start_Time";
            this.btnStart.HeaderText = "Start_Time";
            this.btnStart.MinimumWidth = 6;
            this.btnStart.Name = "btnStart";
            this.btnStart.ReadOnly = true;
            this.btnStart.Width = 125;
            // 
            // btnFinish
            // 
            this.btnFinish.DataPropertyName = "Finish_Time";
            this.btnFinish.HeaderText = "Finish_Time";
            this.btnFinish.MinimumWidth = 6;
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.ReadOnly = true;
            this.btnFinish.Width = 125;
            // 
            // btnPayment
            // 
            this.btnPayment.DataPropertyName = "Payment";
            this.btnPayment.HeaderText = "Payment";
            this.btnPayment.MinimumWidth = 6;
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.ReadOnly = true;
            this.btnPayment.Width = 125;
            // 
            // txtgame
            // 
            this.txtgame.Location = new System.Drawing.Point(146, 70);
            this.txtgame.Name = "txtgame";
            this.txtgame.Size = new System.Drawing.Size(100, 22);
            this.txtgame.TabIndex = 6;
            // 
            // txtstart
            // 
            this.txtstart.Location = new System.Drawing.Point(252, 70);
            this.txtstart.Name = "txtstart";
            this.txtstart.Size = new System.Drawing.Size(100, 22);
            this.txtstart.TabIndex = 6;
            // 
            // txtfinish
            // 
            this.txtfinish.Location = new System.Drawing.Point(358, 70);
            this.txtfinish.Name = "txtfinish";
            this.txtfinish.Size = new System.Drawing.Size(100, 22);
            this.txtfinish.TabIndex = 6;
            // 
            // txtpa
            // 
            this.txtpa.Location = new System.Drawing.Point(464, 70);
            this.txtpa.Name = "txtpa";
            this.txtpa.Size = new System.Drawing.Size(100, 22);
            this.txtpa.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(635, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Registration";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_open.Properties.Resources.apps_65175_66515090704019777_c95568d5_8811_4e30_a0f2_3ac354b35880;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpa);
            this.Controls.Add(this.txtfinish);
            this.Controls.Add(this.txtstart);
            this.Controls.Add(this.txtgame);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main page";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtgame;
        private System.Windows.Forms.TextBox txtstart;
        private System.Windows.Forms.TextBox txtfinish;
        private System.Windows.Forms.TextBox txtpa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnPayment;
    }
}