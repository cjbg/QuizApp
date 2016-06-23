﻿using System.Drawing;
using System.Windows.Forms;

namespace QuizApp.View.Interface
{
  public interface IQuizView
  {
    string Question { get; set; }

    string Answer1 { get; set; }

    string Answer2 { get; set; }

    string Answer3 { get; set; }

    string Answer4 { get; set; }

    string Answer5 { get; set; }

    Color ColorAnswer1 { set; }

    Color ColorAnswer2 { set; }

    Color ColorAnswer3 { set; }

    Color ColorAnswer4 { set; }

    Color ColorAnswer5 { set; }

    bool CheckedAnswer1 { get; set; }

    bool CheckedAnswer2 { get; set; }

    bool CheckedAnswer3 { get; set; }

    bool CheckedAnswer4 { get; set; }

    bool CheckedAnswer5 { get; set; }   

    bool CheckButtonEnabled { get; set; }

    bool LearnedButtonEnabled { get; set; }

    bool NextButtonEnabled { get; set; }

    void SetHeightAnswer1(int height);

    bool VisibleAnswer1 { set; }

    bool VisibleAnswer2 { set; }

    bool VisibleAnswer3 { set; }

    bool VisibleAnswer4 { set; }

    bool VisibleAnswer5 { set; }
  }
}