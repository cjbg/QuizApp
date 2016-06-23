namespace QuizApp.View
{
  partial class QuizView
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
      this.checkBoxAnswer1 = new System.Windows.Forms.CheckBox();
      this.checkBoxAnswer2 = new System.Windows.Forms.CheckBox();
      this.checkBoxAnswer3 = new System.Windows.Forms.CheckBox();
      this.checkBoxAnswer4 = new System.Windows.Forms.CheckBox();
      this.checkBoxAnswer5 = new System.Windows.Forms.CheckBox();
      this.buttonCheck = new System.Windows.Forms.Button();
      this.buttonNextQuestion = new System.Windows.Forms.Button();
      this.buttonQuestionLearned = new System.Windows.Forms.Button();
      this.textBoxQuestion = new System.Windows.Forms.TextBox();
      this.textBoxAnswer1 = new System.Windows.Forms.TextBox();
      this.textBoxAnswer2 = new System.Windows.Forms.TextBox();
      this.textBoxAnswer3 = new System.Windows.Forms.TextBox();
      this.textBoxAnswer4 = new System.Windows.Forms.TextBox();
      this.textBoxAnswer5 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // checkBoxAnswer1
      // 
      this.checkBoxAnswer1.AutoSize = true;
      this.checkBoxAnswer1.Location = new System.Drawing.Point(26, 70);
      this.checkBoxAnswer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.checkBoxAnswer1.Name = "checkBoxAnswer1";
      this.checkBoxAnswer1.Size = new System.Drawing.Size(15, 14);
      this.checkBoxAnswer1.TabIndex = 2;
      this.checkBoxAnswer1.UseVisualStyleBackColor = true;
      // 
      // checkBoxAnswer2
      // 
      this.checkBoxAnswer2.AutoSize = true;
      this.checkBoxAnswer2.Location = new System.Drawing.Point(26, 160);
      this.checkBoxAnswer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.checkBoxAnswer2.Name = "checkBoxAnswer2";
      this.checkBoxAnswer2.Size = new System.Drawing.Size(15, 14);
      this.checkBoxAnswer2.TabIndex = 3;
      this.checkBoxAnswer2.UseVisualStyleBackColor = true;
      // 
      // checkBoxAnswer3
      // 
      this.checkBoxAnswer3.AutoSize = true;
      this.checkBoxAnswer3.Location = new System.Drawing.Point(26, 250);
      this.checkBoxAnswer3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.checkBoxAnswer3.Name = "checkBoxAnswer3";
      this.checkBoxAnswer3.Size = new System.Drawing.Size(15, 14);
      this.checkBoxAnswer3.TabIndex = 4;
      this.checkBoxAnswer3.UseVisualStyleBackColor = true;
      // 
      // checkBoxAnswer4
      // 
      this.checkBoxAnswer4.AutoSize = true;
      this.checkBoxAnswer4.Location = new System.Drawing.Point(26, 340);
      this.checkBoxAnswer4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.checkBoxAnswer4.Name = "checkBoxAnswer4";
      this.checkBoxAnswer4.Size = new System.Drawing.Size(15, 14);
      this.checkBoxAnswer4.TabIndex = 5;
      this.checkBoxAnswer4.UseVisualStyleBackColor = true;
      // 
      // checkBoxAnswer5
      // 
      this.checkBoxAnswer5.AutoSize = true;
      this.checkBoxAnswer5.Location = new System.Drawing.Point(26, 430);
      this.checkBoxAnswer5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.checkBoxAnswer5.Name = "checkBoxAnswer5";
      this.checkBoxAnswer5.Size = new System.Drawing.Size(15, 14);
      this.checkBoxAnswer5.TabIndex = 6;
      this.checkBoxAnswer5.UseVisualStyleBackColor = true;
      // 
      // buttonCheck
      // 
      this.buttonCheck.Location = new System.Drawing.Point(220, 530);
      this.buttonCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonCheck.Name = "buttonCheck";
      this.buttonCheck.Size = new System.Drawing.Size(109, 30);
      this.buttonCheck.TabIndex = 7;
      this.buttonCheck.Text = "Sprawdź";
      this.buttonCheck.UseVisualStyleBackColor = true;
      this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
      // 
      // buttonNextQuestion
      // 
      this.buttonNextQuestion.Location = new System.Drawing.Point(445, 530);
      this.buttonNextQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonNextQuestion.Name = "buttonNextQuestion";
      this.buttonNextQuestion.Size = new System.Drawing.Size(109, 30);
      this.buttonNextQuestion.TabIndex = 8;
      this.buttonNextQuestion.Text = "Następne";
      this.buttonNextQuestion.UseVisualStyleBackColor = true;
      this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
      // 
      // buttonQuestionLearned
      // 
      this.buttonQuestionLearned.Location = new System.Drawing.Point(333, 530);
      this.buttonQuestionLearned.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.buttonQuestionLearned.Name = "buttonQuestionLearned";
      this.buttonQuestionLearned.Size = new System.Drawing.Size(109, 30);
      this.buttonQuestionLearned.TabIndex = 9;
      this.buttonQuestionLearned.Text = "Umiem";
      this.buttonQuestionLearned.UseVisualStyleBackColor = true;
      this.buttonQuestionLearned.Click += new System.EventHandler(this.buttonQuestionLearned_Click);
      // 
      // textBoxQuestion
      // 
      this.textBoxQuestion.Location = new System.Drawing.Point(8, 8);
      this.textBoxQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.textBoxQuestion.Multiline = true;
      this.textBoxQuestion.Name = "textBoxQuestion";
      this.textBoxQuestion.Size = new System.Drawing.Size(793, 43);
      this.textBoxQuestion.TabIndex = 10;
      // 
      // textBoxAnswer1
      // 
      this.textBoxAnswer1.Location = new System.Drawing.Point(46, 67);
      this.textBoxAnswer1.Multiline = true;
      this.textBoxAnswer1.Name = "textBoxAnswer1";
      this.textBoxAnswer1.Size = new System.Drawing.Size(698, 65);
      this.textBoxAnswer1.TabIndex = 11;
      // 
      // textBoxAnswer2
      // 
      this.textBoxAnswer2.Location = new System.Drawing.Point(46, 157);
      this.textBoxAnswer2.Multiline = true;
      this.textBoxAnswer2.Name = "textBoxAnswer2";
      this.textBoxAnswer2.Size = new System.Drawing.Size(698, 65);
      this.textBoxAnswer2.TabIndex = 12;
      // 
      // textBoxAnswer3
      // 
      this.textBoxAnswer3.Location = new System.Drawing.Point(46, 247);
      this.textBoxAnswer3.Multiline = true;
      this.textBoxAnswer3.Name = "textBoxAnswer3";
      this.textBoxAnswer3.Size = new System.Drawing.Size(698, 65);
      this.textBoxAnswer3.TabIndex = 13;
      // 
      // textBoxAnswer4
      // 
      this.textBoxAnswer4.Location = new System.Drawing.Point(46, 337);
      this.textBoxAnswer4.Multiline = true;
      this.textBoxAnswer4.Name = "textBoxAnswer4";
      this.textBoxAnswer4.Size = new System.Drawing.Size(698, 65);
      this.textBoxAnswer4.TabIndex = 14;
      // 
      // textBoxAnswer5
      // 
      this.textBoxAnswer5.Location = new System.Drawing.Point(46, 427);
      this.textBoxAnswer5.Multiline = true;
      this.textBoxAnswer5.Name = "textBoxAnswer5";
      this.textBoxAnswer5.Size = new System.Drawing.Size(698, 65);
      this.textBoxAnswer5.TabIndex = 15;
      // 
      // QuizView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(801, 601);
      this.Controls.Add(this.textBoxAnswer5);
      this.Controls.Add(this.textBoxAnswer4);
      this.Controls.Add(this.textBoxAnswer3);
      this.Controls.Add(this.textBoxAnswer2);
      this.Controls.Add(this.textBoxAnswer1);
      this.Controls.Add(this.textBoxQuestion);
      this.Controls.Add(this.buttonQuestionLearned);
      this.Controls.Add(this.buttonNextQuestion);
      this.Controls.Add(this.buttonCheck);
      this.Controls.Add(this.checkBoxAnswer5);
      this.Controls.Add(this.checkBoxAnswer4);
      this.Controls.Add(this.checkBoxAnswer3);
      this.Controls.Add(this.checkBoxAnswer2);
      this.Controls.Add(this.checkBoxAnswer1);
      this.Name = "QuizView";
      this.Text = "Quiz";
      this.Load += new System.EventHandler(this.QuizView_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxAnswer1;
        private System.Windows.Forms.CheckBox checkBoxAnswer2;
        private System.Windows.Forms.CheckBox checkBoxAnswer3;
        private System.Windows.Forms.CheckBox checkBoxAnswer4;
        private System.Windows.Forms.CheckBox checkBoxAnswer5;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonNextQuestion;
    private System.Windows.Forms.Button buttonQuestionLearned;
    private System.Windows.Forms.TextBox textBoxQuestion;
    private System.Windows.Forms.TextBox textBoxAnswer1;
    private System.Windows.Forms.TextBox textBoxAnswer2;
    private System.Windows.Forms.TextBox textBoxAnswer3;
    private System.Windows.Forms.TextBox textBoxAnswer4;
    private System.Windows.Forms.TextBox textBoxAnswer5;
  }
}