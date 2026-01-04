using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Calculate_IMT;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
    }
 /*
    private void CalculateButton_OnClick(object? sender, RoutedEventArgs e)
    {
        string heightTex = HeightTextBox.Text;
        string widthText = WeightTextBox.Text;
        double.TryParse(heightTex, out double height);
        double.TryParse(widthText, out double width);

        if (height <= 0 || width <= 0)
        {
            ResultTextBlock.Text = "Error";
            return;
        }

        double heightMetr = height / 100;
        double formulaIMT = width / ( Math.Pow(heightMetr,2));
        if (formulaIMT <= 18.5)
            ResultTextBlock.Text = $"ИМТ: {formulaIMT:F1} - Недостаточный вес";
        else if (formulaIMT <= 24.9)
            ResultTextBlock.Text = $"ИМТ: {formulaIMT:F1} - Норма";
        else if (formulaIMT <= 29.9)
            ResultTextBlock.Text = $"ИМТ: {formulaIMT:F1} - Избыточный вес";
        else
            ResultTextBlock.Text = $"ИМТ: {formulaIMT:F1} - Ожирение"; >>
    }*/
}