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
      this.checkBoxShuffleAnswers = new System.Windows.Forms.CheckBox();
      this.checkBoxHideAnswerNumber = new System.Windows.Forms.CheckBox();
      this.textBoxRepetitionNumber = new System.Windows.Forms.TextBox();
      this.labelRepetitionNumber = new System.Windows.Forms.Label();
      this.buttonStart = new System.Windows.Forms.Button();
      this._comboBoxQuiz = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // checkBoxShuffleAnswers
      // 
      this.checkBoxShuffleAnswers.AutoSize = true;
      this.checkBoxShuffleAnswers.Location = new System.Drawing.Point(57, 97);
      this.checkBoxShuffleAnswers.Name = "checkBoxShuffleAnswers";
      this.checkBoxShuffleAnswers.Size = new System.Drawing.Size(167, 17);
      this.checkBoxShuffleAnswers.TabIndex = 1;
      this.checkBoxShuffleAnswers.Text = "Losowa kolejność odpowiedzi";
      this.checkBoxShuffleAnswers.UseVisualStyleBackColor = true;
      // 
      // checkBoxHideAnswerNumber
      // 
      this.checkBoxHideAnswerNumber.AutoSize = true;
      this.checkBoxHideAnswerNumber.Location = new System.Drawing.Point(57, 120);
      this.checkBoxHideAnswerNumber.Name = "checkBoxHideAnswerNumber";
      this.checkBoxHideAnswerNumber.Size = new System.Drawing.Size(170, 17);
      this.checkBoxHideAnswerNumber.TabIndex = 2;
      this.checkBoxHideAnswerNumber.Text = "Ukryj litery przy odpowiedziach";
      this.checkBoxHideAnswerNumber.UseVisualStyleBackColor = true;
      // 
      // textBoxRepetitionNumber
      // 
      this.textBoxRepetitionNumber.Location = new System.Drawing.Point(187, 140);
      this.textBoxRepetitionNumber.Name = "textBoxRepetitionNumber";
      this.textBoxRepetitionNumber.Size = new System.Drawing.Size(35, 20);
      this.textBoxRepetitionNumber.TabIndex = 3;
      // 
      // labelRepetitionNumber
      // 
      this.labelRepetitionNumber.AutoSize = true;
      this.labelRepetitionNumber.Location = new System.Drawing.Point(54, 143);
      this.labelRepetitionNumber.Name = "labelRepetitionNumber";
      this.labelRepetitionNumber.Size = new System.Drawing.Size(127, 13);
      this.labelRepetitionNumber.TabIndex = 4;
      this.labelRepetitionNumber.Text = "Liczba powtórzeń pytania";
      // 
      // buttonStart
      // 
      this.buttonStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.buttonStart.Location = new System.Drawing.Point(57, 195);
      this.buttonStart.Name = "buttonStart";
      this.buttonStart.Size = new System.Drawing.Size(165, 48);
      this.buttonStart.TabIndex = 8;
      this.buttonStart.Text = "Start";
      this.buttonStart.UseVisualStyleBackColor = false;
      this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
      // 
      // _comboBoxQuiz
      // 
      this._comboBoxQuiz.FormattingEnabled = true;
      this._comboBoxQuiz.Location = new System.Drawing.Point(57, 49);
      this._comboBoxQuiz.Name = "_comboBoxQuiz";
      this._comboBoxQuiz.Size = new System.Drawing.Size(165, 21);
      this._comboBoxQuiz.TabIndex = 9;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(54, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(69, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Wybierz Quiz";
      // 
      // MenuView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(287, 284);
      this.Controls.Add(this.label1);
      this.Controls.Add(this._comboBoxQuiz);
      this.Controls.Add(this.buttonStart);
      this.Controls.Add(this.labelRepetitionNumber);
      this.Controls.Add(this.textBoxRepetitionNumber);
      this.Controls.Add(this.checkBoxHideAnswerNumber);
      this.Controls.Add(this.checkBoxShuffleAnswers);
      this.Name = "MenuView";
      this.Text = "Menu";
      this.Load += new System.EventHandler(this.MenuView_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.CheckBox checkBoxShuffleAnswers;
    private System.Windows.Forms.CheckBox checkBoxHideAnswerNumber;
    private System.Windows.Forms.TextBox textBoxRepetitionNumber;
    private System.Windows.Forms.Label labelRepetitionNumber;
    private System.Windows.Forms.Button buttonStart;
    private System.Windows.Forms.ComboBox _comboBoxQuiz;
    private System.Windows.Forms.Label label1;
  }
}

