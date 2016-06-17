using System.Collections.Generic;
using QuizApp.Model.Interface;

namespace QuizApp.Model
{
  public class QuizModel : IQuizModel
  {
    private bool _shuffleAnswers;
    private bool _hideAnswerLetter;
    private int _repetitionNumber;


    public QuizModel(bool shuffleAnswers, bool hideAnswerLetter, int repetitionNumber)
    {
      _shuffleAnswers = shuffleAnswers;
      _hideAnswerLetter = hideAnswerLetter;
      _repetitionNumber = repetitionNumber;
    }

    public bool ShuffleAnswers
    {
      get { return _shuffleAnswers; }
      set { _shuffleAnswers = value; }
    }

    public bool HideAnswerLetter
    {
      get { return _hideAnswerLetter; }
      set { _hideAnswerLetter = value; }
    }

    public int RepetitionNumber
    {
      get { return _repetitionNumber; }
      set { _repetitionNumber = value; }
    }

    public List<Question> Questions { get; set; }
  }
}
