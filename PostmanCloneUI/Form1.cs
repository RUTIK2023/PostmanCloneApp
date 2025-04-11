using System.Windows.Forms.Design;
using System.Net.Http;

//using PostmanCloneLibrary;

//namespace PostmanCloneUI

//{


//    public partial class Form1 : Form
//    {

//        private readonly IApiAccess api = new ApiAccess();

//        public Form1()
//        {
//            InitializeComponent();
//            //api = new ApiService(); 
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }

//        private void textBox2_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private async void callApi_Click(object sender, EventArgs e)
//        {
//            // validtaionn requires

//            if (api.IsValidUrl(apiText.Text)== false) {
//                systemStatus.Text = "Invalid URL..";
//                return;
//            }

//            try
//            {
//                systemStatus.Text = "API calling...";

//                resultsText.Text=  await api.CallApiAsync(apiText.Text);

//                systemStatus.Text = "Ready";



//            }
//            catch (Exception ex)
//            {

//                resultsText.Text = "Error coming as:" + ex.Message;
//                //systemStatus.Text = "Error";
//            }


//        }

//        private void apiText_TextChanged(object sender, EventArgs e)
//        {

//        }
//    }


//}


namespace PostmanCloneUI

{


    public partial class Form1 : Form
    {

        private readonly IApiAccess api = new ApiAccess();

        public Form1()
        {
            InitializeComponent();
            httpVerb.SelectedItem = "GET";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void callApi_Click(object sender, EventArgs e)
        {
            // validtaionn requires

            if (api.IsValidUrl(apiText.Text) == false)
            {
                systemStatus.Text = "Invalid URL..";
                return;
            }


            HttpAction action;

            if (Enum.TryParse(httpVerb.SelectedItem!.ToString(), out action) == false)
            {
                systemStatus.Text = "Invalid  Http Verb";
                return;
            }


            try
            {
                systemStatus.Text = "API calling...";

                resultsText.Text = await api.CallApiAsync(apiText.Text, bodyText.Text, action);
                callData.SelectedTab = resultTab;
                resultTab.Focus();
                systemStatus.Text = "Ready";



            }
            catch (Exception ex)
            {

                resultsText.Text = "Error coming as:" + ex.Message;
                //systemStatus.Text = "Error";
            }


        }

        private void apiText_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }


}

