namespace RedAlertLauncher
{
    partial class MapEditorsForm
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
            this.but_RAED = new System.Windows.Forms.Button();
            this.but_RAED_DesertWinter = new System.Windows.Forms.Button();
            this.but_edwin = new System.Windows.Forms.Button();
            this.but_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_RAED
            // 
            this.but_RAED.Location = new System.Drawing.Point(49, 36);
            this.but_RAED.Name = "but_RAED";
            this.but_RAED.Padding = new System.Windows.Forms.Padding(5);
            this.but_RAED.Size = new System.Drawing.Size(336, 31);
            this.but_RAED.TabIndex = 0;
            this.but_RAED.Text = "RAED Map Editor";
            this.but_RAED.UseVisualStyleBackColor = true;
            this.but_RAED.Click += new System.EventHandler(this.but_RAED_Click);
            // 
            // but_RAED_DesertWinter
            // 
            this.but_RAED_DesertWinter.Location = new System.Drawing.Point(49, 73);
            this.but_RAED_DesertWinter.Name = "but_RAED_DesertWinter";
            this.but_RAED_DesertWinter.Padding = new System.Windows.Forms.Padding(5);
            this.but_RAED_DesertWinter.Size = new System.Drawing.Size(336, 31);
            this.but_RAED_DesertWinter.TabIndex = 1;
            this.but_RAED_DesertWinter.Text = "RAED Map Editor (Desert && Winter)";
            this.but_RAED_DesertWinter.UseVisualStyleBackColor = true;
            this.but_RAED_DesertWinter.Click += new System.EventHandler(this.but_RAED_DesertWinter_Click);
            // 
            // but_edwin
            // 
            this.but_edwin.Location = new System.Drawing.Point(49, 110);
            this.but_edwin.Name = "but_edwin";
            this.but_edwin.Padding = new System.Windows.Forms.Padding(5);
            this.but_edwin.Size = new System.Drawing.Size(336, 31);
            this.but_edwin.TabIndex = 2;
            this.but_edwin.Text = "Edwin Terrain Editor";
            this.but_edwin.UseVisualStyleBackColor = true;
            this.but_edwin.Click += new System.EventHandler(this.but_edwin_Click);
            // 
            // but_close
            // 
            this.but_close.Location = new System.Drawing.Point(49, 147);
            this.but_close.Name = "but_close";
            this.but_close.Padding = new System.Windows.Forms.Padding(5);
            this.but_close.Size = new System.Drawing.Size(336, 31);
            this.but_close.TabIndex = 3;
            this.but_close.Text = "Close";
            this.but_close.UseVisualStyleBackColor = true;
            // 
            // MapEditorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_close;
            this.ClientSize = new System.Drawing.Size(428, 210);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.but_edwin);
            this.Controls.Add(this.but_RAED_DesertWinter);
            this.Controls.Add(this.but_RAED);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MapEditorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose map editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_RAED;
        private System.Windows.Forms.Button but_RAED_DesertWinter;
        private System.Windows.Forms.Button but_edwin;
        private System.Windows.Forms.Button but_close;

    }
}