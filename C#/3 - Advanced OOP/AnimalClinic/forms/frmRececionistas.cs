using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using MailKit.Net.Smtp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AnimalClinic.forms
{
    public partial class frmRececionistas : Form
    {
        private event EventHandler UserLogadoAlterado;

        private Rececionista UserLogado { get; set; }

        public frmRececionistas()
        {
            InitializeComponent();
            UserLogadoAlterado += userlogadoalterado;

            // Configurações DataGridView Consultas
            dgvConsultas.DataSource = Clinica.consultalist;
            dgvConsultas.Columns["Animal"].Visible = false;
            dgvConsultas.Columns["Medico"].Visible = false;
            dgvConsultas.Columns["DataeHora"].HeaderText = "Data e hora";
            dgvConsultas.Columns["NomeMedico"].HeaderText = "Medico";
            dgvConsultas.Columns["IDAnimal"].HeaderText = "Animal ID";
            dgvConsultas.Columns["NomeAnimal"].HeaderText = "Animal";
            dgvConsultas.Columns["NomeDono"].HeaderText = "Tutor";
            dgvConsultas.Columns["NICDono"].HeaderText = "NIC";
        }

        public void LoadTema()
        {
            dgvConsultas.DefaultCellStyle.SelectionBackColor = Cores.CorDefenida;
            if (!MainForm.IconAtual)
            {
                if (MainForm.TemaAtual)
                    btnEmail.Image = Properties.Resources.email_black;
                else
                    btnEmail.Image = Properties.Resources.email_white;
            }
            btnRemover.BackColor = Cores.CorDefenida;
            btnNovo.BackColor = Cores.CorDefenida;
            lblConsultas.ForeColor = Cores.CorDefenida;
            lblCaixaEntrada.ForeColor = Cores.CorDefenida;
            lblAssunto.ForeColor = Cores.CorDefenida;
            lblRemetente.ForeColor = Cores.CorDefenida;
            grpbxDetalhes.ForeColor = Cores.CorDefenida;
            btnMessage.BackColor = Cores.CorDefenida;
            if (MainForm.TemaAtual)
            {
                BackColor = Color.Gainsboro;
                dgvConsultas.BackgroundColor = Color.FromArgb(201, 201, 201);
                dgvConsultas.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvConsultas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                txtAssunto.BackColor = Color.FromArgb(229, 230, 220);
                txtDestinatario.BackColor = Color.FromArgb(229, 230, 220);
                txtCorpo.BackColor = Color.FromArgb(229, 230, 220);
                txtpassword.BackColor = Color.FromArgb(229, 230, 220);
                cmbNICs.BackColor = Color.FromArgb(229, 230, 220);
                txtAssunto.ForeColor = Color.Black;
                txtDestinatario.ForeColor = Color.Black;
                txtCorpo.ForeColor = Color.Black;
                txtpassword.ForeColor = Color.Black;
                cmbNICs.ForeColor = Color.Black;
                lblNICs.ForeColor = Color.Black;
                lblPassword.ForeColor = Color.Black;
            }
            else
            {
                BackColor = Color.FromArgb(46, 50, 58);
                dgvConsultas.BackgroundColor = Color.FromArgb(72, 76, 82);
                dgvConsultas.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgvConsultas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                txtAssunto.BackColor = Color.FromArgb(61, 66, 77);
                txtDestinatario.BackColor = Color.FromArgb(61, 66, 77);
                txtCorpo.BackColor = Color.FromArgb(61, 66, 77);
                txtpassword.BackColor = Color.FromArgb(61, 66, 77);
                cmbNICs.BackColor = Color.FromArgb(61, 66, 77);
                txtAssunto.ForeColor = Color.White;
                txtDestinatario.ForeColor = Color.White;
                txtCorpo.ForeColor = Color.White;
                txtpassword.ForeColor = Color.White;
                cmbNICs.ForeColor = Color.White;
                lblNICs.ForeColor = Color.White;
                lblPassword.ForeColor = Color.White;
            }
        }

        public void LoadIcons()
        {
            if (btnEmail.Image != Properties.Resources.de_volta)
            {
                if (MainForm.IconAtual)
                    btnEmail.Image = Properties.Resources.email_color;
                else
                {
                    if (MainForm.TemaAtual)
                        btnEmail.Image = Properties.Resources.email_black;
                    else
                        btnEmail.Image = Properties.Resources.email_white;
                }
            }
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            Rececionista logado = Clinica.ObterRececionistabtNIC(cmbNICs.Text);
            if (logado.Email != "(Por defenir)")
            {
                picbxLoading.Visible = true;
                try
                {
                    using (var client = new ImapClient())
                    {
                        // Conecta ao servidor de e-mail
                        client.Connect("imap.gmail.com", 993, true); // Restrição do programa ao gmail...

                        // Autentica com as credenciais do usuário
                        client.Authenticate(logado.Email, txtpassword.Text);

                        client.Disconnect(true);
                    }
                    UserLogado = logado;
                    UserLogado.Password = txtpassword.Text;
                    UserLogadoAlterado?.Invoke(new object(), EventArgs.Empty);
                }
                catch (System.Net.Sockets.SocketException ex)
                {
                    picbxLoading.Visible = false;
                    MessageBox.Show("Verifique a sua conexão á internet.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MailKit.Security.AuthenticationException ex)
                {
                    if (ex.Message == "Invalid credentials (Failure)")
                    {
                        picbxLoading.Visible = false;
                        MessageBox.Show("As credênciais são inválidas.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Message == "Application-specific password required: https://support.google.com/accounts/answer/185833 (Failure)")
                    {
                        if (logado.Password != null)
                        {
                            try
                            {
                                using (var client = new ImapClient())
                                {
                                    // Conecta ao servidor de e-mail
                                    client.Connect("imap.gmail.com", 993, true); // Restrição do programa ao gmail...

                                    // Autentica com as credenciais do usuário
                                    client.Authenticate(logado.Email, logado.Password);

                                    client.Disconnect(true);
                                }
                                UserLogado = logado;
                                UserLogadoAlterado?.Invoke(new object(), EventArgs.Empty);
                            }
                            catch (Exception)
                            {
                                picbxLoading.Visible = false;
                                DialogResult resultado = MessageBox.Show("Desculpe, mas neste email necessita de criar uma senha de app (Gerir Conta).\nDeseja obter ajuda?", Clinica.appname, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                                if (resultado == DialogResult.Yes)
                                    Process.Start(new ProcessStartInfo("https://support.google.com/accounts/answer/185833") { UseShellExecute = true });
                            }
                        }
                        else
                        {
                            picbxLoading.Visible = false;
                            DialogResult resultado = MessageBox.Show("Desculpe, mas neste email necessita de criar uma senha de app (Gerir Conta).\nDeseja obter ajuda?", Clinica.appname, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (resultado == DialogResult.Yes)
                                Process.Start(new ProcessStartInfo("https://support.google.com/accounts/answer/185833") { UseShellExecute = true });
                        }
                    }
                    else if (ex.Message == "Your account is not enabled for IMAP use. Please visit your Gmail settings page and enable your account for IMAP access. (Failure)")
                    {
                        picbxLoading.Visible = false;
                        MessageBox.Show("Este email não tem Endereçamento IMAP ativado.\nPor favor ative em Definições.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }
            }
            else
            {
                string msg = "O NIC selecionado não possui nenhum email anexado.\nPor favor, contacte um administrador.";
                MessageBox.Show(msg, Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmRececionistacs_Load(object sender, EventArgs e)
        {
            cmbNICs.DataSource = null;
            cmbNICs.DataSource = Clinica.rececionistalist.Select(r => r.NIC).ToList();
            txtpassword.Clear();
            LoadTema();
            LoadIcons();
        }

        private void userlogadoalterado(object sender, EventArgs e)
        {
            picbxLoading.Visible = false;
            if (UserLogado == null)
            {
                lblNICs.Visible = true;
                lblPassword.Visible = true;
                cmbNICs.Visible = true;
                txtpassword.Visible = true;
                txtpassword.Clear();
                btnAutenticar.Visible = true;
                lblStatus.Visible = false;
                tglbtnStatus.Visible = false;
                btnLogout.Visible = false;
                btnMessage.Visible = false;
                dgvConsultas.Visible = false;
                tlp.Visible = false;
                btnEmail.Visible = false;
                lblConsultas.Visible = false;
                flpnlAssuntos.Visible = false;
                pnlEmail.Visible = false;
            }
            else
            {
                tglbtnStatus.Checked = UserLogado.Status;
                lblNICs.Visible = false;
                lblPassword.Visible = false;
                cmbNICs.Visible = false;
                txtpassword.Visible = false;
                btnAutenticar.Visible = false;
                lblStatus.Visible = true;
                tglbtnStatus.Visible = true;
                btnLogout.Visible = true;
                dgvConsultas.Visible = true;
                tlp.Visible = true;
                btnEmail.Visible = true;
                lblConsultas.Visible = true;
                LoadIcons();
            }
        }

        private void cmbNICs_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtpassword.Clear();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserLogado = null;
            UserLogadoAlterado?.Invoke(new object(), EventArgs.Empty);
        }

        private void tglbtnStatus_CheckedChanged_1(object sender, EventArgs e)
        {
            if (tglbtnStatus.Checked)
            {
                lblStatus.Text = "Disponível";
                lblStatus.ForeColor = Color.FromArgb(70, 255, 140);
                UserLogado.Status = true;
            }
            else
            {
                lblStatus.Text = "Ausente";
                lblStatus.ForeColor = Color.FromArgb(255, 150, 100);
                UserLogado.Status = false;
            }
        }

        private void frmRececionistas_VisibleChanged(object sender, EventArgs e)
        {
            LoadTema();
            LoadIcons();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvConsultas.Rows.Count > 0)
            {
                Consulta cnslt = dgvConsultas.CurrentRow.DataBoundItem as Consulta; // Obtem os dados da linha atual
                int i = Clinica.consultalist.IndexOf(cnslt); // retorna -1 quando não encontra o animal
                if (i < 0)
                {
                    MessageBox.Show("Animal não encontrado na lista...", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string msg = "Deseja remover a consulta selecionada?";
                DialogResult resultado = MessageBox.Show(msg, Clinica.appname, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes) // Quando removemos a unica linha visivel na dgv
                {
                    cnslt.Medico.Consultas.Remove(cnslt);
                    cnslt.Animal.Consultas.Remove(cnslt);
                    Clinica.consultalist.RemoveAt(i);
                }
            }
            else
            {
                MessageBox.Show("Não pode remover consultas inexistentes.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmEditConsultas form = new frmEditConsultas();
            form.ShowDialog();
            form.Dispose();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (flpnlAssuntos.Visible)
            {
                btnEmail.Image = null;
                LoadIcons();
                flpnlAssuntos.Visible = false;
                pnlEmail.Visible = false;
                btnMessage.Visible = false;
                dgvConsultas.Visible = true;
                tlp.Visible = true;
                lblConsultas.Visible = true;
            }
            else
            {
                btnEmail.Image = Properties.Resources.de_volta;
                flpnlAssuntos.Visible = true;
                pnlEmail.Visible = true;
                btnMessage.Visible = true;
                dgvConsultas.Visible = false;
                tlp.Visible = false;
                lblConsultas.Visible = false;


                lblCaixaEntrada.Text = "A pensar...";

                using (var client = new ImapClient())
                {
                    // Conecta ao servidor de e-mail
                    client.Connect("imap.gmail.com", 993, true);

                    // Autentica com as credenciais do usuário
                    client.Authenticate(UserLogado.Email, UserLogado.Password);

                    // Abre a caixa de entrada
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    // Filtra as mensagens recebidas nas últimas 24 horas
                    var today = DateTime.Now.Date;
                    var yesterday = today.AddDays(-1);
                    var query = SearchQuery.DeliveredAfter(yesterday);

                    // Busca pelas mensagens que atendem ao filtro
                    var messages = inbox.Search(query);

                    // Processa as mensagens recebidas
                    foreach (var uid in messages)
                    {
                        var message = inbox.GetMessage(uid);

                        // Adiciona o assunto da mensagem à lista de assuntos

                        var btn = new CostumButton();
                        btn.Text = message.Subject+" - "+message.Date.ToString().Substring(0, 16);
                        btn.Font = new Font("Montserrat", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                        btn.BorderRadius = 15;
                        btn.Dock = DockStyle.Top;
                        btn.Size = new Size(btn.Width, 60);
                        btn.Click += (btnSender, btnEvent) =>
                        {
                            txtAssunto.Visible = false;
                            txtDestinatario.Visible = false;
                            txtCorpo.ReadOnly = true;
                            btnMessage.Text = "Nova mensagem";
                            lblAssunto.Text = "Assunto: " + message.Subject;
                            lblRemetente.Text = "Remetente: " + message.From;
                            txtCorpo.Text = message.TextBody;
                        };
                        btn.TextAlign = ContentAlignment.MiddleLeft;
                        flpnlAssuntos.Controls.Add(btn);
                        flpnlAssuntos.Controls.SetChildIndex(btn, 1);
                    }

                    // Desconecta do servidor de e-mail
                    client.Disconnect(true);
                }

                lblCaixaEntrada.Text = "Caixa de Entrada";
            }
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            if (btnMessage.Text == "Enviar")
            {
                if (Pessoa.IsValidEmail(txtDestinatario.Text))
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress(UserLogado.Nome, UserLogado.Email));
                    message.To.Add(new MailboxAddress("", txtDestinatario.Text));
                    message.Subject = txtAssunto.Text;

                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.TextBody = txtCorpo.Text;

                    message.Body = bodyBuilder.ToMessageBody();

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp.gmail.com", 465);

                        client.Authenticate(UserLogado.Email, UserLogado.Password);

                        client.Send(message);
                        client.Disconnect(true);
                    }
                    MessageBox.Show("Email enviado com sucesso", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("O Email do destinatário não é valido.", Clinica.appname, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblAssunto.Text = "Assunto:";
                lblRemetente.Text = "Destinatário: ";
                btnMessage.Text = "Enviar";
                txtAssunto.Visible = true;
                txtDestinatario.Visible = true;
                txtCorpo.Clear();
                txtCorpo.ReadOnly = false;
            }
        }
    }
}