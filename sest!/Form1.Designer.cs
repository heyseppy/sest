
namespace sest_
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
            this.url_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.field_val_lbx = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.value_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.field_txt = new System.Windows.Forms.TextBox();
            this.get_btn = new System.Windows.Forms.Button();
            this.post_btn = new System.Windows.Forms.Button();
            this.put_btn = new System.Windows.Forms.Button();
            this.results_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // url_txt
            // 
            this.url_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_txt.Location = new System.Drawing.Point(55, 12);
            this.url_txt.Multiline = true;
            this.url_txt.Name = "url_txt";
            this.url_txt.Size = new System.Drawing.Size(809, 34);
            this.url_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "url:";
            // 
            // field_val_lbx
            // 
            this.field_val_lbx.BackColor = System.Drawing.Color.White;
            this.field_val_lbx.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field_val_lbx.FormattingEnabled = true;
            this.field_val_lbx.ItemHeight = 28;
            this.field_val_lbx.Location = new System.Drawing.Point(12, 181);
            this.field_val_lbx.Name = "field_val_lbx";
            this.field_val_lbx.Size = new System.Drawing.Size(852, 60);
            this.field_val_lbx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(350, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "value:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // value_txt
            // 
            this.value_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_txt.Location = new System.Drawing.Point(422, 134);
            this.value_txt.Multiline = true;
            this.value_txt.Name = "value_txt";
            this.value_txt.Size = new System.Drawing.Size(279, 32);
            this.value_txt.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(707, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(7, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "field:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // field_txt
            // 
            this.field_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field_txt.Location = new System.Drawing.Point(74, 134);
            this.field_txt.Multiline = true;
            this.field_txt.Name = "field_txt";
            this.field_txt.Size = new System.Drawing.Size(270, 32);
            this.field_txt.TabIndex = 9;
            // 
            // get_btn
            // 
            this.get_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.get_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_btn.ForeColor = System.Drawing.Color.Black;
            this.get_btn.Location = new System.Drawing.Point(285, 63);
            this.get_btn.Name = "get_btn";
            this.get_btn.Size = new System.Drawing.Size(107, 49);
            this.get_btn.TabIndex = 11;
            this.get_btn.Text = "GET";
            this.get_btn.UseVisualStyleBackColor = false;
            this.get_btn.Click += new System.EventHandler(this.get_btn_Click);
            // 
            // post_btn
            // 
            this.post_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.post_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_btn.Location = new System.Drawing.Point(398, 64);
            this.post_btn.Name = "post_btn";
            this.post_btn.Size = new System.Drawing.Size(107, 49);
            this.post_btn.TabIndex = 12;
            this.post_btn.Text = "POST";
            this.post_btn.UseVisualStyleBackColor = false;
            this.post_btn.Click += new System.EventHandler(this.post_btn_Click);
            // 
            // put_btn
            // 
            this.put_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.put_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.put_btn.Location = new System.Drawing.Point(511, 64);
            this.put_btn.Name = "put_btn";
            this.put_btn.Size = new System.Drawing.Size(107, 49);
            this.put_btn.TabIndex = 13;
            this.put_btn.Text = "PUT";
            this.put_btn.UseVisualStyleBackColor = false;
            this.put_btn.Click += new System.EventHandler(this.put_btn_Click);
            // 
            // results_txt
            // 
            this.results_txt.BackColor = System.Drawing.Color.White;
            this.results_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results_txt.Location = new System.Drawing.Point(12, 247);
            this.results_txt.Multiline = true;
            this.results_txt.Name = "results_txt";
            this.results_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.results_txt.Size = new System.Drawing.Size(852, 332);
            this.results_txt.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(881, 613);
            this.Controls.Add(this.results_txt);
            this.Controls.Add(this.put_btn);
            this.Controls.Add(this.post_btn);
            this.Controls.Add(this.get_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.field_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.value_txt);
            this.Controls.Add(this.field_val_lbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.url_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sest!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox field_val_lbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox value_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox field_txt;
        private System.Windows.Forms.Button get_btn;
        private System.Windows.Forms.Button post_btn;
        private System.Windows.Forms.Button put_btn;
        private System.Windows.Forms.TextBox results_txt;
    }
}

