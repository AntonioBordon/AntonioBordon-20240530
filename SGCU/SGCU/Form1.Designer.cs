namespace SGCU
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tab_Cadastro = new System.Windows.Forms.TabControl();
            this.Tab_Cadastro_user = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_idUusario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.ckb_Ativo = new System.Windows.Forms.CheckBox();
            this.list_Usuarios = new System.Windows.Forms.ListBox();
            this.btn_newUser = new System.Windows.Forms.Button();
            this.btn_PesquisarUser = new System.Windows.Forms.Button();
            this.btn_ExcluirUser = new System.Windows.Forms.Button();
            this.Tab_Cadastro_colaborador = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_colaborador = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_unidadeAssociada = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cb_Unidades = new System.Windows.Forms.ComboBox();
            this.lbl_usuarioAssociado = new System.Windows.Forms.Label();
            this.cb_Usuarios = new System.Windows.Forms.ComboBox();
            this.btn_newColaborador = new System.Windows.Forms.Button();
            this.btn_PesquisarColaborador = new System.Windows.Forms.Button();
            this.btn_ExcluirColaborador = new System.Windows.Forms.Button();
            this.Tab_Cadastro_unid = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_unidade = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.lbl_codigoUnidade = new System.Windows.Forms.Label();
            this.lbl_nomeUnidade = new System.Windows.Forms.Label();
            this.ckb_uniadeAtiva = new System.Windows.Forms.CheckBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_newUnidade = new System.Windows.Forms.Button();
            this.btn_PesquisarUnidade = new System.Windows.Forms.Button();
            this.Tab_Cadastro.SuspendLayout();
            this.Tab_Cadastro_user.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Tab_Cadastro_colaborador.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Tab_Cadastro_unid.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Cadastro
            // 
            this.Tab_Cadastro.Controls.Add(this.Tab_Cadastro_user);
            this.Tab_Cadastro.Controls.Add(this.Tab_Cadastro_colaborador);
            this.Tab_Cadastro.Controls.Add(this.Tab_Cadastro_unid);
            this.Tab_Cadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_Cadastro.Location = new System.Drawing.Point(0, 0);
            this.Tab_Cadastro.Name = "Tab_Cadastro";
            this.Tab_Cadastro.SelectedIndex = 0;
            this.Tab_Cadastro.Size = new System.Drawing.Size(800, 450);
            this.Tab_Cadastro.TabIndex = 0;
            // 
            // Tab_Cadastro_user
            // 
            this.Tab_Cadastro_user.Controls.Add(this.tableLayoutPanel1);
            this.Tab_Cadastro_user.Location = new System.Drawing.Point(4, 22);
            this.Tab_Cadastro_user.Name = "Tab_Cadastro_user";
            this.Tab_Cadastro_user.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Cadastro_user.Size = new System.Drawing.Size(792, 424);
            this.Tab_Cadastro_user.TabIndex = 0;
            this.Tab_Cadastro_user.Text = "Usuario";
            this.Tab_Cadastro_user.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_idUusario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_usuario, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_senha, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.ckb_Ativo, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.list_Usuarios, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_newUser, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_PesquisarUser, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_ExcluirUser, 6, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_idUusario
            // 
            this.lbl_idUusario.AutoSize = true;
            this.lbl_idUusario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_idUusario.Location = new System.Drawing.Point(3, 20);
            this.lbl_idUusario.Name = "lbl_idUusario";
            this.lbl_idUusario.Size = new System.Drawing.Size(139, 13);
            this.lbl_idUusario.TabIndex = 0;
            this.lbl_idUusario.Text = "Id Usuario";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(168, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(333, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 3;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_usuario.Location = new System.Drawing.Point(168, 20);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(139, 13);
            this.lbl_usuario.TabIndex = 4;
            this.lbl_usuario.Text = "LOGIN";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_senha.Location = new System.Drawing.Point(333, 20);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(139, 13);
            this.lbl_senha.TabIndex = 5;
            this.lbl_senha.Text = "SENHA";
            // 
            // ckb_Ativo
            // 
            this.ckb_Ativo.AutoSize = true;
            this.ckb_Ativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_Ativo.Location = new System.Drawing.Point(498, 36);
            this.ckb_Ativo.Name = "ckb_Ativo";
            this.ckb_Ativo.Size = new System.Drawing.Size(139, 20);
            this.ckb_Ativo.TabIndex = 6;
            this.ckb_Ativo.Text = "ATIVO";
            this.ckb_Ativo.UseVisualStyleBackColor = true;
            // 
            // list_Usuarios
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.list_Usuarios, 6);
            this.list_Usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_Usuarios.FormattingEnabled = true;
            this.list_Usuarios.Location = new System.Drawing.Point(148, 131);
            this.list_Usuarios.Name = "list_Usuarios";
            this.tableLayoutPanel1.SetRowSpan(this.list_Usuarios, 3);
            this.list_Usuarios.Size = new System.Drawing.Size(489, 264);
            this.list_Usuarios.TabIndex = 7;
            // 
            // btn_newUser
            // 
            this.btn_newUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_newUser.Location = new System.Drawing.Point(168, 82);
            this.btn_newUser.Name = "btn_newUser";
            this.btn_newUser.Size = new System.Drawing.Size(139, 23);
            this.btn_newUser.TabIndex = 8;
            this.btn_newUser.Text = "CADASTRAR / SALVAR";
            this.btn_newUser.UseVisualStyleBackColor = true;
            // 
            // btn_PesquisarUser
            // 
            this.btn_PesquisarUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_PesquisarUser.Location = new System.Drawing.Point(333, 82);
            this.btn_PesquisarUser.Name = "btn_PesquisarUser";
            this.btn_PesquisarUser.Size = new System.Drawing.Size(139, 23);
            this.btn_PesquisarUser.TabIndex = 9;
            this.btn_PesquisarUser.Text = "PESQUISAR";
            this.btn_PesquisarUser.UseVisualStyleBackColor = true;
            // 
            // btn_ExcluirUser
            // 
            this.btn_ExcluirUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ExcluirUser.Location = new System.Drawing.Point(498, 82);
            this.btn_ExcluirUser.Name = "btn_ExcluirUser";
            this.btn_ExcluirUser.Size = new System.Drawing.Size(139, 23);
            this.btn_ExcluirUser.TabIndex = 10;
            this.btn_ExcluirUser.Text = "EXLUIR";
            this.btn_ExcluirUser.UseVisualStyleBackColor = true;
            // 
            // Tab_Cadastro_colaborador
            // 
            this.Tab_Cadastro_colaborador.Controls.Add(this.tableLayoutPanel2);
            this.Tab_Cadastro_colaborador.Location = new System.Drawing.Point(4, 22);
            this.Tab_Cadastro_colaborador.Name = "Tab_Cadastro_colaborador";
            this.Tab_Cadastro_colaborador.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Cadastro_colaborador.Size = new System.Drawing.Size(792, 424);
            this.Tab_Cadastro_colaborador.TabIndex = 1;
            this.Tab_Cadastro_colaborador.Text = "Colaborador";
            this.Tab_Cadastro_colaborador.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_colaborador, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox5, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_nome, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_unidadeAssociada, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.listBox1, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.cb_Unidades, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_usuarioAssociado, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.cb_Usuarios, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_newColaborador, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_PesquisarColaborador, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_ExcluirColaborador, 6, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbl_colaborador
            // 
            this.lbl_colaborador.AutoSize = true;
            this.lbl_colaborador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_colaborador.Location = new System.Drawing.Point(3, 20);
            this.lbl_colaborador.Name = "lbl_colaborador";
            this.lbl_colaborador.Size = new System.Drawing.Size(139, 13);
            this.lbl_colaborador.TabIndex = 0;
            this.lbl_colaborador.Text = "Id Colaborador";
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(3, 36);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(168, 36);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(139, 20);
            this.textBox5.TabIndex = 2;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_nome.Location = new System.Drawing.Point(168, 20);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(139, 13);
            this.lbl_nome.TabIndex = 4;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_unidadeAssociada
            // 
            this.lbl_unidadeAssociada.AutoSize = true;
            this.lbl_unidadeAssociada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_unidadeAssociada.Location = new System.Drawing.Point(333, 20);
            this.lbl_unidadeAssociada.Name = "lbl_unidadeAssociada";
            this.lbl_unidadeAssociada.Size = new System.Drawing.Size(139, 13);
            this.lbl_unidadeAssociada.TabIndex = 5;
            this.lbl_unidadeAssociada.Text = "UNIDADE";
            // 
            // listBox1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.listBox1, 6);
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(148, 132);
            this.listBox1.Name = "listBox1";
            this.tableLayoutPanel2.SetRowSpan(this.listBox1, 3);
            this.listBox1.Size = new System.Drawing.Size(489, 261);
            this.listBox1.TabIndex = 7;
            // 
            // cb_Unidades
            // 
            this.cb_Unidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Unidades.FormattingEnabled = true;
            this.cb_Unidades.Location = new System.Drawing.Point(333, 36);
            this.cb_Unidades.Name = "cb_Unidades";
            this.cb_Unidades.Size = new System.Drawing.Size(139, 21);
            this.cb_Unidades.TabIndex = 8;
            // 
            // lbl_usuarioAssociado
            // 
            this.lbl_usuarioAssociado.AutoSize = true;
            this.lbl_usuarioAssociado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_usuarioAssociado.Location = new System.Drawing.Point(498, 20);
            this.lbl_usuarioAssociado.Name = "lbl_usuarioAssociado";
            this.lbl_usuarioAssociado.Size = new System.Drawing.Size(139, 13);
            this.lbl_usuarioAssociado.TabIndex = 9;
            this.lbl_usuarioAssociado.Text = "USUARIO";
            // 
            // cb_Usuarios
            // 
            this.cb_Usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Usuarios.FormattingEnabled = true;
            this.cb_Usuarios.Location = new System.Drawing.Point(498, 36);
            this.cb_Usuarios.Name = "cb_Usuarios";
            this.cb_Usuarios.Size = new System.Drawing.Size(139, 21);
            this.cb_Usuarios.TabIndex = 10;
            // 
            // btn_newColaborador
            // 
            this.btn_newColaborador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_newColaborador.Location = new System.Drawing.Point(168, 83);
            this.btn_newColaborador.Name = "btn_newColaborador";
            this.btn_newColaborador.Size = new System.Drawing.Size(139, 23);
            this.btn_newColaborador.TabIndex = 11;
            this.btn_newColaborador.Text = "CADASTRAR / SALVAR";
            this.btn_newColaborador.UseVisualStyleBackColor = true;
            // 
            // btn_PesquisarColaborador
            // 
            this.btn_PesquisarColaborador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_PesquisarColaborador.Location = new System.Drawing.Point(333, 83);
            this.btn_PesquisarColaborador.Name = "btn_PesquisarColaborador";
            this.btn_PesquisarColaborador.Size = new System.Drawing.Size(139, 23);
            this.btn_PesquisarColaborador.TabIndex = 12;
            this.btn_PesquisarColaborador.Text = "PESQUISAR";
            this.btn_PesquisarColaborador.UseVisualStyleBackColor = true;
            // 
            // btn_ExcluirColaborador
            // 
            this.btn_ExcluirColaborador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ExcluirColaborador.Location = new System.Drawing.Point(498, 83);
            this.btn_ExcluirColaborador.Name = "btn_ExcluirColaborador";
            this.btn_ExcluirColaborador.Size = new System.Drawing.Size(139, 23);
            this.btn_ExcluirColaborador.TabIndex = 13;
            this.btn_ExcluirColaborador.Text = "EXLUIR";
            this.btn_ExcluirColaborador.UseVisualStyleBackColor = true;
            // 
            // Tab_Cadastro_unid
            // 
            this.Tab_Cadastro_unid.Controls.Add(this.tableLayoutPanel3);
            this.Tab_Cadastro_unid.Location = new System.Drawing.Point(4, 22);
            this.Tab_Cadastro_unid.Name = "Tab_Cadastro_unid";
            this.Tab_Cadastro_unid.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Cadastro_unid.Size = new System.Drawing.Size(792, 424);
            this.Tab_Cadastro_unid.TabIndex = 2;
            this.Tab_Cadastro_unid.Text = "Unidade";
            this.Tab_Cadastro_unid.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_unidade, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox7, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox8, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox9, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_codigoUnidade, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_nomeUnidade, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.ckb_uniadeAtiva, 6, 2);
            this.tableLayoutPanel3.Controls.Add(this.listBox2, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.btn_newUnidade, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.btn_PesquisarUnidade, 4, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lbl_unidade
            // 
            this.lbl_unidade.AutoSize = true;
            this.lbl_unidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_unidade.Location = new System.Drawing.Point(3, 20);
            this.lbl_unidade.Name = "lbl_unidade";
            this.lbl_unidade.Size = new System.Drawing.Size(139, 13);
            this.lbl_unidade.TabIndex = 0;
            this.lbl_unidade.Text = "Id Unidade";
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(3, 36);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(139, 20);
            this.textBox7.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Location = new System.Drawing.Point(168, 36);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(139, 20);
            this.textBox8.TabIndex = 2;
            // 
            // textBox9
            // 
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.Location = new System.Drawing.Point(333, 36);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(139, 20);
            this.textBox9.TabIndex = 3;
            // 
            // lbl_codigoUnidade
            // 
            this.lbl_codigoUnidade.AutoSize = true;
            this.lbl_codigoUnidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_codigoUnidade.Location = new System.Drawing.Point(168, 20);
            this.lbl_codigoUnidade.Name = "lbl_codigoUnidade";
            this.lbl_codigoUnidade.Size = new System.Drawing.Size(139, 13);
            this.lbl_codigoUnidade.TabIndex = 4;
            this.lbl_codigoUnidade.Text = "Codigo Unidade";
            // 
            // lbl_nomeUnidade
            // 
            this.lbl_nomeUnidade.AutoSize = true;
            this.lbl_nomeUnidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_nomeUnidade.Location = new System.Drawing.Point(333, 20);
            this.lbl_nomeUnidade.Name = "lbl_nomeUnidade";
            this.lbl_nomeUnidade.Size = new System.Drawing.Size(139, 13);
            this.lbl_nomeUnidade.TabIndex = 5;
            this.lbl_nomeUnidade.Text = "Unidade";
            // 
            // ckb_uniadeAtiva
            // 
            this.ckb_uniadeAtiva.AutoSize = true;
            this.ckb_uniadeAtiva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_uniadeAtiva.Location = new System.Drawing.Point(498, 36);
            this.ckb_uniadeAtiva.Name = "ckb_uniadeAtiva";
            this.ckb_uniadeAtiva.Size = new System.Drawing.Size(139, 20);
            this.ckb_uniadeAtiva.TabIndex = 6;
            this.ckb_uniadeAtiva.Text = "ATIVO";
            this.ckb_uniadeAtiva.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.listBox2, 6);
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(148, 131);
            this.listBox2.Name = "listBox2";
            this.tableLayoutPanel3.SetRowSpan(this.listBox2, 3);
            this.listBox2.Size = new System.Drawing.Size(489, 264);
            this.listBox2.TabIndex = 7;
            // 
            // btn_newUnidade
            // 
            this.btn_newUnidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_newUnidade.Location = new System.Drawing.Point(168, 82);
            this.btn_newUnidade.Name = "btn_newUnidade";
            this.btn_newUnidade.Size = new System.Drawing.Size(139, 23);
            this.btn_newUnidade.TabIndex = 8;
            this.btn_newUnidade.Text = "CADASTRAR / SALVAR";
            this.btn_newUnidade.UseVisualStyleBackColor = true;
            // 
            // btn_PesquisarUnidade
            // 
            this.btn_PesquisarUnidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_PesquisarUnidade.Location = new System.Drawing.Point(333, 82);
            this.btn_PesquisarUnidade.Name = "btn_PesquisarUnidade";
            this.btn_PesquisarUnidade.Size = new System.Drawing.Size(139, 23);
            this.btn_PesquisarUnidade.TabIndex = 9;
            this.btn_PesquisarUnidade.Text = "PESQUISAR";
            this.btn_PesquisarUnidade.UseVisualStyleBackColor = true;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tab_Cadastro);
            this.Name = "FormCadastro";
            this.Text = "Cadastro";
            this.Tab_Cadastro.ResumeLayout(false);
            this.Tab_Cadastro_user.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Tab_Cadastro_colaborador.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.Tab_Cadastro_unid.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_Cadastro;
        private System.Windows.Forms.TabPage Tab_Cadastro_user;
        private System.Windows.Forms.TabPage Tab_Cadastro_colaborador;
        private System.Windows.Forms.TabPage Tab_Cadastro_unid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_idUusario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.CheckBox ckb_Ativo;
        private System.Windows.Forms.ListBox list_Usuarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_colaborador;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_unidadeAssociada;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_unidade;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lbl_codigoUnidade;
        private System.Windows.Forms.Label lbl_nomeUnidade;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox cb_Unidades;
        private System.Windows.Forms.Label lbl_usuarioAssociado;
        private System.Windows.Forms.ComboBox cb_Usuarios;
        private System.Windows.Forms.CheckBox ckb_uniadeAtiva;
        private System.Windows.Forms.Button btn_newUser;
        private System.Windows.Forms.Button btn_PesquisarUser;
        private System.Windows.Forms.Button btn_ExcluirUser;
        private System.Windows.Forms.Button btn_newColaborador;
        private System.Windows.Forms.Button btn_PesquisarColaborador;
        private System.Windows.Forms.Button btn_ExcluirColaborador;
        private System.Windows.Forms.Button btn_newUnidade;
        private System.Windows.Forms.Button btn_PesquisarUnidade;
    }
}

