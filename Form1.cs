using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        string pastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string caminhoArquivo = Path.Combine(pastaDocumentos, "arquivo.txt");

            using (Stream arquivo = File.Open(caminhoArquivo, FileMode.Open))
            using (StreamReader leitor = new StreamReader(arquivo))
            {
                textoConteudo.Text = leitor.ReadToEnd();
            }
        }

        private void botaoGrava_Click(object sender, EventArgs e)
        {
            string caminhoArquivo = Path.Combine(pastaDocumentos, "arquivo.txt");

            using (Stream saida = File.Open(caminhoArquivo, FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(saida))
            {
                escritor.Write(textoConteudo.Text);
            }
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            string busca = textoBusca.Text;
            string textoDoEditor = textoConteudo.Text;
            int resultado = textoDoEditor.IndexOf(busca);
            if (resultado >= 0)
            {
                MessageBox.Show("Achei o Texto" + busca);
            }
            else
            {
                MessageBox.Show("Não achei");
            }
        }
    }
}
