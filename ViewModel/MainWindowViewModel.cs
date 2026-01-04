

using System.Windows.Input;
using Avalonia.Media;

namespace Calculate_IMT.ViewModel;

public class MainWindowViewModel:BaseVM
{
    public ICommand CalculateCommand { get; set; }
    public MainWindowViewModel()
    {
        CalculateCommand = new RelayCommand(Calculat);
    }
     
    string _color = "Black";

    public string Color
    {
        get => _color;
        set
        {
            if (_color != value)
            {
                _color = value;
                OnPropertyChanged();
            }
        }
    }

   
        private double _height = 0;
        public double Height
        {
            get => _height;
            set
            {
                if  (_height != value)
                {
                    _height = value;
                    OnPropertyChanged();
                   
                   
                    
                }
            }
        }

    

    private double _width = 0;
    public double Width
    {
        get => _width;
        set
        {
            if (_width != value)
            {
                _width = value;
                OnPropertyChanged();
                
            }
        }
    }
    
    private string _result = " ";
    public string Result
    {
        get => _result;
        set
        {
            if (_result != value)
            {
                _result = value;
                OnPropertyChanged();
            }
        }
    }


  
    void Calculat()
    {
        if (Height == 0 || Width == 0)
        {
            Result = "Введите числа";
        }
        else
        {
            double heigtMetr = Height / 100;
            double formulaIMT = Width / (heigtMetr * heigtMetr);
            if (formulaIMT <= 18.5)
                Result= $"ИМТ:{Color = "Blue"} {formulaIMT:F1} - Недостаточный вес";
            else if (formulaIMT <= 24.9)
                Result = $"ИМТ: {Color = "Green"} {formulaIMT:F1} - Норма";
            else if (formulaIMT <= 29.9)
                Result= $"ИМТ:  {Color = "Orange"} {formulaIMT:F1} - Избыточный вес";
            else
                Result= $"ИМТ: {Color = "Red"} {formulaIMT:F1} - Ожирение"; 
            
        }
       

    }
   
   
   
}