namespace TrainStation
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addall = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.commitView = new System.Windows.Forms.ListView();
            this.NoOfCommitsHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(435, 122);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addall
            // 
            this.addall.Location = new System.Drawing.Point(191, 402);
            this.addall.Margin = new System.Windows.Forms.Padding(4);
            this.addall.Name = "addall";
            this.addall.Size = new System.Drawing.Size(145, 28);
            this.addall.TabIndex = 2;
            this.addall.Text = "Commit changes";
            this.addall.UseVisualStyleBackColor = true;
            this.addall.Click += new System.EventHandler(this.addall_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(435, 203);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(100, 28);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Station";
            // 
            // commitView
            // 
            this.commitView.Location = new System.Drawing.Point(169, 110);
            this.commitView.Name = "commitView";
            this.commitView.Size = new System.Drawing.Size(199, 259);
            this.commitView.TabIndex = 5;
            this.commitView.UseCompatibleStateImageBehavior = false;
            // 
            // NoOfCommitsHint
            // 
            this.NoOfCommitsHint.AutoSize = true;
            this.NoOfCommitsHint.Location = new System.Drawing.Point(179, 372);
            this.NoOfCommitsHint.Name = "NoOfCommitsHint";
            this.NoOfCommitsHint.Size = new System.Drawing.Size(157, 17);
            this.NoOfCommitsHint.TabIndex = 6;
            this.NoOfCommitsHint.Text = "Items to be commited  0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.NoOfCommitsHint);
            this.Controls.Add(this.commitView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.addall);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addall;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView commitView;
        private System.Windows.Forms.Label NoOfCommitsHint;
    }
}

