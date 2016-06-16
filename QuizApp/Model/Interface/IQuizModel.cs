using System.Collections.Generic;

namespace QuizApp.Model.Interface
{
  public interface IQuizModel
  {
    List<Question> Questions { get; set; }
  }
}
