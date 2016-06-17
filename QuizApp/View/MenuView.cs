using System.Windows.Forms;
using QuizApp.Model;
using QuizApp.Presenter;
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
      _presenter.StartQuiz();
    }

    public bool ShuffleAnswers
    {
      get { return checkBoxShuffleAnswers.Checked; }      
    }
  }
}
