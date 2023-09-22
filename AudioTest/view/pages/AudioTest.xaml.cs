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

namespace AudioTest.view.pages
{
    public partial class AudioTest : Page
    {
        Dictionary<string, string> question = new Dictionary<string, string>()
        {
            {"text", "" },
            {"answer1", ""},
            {"answer2", "" },
            {"answer3", "" },
            {"answer4", "" },
            {"answer5", "" },
            {"answer6", "" },
            {"answer7", "" },
            {"ProfessionAnswer1", "" },
        };

        Dictionary<string, string> question1 = new Dictionary<string, string>()
        {
            {"text", "Тип аудиосистемы?" },
            {"answer1", "Автомобильные динамики"},
            {"answer2", "Автомагнитола" },
        };

        public AudioTest()
        {
            InitializeComponent();
            TB_Question.Text = question1["text"];
            RB1_Text.Text = question1["answer1"];
            RB2_Text.Text = question1["answer2"];
            RB3.Visibility = Visibility.Collapsed;
            RB4.Visibility = Visibility.Collapsed;
        }

        private void Btn_next_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
