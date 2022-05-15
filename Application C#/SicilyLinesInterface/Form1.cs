using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace SicilyLinesInterface
{
    public partial class Form1 : Form
    {

        //Initialisation de la liste en premier pour pouvoir y accéder dans toutes les méthodes
        List<string> listLiaison = new List<string>();


        //Initialisation 

        private string c;
        private int i = -1;



        //Permet de bouger la fenêtre sans les bordures "moches"
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();




        //Permet de rendre le panel de navigation round

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn

            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );





        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 26, 26));
            pnlNav.Height = btnAccueil.Height;
            pnlNav.Top = btnAccueil.Top;
            pnlNav.Left = btnAccueil.Left;
            btnAccueil.BackColor = Color.FromArgb(27, 44, 88);

        }




        private const int CS_DropShadow = 0x0020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }

        }


        private void Form1_Load(object sender, EventArgs e)
                {
                    ListBoxReservation.Hide();
                    label1.Hide();
                    btnSuppr.Hide();
                    btnUpdate.Hide();
                    btnLoad.Hide();
                    btnPath.Hide();
                    textBoxPath.Hide();
                    labelStatus.Hide();
                    btnSave.Hide();
                    lbAjoutLiaison.Hide();
                    lbModificationLiaison.Hide();
                    textBox_Ajout.Hide();
                    textBox_Modification.Hide();
                    btnOKAjout.Hide();
                    btnModifOK.Hide();

                }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAccueil.Height;
            pnlNav.Top = btnAccueil.Top;
            pnlNav.Left = btnAccueil.Left;
            btnAccueil.BackColor = Color.FromArgb(27, 50, 105);



            ListBoxReservation.Hide();
            label1.Hide();
            btnSuppr.Hide();
            btnUpdate.Hide();

            labelStatus.Hide();
            btnSave.Hide();

            lbAjoutLiaison.Hide();
            lbModificationLiaison.Hide();

            textBox_Ajout.Hide();
            textBox_Modification.Hide();


            btnOKAjout.Hide();
            btnModifOK.Hide();

            label2.Show();

            btnLoad.Hide();
            btnPath.Hide();
            textBoxPath.Hide();





        }

        private void btnAccueil_Leave(object sender, EventArgs e)
        {
            btnAccueil.BackColor = Color.FromArgb(25, 42, 86);
        }


        private void btnReservation_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReservation.Height;
            pnlNav.Top = btnReservation.Top;
            pnlNav.Left = btnReservation.Left;
            btnReservation.BackColor = Color.FromArgb(27, 50, 105);

            pnlNav.BringToFront();

            ListBoxReservation.Show();
            label2.Hide();
            ListBoxReservation.Show();
            label1.Show();

            lbAjoutLiaison.Show();
            lbModificationLiaison.Show();

            textBox_Ajout.Show();
            textBox_Modification.Show();

            btnOKAjout.Show();
            btnModifOK.Show();

            labelStatus.Show();
            btnSave.Show();

            btnSuppr.Show();
            btnUpdate.Show();

            btnLoad.Show();
            btnPath.Show();
            textBoxPath.Show();

        }





        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close(); //Permet de fermer la fenêtre 
        }



        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Permet de minimiser la fenêtre 
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            
        }


        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            //Permet de récupérer l'emplacement du fichier txt
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                if (op.ShowDialog() == DialogResult.OK)
                {
                    textBoxPath.Text = op.FileName;
                }
            }

            catch
            { }
        }


        private void affich(List<string> listAfficher)
        {
            ListBoxReservation.DataSource = null;
            ListBoxReservation.DataSource = listAfficher;
            ListBoxReservation.DisplayMember = "Description";
        }


        private void chargerFichier()
        {
            //Permet de charger le texte présent dans le fichier txt dans la listBox
            try
            {
                //string[] lines = System.IO.File.ReadAllLines(textBoxPath.Text.Trim());
                listLiaison = System.IO.File.ReadAllLines(textBoxPath.Text.Trim()).ToList();
                affich(listLiaison);
            }
            catch { }
        }






        private void ActualiserLB()
        {
            //Permet de charger le text présent dans le fichier txt dans la listBox
            try
            {
                affich(listLiaison);
            }
            catch { }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            chargerFichier();

        }

        private void indexSelect()
        {

            try
            {
                this.i = ListBoxReservation.SelectedIndex;
                c = listLiaison[this.i];
            }

            catch
            {

            }

        }


        private void btnSuppr_Click(object sender, EventArgs e)
        {
            indexSelect();
            try { 
                listLiaison.RemoveAt(this.i);
            }
            catch {

            }
            ActualiserLB();


        }

        private void exportFile()
        {
            String filePath = textBoxPath.Text; 
            StreamWriter tw = new StreamWriter(filePath);

            foreach (String s in listLiaison)
            {
                tw.WriteLine(s);
            }

            tw.Close();


        }

        private async void metroButton3_ClickAsync(object sender, EventArgs e)
        {
            exportFile();

            labelStatus.Text = "File Save Successfully";
            Random r = new Random();
            labelStatus.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            

            await Task.Delay(3_000);
            labelStatus.Text = string.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            indexSelect();
            textBox_Modification.Text = listLiaison[this.i];


        }



        private void btnOKAjout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show ("êtes-vous sur de vouloir ajouter une liaison ?", "Confirmation", MessageBoxButtons.YesNo);
            try
            {

                if (result == DialogResult.Yes)
                {
                    listLiaison.Add(textBox_Ajout.Text);
                    ActualiserLB();
                    textBox_Ajout.Text = "";
                }

                else if (result == DialogResult.No)
                {
                    //Rien
                }

            }

            catch { }

        }

        private void btnModifOK_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("êtes-vous sur de vouloir modifier une liaison ?", "Confirmation", MessageBoxButtons.YesNo);

            //Si y'a des erreurs faut sup le try catch
            try
            {
                if (result == DialogResult.Yes)
                {
                    listLiaison[this.i] = textBox_Modification.Text;
                    ActualiserLB();

                }

                else if (result == DialogResult.No)
                {
                    //Rien
                }
            }
            catch { }


            if (result == DialogResult.Yes)
            {
                listLiaison[this.i] = textBox_Modification.Text;
                ActualiserLB();
     
            }

            else if (result == DialogResult.No)
            {
                //Rien
            }


        }

        private void textBox_Ajout_TextChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListBoxReservation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
