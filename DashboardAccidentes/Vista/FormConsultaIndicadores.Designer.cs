namespace DashboardAccidentes.Vista
{
    partial class FormConsultaIndicadores
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_indicador = new System.Windows.Forms.ComboBox();
            this.grafico_consulta_indicadores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_consulta_indicadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_consultar.Location = new System.Drawing.Point(869, 593);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(261, 35);
            this.btn_consultar.TabIndex = 20;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(925, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Indicador:";
            // 
            // comboBox_indicador
            // 
            this.comboBox_indicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_indicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_indicador.FormattingEnabled = true;
            this.comboBox_indicador.Location = new System.Drawing.Point(1001, 43);
            this.comboBox_indicador.Name = "comboBox_indicador";
            this.comboBox_indicador.Size = new System.Drawing.Size(129, 24);
            this.comboBox_indicador.TabIndex = 22;
            // 
            // grafico_consulta_indicadores
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico_consulta_indicadores.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico_consulta_indicadores.Legends.Add(legend1);
            this.grafico_consulta_indicadores.Location = new System.Drawing.Point(33, 77);
            this.grafico_consulta_indicadores.Name = "grafico_consulta_indicadores";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafico_consulta_indicadores.Series.Add(series1);
            this.grafico_consulta_indicadores.Size = new System.Drawing.Size(1124, 500);
            this.grafico_consulta_indicadores.TabIndex = 23;
            this.grafico_consulta_indicadores.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Consulta de Indicadores";
            // 
            // FormConsultaIndicadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grafico_consulta_indicadores);
            this.Controls.Add(this.comboBox_indicador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_consultar);
            this.Name = "FormConsultaIndicadores";
            this.Text = "Consulta según indicadores";
            this.Load += new System.EventHandler(this.FormConsultaIndicadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafico_consulta_indicadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_indicador;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico_consulta_indicadores;
        private System.Windows.Forms.Label label2;
    }
}