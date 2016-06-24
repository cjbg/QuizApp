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

    private void buttonStart_Click(object sender, System.EventArgs e)
    {      
      QuizView view = new QuizView(
        ShuffleAnswers,
        HideAnswerLetter,
        RepetitionNumberText,
        QuizSet.Questions_1_114);

      view.ShowDialog();
    }

    private void buttonStart_Questions_115_294_Click(object sender, System.EventArgs e)
    {
      QuizView view = new QuizView(
        ShuffleAnswers,
        HideAnswerLetter,
        RepetitionNumberText,
        QuizSet.Questions_115_294);

      view.ShowDialog();
    }
  }
}
