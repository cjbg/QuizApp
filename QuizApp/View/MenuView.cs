using System.IO;
using System.Windows.Forms;
using QuizApp.Properties;
using QuizManager.Model;
using QuizManager.Model.ExtensionMethods;
using QuizManager.Presenter;
using QuizManager.View.Interface;

namespace QuizApp.View
{
  public partial class MenuView : Form, IMenuView
  {
    private MenuPresenter _presenter;

    public bool ShuffleAnswers => checkBoxShuffleAnswers.Checked;

    public bool HideAnswerLetter => checkBoxHideAnswerNumber.Checked;

    public string RepetitionNumberText => textBoxRepetitionNumber.Text;

    public ComboBox QuizComboBox
    {
      get { return _comboBoxQuiz; }
      set { _comboBoxQuiz = value; }
    }


    public MenuView()
    {
      InitializeComponent();
    }

    private void MenuView_Load(object sender, System.EventArgs e)
    {
      _presenter = new MenuPresenter(this);

    }

    private void buttonStart_Click(object sender, System.EventArgs e)
    {
      string filePath = string.Empty;
      var selectedQuizSet = QuizComboBox.SelectedItem as QuizSet;      
      if (selectedQuizSet.Value == QuizSets.FromFile)
      {
        StartQuizFromFile();
      }
      else
      {
        StartQuiz(filePath);
      }      
    }

    private void StartQuizFromFile()
    {
      string filePath;
      filePath = GetFilePathFromUser();
      if (string.IsNullOrEmpty(filePath))
      {
        MessageBox.Show(Resources.CannotReadFile);
      }
      else
      {
        StartQuiz(filePath);
      }
    }

    private void StartQuiz(string filePath)
    {
      QuizView quizView = new QuizView(
        ShuffleAnswers,
        HideAnswerLetter,
        RepetitionNumberText,
        QuizComboBox.SelectedItem as QuizSet,
        filePath);

      quizView.ShowDialog();
    }

    private string GetFilePathFromUser()
    {
      using (OpenFileDialog fileDialog = new OpenFileDialog())
      {
        fileDialog.Filter = "Pliki tekstowe (.txt)|*.txt";
        DialogResult result = fileDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
          return fileDialog.FileName;
        }

        return null;
      }
    }
  }
}
