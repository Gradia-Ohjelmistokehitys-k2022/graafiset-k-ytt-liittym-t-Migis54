namespace T_14
{
    public partial class Form1 : Form
    {
        private String _EditorFileName = "Untitled";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SetFormTitleText()

        {

            // Tiedoston nimi formiin. 

            FileInfo fileinfo = new FileInfo(_EditorFileName);

            Text = fileinfo.Name + " - Editor";

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _EditorFileName = "Untitled";

            richTextBox1.Clear();

            SetFormTitleText();
        }
        private void ReadFile()
        {

            try
            {
                using (StreamReader Reader = new StreamReader(_EditorFileName))

                {
                    richTextBox1.Clear();
                    richTextBox1.Text = Reader.ReadToEnd();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Open File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void SaveFile()
        {
            try
            {
                using (StreamWriter Writer = new StreamWriter(_EditorFileName))
                {
                    Writer.Write(richTextBox1.Text);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Save File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Luodaan standardi avausdialogiobjekti ja alustetaan se. 

            OpenFileDialog OpenFileDlg = new OpenFileDialog();

            OpenFileDlg.Title = "Open";

            OpenFileDlg.ShowReadOnly = true;

            OpenFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*";



            // Avataan windowsin standardi avausdialogi. 

            if (OpenFileDlg.ShowDialog() == DialogResult.OK)

            {

                // Talletetaan tiedoston nimi ja polku lukemista varten. 

                _EditorFileName = OpenFileDlg.FileName;



                // Luetaan tiedosotn sisältö ja tuodaan se näytölle. 

                ReadFile();



                SetFormTitleText();

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_EditorFileName == "Untitled")

            {

                saveAsToolStripMenuItem_Click(sender, e);

            }

            else

            {

                SaveFile();

            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Luodaan standardi talletusdialogiobjekti ja alustetaan se. 

            SaveFileDialog SaveFileDlg = new SaveFileDialog();

            SaveFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*";



            // Avataan windowsin standardi talletusdialogi. 

            if (SaveFileDlg.ShowDialog() == DialogResult.OK)

            {

                // Talletetaan tiedoston nimi ja polku talletusta varten. 

                _EditorFileName = SaveFileDlg.FileName;



                SaveFile();



                SetFormTitleText();

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
