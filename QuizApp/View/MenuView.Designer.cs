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
      this.buttonStart_Questions_1_114 = new System.Windows.Forms.Button();
      this.checkBoxShuffleAnswers = new System.Windows.Forms.CheckBox();
      this.checkBoxHideAnswerNumber = new System.Windows.Forms.CheckBox();
      this.textBoxRepetitionNumber = new System.Windows.Forms.TextBox();
      this.labelRepetitionNumber = new System.Windows.Forms.Label();
      this.buttonStart_Questions_115_294 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // buttonStart_Questions_1_114
      // 
      this.buttonStart_Questions_1_114.Location = new System.Drawing.Point(86, 210);
      this.buttonStart_Questions_1_114.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonStart_Questions_1_114.Name = "buttonStart_Questions_1_114";
      this.buttonStart_Questions_1_114.Size = new System.Drawing.Size(220, 74);
      this.buttonStart_Questions_1_114.TabIndex = 0;
      this.buttonStart_Questions_1_114.Text = "Start - Fizjologia 1-114";
      this.buttonStart_Questions_1_114.UseVisualStyleBackColor = true;
      this.buttonStart_Questions_1_114.Click += new System.EventHandler(this.buttonStart_Click);
      // 
      // checkBoxShuffleAnswers
      // 
      this.checkBoxShuffleAnswers.AutoSize = true;
      this.checkBoxShuffleAnswers.Location = new System.Drawing.Point(86, 117);
      this.checkBoxShuffleAnswers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.checkBoxShuffleAnswers.Name = "checkBoxShuffleAnswers";
      this.checkBoxShuffleAnswers.Size = new System.Drawing.Size(236, 24);
      this.checkBoxShuffleAnswers.TabIndex = 1;
      this.checkBoxShuffleAnswers.Text = "Losowa kolejność odpowiedzi";
      this.checkBoxShuffleAnswers.UseVisualStyleBackColor = true;
      // 
      // checkBoxHideAnswerNumber
      // 
      this.checkBoxHideAnswerNumber.AutoSize = true;
      this.checkBoxHideAnswerNumber.Location = new System.Drawing.Point(86, 152);
      this.checkBoxHideAnswerNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.checkBoxHideAnswerNumber.Name = "checkBoxHideAnswerNumber";
      this.checkBoxHideAnswerNumber.Size = new System.Drawing.Size(241, 24);
      this.checkBoxHideAnswerNumber.TabIndex = 2;
      this.checkBoxHideAnswerNumber.Text = "Ukryj litery przy odpowiedziach";
      this.checkBoxHideAnswerNumber.UseVisualStyleBackColor = true;
      // 
      // textBoxRepetitionNumber
      // 
      this.textBoxRepetitionNumber.Location = new System.Drawing.Point(86, 77);
      this.textBoxRepetitionNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.textBoxRepetitionNumber.Name = "textBoxRepetitionNumber";
      this.textBoxRepetitionNumber.Size = new System.Drawing.Size(218, 26);
      this.textBoxRepetitionNumber.TabIndex = 3;
      // 
      // labelRepetitionNumber
      // 
      this.labelRepetitionNumber.AutoSize = true;
      this.labelRepetitionNumber.Location = new System.Drawing.Point(81, 52);
      this.labelRepetitionNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelRepetitionNumber.Name = "labelRepetitionNumber";
      this.labelRepetitionNumber.Size = new System.Drawing.Size(188, 20);
      this.labelRepetitionNumber.TabIndex = 4;
      this.labelRepetitionNumber.Text = "Liczba powtórzeń pytania";
      // 
      // buttonStart_Questions_115_294
      // 
      this.buttonStart_Questions_115_294.Location = new System.Drawing.Point(84, 294);
      this.buttonStart_Questions_115_294.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonStart_Questions_115_294.Name = "buttonStart_Questions_115_294";
      this.buttonStart_Questions_115_294.Size = new System.Drawing.Size(220, 74);
      this.buttonStart_Questions_115_294.TabIndex = 5;
      this.buttonStart_Questions_115_294.Text = "Start - Fizjologia 115-294";
      this.buttonStart_Questions_115_294.UseVisualStyleBackColor = true;
      this.buttonStart_Questions_115_294.Click += new System.EventHandler(this.buttonStart_Questions_115_294_Click);
      // 
      // MenuView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(414, 391);
      this.Controls.Add(this.buttonStart_Questions_115_294);
      this.Controls.Add(this.labelRepetitionNumber);
      this.Controls.Add(this.textBoxRepetitionNumber);
      this.Controls.Add(this.checkBoxHideAnswerNumber);
      this.Controls.Add(this.checkBoxShuffleAnswers);
      this.Controls.Add(this.buttonStart_Questions_1_114);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "MenuView";
      this.Text = "Menu";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonStart_Questions_1_114;
    private System.Windows.Forms.CheckBox checkBoxShuffleAnswers;
    private System.Windows.Forms.CheckBox checkBoxHideAnswerNumber;
    private System.Windows.Forms.TextBox textBoxRepetitionNumber;
    private System.Windows.Forms.Label labelRepetitionNumber;
    private System.Windows.Forms.Button buttonStart_Questions_115_294;
  }
}

