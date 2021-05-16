
namespace WindowsFormsAsyncAwaitExample
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
            this.btnProcessFileSync = new System.Windows.Forms.Button();
            this.btnProcessFileAsync = new System.Windows.Forms.Button();
            this.labelCount1 = new System.Windows.Forms.Label();
            this.labelCount2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcessFileSync
            // 
            this.btnProcessFileSync.Location = new System.Drawing.Point(34, 82);
            this.btnProcessFileSync.Name = "btnProcessFileSync";
            this.btnProcessFileSync.Size = new System.Drawing.Size(241, 55);
            this.btnProcessFileSync.TabIndex = 0;
            this.btnProcessFileSync.Text = "Process File Sync";
            this.btnProcessFileSync.UseVisualStyleBackColor = true;
            this.btnProcessFileSync.Click += new System.EventHandler(this.btnProcessFileSync_Click);
            // 
            // btnProcessFileAsync
            // 
            this.btnProcessFileAsync.Location = new System.Drawing.Point(475, 82);
            this.btnProcessFileAsync.Name = "btnProcessFileAsync";
            this.btnProcessFileAsync.Size = new System.Drawing.Size(241, 55);
            this.btnProcessFileAsync.TabIndex = 1;
            this.btnProcessFileAsync.Text = "Process File Async";
            this.btnProcessFileAsync.UseVisualStyleBackColor = true;
            this.btnProcessFileAsync.Click += new System.EventHandler(this.btnProcessFileAsync_Click);
            // 
            // labelCount1
            // 
            this.labelCount1.AutoSize = true;
            this.labelCount1.Location = new System.Drawing.Point(42, 199);
            this.labelCount1.Name = "labelCount1";
            this.labelCount1.Size = new System.Drawing.Size(145, 20);
            this.labelCount1.TabIndex = 2;
            this.labelCount1.Text = "0 Characters in File";
            // 
            // labelCount2
            // 
            this.labelCount2.AutoSize = true;
            this.labelCount2.Location = new System.Drawing.Point(471, 199);
            this.labelCount2.Name = "labelCount2";
            this.labelCount2.Size = new System.Drawing.Size(145, 20);
            this.labelCount2.TabIndex = 3;
            this.labelCount2.Text = "0 Characters in File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCount2);
            this.Controls.Add(this.labelCount1);
            this.Controls.Add(this.btnProcessFileAsync);
            this.Controls.Add(this.btnProcessFileSync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcessFileSync;
        private System.Windows.Forms.Button btnProcessFileAsync;
        private System.Windows.Forms.Label labelCount1;
        private System.Windows.Forms.Label labelCount2;
    }
}

