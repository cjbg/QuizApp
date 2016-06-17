using System.Drawing;

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
  }
}