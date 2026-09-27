namespace assignment
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
            this.lplname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtdepartemenet = new System.Windows.Forms.TextBox();
            this.lplstudent = new System.Windows.Forms.Label();
            this.lpldepartimenet = new System.Windows.Forms.Label();
            this.lplsemester = new System.Windows.Forms.Label();
            this.textsemester = new System.Windows.Forms.TextBox();
            this.showbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.Lpoutput = new System.Windows.Forms.Label();
            this.lblstudentinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lplname
            // 
            this.lplname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lplname.Location = new System.Drawing.Point(173, 70);
            this.lplname.Name = "lplname";
            this.lplname.Size = new System.Drawing.Size(121, 17);
            this.lplname.TabIndex = 0;
            this.lplname.Text = "Enter Student Name";
            this.lplname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(356, 67);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(175, 20);
            this.txtname.TabIndex = 1;
            this.txtname.UseWaitCursor = true;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtstudentid
            // 
            this.txtstudentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstudentid.Location = new System.Drawing.Point(356, 118);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(175, 20);
            this.txtstudentid.TabIndex = 2;
            // 
            // txtdepartemenet
            // 
            this.txtdepartemenet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdepartemenet.Location = new System.Drawing.Point(356, 168);
            this.txtdepartemenet.Name = "txtdepartemenet";
            this.txtdepartemenet.Size = new System.Drawing.Size(175, 20);
            this.txtdepartemenet.TabIndex = 3;
            // 
            // lplstudent
            // 
            this.lplstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lplstudent.Location = new System.Drawing.Point(173, 118);
            this.lplstudent.Name = "lplstudent";
            this.lplstudent.Size = new System.Drawing.Size(121, 17);
            this.lplstudent.TabIndex = 4;
            this.lplstudent.Text = "Enter Student ID";
            // 
            // lpldepartimenet
            // 
            this.lpldepartimenet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpldepartimenet.Location = new System.Drawing.Point(173, 168);
            this.lpldepartimenet.Name = "lpldepartimenet";
            this.lpldepartimenet.Size = new System.Drawing.Size(167, 20);
            this.lpldepartimenet.TabIndex = 5;
            this.lpldepartimenet.Text = "EnterThe Departement";
            // 
            // lplsemester
            // 
            this.lplsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lplsemester.Location = new System.Drawing.Point(173, 218);
            this.lplsemester.Name = "lplsemester";
            this.lplsemester.Size = new System.Drawing.Size(121, 17);
            this.lplsemester.TabIndex = 6;
            this.lplsemester.Text = "EnterThe Semester";
            // 
            // textsemester
            // 
            this.textsemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textsemester.Location = new System.Drawing.Point(356, 215);
            this.textsemester.Name = "textsemester";
            this.textsemester.Size = new System.Drawing.Size(175, 20);
            this.textsemester.TabIndex = 7;
            // 
            // showbtn
            // 
            this.showbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.showbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showbtn.Location = new System.Drawing.Point(176, 325);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(143, 29);
            this.showbtn.TabIndex = 8;
            this.showbtn.Text = "Show informatin";
            this.showbtn.UseVisualStyleBackColor = false;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(388, 325);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(143, 29);
            this.clearbtn.TabIndex = 9;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // Lpoutput
            // 
            this.Lpoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lpoutput.Location = new System.Drawing.Point(176, 252);
            this.Lpoutput.Name = "Lpoutput";
            this.Lpoutput.Size = new System.Drawing.Size(355, 45);
            this.Lpoutput.TabIndex = 10;
            // 
            // lblstudentinfo
            // 
            this.lblstudentinfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentinfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblstudentinfo.Location = new System.Drawing.Point(249, 9);
            this.lblstudentinfo.Name = "lblstudentinfo";
            this.lblstudentinfo.Size = new System.Drawing.Size(218, 23);
            this.lblstudentinfo.TabIndex = 11;
            this.lblstudentinfo.Text = "Student Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.lblstudentinfo);
            this.Controls.Add(this.Lpoutput);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.textsemester);
            this.Controls.Add(this.lplsemester);
            this.Controls.Add(this.lpldepartimenet);
            this.Controls.Add(this.lplstudent);
            this.Controls.Add(this.txtdepartemenet);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lplname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lplname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtdepartemenet;
        private System.Windows.Forms.Label lplstudent;
        private System.Windows.Forms.Label lpldepartimenet;
        private System.Windows.Forms.Label lplsemester;
        private System.Windows.Forms.TextBox textsemester;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Label Lpoutput;
        private System.Windows.Forms.Label lblstudentinfo;
    }
}

