using ProjecteFinal_m02_m04.BBDD;
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
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Esborrar Dades actuals de les taules per evitar duplicitat d'informació
                //int rowsAffedted = 0
                //BBDDManager.deleteData("contacts");
                //BBDDManager.deleteData("opportunities");
                //int rowsAffected = BBDDManager.deleteData("customers");

                CRMManager.loadXML(openFileDialog.FileName);

                // Cridar a StoredProcedure per extreure les dades i escriure-les a un fitxer
                BBDDManager.ExtractData();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

    }
}