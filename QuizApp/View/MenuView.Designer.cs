﻿namespace QuizApp.View
{
  partial class MenuView
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
      this.buttonStart = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // buttonStart
      // 
      this.buttonStart.Location = new System.Drawing.Point(68, 103);
      this.buttonStart.Name = "buttonStart";
      this.buttonStart.Size = new System.Drawing.Size(147, 48);
      this.buttonStart.TabIndex = 0;
      this.buttonStart.Text = "Start";
      this.buttonStart.UseVisualStyleBackColor = true;
      this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
      // 
      // MenuView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.buttonStart);
      this.Name = "MenuView";
      this.Text = "Menu";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonStart;
  }
}

