using System;
using System.Drawing;
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
      _view.CheckedAnswer1 = false;
      _view.CheckedAnswer2 = false;
      _view.CheckedAnswer3 = false;
      _view.CheckedAnswer4 = false;
      _view.CheckedAnswer5 = false;
      _view.ColorAnswer1 = Color.Black;
      _view.ColorAnswer2 = Color.Black;
      _view.ColorAnswer3 = Color.Black;
      _view.ColorAnswer4 = Color.Black;
      _view.ColorAnswer5 = Color.Black;
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

    public void CheckAnswers()
    {
      SetAnswersColor();
      if (IsAnsweredCorrectly())
      {
        _currentQuestion.RepetitionNumber--;
      }
    }

    private bool IsAnsweredCorrectly()
    {
      if (_view.CheckedAnswer1 != _currentQuestion.Answers[0].IsCorrect)
      {
        return false;
      }

      if (_view.CheckedAnswer2 != _currentQuestion.Answers[1].IsCorrect)
      {
        return false;
      }

      if (_view.CheckedAnswer3 != _currentQuestion.Answers[2].IsCorrect)
      {
        return false;
      }

      if (_view.CheckedAnswer4 != _currentQuestion.Answers[3].IsCorrect)
      {
        return false;
      }

      if (_view.CheckedAnswer5 != _currentQuestion.Answers[4].IsCorrect)
      {
        return false;
      }

      return true;
    }

    private void SetAnswersColor()
    {
      if (_currentQuestion.Answers[0].IsCorrect)
      {
        _view.ColorAnswer1 = Color.Green;
      }

      if (_currentQuestion.Answers[1].IsCorrect)
      {
        _view.ColorAnswer2 = Color.Green;
      }

      if (_currentQuestion.Answers[2].IsCorrect)
      {
        _view.ColorAnswer3 = Color.Green;
      }

      if (_currentQuestion.Answers[3].IsCorrect)
      {
        _view.ColorAnswer4 = Color.Green;
      }

      if (_currentQuestion.Answers[4].IsCorrect)
      {
        _view.ColorAnswer5 = Color.Green;
      }
    }

    public void QuestionLearned()
    {
      _currentQuestion.RepetitionNumber = 0;
    }

    public void SetNextQuestion()
    {
      if (IsAllAnswered())
      {
        SetViewAtQuizEnd();
        return;
      }

      _currentQuestion = GetRandomQuestion();
      SetViewData();
    }

    private bool IsAllAnswered()
    {
      foreach (var question in _model.Questions)
      {
        if (question.RepetitionNumber > 0)
        {
          return false;
        }
      }

      return true;
    }

    private void SetViewAtQuizEnd()
    {
      _view.Question = "Poprawnie odpowiedziano na wszystkie pytania";
      _view.Answer1 = String.Empty;
      _view.Answer2 = String.Empty;
      _view.Answer3 = String.Empty;
      _view.Answer4 = String.Empty;
      _view.Answer5 = String.Empty;
    }
  }
}
