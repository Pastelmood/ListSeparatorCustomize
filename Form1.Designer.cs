namespace List_Separator_Customize
{
    partial class Form_Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5_BackSlash = new System.Windows.Forms.RadioButton();
            this.radioButton4_SemiColon = new System.Windows.Forms.RadioButton();
            this.radioButton3_Colon = new System.Windows.Forms.RadioButton();
            this.radioButton2_Pipe = new System.Windows.Forms.RadioButton();
            this.radioButton1_Comma = new System.Windows.Forms.RadioButton();
            this.button_OK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5_BackSlash);
            this.groupBox1.Controls.Add(this.radioButton4_SemiColon);
            this.groupBox1.Controls.Add(this.radioButton3_Colon);
            this.groupBox1.Controls.Add(this.radioButton2_Pipe);
            this.groupBox1.Controls.Add(this.radioButton1_Comma);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Separator";
            // 
            // radioButton5_BackSlash
            // 
            this.radioButton5_BackSlash.AutoSize = true;
            this.radioButton5_BackSlash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton5_BackSlash.Location = new System.Drawing.Point(23, 162);
            this.radioButton5_BackSlash.Name = "radioButton5_BackSlash";
            this.radioButton5_BackSlash.Size = new System.Drawing.Size(129, 25);
            this.radioButton5_BackSlash.TabIndex = 4;
            this.radioButton5_BackSlash.Text = "Back Slash ( / )";
            this.radioButton5_BackSlash.UseVisualStyleBackColor = true;
            // 
            // radioButton4_SemiColon
            // 
            this.radioButton4_SemiColon.AutoSize = true;
            this.radioButton4_SemiColon.Checked = true;
            this.radioButton4_SemiColon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton4_SemiColon.Location = new System.Drawing.Point(23, 131);
            this.radioButton4_SemiColon.Name = "radioButton4_SemiColon";
            this.radioButton4_SemiColon.Size = new System.Drawing.Size(135, 25);
            this.radioButton4_SemiColon.TabIndex = 3;
            this.radioButton4_SemiColon.TabStop = true;
            this.radioButton4_SemiColon.Text = "Semi-Colon ( ; )";
            this.radioButton4_SemiColon.UseVisualStyleBackColor = true;
            // 
            // radioButton3_Colon
            // 
            this.radioButton3_Colon.AutoSize = true;
            this.radioButton3_Colon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3_Colon.Location = new System.Drawing.Point(23, 100);
            this.radioButton3_Colon.Name = "radioButton3_Colon";
            this.radioButton3_Colon.Size = new System.Drawing.Size(94, 25);
            this.radioButton3_Colon.TabIndex = 2;
            this.radioButton3_Colon.Text = "Colon ( : )";
            this.radioButton3_Colon.UseVisualStyleBackColor = true;
            // 
            // radioButton2_Pipe
            // 
            this.radioButton2_Pipe.AutoSize = true;
            this.radioButton2_Pipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2_Pipe.Location = new System.Drawing.Point(23, 69);
            this.radioButton2_Pipe.Name = "radioButton2_Pipe";
            this.radioButton2_Pipe.Size = new System.Drawing.Size(84, 25);
            this.radioButton2_Pipe.TabIndex = 1;
            this.radioButton2_Pipe.Text = "Pipe ( | )";
            this.radioButton2_Pipe.UseVisualStyleBackColor = true;
            // 
            // radioButton1_Comma
            // 
            this.radioButton1_Comma.AutoSize = true;
            this.radioButton1_Comma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1_Comma.Location = new System.Drawing.Point(23, 38);
            this.radioButton1_Comma.Name = "radioButton1_Comma";
            this.radioButton1_Comma.Size = new System.Drawing.Size(108, 25);
            this.radioButton1_Comma.TabIndex = 0;
            this.radioButton1_Comma.Text = "Comma ( , )";
            this.radioButton1_Comma.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_OK.Location = new System.Drawing.Point(214, 25);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(100, 39);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 252);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.Text = "List Separator Customize";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton5_BackSlash;
        private RadioButton radioButton4_SemiColon;
        private RadioButton radioButton3_Colon;
        private RadioButton radioButton2_Pipe;
        private RadioButton radioButton1_Comma;
        private Button button_OK;
    }
}