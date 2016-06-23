using System;
using System.Windows.Forms;
using QuizApp.Model;
using QuizApp.Model.Interface;
using QuizApp.View;
using QuizApp.View.Interface;

namespace QuizApp.Presenter
{
  public class MenuPresenter
  {
    private const int DefaultRepetitionNumber = 1;
    private readonly IMenuModel _model;
    private readonly IMenuView _view;

    // TODO: Impl DI    

    public MenuPresenter(IMenuModel model, IMenuView view)
    {
      _model = model;
      _view = view;
    }

    public void StartQuiz(string textFromResource)
    {
      QuizView view = new QuizView(
        _view.ShuffleAnswers,
        _view.HideAnswerLetter,
        ConvertRepetitionNumber(),
        textFromResource);

      view.ShowDialog();
    }

    private int ConvertRepetitionNumber()
    {
      int repetitionNumber = DefaultRepetitionNumber;
      if (!string.IsNullOrWhiteSpace(_view.RepetitionNumberText))
      {
        repetitionNumber = Convert.ToInt32(_view.RepetitionNumberText); 
      }

      return repetitionNumber;
    }
  }
}
