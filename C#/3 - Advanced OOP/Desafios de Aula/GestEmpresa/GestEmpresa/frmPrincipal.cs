using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestEmpresa
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            // O construtor surge antes do Load()
            // http://www.codeproject.com/Articles/4012/C-List-View-v

            InitializeComponent();

            // https://www.vbforums.com/showthread.php?889910-RESOLVED-DataGridView-FullRowSelect-selects-column-header-too
            // https://stackoverflow.com/questions/51513396/breaking-change-in-datagridview-between-net-4-0-and-net-4-7-2-header-selection
            // Uma das soluções para remover a seleção da célula no cabeçalho de coluna é
            // desativar o estilo de visualização, mas não oferece um efeito visual agradável.
            
            //dataGridView.EnableHeadersVisualStyles = false;
            //dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = dataGridView.ColumnHeadersDefaultCellStyle.BackColor;
            //dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
            //dataGridView.DefaultCellStyle.SelectionForeColor = dataGridView.DefaultCellStyle.ForeColor;
            
            // Em alternativa podemos incluir código em program.cs no início do método Main() para desativar as "melhorias"
            // Esta foi a opção utilizada
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Empregado.GetNomeAbreviado("Carlos manuel ALmeiDA"));

            // Alterar o título da Janela
            Text = Empresa.appNome + " " + Empresa.appVer;

            // Alterar algumas propriedades da datagridView
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.MultiSelect = false;
            dgvDados.RowHeadersVisible = false;
            dgvDados.ReadOnly = true;
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.AllowUserToResizeRows = false;
            dgvDados.AllowUserToResizeColumns = false;
            dgvDados.AllowUserToOrderColumns = true;

            // Associar os dados na DataGridView
            dgvDados.DataSource = Empresa.emp;

            // Mostrar apenas as 4 primeiras propriedades da classe Empregado na DataGridView
            // Por defeito todas as colunas da DataGridView têm a propriedade Visible = True

            for (int i = 4; i < dgvDados.ColumnCount; i++)
                   dgvDados.Columns[i].Visible = false;

            // Posso aceder â coluna pelo seu indice ou pelo nome da coluna/nome da propriedade
            dgvDados.Columns["ValorID"].HeaderText = "ID";
            dgvDados.Columns["ValorID"].DefaultCellStyle.BackColor = Color.LightYellow;
            dgvDados.Columns["ValorID"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dgvDados.Columns["ValorID"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvDados.Columns["Cargo"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic);

            dgvDados.Columns["ValorID"].Width = 50;
            dgvDados.Columns["NomeAbreviado"].Width = 150;
            dgvDados.Columns["NomeAbreviado"].HeaderText = "Nome";
            
            // Para que o formulário receba a tecla pressionad
            KeyPreview = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVerEditar_Click(object sender, EventArgs e)
        {
            // Temos pelo menos um empregado na lista?
            if (dgvDados.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum empregado na lista de dados...", Empresa.appNome, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                

            Empregado dados = GetCurrentDataRown();

            if (dados != null)
            { 
                // Qual a posição dos dados do empregado na lista
                int i = Empresa.emp.IndexOf(dados);
                
                frmEmpregado form = new frmEmpregado((Empregado)Empresa.emp[i].Clone());
                DialogResult res = form.ShowDialog();

                // se clicou OK ao fechar a janela
                if (res == DialogResult.OK)
                {
                    Empresa.emp[i] = form.Emp;

                    // Se o cargo for alterado, a lista não fica ordenada pelo ID
                    // Neste caso podemo ordenar a lista pelo ID
                    // Se ordenar a Lista, a BindingLista tamb+ém fica ordenada
                    // O método CoimpareTo devolve -1, 0 ou 1, por exemplo se devolve 0, o ID de X e Y são iguais.. 1, é maior e -1 é menor
                    Empresa.empList.Sort((Empregado X, Empregado Y) => X.ValorID.CompareTo(Y.ValorID));

                    // Uma vez que editei diretamente os dados na lista,
                    // é necessário informar a DataGridView que a BindingList foi alterada
                    // Temos de forçar a comunicação da atualização dos dados
                    Empresa.emp.ResetBindings();

                    MessageBox.Show("Empregado atualizado com sucesso...", Empresa.appNome, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Não existe o empregado na lista...", Empresa.appNome, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Devolve o empregado atualmente selecionado na datagridView
        /// </summary>
        private Empregado GetCurrentDataRown()
        {
            if (dgvDados.SelectedRows.Count > 0)
                // Aceder aos dados associados à linha selecionada
                // e converter esses dados para Empregado
                return (Empregado)dgvDados.CurrentRow.DataBoundItem;
            else
                return null;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvDados.Rows.Count > 0)
            {
                Empregado dados = GetCurrentDataRown();
                int i = Empresa.emp.IndexOf(dados);

                // Não encontrou o empregado na BindingList?
                if (i<0)
                {
                    MessageBox.Show("Empregado não encontrado na lista de dados...", Empresa.appNome, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sai da função
                }

                // em vez de dados podia também Empresa.emp[i]
                string msg = "Remover o " + dados.getCargo() + " " + dados.Nome + "?";

                DialogResult res = MessageBox.Show(msg, Empresa.appNome, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                    Empresa.emp.RemoveAt(i);
            }
            else
                MessageBox.Show("Não existem empregados na lista de dados...", Empresa.appNome, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Caso seja eliminado o último da lista, nemhum empregado fica automaticamente selecionado na DataGridView
            // É prerciso, neste caso, selecionar o último da lista
            // Nota: é necessário testra se existem empregado primeiro para não ocorrer caso a lista esteja vazia
            if (dgvDados.Rows.Count > 0 && dgvDados.SelectedRows.Count == 0)
                dgvDados.Rows[dgvDados.Rows.Count - 1].Selected = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Como queremos adicionar um novo empregado, basta indicar null ao empregado
            frmEmpregado form = new frmEmpregado(null);

            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                Empresa.emp.Add(form.Emp);
                MessageBox.Show("Novo empregado adicionado com sucesso", Empresa.appNome, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                btnRemover.PerformClick();  // Vai chamar o método btnRemover_Click(object sender, EventArgs e)
            else if (e.KeyCode == Keys.Enter)
                btnVerEditar.PerformClick();
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnVerEditar.PerformClick();
        }

        private void frmPrincipal_MouseUp(object sender, MouseEventArgs e)
        {
            // Janela de contexto para as operações de eliminar e editar
            // Para implementar
        }
    }
}
