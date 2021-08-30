
namespace SubscribeToBanderita
{
    partial class frm1
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
            this.btn_Subscribe = new System.Windows.Forms.Button();
            this.cmb_Browser = new System.Windows.Forms.ComboBox();
            this.cmb_LikeOrDislike = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Subscribe
            // 
            this.btn_Subscribe.BackColor = System.Drawing.Color.Red;
            this.btn_Subscribe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Subscribe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Subscribe.FlatAppearance.BorderSize = 0;
            this.btn_Subscribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Subscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Subscribe.ForeColor = System.Drawing.Color.White;
            this.btn_Subscribe.Location = new System.Drawing.Point(0, 56);
            this.btn_Subscribe.Name = "btn_Subscribe";
            this.btn_Subscribe.Size = new System.Drawing.Size(305, 59);
            this.btn_Subscribe.TabIndex = 0;
            this.btn_Subscribe.Text = "اشتراك";
            this.btn_Subscribe.UseVisualStyleBackColor = false;
            this.btn_Subscribe.Click += new System.EventHandler(this.btn_Subscribe_Click);
            // 
            // cmb_Browser
            // 
            this.cmb_Browser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmb_Browser.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmb_Browser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Browser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Browser.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_Browser.FormattingEnabled = true;
            this.cmb_Browser.IntegralHeight = false;
            this.cmb_Browser.ItemHeight = 20;
            this.cmb_Browser.Items.AddRange(new object[] {
            "FireFox",
            "Chrome"});
            this.cmb_Browser.Location = new System.Drawing.Point(0, 0);
            this.cmb_Browser.Name = "cmb_Browser";
            this.cmb_Browser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Browser.Size = new System.Drawing.Size(305, 28);
            this.cmb_Browser.TabIndex = 2;
            // 
            // cmb_LikeOrDislike
            // 
            this.cmb_LikeOrDislike.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmb_LikeOrDislike.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmb_LikeOrDislike.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_LikeOrDislike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LikeOrDislike.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_LikeOrDislike.FormattingEnabled = true;
            this.cmb_LikeOrDislike.IntegralHeight = false;
            this.cmb_LikeOrDislike.ItemHeight = 20;
            this.cmb_LikeOrDislike.Items.AddRange(new object[] {
            "Like",
            "Dis Like"});
            this.cmb_LikeOrDislike.Location = new System.Drawing.Point(0, 28);
            this.cmb_LikeOrDislike.Name = "cmb_LikeOrDislike";
            this.cmb_LikeOrDislike.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_LikeOrDislike.Size = new System.Drawing.Size(305, 28);
            this.cmb_LikeOrDislike.TabIndex = 3;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(305, 115);
            this.Controls.Add(this.cmb_LikeOrDislike);
            this.Controls.Add(this.cmb_Browser);
            this.Controls.Add(this.btn_Subscribe);
            this.Name = "frm1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اشتراك لبندريتا";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Subscribe;
        private System.Windows.Forms.ComboBox cmb_Browser;
        private System.Windows.Forms.ComboBox cmb_LikeOrDislike;
    }
}

