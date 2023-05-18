using ProjecteFinal_m02_m04.Model;

namespace ProjecteFinal_m02_m04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File XML (*.xml)[*.xml]";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CRMManager.loadModel(openFileDialog.FileName);
            }
        }
    }
}