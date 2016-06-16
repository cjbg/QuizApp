using System;
using System.Collections.Generic;
using System.Linq;
using QuizApp.Model;
using QuizApp.Properties;
using QuizApp.Service.Interface;

namespace QuizApp.Service
{
  public class QuizReader : IQuizReader
  {
    private readonly IQuizParser _parser;

    public QuizReader()
      : this(new QuizParser())
    {      
    }

    public QuizReader(IQuizParser parser)
    {
      _parser = parser;
    }

    public List<Question> ReadQuestionsFromResources()
    {
      string resourceData = Resources.Fizjologia_Pytania_1_114;

      List<string> lines = resourceData.Split(
          new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
        .ToList();

      return _parser.ParseQuestions(lines);
    }
  }
}
