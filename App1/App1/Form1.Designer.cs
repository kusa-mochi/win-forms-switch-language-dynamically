namespace App1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.TestLabel = new System.Windows.Forms.Label();
            this.EnButton = new System.Windows.Forms.Button();
            this.JaButton = new System.Windows.Forms.Button();
            this.OpenModalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TestLabel.Location = new System.Drawing.Point(297, 94);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(96, 34);
            this.TestLabel.TabIndex = 0;
            this.TestLabel.Text = "label1";
            // 
            // EnButton
            // 
            this.EnButton.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EnButton.Location = new System.Drawing.Point(159, 223);
            this.EnButton.Name = "EnButton";
            this.EnButton.Size = new System.Drawing.Size(164, 60);
            this.EnButton.TabIndex = 1;
            this.EnButton.Text = "English";
            this.EnButton.UseVisualStyleBackColor = true;
            this.EnButton.Click += new System.EventHandler(this.EnButton_Click);
            // 
            // JaButton
            // 
            this.JaButton.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JaButton.Location = new System.Drawing.Point(377, 223);
            this.JaButton.Name = "JaButton";
            this.JaButton.Size = new System.Drawing.Size(164, 60);
            this.JaButton.TabIndex = 2;
            this.JaButton.Text = "日本語";
            this.JaButton.UseVisualStyleBackColor = true;
            this.JaButton.Click += new System.EventHandler(this.JaButton_Click);
            // 
            // OpenModalButton
            // 
            this.OpenModalButton.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OpenModalButton.Location = new System.Drawing.Point(213, 324);
            this.OpenModalButton.Name = "OpenModalButton";
            this.OpenModalButton.Size = new System.Drawing.Size(308, 85);
            this.OpenModalButton.TabIndex = 3;
            this.OpenModalButton.UseVisualStyleBackColor = true;
            this.OpenModalButton.Click += new System.EventHandler(this.OpenModalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenModalButton);
            this.Controls.Add(this.JaButton);
            this.Controls.Add(this.EnButton);
            this.Controls.Add(this.TestLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TestLabel;
        private System.Windows.Forms.Button EnButton;
        private System.Windows.Forms.Button JaButton;
        private System.Windows.Forms.Button OpenModalButton;
    }
}

