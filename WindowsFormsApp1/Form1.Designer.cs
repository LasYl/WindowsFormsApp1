﻿namespace WindowsFormsApp1
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
            this.buttonHelloWorld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHelloWorld
            // 
            this.buttonHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelloWorld.Location = new System.Drawing.Point(271, 170);
            this.buttonHelloWorld.Name = "buttonHelloWorld";
            this.buttonHelloWorld.Size = new System.Drawing.Size(297, 68);
            this.buttonHelloWorld.TabIndex = 0;
            this.buttonHelloWorld.Text = "paina tästä";
            this.buttonHelloWorld.UseVisualStyleBackColor = true;
            this.buttonHelloWorld.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelloWorld);
            this.Name = "Form1";
            this.Text = "Pääikkuna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelloWorld;
    }
}

