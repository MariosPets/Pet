using MariosPet.Classes;
using MariosPet.Crud;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;


namespace MariosPet.Telas
{
    public partial class FrmAnimal : Form
    {
        Animal classeAni = new Animal();
        Foto classeFot = new Foto();
        Cliente classeCli = new Cliente();

        CrudCliente CrudCli = new CrudCliente();
        public FrmAnimal()
        {
            InitializeComponent();

            if (Estatica.id != 0)
            {
                CopiarParaFormulario();
            }
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {            
            Close();            
        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtNomeAnimal.Clear();
            txtPelagemCor.Clear();
            txtRacaPorte.Clear();
            maskedTxtNascimentoAnimal.Clear();
        }

        public void CopiarParaClasseAnimal()
        {
            classeCli.nome = txtPesquisaCliente.Text;
            //Animal
            classeAni.nome = txtNomeAnimal.Text;
            classeAni.racaPorte = txtRacaPorte.Text;
            classeAni.pelagemCor = txtPelagemCor.Text;
            classeAni.nascimento = maskedTxtNascimentoAnimal.Text;
            classeAni.sexo = radioButtonFemea.Checked;
            if (Estatica.id == 0)
                classeAni.carteirinha = Convert.ToInt32(DateTime.Now.DayOfYear.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString());

            MemoryStream imagem = new MemoryStream();
            pictureBoxAnimal.Image.Save(imagem, ImageFormat.Jpeg);

            Byte[] arquivoFoto = new byte[imagem.Length];
            imagem.Position = 0;
            imagem.Read(arquivoFoto, 0, Convert.ToInt32(imagem.Length));

            classeFot.foto = arquivoFoto;
        }

        public void CopiarParaFormulario()
        {
            CrudAnimal CrudAni = new CrudAnimal();

            string sql = "select * from animal where id_animal = " + Estatica.id.ToString();
            DataTable animal = CrudAni.consultaAnimal(sql);

            //Dados Animal
            classeAni.id = Convert.ToInt32(animal.Rows[0][0].ToString());
            classeAni.carteirinha = Convert.ToInt32(animal.Rows[0][1].ToString());
            txtNomeAnimal.Text = animal.Rows[0][2].ToString();
            classeAni.idCliente = Convert.ToInt32(animal.Rows[0][3].ToString());
            txtRacaPorte.Text = animal.Rows[0][4].ToString();
            radioButtonFemea.Text = animal.Rows[0][5].ToString();
            radioButtonMacho.Text = animal.Rows[0][5].ToString();
            txtPelagemCor.Text = animal.Rows[0][6].ToString();
            maskedTxtNascimentoAnimal.Text = animal.Rows[0][7].ToString();
        }

        private void radioButtonFem_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFemea.Checked == true)
            {
                radioButtonMacho.Checked = false;
            }
            else
            {
                radioButtonMacho.Checked = true;
            }
        }

        private void radioButtonMasc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMacho.Checked == true)
            {
                radioButtonFemea.Checked = false;
            }
            else
            {
                radioButtonFemea.Checked = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmPesquisas form = new FrmPesquisas();
            Visible = false;
            form.ShowDialog();
            Visible = true;
        }

        private void btmSalvar_Click_1(object sender, EventArgs e)
        {
            CopiarParaClasseAnimal();

            CrudAnimal CrudAni = new CrudAnimal();
            CrudFoto CrudFoto = new Crud.CrudFoto();

            if (Estatica.id != 0)
            {
                CrudAni.alteraAnimal(classeAni);

                Estatica.id = 0;
            }
            else
            {
                CrudAni.inserirAnimal(classeAni);

                classeAni.id = Convert.ToInt32(CrudCli.consultaCliente("Select top 1 ID_ANIMAL from ANIMAL order by ID_ANIMAL desc").Rows[0][0].ToString());

                classeFot.idAnimal = classeAni.id;
                CrudFoto.inserirFoto(classeFot);
            }
        }

        private void btnBuscaFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images only. |*.jpg; *.jpeg; *.png; *.gif;";

            DialogResult dialogResult = openFileDialog.ShowDialog();

            pictureBoxAnimal.Image = Image.FromFile(openFileDialog.FileName);
        }
    }
}
