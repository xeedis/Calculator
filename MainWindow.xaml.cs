using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ResultText.Text = string.Empty;
    }

    private bool isNegative = false;

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        var button = sender as Button;

        var currentNumber = button?.Name[button.Name.Length - 1];
        CurrentOperationText.Text += currentNumber;
    }

    private void ClearButton_Click(object sender, RoutedEventArgs e)
    {
        ResultText.Text = string.Empty;
        CurrentOperationText.Text = string.Empty;
    }

    private void ChangeValueButton_Click(object sender, RoutedEventArgs e)
    {
        /*isNegative = !isNegative;
        if (isNegative)
        {
            CurrentOperationText.Text = "-" + CurrentOperationText.Text;
        }
        else
        {
            if (CurrentOperationText.Text.Length > 0 && CurrentOperationText.Text[0] == '-')
            {
                CurrentOperationText.Text = CurrentOperationText.Text.Substring(1);
            }
        }*/
    }

    private void OperatorButton_Click(object sender, RoutedEventArgs e)
    {
        var button = sender as Button;

        var currentOperation = button?.Content.ToString();

        CurrentOperationText.Text += currentOperation;
        isNegative = false; 
    }

    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        var operation = CurrentOperationText.Text;
        if(CalculatorOperations.ConatinsOperation(operation))
        {
            CurrentOperationText.Text = CalculatorOperations.CalculateResult(operation).ToString();
        }

        CurrentOperationText.Text += "+";
    }

    private void MinusButton_Click(object sender, RoutedEventArgs e)
    {
        var operation = CurrentOperationText.Text;
        if (CalculatorOperations.ConatinsOperation(operation))
        {
            CurrentOperationText.Text = CalculatorOperations.CalculateResult(operation).ToString();
        }

        CurrentOperationText.Text += "-";
    }

    private void MultiplyButton_Click(object sender, RoutedEventArgs e)
    {
        var operation = CurrentOperationText.Text;
        if (CalculatorOperations.ConatinsOperation(operation))
        {
            CurrentOperationText.Text = CalculatorOperations.CalculateResult(operation).ToString();
        }

        CurrentOperationText.Text += "*";
    }

    private void DivideButton_Click(object sender, RoutedEventArgs e)
    {
        var operation = CurrentOperationText.Text;
        if (CalculatorOperations.ConatinsOperation(operation))
        {
            CurrentOperationText.Text = CalculatorOperations.CalculateResult(operation).ToString();
        }

        CurrentOperationText.Text += "/";
    }

    private void ResultButton_Click(object sender, RoutedEventArgs e)
    {
        var operation = CurrentOperationText.Text;

        var result = CalculatorOperations.CalculateResult(operation);

        ResultText.Text = result.ToString();

        CurrentOperationText.Text = string.Empty;
    }
}
