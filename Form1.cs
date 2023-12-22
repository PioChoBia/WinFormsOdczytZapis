namespace WinFormsOdczytZapis
{
    public partial class Form1 : Form
    {
        string path = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButtonOdczyt_Click(object sender, EventArgs e)
        {
            FileStream fS;
            StreamReader sR;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //wybór scie¿ki
                path = openFileDialog1.FileName;

                //otwarcie strumienia z plikiem
                fS = new FileStream(
                    path,
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.None);

                //utworzenia strumienia do odczytu
                sR = new StreamReader(fS);

                //wczytanie zawartoœci pliku do RichBoxText
                richTextBoxOkno.Text = sR.ReadToEnd();

                //zamkniêcie strumieni pliku i odczytu
                sR.Close();
                fS.Close();
            }

        }

        private void toolStripButtonZapis_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //umo¿liwia skalowanie richBoxText1
            //wraz z zmian¹ okna programu
            richTextBoxOkno.Width= 
                Form1.ActiveForm.Size.Width-40;
            richTextBoxOkno.Height= 
                Form1.ActiveForm.Size.Height-120;            
        }
    }
}