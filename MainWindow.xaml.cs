using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW_Upper_Lower;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnConvertBtnClick(object sender, RoutedEventArgs routedEventArgs)
    {
        if (String.IsNullOrEmpty(InputTxtBox.Text))
        {
            MessageBox.Show("Type the text first!");
            
            return;
        }
        
        string text = ((UpperRadioBtn is not null && LowerRadioBtn is not null) && UpperRadioBtn.IsChecked.HasValue
            && UpperRadioBtn.IsChecked.Value)
            ? InputTxtBox.Text.ToUpper()
            : InputTxtBox.Text.ToLower();
        
        Clipboard.SetText(text);

        MessageBox.Show("Copied to clipboard!");
    }
}