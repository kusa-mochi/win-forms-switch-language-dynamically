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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TestLabel = new System.Windows.Forms.Label();
            this.EnButton = new System.Windows.Forms.Button();
            this.JaButton = new System.Windows.Forms.Button();
            this.OpenModalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestLabel
            // 
            resources.ApplyResources(this.TestLabel, "TestLabel");
            this.TestLabel.Name = "TestLabel";
            // 
            // EnButton
            // 
            resources.ApplyResources(this.EnButton, "EnButton");
            this.EnButton.Name = "EnButton";
            this.EnButton.UseVisualStyleBackColor = true;
            this.EnButton.Click += new System.EventHandler(this.EnButton_Click);
            // 
            // JaButton
            // 
            resources.ApplyResources(this.JaButton, "JaButton");
            this.JaButton.Name = "JaButton";
            this.JaButton.UseVisualStyleBackColor = true;
            this.JaButton.Click += new System.EventHandler(this.JaButton_Click);
            // 
            // OpenModalButton
            // 
            resources.ApplyResources(this.OpenModalButton, "OpenModalButton");
            this.OpenModalButton.Name = "OpenModalButton";
            this.OpenModalButton.UseVisualStyleBackColor = true;
            this.OpenModalButton.Click += new System.EventHandler(this.OpenModalButton_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OpenModalButton);
            this.Controls.Add(this.JaButton);
            this.Controls.Add(this.EnButton);
            this.Controls.Add(this.TestLabel);
            this.Name = "Form1";
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

