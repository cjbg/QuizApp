using System;
using QuizApp.Model;
using QuizApp.Model.Interface;
using QuizApp.Service.Interface;
using QuizApp.View.Interface;

namespace QuizApp.Presenter
{
  public class QuizPresenter
  {
    private readonly IQuizModel _model;
    private readonly IQuizView _view;
    private readonly IQuizReader _reader;
    private Question _currentQuestion;

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
      _currentQuestion = GetRandomQuestion();
      SetViewData();
    }

    private void SetViewData()
    {
      _view.Question = _currentQuestion.Name;
      _view.Answer1 = _currentQuestion.Answers[0].Name;
      _view.Answer2 = _currentQuestion.Answers[1].Name;
      _view.Answer3 = _currentQuestion.Answers[2].Name;
      _view.Answer4 = _currentQuestion.Answers[3].Name;
      _view.Answer5 = _currentQuestion.Answers[4].Name;
    }

    private Question GetRandomQuestion()
    {
      var random = new Random();
      var index = random.Next(_model.Questions.Count - 1);
      Question question;

      do
      {
        question = _model.Questions[index];

      } while (question.RepetitionNumber == 0);

      return question;
    }
  }
}
