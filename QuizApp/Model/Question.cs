using System.Collections.Generic;

namespace QuizApp.Model
{
  public class Question
  {
    public int Number { get; set; }

    public string Name { get; set; }

    public List<Answer> Answers { get; set; }    
  }
}
