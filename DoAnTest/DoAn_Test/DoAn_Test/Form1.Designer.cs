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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStudentInfo
            // 
            this.btnStudentInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStudentInfo.BackgroundImage")));
            this.btnStudentInfo.Location = new System.Drawing.Point(177, 106);
            this.btnStudentInfo.Name = "btnStudentInfo";
            this.btnStudentInfo.Size = new System.Drawing.Size(129, 127);
            this.btnStudentInfo.TabIndex = 0;
            this.btnStudentInfo.UseVisualStyleBackColor = true;
            this.btnStudentInfo.Click += new System.EventHandler(this.BtnStudentInfo_Click);
            // 
            // btnScore
            // 
            this.btnScore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScore.BackgroundImage")));
            this.btnScore.Location = new System.Drawing.Point(512, 106);
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
            this.lbStudentInfo.Location = new System.Drawing.Point(137, 257);
            this.lbStudentInfo.Name = "lbStudentInfo";
            this.lbStudentInfo.Size = new System.Drawing.Size(213, 25);
            this.lbStudentInfo.TabIndex = 3;
            this.lbStudentInfo.Text = "Thông tin sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Điểm số";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Location = new System.Drawing.Point(177, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 127);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thêm thông tin sinh viên";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(512, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 127);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Xóa thông tin sinh viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

