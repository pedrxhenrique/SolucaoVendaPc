namespace VendaPc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbltitulo = new Label();
            lblid = new Label();
            lblCliente = new Label();
            txtID = new TextBox();
            txtCliente = new TextBox();
            lblProcessador = new Label();
            lblPecas = new Label();
            lblmemoria = new Label();
            cbProcessador = new ComboBox();
            cbMemoria = new ComboBox();
            lblPlacaMae = new Label();
            cbPlacaMae = new ComboBox();
            cbHD = new ComboBox();
            lblHD = new Label();
            lblFonte = new Label();
            label6 = new Label();
            lblPlaca = new Label();
            label8 = new Label();
            cbFonte = new ComboBox();
            cbPlacaDeVideo = new ComboBox();
            cbGabinete = new ComboBox();
            cbMonitor = new ComboBox();
            lblCpf = new Label();
            txtCpf = new TextBox();
            lblLoja = new Label();
            cbLoja = new ComboBox();
            gpbPagamento = new GroupBox();
            rbCartao = new RadioButton();
            rbDinheiro = new RadioButton();
            rbPix = new RadioButton();
            label1 = new Label();
            checkSim = new CheckBox();
            checkNao = new CheckBox();
            label2 = new Label();
            cmbParcelas = new ComboBox();
            label3 = new Label();
            gpbPagamento.SuspendLayout();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitulo.Location = new Point(176, 24);
            lbltitulo.Margin = new Padding(4, 0, 4, 0);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(333, 24);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Cadastro Venda de Computador";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(26, 79);
            lblid.Name = "lblid";
            lblid.Size = new Size(113, 18);
            lblid.TabIndex = 1;
            lblid.Text = "ID Funcionário:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(397, 79);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(61, 18);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente:";
            // 
            // txtID
            // 
            txtID.Location = new Point(145, 76);
            txtID.Name = "txtID";
            txtID.Size = new Size(134, 26);
            txtID.TabIndex = 3;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(464, 76);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(181, 26);
            txtCliente.TabIndex = 4;
            // 
            // lblProcessador
            // 
            lblProcessador.AutoSize = true;
            lblProcessador.Location = new Point(26, 239);
            lblProcessador.Name = "lblProcessador";
            lblProcessador.Size = new Size(102, 18);
            lblProcessador.TabIndex = 5;
            lblProcessador.Text = "Processador:";
            // 
            // lblPecas
            // 
            lblPecas.AutoSize = true;
            lblPecas.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPecas.Location = new Point(26, 188);
            lblPecas.Margin = new Padding(4, 0, 4, 0);
            lblPecas.Name = "lblPecas";
            lblPecas.Size = new Size(79, 24);
            lblPecas.TabIndex = 6;
            lblPecas.Text = "Peças:";
            // 
            // lblmemoria
            // 
            lblmemoria.AutoSize = true;
            lblmemoria.Location = new Point(26, 301);
            lblmemoria.Name = "lblmemoria";
            lblmemoria.Size = new Size(113, 18);
            lblmemoria.TabIndex = 7;
            lblmemoria.Text = "Memória RAM:";
            lblmemoria.Click += label2_Click;
            // 
            // cbProcessador
            // 
            cbProcessador.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProcessador.FormattingEnabled = true;
            cbProcessador.Items.AddRange(new object[] { "AMD Ryzen 7 5800X", "AMD Ryzen 9 7950X", "Intel Core I9 13900K", "Intel Core I7 13700" });
            cbProcessador.Location = new Point(145, 231);
            cbProcessador.Name = "cbProcessador";
            cbProcessador.Size = new Size(232, 26);
            cbProcessador.TabIndex = 8;
            // 
            // cbMemoria
            // 
            cbMemoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMemoria.FormattingEnabled = true;
            cbMemoria.Items.AddRange(new object[] { "Corsair Vengeance, 16GB (2x8)", "Kingspec, 16GB (1x16)", "Rise Mode Z, 8GB (1x8)" });
            cbMemoria.Location = new Point(145, 298);
            cbMemoria.Name = "cbMemoria";
            cbMemoria.Size = new Size(232, 26);
            cbMemoria.TabIndex = 9;
            // 
            // lblPlacaMae
            // 
            lblPlacaMae.AutoSize = true;
            lblPlacaMae.Location = new Point(26, 274);
            lblPlacaMae.Name = "lblPlacaMae";
            lblPlacaMae.Size = new Size(88, 18);
            lblPlacaMae.TabIndex = 10;
            lblPlacaMae.Text = "Placa-Mãe:";
            // 
            // cbPlacaMae
            // 
            cbPlacaMae.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPlacaMae.FormattingEnabled = true;
            cbPlacaMae.Items.AddRange(new object[] { "Asus ROG Crosshair X670E", "Asus Rog Crosshair X670E Extreme", "Asus ROG Maximus Z790 Hero", "Gigabyte X299 UD4 PRO" });
            cbPlacaMae.Location = new Point(145, 264);
            cbPlacaMae.Name = "cbPlacaMae";
            cbPlacaMae.Size = new Size(232, 26);
            cbPlacaMae.TabIndex = 11;
            // 
            // cbHD
            // 
            cbHD.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHD.FormattingEnabled = true;
            cbHD.Items.AddRange(new object[] { "SSD 240 GB Kingston", "SSD 960 GB Kingston", "HD Seagate 4TB", "HD Seagate 2TB" });
            cbHD.Location = new Point(475, 264);
            cbHD.Name = "cbHD";
            cbHD.Size = new Size(253, 26);
            cbHD.TabIndex = 12;
            // 
            // lblHD
            // 
            lblHD.AutoSize = true;
            lblHD.Location = new Point(396, 272);
            lblHD.Name = "lblHD";
            lblHD.Size = new Size(73, 18);
            lblHD.TabIndex = 13;
            lblHD.Text = "HD/SSD:";
            // 
            // lblFonte
            // 
            lblFonte.AutoSize = true;
            lblFonte.Location = new Point(396, 239);
            lblFonte.Name = "lblFonte";
            lblFonte.Size = new Size(52, 18);
            lblFonte.TabIndex = 14;
            lblFonte.Text = "Fonte:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(396, 306);
            label6.Name = "label6";
            label6.Size = new Size(76, 18);
            label6.TabIndex = 15;
            label6.Text = "Gabinete:";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(26, 336);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(119, 18);
            lblPlaca.TabIndex = 16;
            lblPlaca.Text = "Placa de Vídeo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(397, 336);
            label8.Name = "label8";
            label8.Size = new Size(64, 18);
            label8.TabIndex = 17;
            label8.Text = "Monitor:";
            // 
            // cbFonte
            // 
            cbFonte.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFonte.FormattingEnabled = true;
            cbFonte.Items.AddRange(new object[] { "Corsair CV650, 650W", "Gamemax, 600W", "MSI MAG A500DN, 500W", "MSI MAG A650BN, 650W" });
            cbFonte.Location = new Point(475, 231);
            cbFonte.Name = "cbFonte";
            cbFonte.Size = new Size(253, 26);
            cbFonte.TabIndex = 18;
            // 
            // cbPlacaDeVideo
            // 
            cbPlacaDeVideo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPlacaDeVideo.FormattingEnabled = true;
            cbPlacaDeVideo.Items.AddRange(new object[] { "RTX 3060, 12GB", "RTX 3050, 8GB", "RTX 2060, 12GB", "GTX 1660 Super, 6GB" });
            cbPlacaDeVideo.Location = new Point(145, 333);
            cbPlacaDeVideo.Name = "cbPlacaDeVideo";
            cbPlacaDeVideo.Size = new Size(232, 26);
            cbPlacaDeVideo.TabIndex = 19;
            // 
            // cbGabinete
            // 
            cbGabinete.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGabinete.FormattingEnabled = true;
            cbGabinete.Items.AddRange(new object[] { "Rise Mode Glass 06X", "Rise Mode Galaxy Glass", "Rise Mode Z1 Glass", "Bluecase Mini Tower" });
            cbGabinete.Location = new Point(475, 298);
            cbGabinete.Name = "cbGabinete";
            cbGabinete.Size = new Size(253, 26);
            cbGabinete.TabIndex = 20;
            // 
            // cbMonitor
            // 
            cbMonitor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMonitor.FormattingEnabled = true;
            cbMonitor.Items.AddRange(new object[] { "LG 34 Ultra Wide Curvo, 160 Hz", "Husky Storm 27' Curvo, 165 Hz", "AOC Hero 23.8, 144 Hz", "Husky Tempest 34', 144 Hz" });
            cbMonitor.Location = new Point(475, 330);
            cbMonitor.Name = "cbMonitor";
            cbMonitor.Size = new Size(253, 26);
            cbMonitor.TabIndex = 21;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(397, 119);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(45, 18);
            lblCpf.TabIndex = 22;
            lblCpf.Text = "CPF:";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(464, 113);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(181, 26);
            txtCpf.TabIndex = 23;
            // 
            // lblLoja
            // 
            lblLoja.AutoSize = true;
            lblLoja.Location = new Point(26, 121);
            lblLoja.Name = "lblLoja";
            lblLoja.Size = new Size(42, 18);
            lblLoja.TabIndex = 24;
            lblLoja.Text = "Loja:";
            // 
            // cbLoja
            // 
            cbLoja.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoja.FormattingEnabled = true;
            cbLoja.Items.AddRange(new object[] { "Shopping Da Ilha", "Shopping Rio Anil", "Shopping São Luís", "Filial Centro", "Filial Cohab" });
            cbLoja.Location = new Point(74, 113);
            cbLoja.Name = "cbLoja";
            cbLoja.Size = new Size(205, 26);
            cbLoja.TabIndex = 25;
            // 
            // gpbPagamento
            // 
            gpbPagamento.Controls.Add(rbCartao);
            gpbPagamento.Controls.Add(rbDinheiro);
            gpbPagamento.Controls.Add(rbPix);
            gpbPagamento.Location = new Point(228, 401);
            gpbPagamento.Name = "gpbPagamento";
            gpbPagamento.Size = new Size(253, 100);
            gpbPagamento.TabIndex = 26;
            gpbPagamento.TabStop = false;
            gpbPagamento.Text = "Forma de Pagamento";
            // 
            // rbCartao
            // 
            rbCartao.AutoSize = true;
            rbCartao.Location = new Point(162, 39);
            rbCartao.Name = "rbCartao";
            rbCartao.Size = new Size(74, 22);
            rbCartao.TabIndex = 2;
            rbCartao.TabStop = true;
            rbCartao.Text = "Cartão";
            rbCartao.UseVisualStyleBackColor = true;
            // 
            // rbDinheiro
            // 
            rbDinheiro.AutoSize = true;
            rbDinheiro.Location = new Point(71, 39);
            rbDinheiro.Name = "rbDinheiro";
            rbDinheiro.Size = new Size(85, 22);
            rbDinheiro.TabIndex = 1;
            rbDinheiro.TabStop = true;
            rbDinheiro.Text = "Dinheiro";
            rbDinheiro.UseVisualStyleBackColor = true;
            // 
            // rbPix
            // 
            rbPix.AutoSize = true;
            rbPix.Location = new Point(17, 39);
            rbPix.Name = "rbPix";
            rbPix.Size = new Size(48, 22);
            rbPix.TabIndex = 0;
            rbPix.TabStop = true;
            rbPix.Text = "Pix";
            rbPix.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 401);
            label1.Name = "label1";
            label1.Size = new Size(173, 18);
            label1.TabIndex = 27;
            label1.Text = "Montagem a Domicílio?";
            // 
            // checkSim
            // 
            checkSim.AutoSize = true;
            checkSim.Location = new Point(26, 431);
            checkSim.Name = "checkSim";
            checkSim.Size = new Size(55, 22);
            checkSim.TabIndex = 28;
            checkSim.Text = "Sim";
            checkSim.UseVisualStyleBackColor = true;
            // 
            // checkNao
            // 
            checkNao.AutoSize = true;
            checkNao.Location = new Point(89, 431);
            checkNao.Name = "checkNao";
            checkNao.Size = new Size(56, 22);
            checkNao.TabIndex = 29;
            checkNao.Text = "Não";
            checkNao.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(497, 401);
            label2.Name = "label2";
            label2.Size = new Size(74, 18);
            label2.TabIndex = 30;
            label2.Text = "Parcelas:";
            // 
            // cmbParcelas
            // 
            cmbParcelas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParcelas.FormattingEnabled = true;
            cmbParcelas.Items.AddRange(new object[] { "2x Sem Juros", "4x Sem Juros", "6x Com Juros", "10x Com Juros" });
            cmbParcelas.Location = new Point(497, 427);
            cmbParcelas.Name = "cmbParcelas";
            cmbParcelas.Size = new Size(217, 26);
            cmbParcelas.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 547);
            label3.Name = "label3";
            label3.Size = new Size(60, 24);
            label3.TabIndex = 32;
            label3.Text = "Total:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 620);
            Controls.Add(label3);
            Controls.Add(cmbParcelas);
            Controls.Add(label2);
            Controls.Add(checkNao);
            Controls.Add(checkSim);
            Controls.Add(label1);
            Controls.Add(gpbPagamento);
            Controls.Add(cbLoja);
            Controls.Add(lblLoja);
            Controls.Add(txtCpf);
            Controls.Add(lblCpf);
            Controls.Add(cbMonitor);
            Controls.Add(cbGabinete);
            Controls.Add(cbPlacaDeVideo);
            Controls.Add(cbFonte);
            Controls.Add(label8);
            Controls.Add(lblPlaca);
            Controls.Add(label6);
            Controls.Add(lblFonte);
            Controls.Add(lblHD);
            Controls.Add(cbHD);
            Controls.Add(cbPlacaMae);
            Controls.Add(lblPlacaMae);
            Controls.Add(cbMemoria);
            Controls.Add(cbProcessador);
            Controls.Add(lblmemoria);
            Controls.Add(lblPecas);
            Controls.Add(lblProcessador);
            Controls.Add(txtCliente);
            Controls.Add(txtID);
            Controls.Add(lblCliente);
            Controls.Add(lblid);
            Controls.Add(lbltitulo);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Cadastro de Venda";
            gpbPagamento.ResumeLayout(false);
            gpbPagamento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Label lblid;
        private Label lblCliente;
        private TextBox txtID;
        private TextBox txtCliente;
        private Label lblProcessador;
        private Label lblPecas;
        private Label lblmemoria;
        private ComboBox cbProcessador;
        private ComboBox cbMemoria;
        private Label lblPlacaMae;
        private ComboBox cbPlacaMae;
        private ComboBox cbHD;
        private Label lblHD;
        private Label lblFonte;
        private Label label6;
        private Label lblPlaca;
        private Label label8;
        private ComboBox cbFonte;
        private ComboBox cbPlacaDeVideo;
        private ComboBox cbGabinete;
        private ComboBox cbMonitor;
        private Label lblCpf;
        private TextBox txtCpf;
        private Label lblLoja;
        private ComboBox cbLoja;
        private GroupBox gpbPagamento;
        private RadioButton rbCartao;
        private RadioButton rbDinheiro;
        private RadioButton rbPix;
        private Label label1;
        private CheckBox checkSim;
        private CheckBox checkNao;
        private Label label2;
        private ComboBox cmbParcelas;
        private Label label3;
    }
}