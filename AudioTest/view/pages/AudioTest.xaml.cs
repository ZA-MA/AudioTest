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
            {"Result1", "" },
        };

        static Dictionary<string, string> question1 = new Dictionary<string, string>()
        {
            {"text", "Тип аудиосистемы?" },
            {"answer1", "Автомобильные динамики"},
            {"answer2", "Автомагнитола" },
        };
        static Dictionary<string, string> question2 = new Dictionary<string, string>()
        {
            {"text", "Форма динамики?" },
            {"answer1", "Круглые"},
            {"answer2", "Овальные" },
        };
        static Dictionary<string, string> question3 = new Dictionary<string, string>()
        {
            {"text", "Наличие сенсора?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
        };
        static Dictionary<string, string> question4 = new Dictionary<string, string>()
        {
            {"text", "Размер?" },
            {"answer1", "10 см"},
            {"answer2", "13 см" },
            {"answer3", "16.5" },
        };
        static Dictionary<string, string> question5 = new Dictionary<string, string>()
        {
            {"text", "Бюджет?" },
            {"answer1", "1501-2500 р"},
            {"answer2", "2501-4000 р" },
            {"answer3", "4001-6000 р" },
        };
        static Dictionary<string, string> question6 = new Dictionary<string, string>()
        {
            {"text", "Для чего?" },
            {"answer1", "Прослушивание музыки"},
            {"answer2", "Смотреть видео" },
        };
        static Dictionary<string, string> question7 = new Dictionary<string, string>()
        {
            {"text", "Какие разъемы?" },
            {"answer1", "Блютуз"},
            {"answer2", "USB" },
        };
        static Dictionary<string, string> question8 = new Dictionary<string, string>()
        {
            {"text", "Посадочная глубина?" },
            {"answer1", "Менее 50"},
            {"answer2", "50.1-100" },
            {"Result1", "AC SWAT SP-H4" },
            {"Result2", "Ural MOLOT AC-M100" },
        };
        static Dictionary<string, string> question9 = new Dictionary<string, string>()
        {
            {"text", "Номинальная мощность?" },
            {"answer1", "51-100 Вт"},
            {"answer2", "101-150 Вт" },
            {"Result1", "Ural Молния АС-МЛ130" },
            {"Result2", "EDGE EDSPR O5N-E0" },
        };
        static Dictionary<string, string> question10 = new Dictionary<string, string>()
        {
            {"text", "Максимальная мощность?" },
            {"answer1", "Менее 200 Вт"},
            {"answer2", "201-400 Вт" },
            {"Result1", "DEXP YW 6511" },
            {"Result2", "Ural PATRIOT BLACK EDITION" },
        };
        static Dictionary<string, string> question11 = new Dictionary<string, string>()
        {
            {"text", "Минимальная частота?" },
            {"answer1", "Менее 50"},
            {"answer2", "51-100" },
            {"answer3", "101-150" },
            {"Result1", "EDGE EDBPRO6-E9" },
            {"Result2", "Ural TT 130 ДРАЙВ" },
            {"Result3", "Ural TT 165" },
        };
        static Dictionary<string, string> question12 = new Dictionary<string, string>()
        {
            {"text", "Максимальная мощность?" },
            {"answer1", "Менее 200"},
            {"answer2", "201-400" },
            {"answer3", "401-600" },
            {"Result1", "Ural BULAVA AS-BV200" },
            {"Result2", "Kicx HeadShot F65" },
            {"Result3", "Pioneer TS-M 1610PRO" },
        };
        static Dictionary<string, string> question13 = new Dictionary<string, string>()
        {
            {"text", "Чувствительность?" },
            {"answer1", "Менее 90 дБ"},
            {"answer2", "90.1-100 дБ" },
            {"answer3", "100.01 и более" },
            {"Result1", "Ural AS-W50M" },
            {"Result2", "Pioneer TS-M 2010PRO" },
            {"Result3", "Hertz SV 250.1" },
        };
        static Dictionary<string, string> question14 = new Dictionary<string, string>()
        {
            {"text", "Объем памяти?" },
            {"answer1", "32 gb"},
            {"answer2", "64 gb" },
            {"answer3", "128 gb" },
            {"Result1", "Teyes X1" },
            {"Result2", "Teyes CC2" },
            {"Result3", "Teyes CC2 Plus" },
        };
        static Dictionary<string, string> question15 = new Dictionary<string, string>()
        {
            {"text", "Размер экрана?" },
            {"answer1", "9\""},
            {"answer2", "9.7\"" },
            {"answer3", "10\"" },
            {"Result1", "Teyes CC3" },
            {"Result2", "Teyes PRO2" },
            {"Result3", "Teyes SPRO Plus" },
        };
        static Dictionary<string, string> question16 = new Dictionary<string, string>()
        {
            {"text", "Наличие эквалайзера?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"Result1", "SWAT MEX-1046UBG" },
            {"Result2", "Soundmax SM-CCP 3190FB" },
        };
        static Dictionary<string, string> question17 = new Dictionary<string, string>()
        {
            {"text", "Работа с мобильными устройствами?" },
            {"answer1", "Android"},
            {"answer2", "IOS" },
            {"answer3", "Ipod" },
            {"answer4", "Нет" },
            {"Result1", "Digma DCR-350B" },
            {"Result2", "ACV AVS-918BW" },
            {"Result3", "JVC KD-X368BT" },
            {"Result4", "Digma DCR-360B" },
        };
        static Dictionary<string, string> question18 = new Dictionary<string, string>()
        {
            {"text", "Максимальная выходная мощность?" },
            {"answer1", "Менее 100 Вт"},
            {"answer2", "101-200 Вт" },
            {"answer3", "201-300 Вт" },
            {"Result1", "ACV AVS-1701R" },
            {"Result2", "SWAT MEX-1046UBG" },
            {"Result3", "PROLOGY GT-160" },
        };

        int countQuestion = 1;
        static Dictionary<string, string> questions = question1;

        public AudioTest()
        {
            InitializeComponent();
            TB_Question.Text = question1["text"];
            RB1_Text.Text = question1["answer1"];
            RB2_Text.Text = question1["answer2"];
            RB3.Visibility = Visibility.Collapsed;
            RB4.Visibility = Visibility.Collapsed;
            Btn_restart.Visibility = Visibility.Collapsed;
            IMG_NiceMen.Visibility = Visibility.Collapsed;
        }
        public void Check()
        {
            switch (countQuestion)
            {
                case 1:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question1["answer1"]);

                        countQuestion = 2;
                        questions = question2;

                        RB1.IsChecked = false;
                        TB_Question.Text = questions["text"];
                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question1["answer2"]);
                        countQuestion = 3;
                        questions = question3;
                        RB2.IsChecked = false;

                        TB_Question.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                    }
                    break;
                case 2:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question2["answer1"]);

                        countQuestion = 4;
                        questions = question4;

                        RB1.IsChecked = false;
                        TB_Question.Text = questions["text"];
                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                        RB3_Text.Text = questions["answer3"];

                        RB3.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question2["answer2"]);
                        countQuestion = 5;
                        questions = question5;
                        RB2.IsChecked = false;

                        TB_Question.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                        RB3_Text.Text = questions["answer3"];

                        RB3.Visibility = Visibility.Visible;
                    }
                    break;
                case 3:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question3["answer1"]);

                        countQuestion = 6;
                        questions = question6;

                        RB1.IsChecked = false;
                        TB_Question.Text = questions["text"];
                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question3["answer2"]);
                        countQuestion = 7;
                        questions = question7;
                        RB2.IsChecked = false;

                        TB_Question.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                    }
                    break;
                case 4:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question4["answer1"]);

                        countQuestion = 8;
                        questions = question8;

                        RB1.IsChecked = false;
                        TB_Question.Text = questions["text"];
                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];


                        RB3.Visibility = Visibility.Collapsed;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question4["answer2"]);
                        countQuestion = 9;
                        questions = question9;
                        RB2.IsChecked = false;

                        TB_Question.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];

                        RB3.Visibility = Visibility.Collapsed;
                    }
                    else if (RB3.IsChecked == true)
                    {
                        L_Answers.Items.Add(question4["answer3"]);
                        countQuestion = 10;
                        questions = question10;
                        RB3.IsChecked = false;

                        TB_Question.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];

                        RB3.Visibility = Visibility.Collapsed;
                    }
                    break;
                case 5:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question5["answer1"]);

                        countQuestion = 11;
                        questions = question11;

                        RB1.IsChecked = false;
                        TB_Question.Text = questions["text"];
                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                        RB3_Text.Text = questions["answer3"];
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question5["answer2"]);
                        countQuestion = 12;
                        questions = question12;
                        RB2.IsChecked = false;

                        TB_Question.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                        RB3_Text.Text = questions["answer3"];
                    }
                    else if (RB3.IsChecked == true)
                    {
                        L_Answers.Items.Add(question5["answer3"]);
                        countQuestion = 13;
                        questions = question13;
                        RB3.IsChecked = false;

                        TB_Question.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                        RB3_Text.Text = questions["answer3"];
                    }
                    break;
                case 6:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question6["answer1"]);

                        countQuestion = 14;
                        questions = question14;

                        RB1.IsChecked = false;
                        TB_Question.Text = questions["text"];
                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                        RB3_Text.Text = questions["answer3"];

                        RB3.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question6["answer2"]);
                        countQuestion = 15;
                        questions = question15;
                        RB2.IsChecked = false;

                        TB_Question.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                        RB3_Text.Text = questions["answer3"];

                        RB3.Visibility = Visibility.Visible;
                    }
                    break;
                case 7:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question7["answer1"]);

                        countQuestion = 16;
                        questions = question16;

                        RB1.IsChecked = false;
                        TB_Question.Text = questions["text"];
                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];


                        RB3.Visibility = Visibility.Collapsed;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question7["answer2"]);
                        countQuestion = 17;
                        questions = question17;
                        RB2.IsChecked = false;

                        TB_Question.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                        RB3_Text.Text = questions["answer3"];
                        RB4_Text.Text = questions["answer4"];

                        RB3.Visibility = Visibility.Visible;
                        RB4.Visibility = Visibility.Visible;
                    }
                    else if (RB3.IsChecked == true)
                    {
                        L_Answers.Items.Add(question7["answer3"]);
                        countQuestion = 18;
                        questions = question18;
                        RB3.IsChecked = false;

                        TB_Question.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                        RB3_Text.Text = questions["answer3"];
                    }
                    break;
                case 8:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question8["answer1"]);
                        TB_Question.Text = question8["Result1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question8["answer2"]);
                        TB_Question.Text = question8["Result2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    break;
                case 9:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question9["answer1"]);
                        TB_Question.Text = question9["Result1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question9["answer2"]);
                        TB_Question.Text = question9["Result2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    break;
                case 10:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question10["answer1"]);
                        TB_Question.Text = question10["Result1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question10["answer2"]);
                        TB_Question.Text = question10["Result2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    break;
                case 11:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question11["answer1"]);
                        TB_Question.Text = question11["Result1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question11["answer2"]);
                        TB_Question.Text = question11["Result2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB3.IsChecked == true)
                    {
                        L_Answers.Items.Add(question11["answer3"]);
                        TB_Question.Text = question11["Result3"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    break;
                case 12:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question12["answer1"]);
                        TB_Question.Text = question12["Result1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question12["answer2"]);
                        TB_Question.Text = question12["Result2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB3.IsChecked == true)
                    {
                        L_Answers.Items.Add(question12["answer3"]);
                        TB_Question.Text = question12["Result3"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    break;
                case 13:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question13["answer1"]);
                        TB_Question.Text = question13["Result1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question13["answer2"]);
                        TB_Question.Text = question13["Result2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB3.IsChecked == true)
                    {
                        L_Answers.Items.Add(question13["answer3"]);
                        TB_Question.Text = question13["Result3"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    break;
                case 14:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question14["answer1"]);
                        TB_Question.Text = question14["Result1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question14["answer2"]);
                        TB_Question.Text = question14["Result2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB3.IsChecked == true)
                    {
                        L_Answers.Items.Add(question14["answer3"]);
                        TB_Question.Text = question14["Result3"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    break;
                case 15:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question15["answer1"]);
                        TB_Question.Text = question15["Result1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question15["answer2"]);
                        TB_Question.Text = question15["Result2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB3.IsChecked == true)
                    {
                        L_Answers.Items.Add(question15["answer3"]);
                        TB_Question.Text = question15["Result3"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    break;
                case 16:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question16["answer1"]);
                        TB_Question.Text = question16["Result1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question16["answer2"]);
                        TB_Question.Text = question16["Result2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    break;
                case 17:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question17["answer1"]);
                        TB_Question.Text = question17["Result1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question17["answer2"]);
                        TB_Question.Text = question17["Result2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB3.IsChecked == true)
                    {
                        L_Answers.Items.Add(question17["answer3"]);
                        TB_Question.Text = question17["Result3"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    break;
                case 18:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question18["answer1"]);
                        TB_Question.Text = question18["Result1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question18["answer2"]);
                        TB_Question.Text = question18["Result2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    else if (RB3.IsChecked == true)
                    {
                        L_Answers.Items.Add(question18["answer3"]);
                        TB_Question.Text = question18["Result3"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_NiceMen.Visibility = Visibility.Visible;
                    }
                    break;
            }
        }
        private void Btn_next_Click(object sender, RoutedEventArgs e)
        {
            Check();
        }

        private void Btn_restart_Click(object sender, RoutedEventArgs e)
        {
            L_Answers.Items.Clear();

            countQuestion = 1;
            TB_Question.Text = question1["text"];
            RB1_Text.Text = question1["answer1"];
            RB2_Text.Text = question1["answer2"];

            RB1.IsChecked = false;
            RB2.IsChecked = false;
            RB3.IsChecked = false;
            RB4.IsChecked = false;

            RB1.Visibility = Visibility.Visible;
            RB2.Visibility = Visibility.Visible;
            Btn_next.Visibility = Visibility.Visible;
            Btn_restart.Visibility = Visibility.Collapsed;
            IMG_NiceMen.Visibility = Visibility.Collapsed;
        }
    }
}
