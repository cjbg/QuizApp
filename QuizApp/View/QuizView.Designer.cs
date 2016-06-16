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
      this.SuspendLayout();
      // 
      // checkBoxAnswer1
      // 
      this.checkBoxAnswer1.AutoSize = true;
      this.checkBoxAnswer1.Location = new System.Drawing.Point(39, 103);
      this.checkBoxAnswer1.Name = "checkBoxAnswer1";
      this.checkBoxAnswer1.Size = new System.Drawing.Size(90, 24);
      this.checkBoxAnswer1.TabIndex = 2;
      this.checkBoxAnswer1.Text = "Answer1";
      this.checkBoxAnswer1.UseVisualStyleBackColor = true;
      // 
      // checkBoxAnswer2
      // 
      this.checkBoxAnswer2.AutoSize = true;
      this.checkBoxAnswer2.Location = new System.Drawing.Point(39, 141);
      this.checkBoxAnswer2.Name = "checkBoxAnswer2";
      this.checkBoxAnswer2.Size = new System.Drawing.Size(90, 24);
      this.checkBoxAnswer2.TabIndex = 3;
      this.checkBoxAnswer2.Text = "Answer2";
      this.checkBoxAnswer2.UseVisualStyleBackColor = true;
      // 
      // checkBoxAnswer3
      // 
      this.checkBoxAnswer3.AutoSize = true;
      this.checkBoxAnswer3.Location = new System.Drawing.Point(39, 179);
      this.checkBoxAnswer3.Name = "checkBoxAnswer3";
      this.checkBoxAnswer3.Size = new System.Drawing.Size(90, 24);
      this.checkBoxAnswer3.TabIndex = 4;
      this.checkBoxAnswer3.Text = "Answer3";
      this.checkBoxAnswer3.UseVisualStyleBackColor = true;
      // 
      // checkBoxAnswer4
      // 
      this.checkBoxAnswer4.AutoSize = true;
      this.checkBoxAnswer4.Location = new System.Drawing.Point(39, 217);
      this.checkBoxAnswer4.Name = "checkBoxAnswer4";
      this.checkBoxAnswer4.Size = new System.Drawing.Size(90, 24);
      this.checkBoxAnswer4.TabIndex = 5;
      this.checkBoxAnswer4.Text = "Answer4";
      this.checkBoxAnswer4.UseVisualStyleBackColor = true;
      // 
      // checkBoxAnswer5
      // 
      this.checkBoxAnswer5.AutoSize = true;
      this.checkBoxAnswer5.Location = new System.Drawing.Point(39, 255);
      this.checkBoxAnswer5.Name = "checkBoxAnswer5";
      this.checkBoxAnswer5.Size = new System.Drawing.Size(90, 24);
      this.checkBoxAnswer5.TabIndex = 6;
      this.checkBoxAnswer5.Text = "Answer5";
      this.checkBoxAnswer5.UseVisualStyleBackColor = true;
      // 
      // buttonCheck
      // 
      this.buttonCheck.Location = new System.Drawing.Point(12, 326);
      this.buttonCheck.Name = "buttonCheck";
      this.buttonCheck.Size = new System.Drawing.Size(163, 46);
      this.buttonCheck.TabIndex = 7;
      this.buttonCheck.Text = "Sprawdź";
      this.buttonCheck.UseVisualStyleBackColor = true;
      this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
      // 
      // buttonNextQuestion
      // 
      this.buttonNextQuestion.Location = new System.Drawing.Point(350, 326);
      this.buttonNextQuestion.Name = "buttonNextQuestion";
      this.buttonNextQuestion.Size = new System.Drawing.Size(163, 46);
      this.buttonNextQuestion.TabIndex = 8;
      this.buttonNextQuestion.Text = "Następne";
      this.buttonNextQuestion.UseVisualStyleBackColor = true;
      this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
      // 
      // buttonQuestionLearned
      // 
      this.buttonQuestionLearned.Location = new System.Drawing.Point(181, 326);
      this.buttonQuestionLearned.Name = "buttonQuestionLearned";
      this.buttonQuestionLearned.Size = new System.Drawing.Size(163, 46);
      this.buttonQuestionLearned.TabIndex = 9;
      this.buttonQuestionLearned.Text = "Umiem";
      this.buttonQuestionLearned.UseVisualStyleBackColor = true;
      // 
      // textBoxQuestion
      // 
      this.textBoxQuestion.Location = new System.Drawing.Point(12, 12);
      this.textBoxQuestion.Multiline = true;
      this.textBoxQuestion.Name = "textBoxQuestion";
      this.textBoxQuestion.Size = new System.Drawing.Size(1188, 64);
      this.textBoxQuestion.TabIndex = 10;
      // 
      // QuizView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1212, 384);
      this.Controls.Add(this.textBoxQuestion);
      this.Controls.Add(this.buttonQuestionLearned);
      this.Controls.Add(this.buttonNextQuestion);
      this.Controls.Add(this.buttonCheck);
      this.Controls.Add(this.checkBoxAnswer5);
      this.Controls.Add(this.checkBoxAnswer4);
      this.Controls.Add(this.checkBoxAnswer3);
      this.Controls.Add(this.checkBoxAnswer2);
      this.Controls.Add(this.checkBoxAnswer1);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
  }
}