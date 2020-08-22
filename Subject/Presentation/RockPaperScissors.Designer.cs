namespace Subject.Presentation
{
    partial class RockPaperScissors
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblChant = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAppealingPoint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRock.Location = new System.Drawing.Point(42, 156);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 75);
            this.btnRock.TabIndex = 4;
            this.btnRock.Text = "グー";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPaper.Location = new System.Drawing.Point(231, 156);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 75);
            this.btnPaper.TabIndex = 4;
            this.btnPaper.Text = "パー";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScissors.Location = new System.Drawing.Point(137, 156);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(75, 75);
            this.btnScissors.TabIndex = 4;
            this.btnScissors.Text = "チョキ";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // lblChant
            // 
            this.lblChant.AutoSize = true;
            this.lblChant.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChant.Location = new System.Drawing.Point(83, 98);
            this.lblChant.Name = "lblChant";
            this.lblChant.Size = new System.Drawing.Size(184, 25);
            this.lblChant.TabIndex = 5;
            this.lblChant.Text = "最初はグー、じゃんけん";
            // 
            // btnRecord
            // 
            this.btnRecord.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRecord.Location = new System.Drawing.Point(262, 272);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 46);
            this.btnRecord.TabIndex = 6;
            this.btnRecord.Text = "戦績";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(42, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 23);
            this.txtName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 15);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "名前";
            // 
            // btnAppealingPoint
            // 
            this.btnAppealingPoint.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAppealingPoint.Location = new System.Drawing.Point(116, 272);
            this.btnAppealingPoint.Name = "btnAppealingPoint";
            this.btnAppealingPoint.Size = new System.Drawing.Size(119, 46);
            this.btnAppealingPoint.TabIndex = 9;
            this.btnAppealingPoint.Text = "アピールポイント";
            this.btnAppealingPoint.UseVisualStyleBackColor = true;
            this.btnAppealingPoint.Click += new System.EventHandler(this.btnAppealingPoint_Click);
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 340);
            this.Controls.Add(this.btnAppealingPoint);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.lblChant);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "RockPaperScissors";
            this.Text = "RockPaperScissors";
            this.Load += new System.EventHandler(this.Subject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblChant;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAppealingPoint;
    }
}

