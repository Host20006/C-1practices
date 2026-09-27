namespace home_assignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.nomericmont = new System.Windows.Forms.Label();
            this.nameofmonth = new System.Windows.Forms.Label();
            this.lploutput = new System.Windows.Forms.Label();
            this.dayoftheweek = new System.Windows.Forms.Label();
            this.txtdayoftheweek = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtdayofthemonth = new System.Windows.Forms.TextBox();
            this.txtnameofthemonth = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(204, 182);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(125, 21);
            this.year.TabIndex = 1;
            this.year.Text = "Enter the Year :";
            this.year.Click += new System.EventHandler(this.label2_Click);
            // 
            // nomericmont
            // 
            this.nomericmont.AutoSize = true;
            this.nomericmont.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomericmont.Location = new System.Drawing.Point(71, 136);
            this.nomericmont.Name = "nomericmont";
            this.nomericmont.Size = new System.Drawing.Size(258, 21);
            this.nomericmont.TabIndex = 2;
            this.nomericmont.Text = "Enter the numeric of the month :";
            this.nomericmont.Click += new System.EventHandler(this.label3_Click);
            // 
            // nameofmonth
            // 
            this.nameofmonth.AutoSize = true;
            this.nameofmonth.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameofmonth.Location = new System.Drawing.Point(117, 86);
            this.nameofmonth.Name = "nameofmonth";
            this.nameofmonth.Size = new System.Drawing.Size(212, 21);
            this.nameofmonth.TabIndex = 4;
            this.nameofmonth.Text = "Enter Name of the month :";
            this.nameofmonth.Click += new System.EventHandler(this.label5_Click);
            // 
            // lploutput
            // 
            this.lploutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lploutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lploutput.Location = new System.Drawing.Point(35, 224);
            this.lploutput.Name = "lploutput";
            this.lploutput.Size = new System.Drawing.Size(671, 50);
            this.lploutput.TabIndex = 5;
            this.lploutput.Click += new System.EventHandler(this.lploutput_Click);
            // 
            // dayoftheweek
            // 
            this.dayoftheweek.AutoSize = true;
            this.dayoftheweek.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayoftheweek.Location = new System.Drawing.Point(146, 40);
            this.dayoftheweek.Name = "dayoftheweek";
            this.dayoftheweek.Size = new System.Drawing.Size(183, 21);
            this.dayoftheweek.TabIndex = 6;
            this.dayoftheweek.Text = "Enter day of the week :";
            this.dayoftheweek.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtdayoftheweek
            // 
            this.txtdayoftheweek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdayoftheweek.Location = new System.Drawing.Point(386, 40);
            this.txtdayoftheweek.Name = "txtdayoftheweek";
            this.txtdayoftheweek.Size = new System.Drawing.Size(210, 20);
            this.txtdayoftheweek.TabIndex = 7;
            this.txtdayoftheweek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtyear
            // 
            this.txtyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyear.Location = new System.Drawing.Point(386, 184);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(210, 20);
            this.txtyear.TabIndex = 8;
            // 
            // txtdayofthemonth
            // 
            this.txtdayofthemonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdayofthemonth.Location = new System.Drawing.Point(386, 138);
            this.txtdayofthemonth.Name = "txtdayofthemonth";
            this.txtdayofthemonth.Size = new System.Drawing.Size(210, 20);
            this.txtdayofthemonth.TabIndex = 9;
            // 
            // txtnameofthemonth
            // 
            this.txtnameofthemonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnameofthemonth.Location = new System.Drawing.Point(386, 86);
            this.txtnameofthemonth.Name = "txtnameofthemonth";
            this.txtnameofthemonth.Size = new System.Drawing.Size(210, 20);
            this.txtnameofthemonth.TabIndex = 10;
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(90, 307);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(119, 61);
            this.btnshow.TabIndex = 11;
            this.btnshow.Text = "show date";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(485, 307);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 61);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(285, 307);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(114, 61);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 426);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtnameofthemonth);
            this.Controls.Add(this.txtdayofthemonth);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtdayoftheweek);
            this.Controls.Add(this.dayoftheweek);
            this.Controls.Add(this.lploutput);
            this.Controls.Add(this.nameofmonth);
            this.Controls.Add(this.nomericmont);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label nomericmont;
        private System.Windows.Forms.Label nameofmonth;
        private System.Windows.Forms.Label lploutput;
        private System.Windows.Forms.Label dayoftheweek;
        private System.Windows.Forms.TextBox txtdayoftheweek;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtdayofthemonth;
        private System.Windows.Forms.TextBox txtnameofthemonth;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnclear;
    }
}

