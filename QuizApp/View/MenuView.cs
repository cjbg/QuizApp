using System.Windows.Forms;
using QuizApp.Model;
using QuizApp.Presenter;
using QuizApp.Properties;
using QuizApp.View.Interface;

namespace QuizApp.View
{
  public partial class MenuView : Form, IMenuView
  {
    private readonly MenuPresenter _presenter;
    public MenuView()
    {
      _presenter = new MenuPresenter(
        new MenuModel(),
        this);

      InitializeComponent();
    }

    private void buttonStart_Click(object sender, System.EventArgs e)
    {
      _presenter.StartQuiz(Resources.Fizjologia_Pytania_1_114);
    }

    public bool ShuffleAnswers => checkBoxShuffleAnswers.Checked;

    public bool HideAnswerLetter => checkBoxHideAnswerNumber.Checked;

    public string RepetitionNumberText => textBoxRepetitionNumber.Text;

    private void buttonStart_Questions_115_294_Click(object sender, System.EventArgs e)
    {
      _presenter.StartQuiz(Resources.Fizjologia_Pytania_115_294);
    }
  }
}
