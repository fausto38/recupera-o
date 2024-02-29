namespace recuperação
{
    partial class telacadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telacadastro));
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.labelUSUARIO = new System.Windows.Forms.Label();
            this.textBoxNOMEUSUARIO = new System.Windows.Forms.TextBox();
            this.labelCELULAR = new System.Windows.Forms.Label();
            this.textBoxCELULAR = new System.Windows.Forms.TextBox();
            this.labelNIVEL = new System.Windows.Forms.Label();
            this.dataGridViews1 = new System.Windows.Forms.DataGridView();
            this.buttonALTERAR = new System.Windows.Forms.Button();
            this.buttonDELETAR = new System.Windows.Forms.Button();
            this.radioButtonADM = new System.Windows.Forms.RadioButton();
            this.radioButtonCLIENTE = new System.Windows.Forms.RadioButton();
            this.textBoxCADSENHA = new System.Windows.Forms.TextBox();
            this.labelCADSENHA = new System.Windows.Forms.Label();
            this.labelPESQUISAR = new System.Windows.Forms.Label();
            this.textBoxPESQUISA = new System.Windows.Forms.TextBox();
            this.buttonPROCURAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViews1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCADASTRAR.Location = new System.Drawing.Point(41, 378);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCADASTRAR.TabIndex = 2;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = true;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // labelUSUARIO
            // 
            this.labelUSUARIO.AutoSize = true;
            this.labelUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUSUARIO.Location = new System.Drawing.Point(32, 57);
            this.labelUSUARIO.Name = "labelUSUARIO";
            this.labelUSUARIO.Size = new System.Drawing.Size(61, 16);
            this.labelUSUARIO.TabIndex = 4;
            this.labelUSUARIO.Text = "Usuário";
            // 
            // textBoxNOMEUSUARIO
            // 
            this.textBoxNOMEUSUARIO.Location = new System.Drawing.Point(35, 73);
            this.textBoxNOMEUSUARIO.Name = "textBoxNOMEUSUARIO";
            this.textBoxNOMEUSUARIO.Size = new System.Drawing.Size(255, 20);
            this.textBoxNOMEUSUARIO.TabIndex = 3;
            // 
            // labelCELULAR
            // 
            this.labelCELULAR.AutoSize = true;
            this.labelCELULAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCELULAR.Location = new System.Drawing.Point(32, 107);
            this.labelCELULAR.Name = "labelCELULAR";
            this.labelCELULAR.Size = new System.Drawing.Size(56, 16);
            this.labelCELULAR.TabIndex = 6;
            this.labelCELULAR.Text = "Celular";
            // 
            // textBoxCELULAR
            // 
            this.textBoxCELULAR.Location = new System.Drawing.Point(35, 123);
            this.textBoxCELULAR.Name = "textBoxCELULAR";
            this.textBoxCELULAR.Size = new System.Drawing.Size(255, 20);
            this.textBoxCELULAR.TabIndex = 5;
            // 
            // labelNIVEL
            // 
            this.labelNIVEL.AutoSize = true;
            this.labelNIVEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNIVEL.Location = new System.Drawing.Point(32, 221);
            this.labelNIVEL.Name = "labelNIVEL";
            this.labelNIVEL.Size = new System.Drawing.Size(47, 16);
            this.labelNIVEL.TabIndex = 8;
            this.labelNIVEL.Text = "Nivel:";
            // 
            // dataGridViews1
            // 
            this.dataGridViews1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViews1.Location = new System.Drawing.Point(405, 74);
            this.dataGridViews1.Name = "dataGridViews1";
            this.dataGridViews1.Size = new System.Drawing.Size(637, 339);
            this.dataGridViews1.TabIndex = 9;
            this.dataGridViews1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViews1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // buttonALTERAR
            // 
            this.buttonALTERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonALTERAR.Location = new System.Drawing.Point(122, 378);
            this.buttonALTERAR.Name = "buttonALTERAR";
            this.buttonALTERAR.Size = new System.Drawing.Size(75, 23);
            this.buttonALTERAR.TabIndex = 10;
            this.buttonALTERAR.Text = "Alterar";
            this.buttonALTERAR.UseVisualStyleBackColor = true;
            this.buttonALTERAR.Click += new System.EventHandler(this.buttonALTERAR_Click);
            // 
            // buttonDELETAR
            // 
            this.buttonDELETAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDELETAR.Location = new System.Drawing.Point(203, 378);
            this.buttonDELETAR.Name = "buttonDELETAR";
            this.buttonDELETAR.Size = new System.Drawing.Size(75, 23);
            this.buttonDELETAR.TabIndex = 11;
            this.buttonDELETAR.Text = "Deletar";
            this.buttonDELETAR.UseVisualStyleBackColor = true;
            this.buttonDELETAR.Click += new System.EventHandler(this.buttonDELETAR_Click);
            // 
            // radioButtonADM
            // 
            this.radioButtonADM.AutoSize = true;
            this.radioButtonADM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonADM.Location = new System.Drawing.Point(38, 248);
            this.radioButtonADM.Name = "radioButtonADM";
            this.radioButtonADM.Size = new System.Drawing.Size(58, 20);
            this.radioButtonADM.TabIndex = 12;
            this.radioButtonADM.TabStop = true;
            this.radioButtonADM.Text = "ADM";
            this.radioButtonADM.UseVisualStyleBackColor = true;
            // 
            // radioButtonCLIENTE
            // 
            this.radioButtonCLIENTE.AutoSize = true;
            this.radioButtonCLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCLIENTE.Location = new System.Drawing.Point(122, 248);
            this.radioButtonCLIENTE.Name = "radioButtonCLIENTE";
            this.radioButtonCLIENTE.Size = new System.Drawing.Size(73, 20);
            this.radioButtonCLIENTE.TabIndex = 13;
            this.radioButtonCLIENTE.TabStop = true;
            this.radioButtonCLIENTE.Text = "Cliente";
            this.radioButtonCLIENTE.UseVisualStyleBackColor = true;
            // 
            // textBoxCADSENHA
            // 
            this.textBoxCADSENHA.Location = new System.Drawing.Point(36, 178);
            this.textBoxCADSENHA.Name = "textBoxCADSENHA";
            this.textBoxCADSENHA.Size = new System.Drawing.Size(255, 20);
            this.textBoxCADSENHA.TabIndex = 14;
            // 
            // labelCADSENHA
            // 
            this.labelCADSENHA.AutoSize = true;
            this.labelCADSENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCADSENHA.Location = new System.Drawing.Point(35, 159);
            this.labelCADSENHA.Name = "labelCADSENHA";
            this.labelCADSENHA.Size = new System.Drawing.Size(51, 16);
            this.labelCADSENHA.TabIndex = 15;
            this.labelCADSENHA.Text = "Senha";
            // 
            // labelPESQUISAR
            // 
            this.labelPESQUISAR.AutoSize = true;
            this.labelPESQUISAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPESQUISAR.Location = new System.Drawing.Point(405, 36);
            this.labelPESQUISAR.Name = "labelPESQUISAR";
            this.labelPESQUISAR.Size = new System.Drawing.Size(93, 20);
            this.labelPESQUISAR.TabIndex = 16;
            this.labelPESQUISAR.Text = "Pesquisar:";
            // 
            // textBoxPESQUISA
            // 
            this.textBoxPESQUISA.Location = new System.Drawing.Point(504, 36);
            this.textBoxPESQUISA.Name = "textBoxPESQUISA";
            this.textBoxPESQUISA.Size = new System.Drawing.Size(342, 20);
            this.textBoxPESQUISA.TabIndex = 17;
            // 
            // buttonPROCURAR
            // 
            this.buttonPROCURAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPROCURAR.Location = new System.Drawing.Point(885, 33);
            this.buttonPROCURAR.Name = "buttonPROCURAR";
            this.buttonPROCURAR.Size = new System.Drawing.Size(75, 23);
            this.buttonPROCURAR.TabIndex = 18;
            this.buttonPROCURAR.Text = "Procurar";
            this.buttonPROCURAR.UseVisualStyleBackColor = true;
            this.buttonPROCURAR.Click += new System.EventHandler(this.buttonPROCURAR_Click);
            // 
            // telacadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1097, 518);
            this.Controls.Add(this.buttonPROCURAR);
            this.Controls.Add(this.textBoxPESQUISA);
            this.Controls.Add(this.labelPESQUISAR);
            this.Controls.Add(this.labelCADSENHA);
            this.Controls.Add(this.textBoxCADSENHA);
            this.Controls.Add(this.radioButtonCLIENTE);
            this.Controls.Add(this.radioButtonADM);
            this.Controls.Add(this.buttonDELETAR);
            this.Controls.Add(this.buttonALTERAR);
            this.Controls.Add(this.dataGridViews1);
            this.Controls.Add(this.labelNIVEL);
            this.Controls.Add(this.labelCELULAR);
            this.Controls.Add(this.textBoxCELULAR);
            this.Controls.Add(this.labelUSUARIO);
            this.Controls.Add(this.textBoxNOMEUSUARIO);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telacadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViews1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCADASTRAR;
        private System.Windows.Forms.Label labelUSUARIO;
        private System.Windows.Forms.TextBox textBoxNOMEUSUARIO;
        private System.Windows.Forms.Label labelCELULAR;
        private System.Windows.Forms.TextBox textBoxCELULAR;
        private System.Windows.Forms.Label labelNIVEL;
        private System.Windows.Forms.DataGridView dataGridViews1;
        private System.Windows.Forms.Button buttonALTERAR;
        private System.Windows.Forms.Button buttonDELETAR;
        private System.Windows.Forms.RadioButton radioButtonADM;
        private System.Windows.Forms.RadioButton radioButtonCLIENTE;
        private System.Windows.Forms.TextBox textBoxCADSENHA;
        private System.Windows.Forms.Label labelCADSENHA;
        private System.Windows.Forms.Label labelPESQUISAR;
        private System.Windows.Forms.TextBox textBoxPESQUISA;
        private System.Windows.Forms.Button buttonPROCURAR;
    }
}

