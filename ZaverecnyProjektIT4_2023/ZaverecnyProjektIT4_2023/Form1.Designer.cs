﻿namespace ZaverecnyProjektIT4_2023
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            button_login = new Button();
            button_clear = new Button();
            button_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("LEMON MILK Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(234, 51);
            label1.Name = "label1";
            label1.Size = new Size(134, 38);
            label1.TabIndex = 0;
            label1.Text = "Vítejte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 143);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 203);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(176, 143);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(259, 23);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(176, 203);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(259, 23);
            txt_password.TabIndex = 4;
            // 
            // button_login
            // 
            button_login.Location = new Point(328, 258);
            button_login.Name = "button_login";
            button_login.Size = new Size(107, 31);
            button_login.TabIndex = 5;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(176, 258);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(107, 31);
            button_clear.TabIndex = 6;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(77, 337);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(107, 31);
            button_exit.TabIndex = 7;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 408);
            Controls.Add(button_exit);
            Controls.Add(button_clear);
            Controls.Add(button_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button button_login;
        private Button button_clear;
        private Button button_exit;
    }
}