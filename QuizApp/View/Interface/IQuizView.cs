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
  }
}