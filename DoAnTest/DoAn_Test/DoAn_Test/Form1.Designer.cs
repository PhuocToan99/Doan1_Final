namespace DoAn_Test
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStudentInfo = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStudentInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStudentInfo
            // 
            this.btnStudentInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStudentInfo.BackgroundImage")));
            this.btnStudentInfo.Location = new System.Drawing.Point(194, 106);
            this.btnStudentInfo.Name = "btnStudentInfo";
            this.btnStudentInfo.Size = new System.Drawing.Size(129, 127);
            this.btnStudentInfo.TabIndex = 0;
            this.btnStudentInfo.UseVisualStyleBackColor = true;
            this.btnStudentInfo.Click += new System.EventHandler(this.BtnStudentInfo_Click);
            // 
            // btnScore
            // 
            this.btnScore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScore.BackgroundImage")));
            this.btnScore.Location = new System.Drawing.Point(454, 106);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(129, 127);
            this.btnScore.TabIndex = 1;
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.BtnScore_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phần mềm quản lí sinh viên";
            // 
            // lbStudentInfo
            // 
            this.lbStudentInfo.AutoSize = true;
            this.lbStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentInfo.Location = new System.Drawing.Point(149, 257);
            this.lbStudentInfo.Name = "lbStudentInfo";
            this.lbStudentInfo.Size = new System.Drawing.Size(213, 25);
            this.lbStudentInfo.TabIndex = 3;
            this.lbStudentInfo.Text = "Thông tin sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Điểm số";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbStudentInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnStudentInfo);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentInfo;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStudentInfo;
        private System.Windows.Forms.Label label2;
    }
}

