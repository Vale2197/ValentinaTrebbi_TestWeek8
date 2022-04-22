namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> images = new Dictionary<string, string>()
        {
            {"indefinito", "https://cdn.pixabay.com/photo/2015/11/03/09/03/question-mark-1019993__340.jpg" },
            {"carta", "https://us.123rf.com/450wm/captainvector/captainvector1602/captainvector160247857/53299790-palmo-della-mano.jpg?ver=6" },
            {"sasso", "https://thumbs.dreamstime.com/z/protesta-umana-del-pugno-chiuso-manifesto-ribelle-di-rivoluzione-un-simbolo-forza-e-superiorit%C3%A0-successo-lotta-per-il-suo-101385522.jpg" },
            {"forbici", "https://thumbs.dreamstime.com/z/mano-femminile-isolata-della-donna-aperta-vuota-nella-posizione-del-segno-e-del-numero-due-di-pace-su-un-fondo-bianco-78208939.jpg" }
        };

        Dictionary<string, string> profileImages = new Dictionary<string, string>()
        {
            {"pc", "https://thumbs.dreamstime.com/b/desktop-computer-hand-drawn-line-art-painting-cute-illustration-73656849.jpg" },
            { "me", "https://img.myloview.it/quadri/user-icon-vector-people-icon-profile-vector-icon-person-illustration-business-user-icon-users-group-symbol-male-user-symbol-700-223068886.jpg"}
        };

        int randomNum;
        
        string currentBtn = null;

        string randomImage = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = images["indefinito"];
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox2.ImageLocation = images["indefinito"];
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            pictureProfile.ImageLocation = profileImages["me"];
            pictureProfile.SizeMode = PictureBoxSizeMode.Zoom;

            picturePc.ImageLocation = profileImages["pc"];
            picturePc.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void sassoButton_Click(object sender, EventArgs e)
        {
            GetMyChoice(sassoButton, "sasso");
        }

        private void cartaButton_Click(object sender, EventArgs e)
        {
            GetMyChoice(cartaButton, "carta");
        }

        private void forbiciButton_Click(object sender, EventArgs e)
        {
            GetMyChoice(forbiciButton, "forbici");
        }

        private void GetMyChoice(Button mybtn, string imageString)
        {
            currentBtn = (string)mybtn.Tag;
            pictureBox1.ImageLocation = images[imageString];
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (currentBtn == null)
            {
                labelEsito.Text = "devi prima selezionare un'opzione >=(";
            }
            else
            {
                Random random = new Random();
                randomNum = random.Next(1, 4);

                var image = (Images)randomNum;

                randomImage = images[image.ToString()];
                pictureBox2.ImageLocation = randomImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

                labelEsito.Text = CheckVictory(image.ToString());
            }
        }

        private string CheckVictory(string image)
        {
            string esito = null;

            if(currentBtn == "sasso")
            {
                esito = image == "carta" ? "hai perso :(" : image == "forbici" ? "hai vinto! :D" : "pareggio :)";
            }
            else if(currentBtn == "forbici")
            {
                esito = image == "carta" ? "hai vinto! :D" : image == "forbici" ? "Pareggio :)" : "hai perso :(";

            }
            else
            {
                esito = image == "sasso" ? "hai vinto! :D" : image == "forbici" ? "hai perso :(" : "pareggio :)";

            }

            return esito;
        }
    }

    public enum Images
    {
        forbici = 1,
        sasso = 2,
        carta = 3,
    }
}