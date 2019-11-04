namespace DoAn_Test
{
    partial class frmDelete
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShowScore = new System.Windows.Forms.TextBox();
            this.txtShowStudent = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(621, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Danh sách điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Danh sách sinh viên";
            // 
            // txtShowScore
            // 
            this.txtShowScore.Location = new System.Drawing.Point(459, 98);
            this.txtShowScore.Multiline = true;
            this.txtShowScore.Name = "txtShowScore";
            this.txtShowScore.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtShowScore.Size = new System.Drawing.Size(419, 346);
            this.txtShowScore.TabIndex = 43;
            // 
            // txtShowStudent
            // 
            this.txtShowStudent.Location = new System.Drawing.Point(0, 98);
            this.txtShowStudent.Multiline = true;
            this.txtShowStudent.Name = "txtShowStudent";
            this.txtShowStudent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtShowStudent.Size = new System.Drawing.Size(434, 346);
            this.txtShowStudent.TabIndex = 42;
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(475, 3);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 41;
            this.btnInput.Text = "Đồng ý";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.BtnInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(348, 5);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(75, 20);
            this.txtInput.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Nhập ID thí sinh muốn xóa";
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShowScore);
            this.Controls.Add(this.txtShowStudent);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label7);
            this.Name = "frmDelete";
            this.Text = "Xóa_thông_tin";
            this.Load += new System.EventHandler(this.FrmDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShowScore;
        private System.Windows.Forms.TextBox txtShowStudent;
        private System.Windows.Forms.Button btnInput;
        public System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label7;
    }
}