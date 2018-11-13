namespace DashboardAccidentes.Vista
{
    partial class FormConsultaDinamica
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
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Mi Busqueda", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMenuGroup_distritos = new System.Windows.Forms.Panel();
            this.checkedListBox_distritos = new System.Windows.Forms.CheckedListBox();
            this.btn_distritos = new System.Windows.Forms.Button();
            this.pnlMenuGroup_cantones = new System.Windows.Forms.Panel();
            this.checkedListBox_cantones = new System.Windows.Forms.CheckedListBox();
            this.btn_cantones = new System.Windows.Forms.Button();
            this.pnlMenuGroup_provincias = new System.Windows.Forms.Panel();
            this.checkedListBox_provincias = new System.Windows.Forms.CheckedListBox();
            this.btn_provincias = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_fechaInicial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_anios = new System.Windows.Forms.Panel();
            this.comboBox_fechaFinal = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_indicadores = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_valorIndicador = new System.Windows.Forms.ComboBox();
            this.comboBox_indicador = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_mi_busqueda = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columna_indicador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna_valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_consultar = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlMenuGroup_distritos.SuspendLayout();
            this.pnlMenuGroup_cantones.SuspendLayout();
            this.pnlMenuGroup_provincias.SuspendLayout();
            this.panel_anios.SuspendLayout();
            this.panel_indicadores.SuspendLayout();
            this.panel_mi_busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta Dinámica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(719, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selectores";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.pnlMenuGroup_distritos);
            this.pnlMenu.Controls.Add(this.pnlMenuGroup_cantones);
            this.pnlMenu.Controls.Add(this.pnlMenuGroup_provincias);
            this.pnlMenu.Location = new System.Drawing.Point(723, 61);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(261, 411);
            this.pnlMenu.TabIndex = 9;
            // 
            // pnlMenuGroup_distritos
            // 
            this.pnlMenuGroup_distritos.Controls.Add(this.checkedListBox_distritos);
            this.pnlMenuGroup_distritos.Controls.Add(this.btn_distritos);
            this.pnlMenuGroup_distritos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuGroup_distritos.Location = new System.Drawing.Point(0, 270);
            this.pnlMenuGroup_distritos.Name = "pnlMenuGroup_distritos";
            this.pnlMenuGroup_distritos.Size = new System.Drawing.Size(261, 135);
            this.pnlMenuGroup_distritos.TabIndex = 4;
            // 
            // checkedListBox_distritos
            // 
            this.checkedListBox_distritos.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBox_distritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_distritos.FormattingEnabled = true;
            this.checkedListBox_distritos.Location = new System.Drawing.Point(0, 25);
            this.checkedListBox_distritos.Name = "checkedListBox_distritos";
            this.checkedListBox_distritos.Size = new System.Drawing.Size(261, 106);
            this.checkedListBox_distritos.TabIndex = 1;
            this.checkedListBox_distritos.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_distritos_SelectedIndexChanged);
            // 
            // btn_distritos
            // 
            this.btn_distritos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_distritos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_distritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_distritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_distritos.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_distritos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_distritos.Location = new System.Drawing.Point(0, 0);
            this.btn_distritos.Name = "btn_distritos";
            this.btn_distritos.Size = new System.Drawing.Size(261, 25);
            this.btn_distritos.TabIndex = 0;
            this.btn_distritos.Text = "Distritos";
            this.btn_distritos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_distritos.UseVisualStyleBackColor = false;
            this.btn_distritos.Click += new System.EventHandler(this.btn_distritos_Click);
            // 
            // pnlMenuGroup_cantones
            // 
            this.pnlMenuGroup_cantones.Controls.Add(this.checkedListBox_cantones);
            this.pnlMenuGroup_cantones.Controls.Add(this.btn_cantones);
            this.pnlMenuGroup_cantones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuGroup_cantones.Location = new System.Drawing.Point(0, 134);
            this.pnlMenuGroup_cantones.Name = "pnlMenuGroup_cantones";
            this.pnlMenuGroup_cantones.Size = new System.Drawing.Size(261, 136);
            this.pnlMenuGroup_cantones.TabIndex = 3;
            // 
            // checkedListBox_cantones
            // 
            this.checkedListBox_cantones.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBox_cantones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_cantones.FormattingEnabled = true;
            this.checkedListBox_cantones.Location = new System.Drawing.Point(0, 25);
            this.checkedListBox_cantones.Name = "checkedListBox_cantones";
            this.checkedListBox_cantones.Size = new System.Drawing.Size(261, 106);
            this.checkedListBox_cantones.TabIndex = 5;
            this.checkedListBox_cantones.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_cantones_SelectedIndexChanged);
            // 
            // btn_cantones
            // 
            this.btn_cantones.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_cantones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cantones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cantones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cantones.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cantones.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cantones.Location = new System.Drawing.Point(0, 0);
            this.btn_cantones.Name = "btn_cantones";
            this.btn_cantones.Size = new System.Drawing.Size(261, 25);
            this.btn_cantones.TabIndex = 0;
            this.btn_cantones.Text = "Cantones";
            this.btn_cantones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cantones.UseVisualStyleBackColor = false;
            this.btn_cantones.Click += new System.EventHandler(this.btn_cantones_Click);
            // 
            // pnlMenuGroup_provincias
            // 
            this.pnlMenuGroup_provincias.Controls.Add(this.checkedListBox_provincias);
            this.pnlMenuGroup_provincias.Controls.Add(this.btn_provincias);
            this.pnlMenuGroup_provincias.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuGroup_provincias.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuGroup_provincias.Name = "pnlMenuGroup_provincias";
            this.pnlMenuGroup_provincias.Size = new System.Drawing.Size(261, 134);
            this.pnlMenuGroup_provincias.TabIndex = 0;
            // 
            // checkedListBox_provincias
            // 
            this.checkedListBox_provincias.CheckOnClick = true;
            this.checkedListBox_provincias.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBox_provincias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_provincias.FormattingEnabled = true;
            this.checkedListBox_provincias.Location = new System.Drawing.Point(0, 25);
            this.checkedListBox_provincias.Name = "checkedListBox_provincias";
            this.checkedListBox_provincias.Size = new System.Drawing.Size(261, 106);
            this.checkedListBox_provincias.TabIndex = 10;
            this.checkedListBox_provincias.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_provincias_SelectedIndexChanged);
            // 
            // btn_provincias
            // 
            this.btn_provincias.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_provincias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_provincias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_provincias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_provincias.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_provincias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_provincias.Location = new System.Drawing.Point(0, 0);
            this.btn_provincias.Name = "btn_provincias";
            this.btn_provincias.Size = new System.Drawing.Size(261, 25);
            this.btn_provincias.TabIndex = 0;
            this.btn_provincias.Text = "Provincias";
            this.btn_provincias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_provincias.UseVisualStyleBackColor = false;
            this.btn_provincias.Click += new System.EventHandler(this.btn_provincias_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Final:";
            // 
            // comboBox_fechaInicial
            // 
            this.comboBox_fechaInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_fechaInicial.FormattingEnabled = true;
            this.comboBox_fechaInicial.Location = new System.Drawing.Point(50, 29);
            this.comboBox_fechaInicial.Name = "comboBox_fechaInicial";
            this.comboBox_fechaInicial.Size = new System.Drawing.Size(74, 24);
            this.comboBox_fechaInicial.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Años";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_anios
            // 
            this.panel_anios.Controls.Add(this.comboBox_fechaFinal);
            this.panel_anios.Controls.Add(this.label5);
            this.panel_anios.Controls.Add(this.label3);
            this.panel_anios.Controls.Add(this.comboBox_fechaInicial);
            this.panel_anios.Controls.Add(this.label4);
            this.panel_anios.Location = new System.Drawing.Point(723, 170);
            this.panel_anios.Name = "panel_anios";
            this.panel_anios.Size = new System.Drawing.Size(261, 59);
            this.panel_anios.TabIndex = 15;
            // 
            // comboBox_fechaFinal
            // 
            this.comboBox_fechaFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_fechaFinal.FormattingEnabled = true;
            this.comboBox_fechaFinal.Location = new System.Drawing.Point(179, 29);
            this.comboBox_fechaFinal.Name = "comboBox_fechaFinal";
            this.comboBox_fechaFinal.Size = new System.Drawing.Size(74, 24);
            this.comboBox_fechaFinal.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Indicadores";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_indicadores
            // 
            this.panel_indicadores.Controls.Add(this.button1);
            this.panel_indicadores.Controls.Add(this.comboBox_valorIndicador);
            this.panel_indicadores.Controls.Add(this.comboBox_indicador);
            this.panel_indicadores.Controls.Add(this.label8);
            this.panel_indicadores.Controls.Add(this.label7);
            this.panel_indicadores.Controls.Add(this.label6);
            this.panel_indicadores.Location = new System.Drawing.Point(723, 253);
            this.panel_indicadores.Name = "panel_indicadores";
            this.panel_indicadores.Size = new System.Drawing.Size(261, 78);
            this.panel_indicadores.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.BackgroundImage = global::DashboardAccidentes.Properties.Resources.plus_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(233, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox_valorIndicador
            // 
            this.comboBox_valorIndicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_valorIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_valorIndicador.FormattingEnabled = true;
            this.comboBox_valorIndicador.Items.AddRange(new object[] {
            "asd",
            "asd",
            "asd",
            "asd",
            "axd",
            "zxc",
            "zxc"});
            this.comboBox_valorIndicador.Location = new System.Drawing.Point(154, 49);
            this.comboBox_valorIndicador.Name = "comboBox_valorIndicador";
            this.comboBox_valorIndicador.Size = new System.Drawing.Size(104, 24);
            this.comboBox_valorIndicador.TabIndex = 20;
            // 
            // comboBox_indicador
            // 
            this.comboBox_indicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_indicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_indicador.FormattingEnabled = true;
            this.comboBox_indicador.Location = new System.Drawing.Point(3, 49);
            this.comboBox_indicador.Name = "comboBox_indicador";
            this.comboBox_indicador.Size = new System.Drawing.Size(129, 24);
            this.comboBox_indicador.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(151, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Indicador";
            // 
            // panel_mi_busqueda
            // 
            this.panel_mi_busqueda.Controls.Add(this.listView1);
            this.panel_mi_busqueda.Location = new System.Drawing.Point(723, 356);
            this.panel_mi_busqueda.Name = "panel_mi_busqueda";
            this.panel_mi_busqueda.Size = new System.Drawing.Size(261, 174);
            this.panel_mi_busqueda.TabIndex = 18;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columna_indicador,
            this.columna_valor});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup4.Header = "Mi Busqueda";
            listViewGroup4.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup4.Name = "Mi Busqueda";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4});
            listViewItem4.Group = listViewGroup4;
            listViewItem4.Tag = "";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(0, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(261, 168);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columna_indicador
            // 
            this.columna_indicador.Text = "Indicador";
            this.columna_indicador.Width = 152;
            // 
            // columna_valor
            // 
            this.columna_valor.Text = "Valor";
            this.columna_valor.Width = 104;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_consultar.Location = new System.Drawing.Point(723, 546);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(261, 35);
            this.btn_consultar.TabIndex = 19;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            // 
            // FormConsultaDinamica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 631);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.panel_mi_busqueda);
            this.Controls.Add(this.panel_indicadores);
            this.Controls.Add(this.panel_anios);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormConsultaDinamica";
            this.Text = "Consulta dinámica de indicadores";
            this.Load += new System.EventHandler(this.FormConsultaDinamica_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenuGroup_distritos.ResumeLayout(false);
            this.pnlMenuGroup_cantones.ResumeLayout(false);
            this.pnlMenuGroup_provincias.ResumeLayout(false);
            this.panel_anios.ResumeLayout(false);
            this.panel_anios.PerformLayout();
            this.panel_indicadores.ResumeLayout(false);
            this.panel_indicadores.PerformLayout();
            this.panel_mi_busqueda.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btn_cantones;
        private System.Windows.Forms.Panel pnlMenuGroup_cantones;
        private System.Windows.Forms.Panel pnlMenuGroup_provincias;
        private System.Windows.Forms.Button btn_provincias;
        private System.Windows.Forms.CheckedListBox checkedListBox_provincias;
        private System.Windows.Forms.CheckedListBox checkedListBox_cantones;
        private System.Windows.Forms.Panel pnlMenuGroup_distritos;
        private System.Windows.Forms.CheckedListBox checkedListBox_distritos;
        private System.Windows.Forms.Button btn_distritos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_fechaInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_anios;
        private System.Windows.Forms.ComboBox comboBox_fechaFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_indicadores;
        private System.Windows.Forms.ComboBox comboBox_valorIndicador;
        private System.Windows.Forms.ComboBox comboBox_indicador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_mi_busqueda;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columna_indicador;
        private System.Windows.Forms.ColumnHeader columna_valor;
        private System.Windows.Forms.Button btn_consultar;
    }
}