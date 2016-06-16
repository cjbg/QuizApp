using System.Collections.Generic;
using QuizApp.Model.Interface;

namespace QuizApp.Model
{
  public class QuizModel : IQuizModel
  {
    public List<Question> Questions { get; set; }
  }
}
