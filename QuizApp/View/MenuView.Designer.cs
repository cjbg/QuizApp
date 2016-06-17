namespace QuizApp.View
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
      this.checkBoxShuffleAnswers = new System.Windows.Forms.CheckBox();
      this.checkBoxHideAnswerNumber = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // buttonStart
      // 
      this.buttonStart.Location = new System.Drawing.Point(57, 118);
      this.buttonStart.Name = "buttonStart";
      this.buttonStart.Size = new System.Drawing.Size(147, 48);
      this.buttonStart.TabIndex = 0;
      this.buttonStart.Text = "Start";
      this.buttonStart.UseVisualStyleBackColor = true;
      this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
      // 
      // checkBoxShuffleAnswers
      // 
      this.checkBoxShuffleAnswers.AutoSize = true;
      this.checkBoxShuffleAnswers.Location = new System.Drawing.Point(57, 43);
      this.checkBoxShuffleAnswers.Name = "checkBoxShuffleAnswers";
      this.checkBoxShuffleAnswers.Size = new System.Drawing.Size(167, 17);
      this.checkBoxShuffleAnswers.TabIndex = 1;
      this.checkBoxShuffleAnswers.Text = "Losowa kolejność odpowiedzi";
      this.checkBoxShuffleAnswers.UseVisualStyleBackColor = true;
      // 
      // checkBoxHideAnswerNumber
      // 
      this.checkBoxHideAnswerNumber.AutoSize = true;
      this.checkBoxHideAnswerNumber.Location = new System.Drawing.Point(57, 66);
      this.checkBoxHideAnswerNumber.Name = "checkBoxHideAnswerNumber";
      this.checkBoxHideAnswerNumber.Size = new System.Drawing.Size(170, 17);
      this.checkBoxHideAnswerNumber.TabIndex = 2;
      this.checkBoxHideAnswerNumber.Text = "Ukryj litery przy odpowiedziach";
      this.checkBoxHideAnswerNumber.UseVisualStyleBackColor = true;
      // 
      // MenuView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(276, 254);
      this.Controls.Add(this.checkBoxHideAnswerNumber);
      this.Controls.Add(this.checkBoxShuffleAnswers);
      this.Controls.Add(this.buttonStart);
      this.Name = "MenuView";
      this.Text = "Menu";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonStart;
    private System.Windows.Forms.CheckBox checkBoxShuffleAnswers;
    private System.Windows.Forms.CheckBox checkBoxHideAnswerNumber;
  }
}

