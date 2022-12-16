namespace ricerca_operativa
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_calcola = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_algorithm = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_aggiorna = new System.Windows.Forms.Button();
            this.btn_riempi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_instab = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_righe = new System.Windows.Forms.NumericUpDown();
            this.nud_colonne = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tc_layout = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_nord_ovest = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_Min = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgv_voghel = new System.Windows.Forms.DataGridView();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_righe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_colonne)).BeginInit();
            this.panel2.SuspendLayout();
            this.tc_layout.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nord_ovest)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Min)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_voghel)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 142);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_calcola);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cb_algorithm);
            this.groupBox3.Location = new System.Drawing.Point(513, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 106);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calcola Costo";
            // 
            // btn_calcola
            // 
            this.btn_calcola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcola.Location = new System.Drawing.Point(198, 36);
            this.btn_calcola.Name = "btn_calcola";
            this.btn_calcola.Size = new System.Drawing.Size(88, 44);
            this.btn_calcola.TabIndex = 6;
            this.btn_calcola.Text = "CALCOLA";
            this.btn_calcola.UseVisualStyleBackColor = true;
            this.btn_calcola.Click += new System.EventHandler(this.btn_calcola_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Algoritmo";
            // 
            // cb_algorithm
            // 
            this.cb_algorithm.FormattingEnabled = true;
            this.cb_algorithm.Items.AddRange(new object[] {
            "Nord-Ovest",
            "Minimi Costi",
            "Vogel"});
            this.cb_algorithm.Location = new System.Drawing.Point(76, 50);
            this.cb_algorithm.Name = "cb_algorithm";
            this.cb_algorithm.Size = new System.Drawing.Size(116, 21);
            this.cb_algorithm.TabIndex = 0;
            this.cb_algorithm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_algorithm_KeyDown);
            this.cb_algorithm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_algorithm_KeyPress);
            this.cb_algorithm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cb_algorithm_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_aggiorna);
            this.groupBox2.Controls.Add(this.btn_riempi);
            this.groupBox2.Location = new System.Drawing.Point(352, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 106);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matrice Random";
            // 
            // btn_aggiorna
            // 
            this.btn_aggiorna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aggiorna.Location = new System.Drawing.Point(6, 59);
            this.btn_aggiorna.Name = "btn_aggiorna";
            this.btn_aggiorna.Size = new System.Drawing.Size(128, 34);
            this.btn_aggiorna.TabIndex = 6;
            this.btn_aggiorna.Text = "Aggiorna Matrice";
            this.btn_aggiorna.UseVisualStyleBackColor = true;
            this.btn_aggiorna.Click += new System.EventHandler(this.btn_aggiorna_Click);
            // 
            // btn_riempi
            // 
            this.btn_riempi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_riempi.Location = new System.Drawing.Point(6, 19);
            this.btn_riempi.Name = "btn_riempi";
            this.btn_riempi.Size = new System.Drawing.Size(128, 34);
            this.btn_riempi.TabIndex = 5;
            this.btn_riempi.Text = "Riempi Matrice";
            this.btn_riempi.UseVisualStyleBackColor = true;
            this.btn_riempi.Click += new System.EventHandler(this.btn_riempi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_instab);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nud_righe);
            this.groupBox1.Controls.Add(this.nud_colonne);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impostazione Tabella";
            // 
            // btn_instab
            // 
            this.btn_instab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_instab.Location = new System.Drawing.Point(228, 36);
            this.btn_instab.Name = "btn_instab";
            this.btn_instab.Size = new System.Drawing.Size(92, 44);
            this.btn_instab.TabIndex = 4;
            this.btn_instab.Text = "INSERISCI";
            this.btn_instab.UseVisualStyleBackColor = true;
            this.btn_instab.Click += new System.EventHandler(this.btn_instab_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero Unità\r\n   produttive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero Destinazioni";
            // 
            // nud_righe
            // 
            this.nud_righe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_righe.Location = new System.Drawing.Point(137, 69);
            this.nud_righe.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_righe.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_righe.Name = "nud_righe";
            this.nud_righe.Size = new System.Drawing.Size(73, 24);
            this.nud_righe.TabIndex = 1;
            this.nud_righe.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nud_colonne
            // 
            this.nud_colonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_colonne.Location = new System.Drawing.Point(137, 32);
            this.nud_colonne.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_colonne.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_colonne.Name = "nud_colonne";
            this.nud_colonne.Size = new System.Drawing.Size(73, 24);
            this.nud_colonne.TabIndex = 0;
            this.nud_colonne.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tc_layout);
            this.panel2.Location = new System.Drawing.Point(1, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 380);
            this.panel2.TabIndex = 1;
            // 
            // tc_layout
            // 
            this.tc_layout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_layout.Controls.Add(this.tabPage1);
            this.tc_layout.Controls.Add(this.tabPage2);
            this.tc_layout.Controls.Add(this.tabPage3);
            this.tc_layout.Controls.Add(this.tabPage4);
            this.tc_layout.Location = new System.Drawing.Point(0, 0);
            this.tc_layout.Name = "tc_layout";
            this.tc_layout.SelectedIndex = 0;
            this.tc_layout.Size = new System.Drawing.Size(808, 380);
            this.tc_layout.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(800, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Matrice Base";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(-1, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(798, 361);
            this.dgv.TabIndex = 0;
            this.dgv.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_CellValidating);
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            this.dgv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Grid_EditingControlShowing);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_nord_ovest);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(800, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nord-ovest";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_nord_ovest
            // 
            this.dgv_nord_ovest.AllowUserToAddRows = false;
            this.dgv_nord_ovest.AllowUserToDeleteRows = false;
            this.dgv_nord_ovest.AllowUserToResizeColumns = false;
            this.dgv_nord_ovest.AllowUserToResizeRows = false;
            this.dgv_nord_ovest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_nord_ovest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nord_ovest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nord_ovest.Location = new System.Drawing.Point(1, -3);
            this.dgv_nord_ovest.Name = "dgv_nord_ovest";
            this.dgv_nord_ovest.RowHeadersVisible = false;
            this.dgv_nord_ovest.RowHeadersWidth = 51;
            this.dgv_nord_ovest.Size = new System.Drawing.Size(798, 361);
            this.dgv_nord_ovest.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_Min);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(800, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Minimi-Costi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_Min
            // 
            this.dgv_Min.AllowUserToAddRows = false;
            this.dgv_Min.AllowUserToDeleteRows = false;
            this.dgv_Min.AllowUserToResizeColumns = false;
            this.dgv_Min.AllowUserToResizeRows = false;
            this.dgv_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Min.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Min.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Min.Location = new System.Drawing.Point(1, -3);
            this.dgv_Min.Name = "dgv_Min";
            this.dgv_Min.RowHeadersVisible = false;
            this.dgv_Min.RowHeadersWidth = 51;
            this.dgv_Min.Size = new System.Drawing.Size(798, 361);
            this.dgv_Min.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgv_voghel);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(800, 354);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vogel";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgv_voghel
            // 
            this.dgv_voghel.AllowUserToAddRows = false;
            this.dgv_voghel.AllowUserToDeleteRows = false;
            this.dgv_voghel.AllowUserToResizeColumns = false;
            this.dgv_voghel.AllowUserToResizeRows = false;
            this.dgv_voghel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_voghel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_voghel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_voghel.Location = new System.Drawing.Point(1, -3);
            this.dgv_voghel.Name = "dgv_voghel";
            this.dgv_voghel.RowHeadersVisible = false;
            this.dgv_voghel.RowHeadersWidth = 51;
            this.dgv_voghel.Size = new System.Drawing.Size(798, 361);
            this.dgv_voghel.TabIndex = 1;
            // 
            // rtb_output
            // 
            this.rtb_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_output.Location = new System.Drawing.Point(4, 7);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(273, 485);
            this.rtb_output.TabIndex = 2;
            this.rtb_output.Text = "";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.rtb_output);
            this.panel3.Location = new System.Drawing.Point(811, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 494);
            this.panel3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1093, 514);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_righe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_colonne)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tc_layout.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nord_ovest)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Min)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_voghel)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_instab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_righe;
        private System.Windows.Forms.NumericUpDown nud_colonne;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_riempi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_calcola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_algorithm;
        private System.Windows.Forms.RichTextBox rtb_output;
        private System.Windows.Forms.TabControl tc_layout;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_nord_ovest;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_Min;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgv_voghel;
        private System.Windows.Forms.Button btn_aggiorna;
        private System.Windows.Forms.Panel panel3;
    }
}

