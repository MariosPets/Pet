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
        

        CrudCliente CrudCli = new CrudCliente();
        public FrmAnimal()
        {
            InitializeComponent();

            if (Estatica.tipoAcao == TipoAcao.alterar)
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
            if(Estatica.tipoAcao != TipoAcao.alterar)
                classeAni.idCliente = Estatica.id;
            classeAni.nome = txtNomeAnimal.Text;
            classeAni.racaPorte = txtRacaPorte.Text;
            classeAni.pelagemCor = txtPelagemCor.Text;
            classeAni.nascimento = maskedTxtNascimentoAnimal.Text;
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

            string sql = "select * from animal inner join foto on foto.id_animal = animal.id_animal where animal.id_animal = " + Estatica.id.ToString();
            DataTable animal = CrudAni.consultaAnimal(sql);

            //Dados Animal
            
            classeAni.id = Convert.ToInt32(animal.Rows[0][0].ToString());
            classeAni.carteirinha = Convert.ToInt32(animal.Rows[0][1].ToString());
            txtNomeAnimal.Text = animal.Rows[0][2].ToString();
            classeAni.idCliente = Convert.ToInt32(animal.Rows[0][3].ToString());
            txtRacaPorte.Text = animal.Rows[0][4].ToString();
            txtPelagemCor.Text = animal.Rows[0][6].ToString();
            maskedTxtNascimentoAnimal.Text = animal.Rows[0][7].ToString();

            //pictureBoxAnimal.Image = Image.FromFile(animal.Rows[0][10].ToString());
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Estatica.buscaTipo = BuscaTipo.cliente;

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

            if (Estatica.tipoAcao == TipoAcao.alterar)
            {
                CrudAni.alteraAnimal(classeAni);
                classeFot.idAnimal = Estatica.id;
                CrudFoto.inserirFoto(classeFot);
                Estatica.id = 0;
                MessageBox.Show("Animal Cadastrado com Sucesso", "Animal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CrudAni.inserirAnimal(classeAni);

                classeAni.id = Convert.ToInt32(CrudCli.consultaCliente("Select top 1 ID_ANIMAL from ANIMAL order by ID_ANIMAL desc").Rows[0][0].ToString());

                classeFot.idAnimal = classeAni.id;
                CrudFoto.inserirFoto(classeFot);
                MessageBox.Show("Animal Alterado com Sucesso", "Animal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
