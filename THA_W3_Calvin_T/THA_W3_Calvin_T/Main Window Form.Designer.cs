namespace THA_W3_Calvin_T
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
            this.btn_NextForm = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_FavArtist = new System.Windows.Forms.Label();
            this.cb_agree = new System.Windows.Forms.CheckBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.tbox_Name = new System.Windows.Forms.TextBox();
            this.tbox_FavArtist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_NextForm
            // 
            this.btn_NextForm.Location = new System.Drawing.Point(40, 205);
            this.btn_NextForm.Name = "btn_NextForm";
            this.btn_NextForm.Size = new System.Drawing.Size(179, 50);
            this.btn_NextForm.TabIndex = 0;
            this.btn_NextForm.Text = "Open Next Form";
            this.btn_NextForm.UseVisualStyleBackColor = true;
            this.btn_NextForm.Click += new System.EventHandler(this.btn_NextForm_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(37, 43);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_FavArtist
            // 
            this.lbl_FavArtist.AutoSize = true;
            this.lbl_FavArtist.Location = new System.Drawing.Point(40, 77);
            this.lbl_FavArtist.Name = "lbl_FavArtist";
            this.lbl_FavArtist.Size = new System.Drawing.Size(88, 13);
            this.lbl_FavArtist.TabIndex = 2;
            this.lbl_FavArtist.Text = "My Favorite Artist";
            // 
            // cb_agree
            // 
            this.cb_agree.AutoSize = true;
            this.cb_agree.Location = new System.Drawing.Point(40, 114);
            this.cb_agree.Name = "cb_agree";
            this.cb_agree.Size = new System.Drawing.Size(197, 17);
            this.cb_agree.TabIndex = 3;
            this.cb_agree.Text = "All of the content I put above is true!";
            this.cb_agree.UseVisualStyleBackColor = true;
            this.cb_agree.CheckedChanged += new System.EventHandler(this.cb_agree_CheckedChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.Enabled = false;
            this.btn_submit.Location = new System.Drawing.Point(40, 149);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(88, 40);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // tbox_Name
            // 
            this.tbox_Name.Location = new System.Drawing.Point(140, 43);
            this.tbox_Name.Name = "tbox_Name";
            this.tbox_Name.Size = new System.Drawing.Size(160, 20);
            this.tbox_Name.TabIndex = 5;
            // 
            // tbox_FavArtist
            // 
            this.tbox_FavArtist.Location = new System.Drawing.Point(140, 74);
            this.tbox_FavArtist.Name = "tbox_FavArtist";
            this.tbox_FavArtist.Size = new System.Drawing.Size(160, 20);
            this.tbox_FavArtist.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 337);
            this.Controls.Add(this.tbox_FavArtist);
            this.Controls.Add(this.tbox_Name);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cb_agree);
            this.Controls.Add(this.lbl_FavArtist);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_NextForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NextForm;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_FavArtist;
        private System.Windows.Forms.CheckBox cb_agree;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox tbox_Name;
        private System.Windows.Forms.TextBox tbox_FavArtist;
    }
}

