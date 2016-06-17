using System;
using System.Collections.Generic;
using System.Linq;
using QuizApp.Model;
using static System.Char;

namespace QuizApp.Service
{
  public class QuizParser : IQuizParser
  {
    public List<Question> ParseQuestions(List<string> lines)
    {
      var questions = new List<Question>();
      Question question = new Question();
      string[] validAnswers = { string.Empty };

      foreach (var line in lines)
      {
        if (string.IsNullOrWhiteSpace(line))
        {
          continue;
        }
        if (IsQuestionLine(line))
        {
          question = SetQuestion(line);
        }
        else if (IsAnswerMark(line))
        {
          validAnswers = line.Split(':')[1]
            .Split(',');
        }
        else if (IsLastAnswerLine(line))
        {
          AddAnswer(question, line);
          SetValidAnswers(question, validAnswers);

          questions.Add(question);
        }
        else if (IsAnswerLine(line))
        {
          AddAnswer(question, line);
        }
      }

      return questions;
    }

    private void SetValidAnswers(Question question, string[] validAnswers)
    {
      question.Answers.ForEach(
        x => x.IsCorrect = validAnswers.Any(
          y => y == GetFirstLetter(x.Name).ToString()));
    }

    private bool IsLastAnswerLine(string line)
    {
      return IsAnswerLine(line)
             && GetFirstLetter(line) == 'E';
    }

    private bool IsAnswerMark(string line)
    {
      return line.Contains("ODP:");
    }

    private bool IsAnswerLine(string line)
    {
      char firstLetter = GetFirstLetter(line);
      char seccondLetter = Convert.ToChar(line.Trim()[1]);

      return IsLetter(firstLetter)
        && IsPunctuation(seccondLetter);
    }

    private static bool IsQuestionLine(string line)
    {
      char firstLetter = GetFirstLetter(line);
      return IsDigit(firstLetter);
    }

    private static char GetFirstLetter(string line)
    {
      return Convert.ToChar(line.Trim()[0]);
    }

    private Question SetQuestion(string line)
    {
      Question question = new Question();
      question.Number = Convert.ToInt32(
        line.Split(' ')[0]
        .Split('.')[0]);

      question.Name = line;
      question.RepetitionNumber = 1;
      question.Answers = new List<Answer>();

      return question;
    }

    private void AddAnswer(Question question, string line)
    {
      Answer answer = new Answer();
      answer.Name = line;

      question.Answers.Add(answer);
    }    
  }
}
