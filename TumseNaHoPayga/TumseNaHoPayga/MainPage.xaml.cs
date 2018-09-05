using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TumseNaHoPayga
{
    public partial class MainPage : ContentPage
    {
        public String TarikValue;
        public String GhantaValue;
        public String TopicValue;
        public String PrepValue;
        public String SubjectValue;
        public Double topicsday;
        public Double topichours;

        public MainPage()
        {
            InitializeComponent();
        }

        public void Tarik(object sender, EventArgs e)
        {
            var select = _tarik.Items[_tarik.SelectedIndex];
            TarikValue = select;
        }

        private void ghanta(object sender, EventArgs e)
        {
            var select = _ghantas.Items[_ghantas.SelectedIndex];
            GhantaValue = select;
        }

        private void topic(object sender, EventArgs e)
        {
            var select = _topic.Items[_topic.SelectedIndex];
            TopicValue = select;
        }

        private void prep(object sender, EventArgs e)
        {
            var select = _prep.Items[_prep.SelectedIndex];
            PrepValue = select;
        }

        private void boj(object sender, EventArgs e)
        {
            var select = _subject.Items[_subject.SelectedIndex];
            SubjectValue = select;
        }

        public void calculate()
        {
            var dy = Convert.ToDouble(TarikValue);
            var tp = Convert.ToDouble(TopicValue);
            var hr = Convert.ToDouble(GhantaValue);

            var td = tp / dy;
            var th = td / hr;

            topicsday = td;
            topichours = th;
        }

        public void Submit(object sender, EventArgs e)
        {
            if (TarikValue == "1" || TarikValue == "2" || TarikValue == "3" || TarikValue == "4")
            {   
                if (Convert.ToInt32(GhantaValue) >= 3 && Convert.ToInt32(GhantaValue) <= 15)
                {
                    if(Convert.ToInt32(TopicValue) >= 10 && Convert.ToInt32(TopicValue) <= 20)
                    {
                        if(PrepValue == "BHAGWAN Bharose")
                        {
                            if(SubjectValue == "Kaun si bhasa hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Chill maar! Jai mata di! bol, sab ho jayega");
                            }
                            else if (SubjectValue == "Kuch toh padha hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Bhagwan ka naam le baki sab padha dega wo!!");
                            }
                            else if (SubjectValue == "Sab Kuch aata hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Sab kuch aata hai toh bhagwan bharose kyun hai???");
                            }
                            else if (SubjectValue == "Dost padha dega")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Tera dost hi bhagwan hai!! roz pooja kar uski!!!");
                            }
                            else if (SubjectValue == "Mini Xerox Tyaar hai!!")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Mini Xerox zindabad!!");
                            }
                            else if (SubjectValue == "")
                            {
                                DisplayAlert("Bahut intelligent hai na", "Chal answer de ab!!!", "OK");
                            }
                        }
                        else if (PrepValue == "DOST Bharose")
                        {
                            if (SubjectValue == "Kaun si bhasa hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= "+ topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Jo bhasa dost sikhaya, woh ache se samaj lena.");
                            }
                            else if (SubjectValue == "Kuch toh padha hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("abhi dost ko call laga aur sab padh le");
                            }
                            else if (SubjectValue == "Sab Kuch aata hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("sab ko aata hai toh dost ko kyun tang kar rha hai");
                            }
                            else if (SubjectValue == "Dost padha dega")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Dost Zindabad!!!");
                            }
                            else if (SubjectValue == "Mini Xerox Tyaar hai!!")
                            {
                                calculate();
                                
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Dost ko nahi batyega mini xerox ke bare mein!!!");
                            }
                            else if (SubjectValue == "")
                            {
                                DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                            }
                        }
                        else if (PrepValue == "CHITS Bharose")
                        {
                            if (SubjectValue == "Kaun si bhasa hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Chits sahi bhasa mein bana lena, nahi toh chapne samay lag jayegi");
                            }
                            else if (SubjectValue == "Kuch toh padha hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("baki jo bacha hai chits mein likh lena");
                            }
                            else if (SubjectValue == "Sab Kuch aata hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("sab ko aata hai toh chits kyun bana raha hai?");
                            }
                            else if (SubjectValue == "Dost padha dega")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("dost ke saath chits banane ka plan hai kya?");
                            }
                            else if (SubjectValue == "Mini Xerox Tyaar hai!!")
                            {
                                calculate();
                                
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("chill hai teri life ab!!!");
                            }
                            else if (SubjectValue == "")
                            {
                                DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                            }
                        }
                        else if (PrepValue == "LAL PATTI Bharose")
                        {
                            if (SubjectValue == "Kaun si bhasa hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("paisa har bhasa mein bolti hai");
                            }
                            else if (SubjectValue == "Kuch toh padha hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("ab paisa gina shuru kar!!!");
                            }
                            else if (SubjectValue == "Sab Kuch aata hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("paise kyun de raha hai phir agar sab kuch aata hai???");
                            }
                            else if (SubjectValue == "Dost padha dega")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Dost paisa toh nahi mangega na???");
                            }
                            else if (SubjectValue == "Mini Xerox Tyaar hai!!")
                            {
                                calculate();
                                
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("xerox wale ko hi paisa dede");
                            }
                            else if (SubjectValue == "")
                            {
                                DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                            }
                        }
                        else if (PrepValue == "DIMAAG HAI")
                        {
                            if (SubjectValue == "Kaun si bhasa hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Dimaag hai toh padhai kar");
                            }
                            else if (SubjectValue == "Kuch toh padha hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("kuch, kitna jhooth bolega?");
                            }
                            else if (SubjectValue == "Sab Kuch aata hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("sab ko aata hai toh baki logo ki toh madad karna");
                            }
                            else if (SubjectValue == "Dost padha dega")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("aur jhooth bol");
                            }
                            else if (SubjectValue == "Mini Xerox Tyaar hai!!")
                            {
                                calculate();
                                
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("dimaag hai phir bhi mini xerox????");
                            }
                            else if (SubjectValue == "")
                            {
                                DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                            }
                        }
                        else if (PrepValue == "")
                        {
                            DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                        }

                    }
                    else if(TopicValue == "")
                    {
                        DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                    }
                }
                else if (GhantaValue == "")
                {
                    DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                }
            }
            else if (TarikValue == "5" || TarikValue == "6" || TarikValue == "7" || TarikValue == "8")
            {
                if (Convert.ToInt32(GhantaValue) >= 3 && Convert.ToInt32(GhantaValue) <= 15)
                {
                    if (Convert.ToInt32(TopicValue) >= 10 && Convert.ToInt32(TopicValue) <= 20)
                    {
                        if (PrepValue == "BHAGWAN Bharose")
                        {
                            if (SubjectValue == "Kaun si bhasa hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("samay hai sudhar ja!!!!");
                            }
                            else if (SubjectValue == "Kuch toh padha hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("kuch, baki ka kya????");
                            }
                            else if (SubjectValue == "Sab Kuch aata hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("aab nach!!!!");
                            }
                            else if (SubjectValue == "Dost padha dega")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("kuch din hi baki hai, pakad apne dost ko");
                            }
                            else if (SubjectValue == "Mini Xerox Tyaar hai!!")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Mini Xerox zindabad!!");
                            }
                            else if (SubjectValue == "")
                            {
                                DisplayAlert("Bahut intelligent hai na", "Chal answer de ab!!!", "OK");
                            }
                        }
                        else if (PrepValue == "DOST Bharose")
                        {
                            if (SubjectValue == "Kaun si bhasa hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("bhai dost ko toh bhasa aati hai na????");
                            }
                            else if (SubjectValue == "Kuch toh padha hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("sudhar ja bacha, padh le dost ke saath");
                            }
                            else if (SubjectValue == "Sab Kuch aata hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("dekh le tere dost ko bhi kuch madadd chahiye hogi");
                            }
                            else if (SubjectValue == "Dost padha dega")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Dost Zindabad!!!");
                            }
                            else if (SubjectValue == "Mini Xerox Tyaar hai!!")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("mini xerox aur dost bhi, kitna kaminagiri karega");
                            }
                            else if (SubjectValue == "")
                            {
                                DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                            }
                        }
                        else if (PrepValue == "CHITS Bharose")
                        {
                            if (SubjectValue == "Kaun si bhasa hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("bacha dekh le chits toh sahi bhasa mein hai na");
                            }
                            else if (SubjectValue == "Kuch toh padha hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("woh kuch bhi chits mein likha le, tera koi bharosa nhi");
                            }
                            else if (SubjectValue == "Sab Kuch aata hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("sab ko aata hai toh chits kyun bana raha hai?");
                            }
                            else if (SubjectValue == "Dost padha dega")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("dost aur chits kitna copy karega???");
                            }
                            else if (SubjectValue == "Mini Xerox Tyaar hai!!")
                            {
                                calculate();
                                
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("chill hai teri life ab!!!");
                            }
                            else if (SubjectValue == "")
                            {
                                DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                            }
                        }
                        else if (PrepValue == "LAL PATTI Bharose")
                        {
                            if (SubjectValue == "Kaun si bhasa hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("News padhi hogi na, the great demonetisation");
                            }
                            else if (SubjectValue == "Kuch toh padha hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("ab woh kuch mein Cash TAX padha hai");
                            }
                            else if (SubjectValue == "Sab Kuch aata hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Sab kuch aata hai, phir bhi cashless nhi hua, doob maar");
                            }
                            else if (SubjectValue == "Dost padha dega")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("dost ko bhi demonetisation ka nhi pata, kya hoga tum dono ka");
                            }
                            else if (SubjectValue == "Mini Xerox Tyaar hai!!")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("xerox wala bhi cashless hogaya hai");
                            }
                            else if (SubjectValue == "")
                            {
                                DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                            }
                        }
                        else if (PrepValue == "DIMAAG HAI")
                        {
                            if (SubjectValue == "Kaun si bhasa hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("dimaagi halat thik hai na????");
                            }
                            else if (SubjectValue == "Kuch toh padha hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("dimaag hoke bhi kuch, baki ka kya???");
                            }
                            else if (SubjectValue == "Sab Kuch aata hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("dimaag hai toh sab kuch aata hai na");
                            }
                            else if (SubjectValue == "Dost padha dega")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("dimaag hai toh dost ka kya karega????");
                            }
                            else if (SubjectValue == "Mini Xerox Tyaar hai!!")
                            {
                                calculate();
                                
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("haan saara dimaag mini xerox mein chala gaya tha na");
                            }
                            else if (SubjectValue == "")
                            {
                                DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                            }
                        }
                        else if (PrepValue == "")
                        {
                            DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                        }

                    }
                    else if (TopicValue == "")
                    {
                        DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                    }
                }
                else if (GhantaValue == "")
                {
                    DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                }
            }
            else if (TarikValue == "9" || TarikValue == "10" )
            {
                if (Convert.ToInt32(GhantaValue) >= 3 && Convert.ToInt32(GhantaValue) <= 15)
                {
                    if (Convert.ToInt32(TopicValue) >= 10 && Convert.ToInt32(TopicValue) <= 20)
                    {
                        if (PrepValue == "BHAGWAN Bharose")
                        {
                            if (SubjectValue == "Kaun si bhasa hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Bahut time hai bhasa sikhne ke liye");
                            }
                            else if (SubjectValue == "Kuch toh padha hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Bhagwan ka naam le baki sab padha dega wo!!");
                            }
                            else if (SubjectValue == "Sab Kuch aata hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Ab timepass kar baith ke");
                            }
                            else if (SubjectValue == "Dost padha dega")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("phir kyun tension le rha hai");
                            }
                            else if (SubjectValue == "Mini Xerox Tyaar hai!!")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Mini Xerox zindabad!!");
                            }
                            else if (SubjectValue == "")
                            {
                                DisplayAlert("Bahut intelligent hai na", "Chal answer de ab!!!", "OK");
                            }
                        }
                        else if (PrepValue == "DOST Bharose")
                        {
                            if (SubjectValue == "Kaun si bhasa hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("abhi phele dost ko padhne de.");
                            }
                            else if (SubjectValue == "Kuch toh padha hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("abhi dost ko call laga aur sab padh le");
                            }
                            else if (SubjectValue == "Sab Kuch aata hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("sab ko aata hai toh dost ko kyun tang kar rha hai");
                            }
                            else if (SubjectValue == "Dost padha dega")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Dost Zindabad!!!");
                            }
                            else if (SubjectValue == "Mini Xerox Tyaar hai!!")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("dost ko maat bata dena mini xerox ke bare mein");
                            }
                            else if (SubjectValue == "")
                            {
                                DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                            }
                        }
                        else if (PrepValue == "CHITS Bharose")
                        {
                            if (SubjectValue == "Kaun si bhasa hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("abhi se chits bana ke sapne dekhna shuru??");
                            }
                            else if (SubjectValue == "Kuch toh padha hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("baki jo bacha hai chits mein likh lena");
                            }
                            else if (SubjectValue == "Sab Kuch aata hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("chits abhi banayega toh gum jayega!!!");
                            }
                            else if (SubjectValue == "Dost padha dega")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("dost pada dega toh chits kyun bana rha hai???");
                            }
                            else if (SubjectValue == "Mini Xerox Tyaar hai!!")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("abhi se mini xerox!!!");
                            }
                            else if (SubjectValue == "")
                            {
                                DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                            }
                        }
                        else if (PrepValue == "LAL PATTI Bharose")
                        {
                            if (SubjectValue == "Kaun si bhasa hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Demonetisation ka naam suna hai???");
                            }
                            else if (SubjectValue == "Kuch toh padha hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("toh demonetisation ke bare mein toh padh le");
                            }
                            else if (SubjectValue == "Sab Kuch aata hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("toh online kyun nhi pay karta, tax bharna pasand hai kya???");
                            }
                            else if (SubjectValue == "Dost padha dega")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Dost se demonetisation ke bare mein jaan le");
                            }
                            else if (SubjectValue == "Mini Xerox Tyaar hai!!")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("xerox wale ko bhi demonetisation pata hai");
                            }
                            else if (SubjectValue == "")
                            {
                                DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                            }
                        }
                        else if (PrepValue == "DIMAAG HAI")
                        {
                            if (SubjectValue == "Kaun si bhasa hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("Dimaag hai toh padhai kar");
                            }
                            else if (SubjectValue == "Kuch toh padha hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("kuch, kitna jhooth bolega?");
                            }
                            else if (SubjectValue == "Sab Kuch aata hai")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("sab ko aata hai toh baki logo ki toh madad karna");
                            }
                            else if (SubjectValue == "Dost padha dega")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("aur jhooth bol");
                            }
                            else if (SubjectValue == "Mini Xerox Tyaar hai!!")
                            {
                                calculate();
                                lbl_topic.Text = String.Format("Topics/Day= " + topicsday);
                                lbl_hours.Text = String.Format("Topics/Hours= " + topichours);
                                lbl_msg.Text = String.Format("dimaag hai phir bhi mini xerox????");
                            }
                            else if (SubjectValue == "")
                            {
                                DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                            }
                        }
                        else if (PrepValue == "")
                        {
                            DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                        }

                    }
                    else if (TopicValue == "")
                    {
                        DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                    }
                }
                else if (GhantaValue == "")
                {
                    DisplayAlert("Bahut intelligent hai na", "Chal jabab de", "OK");
                }
            }
            else if (TarikValue == null || TarikValue == "" || TarikValue == "Tarik")
            {
                DisplayAlert("Bahut intelligent hai na", "Chal apni mayaat ki tarik bata", "OK");
            }
        }

        private void Reset(object sender, EventArgs e)
        {
            _tarik.SelectedIndex = 11;
            _ghantas.SelectedIndex = 14;
            _topic.SelectedIndex = 15;
            _subject.SelectedIndex = 6;
            _prep.SelectedIndex = 6;
            lbl_hours.Text = String.Format("");
            lbl_msg.Text = String.Format("");
            lbl_topic.Text = String.Format("");
        }
    }
}
