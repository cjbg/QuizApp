using System.Collections.Generic;
using QuizManager.Model;

namespace QuizManager.Service.Interface
{
  public interface IQuizReader
  {
    List<Question> ReadQuestionsFromResources(int repetitionNumber, string textFromResource);
  }
}