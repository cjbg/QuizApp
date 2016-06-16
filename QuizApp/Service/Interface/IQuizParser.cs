using System.Collections.Generic;
using QuizApp.Model;

namespace QuizApp.Service
{
  public interface IQuizParser
  {
    List<Question> ParseQuestions(List<string> lines);
  }
}