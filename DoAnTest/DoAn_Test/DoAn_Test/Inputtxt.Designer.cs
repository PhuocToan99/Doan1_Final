namespace DoAn_Test
{
    partial class frmFile
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
            this.txtShow = new System.Windows.Forms.TextBox();
            this.rbtDanhsach = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.rbtDiem = new System.Windows.Forms.RadioButton();
            this.rbtDoiTuong = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtShow
            // 
            this.txtShow.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShow.Location = new System.Drawing.Point(-3, -1);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtShow.Size = new System.Drawing.Size(603, 437);
            this.txtShow.TabIndex = 0;
            // 
            // rbtDanhsach
            // 
            this.rbtDanhsach.AutoSize = true;
            this.rbtDanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDanhsach.Location = new System.Drawing.Point(45, 462);
            this.rbtDanhsach.Name = "rbtDanhsach";
            this.rbtDanhsach.Size = new System.Drawing.Size(116, 20);
            this.rbtDanhsach.TabIndex = 1;
            this.rbtDanhsach.TabStop = true;
            this.rbtDanhsach.Text = "DanhSach.txt";
            this.rbtDanhsach.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(202, 497);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(138, 32);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtDiem
            // 
            this.rbtDiem.AutoSize = true;
            this.rbtDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDiem.Location = new System.Drawing.Point(240, 462);
            this.rbtDiem.Name = "rbtDiem";
            this.rbtDiem.Size = new System.Drawing.Size(81, 20);
            this.rbtDiem.TabIndex = 3;
            this.rbtDiem.TabStop = true;
            this.rbtDiem.Text = "Diem.txt";
            this.rbtDiem.UseVisualStyleBackColor = true;
            // 
            // rbtDoiTuong
            // 
            this.rbtDoiTuong.AutoSize = true;
            this.rbtDoiTuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDoiTuong.Location = new System.Drawing.Point(408, 462);
            this.rbtDoiTuong.Name = "rbtDoiTuong";
            this.rbtDoiTuong.Size = new System.Drawing.Size(115, 20);
            this.rbtDoiTuong.TabIndex = 4;
            this.rbtDoiTuong.TabStop = true;
            this.rbtDoiTuong.Text = "ChiTietDT.txt";
            this.rbtDoiTuong.UseVisualStyleBackColor = true;
            // 
            // frmFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 541);
            this.Controls.Add(this.rbtDoiTuong);
            this.Controls.Add(this.rbtDiem);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.rbtDanhsach);
            this.Controls.Add(this.txtShow);
            this.Name = "frmFile";
            this.Text = "Inputtxt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.RadioButton rbtDanhsach;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RadioButton rbtDiem;
        private System.Windows.Forms.RadioButton rbtDoiTuong;
    }
}