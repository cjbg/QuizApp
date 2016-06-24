using System.Collections.Generic;

namespace QuizManager.Model.Interface
{
  public interface IQuizModel
  {
    bool ShuffleAnswers { get; set; }

    bool HideAnswerLetter { get; set; }

    int RepetitionNumber { get; set; }

    string TextFromResource { get; set; }

    List<Question> Questions { get; set; }

    bool IsAllAnswered();
  }
}
