using System;
using System.Collections.Generic;
using System.Linq;
using QuizManager.Model;
using QuizManager.Properties;
using QuizManager.Service.Interface;

namespace QuizManager.Service
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

    public List<Question> ReadQuestionsFromResources(int repetitionNumber, string textFromResource)
    {
      string resourceData = textFromResource;

      List<string> lines = resourceData.Split(
          new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
        .ToList();

      return _parser.ParseQuestions(lines, repetitionNumber);
    }

    public string GetTextFromQuizSet(QuizSet quizSet)
    {
      switch (quizSet)
      {
        case QuizSet.Questions_1_114:
          return Resources.Fizjologia_Pytania_1_114;
        case QuizSet.Questions_115_294:
          return Resources.Fizjologia_Pytania_115_294;
        default:
          return string.Empty;
      }
    }
  }
}
