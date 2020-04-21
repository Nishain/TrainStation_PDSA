namespace TrainStation
{
    partial class AddDesetance
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
            this.loc1 = new System.Windows.Forms.ComboBox();
            this.Loc2 = new System.Windows.Forms.ComboBox();
            this.Text_distance = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Add_All = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NoOfCommitsHint = new System.Windows.Forms.Label();
            this.commitView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // loc1
            // 
            this.loc1.FormattingEnabled = true;
            this.loc1.Location = new System.Drawing.Point(353, 121);
            this.loc1.Margin = new System.Windows.Forms.Padding(4);
            this.loc1.Name = "loc1";
            this.loc1.Size = new System.Drawing.Size(224, 24);
            this.loc1.TabIndex = 0;
            // 
            // Loc2
            // 
            this.Loc2.FormattingEnabled = true;
            this.Loc2.Location = new System.Drawing.Point(353, 205);
            this.Loc2.Margin = new System.Windows.Forms.Padding(4);
            this.Loc2.Name = "Loc2";
            this.Loc2.Size = new System.Drawing.Size(224, 24);
            this.Loc2.TabIndex = 1;
            // 
            // Text_distance
            // 
            this.Text_distance.Location = new System.Drawing.Point(353, 165);
            this.Text_distance.Margin = new System.Windows.Forms.Padding(4);
            this.Text_distance.Name = "Text_distance";
            this.Text_distance.Size = new System.Drawing.Size(124, 22);
            this.Text_distance.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(455, 271);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 28);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Add_All
            // 
            this.Add_All.Location = new System.Drawing.Point(576, 271);
            this.Add_All.Margin = new System.Windows.Forms.Padding(4);
            this.Add_All.Name = "Add_All";
            this.Add_All.Size = new System.Drawing.Size(100, 28);
            this.Add_All.TabIndex = 4;
            this.Add_All.Text = "Add All";
            this.Add_All.UseVisualStyleBackColor = true;
            this.Add_All.Click += new System.EventHandler(this.Add_All_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(446, 353);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(177, 42);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "View shortestest distance\r\nto other train stations\r\n\r\n\r\n\r\n";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Minimum spaning tree\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Railway Distance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Destination station";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start station\r\n";
            // 
            // NoOfCommitsHint
            // 
            this.NoOfCommitsHint.AutoSize = true;
            this.NoOfCommitsHint.Location = new System.Drawing.Point(748, 326);
            this.NoOfCommitsHint.Name = "NoOfCommitsHint";
            this.NoOfCommitsHint.Size = new System.Drawing.Size(157, 17);
            this.NoOfCommitsHint.TabIndex = 12;
            this.NoOfCommitsHint.Text = "Items to be commited  0";
            // 
            // commitView
            // 
            this.commitView.Location = new System.Drawing.Point(738, 64);
            this.commitView.Name = "commitView";
            this.commitView.Size = new System.Drawing.Size(199, 259);
            this.commitView.TabIndex = 11;
            this.commitView.UseCompatibleStateImageBehavior = false;
            // 
            // AddDesetance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.NoOfCommitsHint);
            this.Controls.Add(this.commitView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add_All);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Text_distance);
            this.Controls.Add(this.Loc2);
            this.Controls.Add(this.loc1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDesetance";
            this.Text = "AddDesetance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox loc1;
        private System.Windows.Forms.ComboBox Loc2;
        private System.Windows.Forms.TextBox Text_distance;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Add_All;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NoOfCommitsHint;
        private System.Windows.Forms.ListView commitView;
    }
}