using System.Collections.Generic;

namespace QuizApp.Model.Interface
{
  public interface IQuizModel
  {
    bool ShuffleAnswers { get; set; }

    bool HideAnswerLetter { get; set; }

    int RepetitionNumber { get; set; }

    List<Question> Questions { get; set; }
  }
}
