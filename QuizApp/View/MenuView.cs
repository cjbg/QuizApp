using System.Windows.Forms;
using QuizApp.Interfaces;
using QuizApp.Presenter;

namespace QuizApp.View
{
  public partial class MenuView : Form, IMenuView
  {
    private readonly MenuPresenter _presenter;
    public MenuView()
    {
      _presenter = new MenuPresenter();
      InitializeComponent();
    }
  }
}
