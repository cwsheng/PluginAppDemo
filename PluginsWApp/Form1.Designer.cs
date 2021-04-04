
namespace PluginWFApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_dllName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelPlugin = new System.Windows.Forms.Button();
            this.btnUnload = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRunPlugin = new System.Windows.Forms.Button();
            this.txtPluginName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAppdomain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_dllName
            // 
            this.txt_dllName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dllName.Location = new System.Drawing.Point(83, 8);
            this.txt_dllName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dllName.Name = "txt_dllName";
            this.txt_dllName.Size = new System.Drawing.Size(688, 21);
            this.txt_dllName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "插件目录：";
            // 
            // btnSelPlugin
            // 
            this.btnSelPlugin.Location = new System.Drawing.Point(83, 33);
            this.btnSelPlugin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelPlugin.Name = "btnSelPlugin";
            this.btnSelPlugin.Size = new System.Drawing.Size(72, 21);
            this.btnSelPlugin.TabIndex = 2;
            this.btnSelPlugin.Text = "选择插件";
            this.btnSelPlugin.UseVisualStyleBackColor = true;
            this.btnSelPlugin.Click += new System.EventHandler(this.btnSelPlugin_Click);
            // 
            // btnUnload
            // 
            this.btnUnload.Location = new System.Drawing.Point(83, 58);
            this.btnUnload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(72, 24);
            this.btnUnload.TabIndex = 4;
            this.btnUnload.Text = "卸载插件";
            this.btnUnload.UseVisualStyleBackColor = true;
            this.btnUnload.Click += new System.EventHandler(this.btnUnload_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(10, 111);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(760, 253);
            this.txtOutput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "输出：";
            // 
            // btnRunPlugin
            // 
            this.btnRunPlugin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunPlugin.Location = new System.Drawing.Point(696, 76);
            this.btnRunPlugin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRunPlugin.Name = "btnRunPlugin";
            this.btnRunPlugin.Size = new System.Drawing.Size(72, 22);
            this.btnRunPlugin.TabIndex = 4;
            this.btnRunPlugin.Text = "执行插件";
            this.btnRunPlugin.UseVisualStyleBackColor = true;
            this.btnRunPlugin.Click += new System.EventHandler(this.btnRunPlugin_Click);
            // 
            // txtPluginName
            // 
            this.txtPluginName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPluginName.Location = new System.Drawing.Point(566, 77);
            this.txtPluginName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPluginName.Name = "txtPluginName";
            this.txtPluginName.Size = new System.Drawing.Size(124, 21);
            this.txtPluginName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "插件名称：";
            // 
            // btnAppdomain
            // 
            this.btnAppdomain.Location = new System.Drawing.Point(176, 58);
            this.btnAppdomain.Name = "btnAppdomain";
            this.btnAppdomain.Size = new System.Drawing.Size(75, 23);
            this.btnAppdomain.TabIndex = 8;
            this.btnAppdomain.Text = "程序域";
            this.btnAppdomain.UseVisualStyleBackColor = true;
            this.btnAppdomain.Click += new System.EventHandler(this.btnAppdomain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 371);
            this.Controls.Add(this.btnAppdomain);
            this.Controls.Add(this.txtPluginName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnRunPlugin);
            this.Controls.Add(this.btnUnload);
            this.Controls.Add(this.btnSelPlugin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dllName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PluginApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dllName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelPlugin;
        private System.Windows.Forms.Button btnUnload;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRunPlugin;
        private System.Windows.Forms.TextBox txtPluginName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAppdomain;
    }
}

