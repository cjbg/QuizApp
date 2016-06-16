using System.Collections.Generic;
using QuizApp.Model;
using QuizApp.Model.Interface;
using QuizApp.Properties;
using QuizApp.Service;
using QuizApp.Service.Interface;
using QuizApp.View;
using QuizApp.View.Interface;

namespace QuizApp.Presenter
{
  public class QuizPresenter
  {
    private readonly IQuizModel _model;
    private readonly IQuizView _view;
    private readonly IQuizReader _reader;    

    public QuizPresenter(IQuizModel model, IQuizView view, IQuizReader reader)
    {
      _model = model;
      _view = view;
      _reader = reader;

      PrepareView();
    }

    private void PrepareView()
    {
      _model.Questions = _reader.ReadQuestionsFromResources();
    }
  }
}
