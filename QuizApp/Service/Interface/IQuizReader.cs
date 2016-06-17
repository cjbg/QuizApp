using System.Collections.Generic;
using QuizApp.Model;

namespace QuizApp.Service.Interface
{
  public interface IQuizReader
  {
    List<Question> ReadQuestionsFromResources(int repetitionNumber);
  }
}