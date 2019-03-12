namespace foci
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.csapatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoadButton = new System.Windows.Forms.Button();
            this.BetoltesButton = new System.Windows.Forms.Button();
            this.focistakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.csapatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.focistakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // csapatBindingSource
            // 
            this.csapatBindingSource.DataSource = typeof(foci.Csapat);
            // 
            // LoadButton
            // 
            this.LoadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadButton.BackgroundImage")));
            this.LoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoadButton.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.ForeColor = System.Drawing.Color.Lime;
            this.LoadButton.Location = new System.Drawing.Point(352, 146);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(238, 286);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "Mentés";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // BetoltesButton
            // 
            this.BetoltesButton.BackgroundImage = global::foci.Properties.Resources.messi2;
            this.BetoltesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BetoltesButton.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetoltesButton.ForeColor = System.Drawing.Color.Lime;
            this.BetoltesButton.Location = new System.Drawing.Point(103, 146);
            this.BetoltesButton.Name = "BetoltesButton";
            this.BetoltesButton.Size = new System.Drawing.Size(230, 286);
            this.BetoltesButton.TabIndex = 1;
            this.BetoltesButton.Text = "Betöltés";
            this.BetoltesButton.UseVisualStyleBackColor = true;
            this.BetoltesButton.Click += new System.EventHandler(this.BetoltesButton_Click);
            // 
            // focistakBindingSource
            // 
            this.focistakBindingSource.DataSource = typeof(foci.Focistak);
            this.focistakBindingSource.CurrentChanged += new System.EventHandler(this.focistakBindingSource_CurrentChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.BetoltesButton);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(706, 562);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.csapatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.focistakBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource csapatBindingSource;
        private System.Windows.Forms.BindingSource focistakBindingSource;
        private System.Windows.Forms.Button BetoltesButton;
        private System.Windows.Forms.Button LoadButton;
    }
}
