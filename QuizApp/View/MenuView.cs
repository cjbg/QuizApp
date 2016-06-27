using System.Windows.Forms;
using QuizManager.Model;
using QuizManager.View.Interface;

namespace QuizApp.View
{
  public partial class MenuView : Form, IMenuView
  {
    public bool ShuffleAnswers => checkBoxShuffleAnswers.Checked;

    public bool HideAnswerLetter => checkBoxHideAnswerNumber.Checked;

    public string RepetitionNumberText => textBoxRepetitionNumber.Text;

    public MenuView()
    {
      InitializeComponent();
    }

    private QuizView CreateQuizView(QuizSet quizSet)
    {
      return new QuizView(
        ShuffleAnswers,
        HideAnswerLetter,
        RepetitionNumberText,
        quizSet);
    }

    private void buttonStart_Click(object sender, System.EventArgs e)
    {      
      QuizView view = CreateQuizView(QuizSet.Questions_1_114);
      view.ShowDialog();
    }

    private void buttonStart_Questions_115_294_Click(object sender, System.EventArgs e)
    {
      QuizView view = CreateQuizView(QuizSet.Questions_115_294);
      view.ShowDialog();
    }

    private void buttonStartW1_Click(object sender, System.EventArgs e)
    {
      QuizView view = CreateQuizView(QuizSet.Questions_W1W2W3W4);
      view.ShowDialog();
    }

    private void buttonStartQuestionsFromPictures_Click(object sender, System.EventArgs e)
    {
      QuizView view = CreateQuizView(QuizSet.QuestionsFromPictures);
      view.ShowDialog();
    }

    private void buttonStartFromTxt_Click(object sender, System.EventArgs e)
    {

    }
  }
}
