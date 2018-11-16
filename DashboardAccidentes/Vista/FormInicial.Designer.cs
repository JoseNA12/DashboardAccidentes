namespace DashboardAccidentes
{
    partial class FormInicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_consulta_libre = new System.Windows.Forms.Button();
            this.btn_consulta_indicadores = new System.Windows.Forms.Button();
            this.btn_consulta_dinamica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Incidentes de accidentes de tránsito";
            // 
            // btn_consulta_libre
            // 
            this.btn_consulta_libre.BackColor = System.Drawing.Color.Orange;
            this.btn_consulta_libre.BackgroundImage = global::DashboardAccidentes.Properties.Resources.statistics_64;
            this.btn_consulta_libre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_consulta_libre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consulta_libre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta_libre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_consulta_libre.Location = new System.Drawing.Point(332, 291);
            this.btn_consulta_libre.Name = "btn_consulta_libre";
            this.btn_consulta_libre.Size = new System.Drawing.Size(368, 171);
            this.btn_consulta_libre.TabIndex = 3;
            this.btn_consulta_libre.Text = "Consulta Libre";
            this.btn_consulta_libre.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_consulta_libre.UseVisualStyleBackColor = false;
            this.btn_consulta_libre.Click += new System.EventHandler(this.btn_consulta_libre_Click);
            // 
            // btn_consulta_indicadores
            // 
            this.btn_consulta_indicadores.BackColor = System.Drawing.Color.Crimson;
            this.btn_consulta_indicadores.BackgroundImage = global::DashboardAccidentes.Properties.Resources.growth_64;
            this.btn_consulta_indicadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_consulta_indicadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consulta_indicadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta_indicadores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_consulta_indicadores.Location = new System.Drawing.Point(332, 111);
            this.btn_consulta_indicadores.Name = "btn_consulta_indicadores";
            this.btn_consulta_indicadores.Size = new System.Drawing.Size(368, 174);
            this.btn_consulta_indicadores.TabIndex = 2;
            this.btn_consulta_indicadores.Text = "Consulta Indicadores";
            this.btn_consulta_indicadores.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_consulta_indicadores.UseVisualStyleBackColor = false;
            this.btn_consulta_indicadores.Click += new System.EventHandler(this.btn_consulta_indicadores_Click);
            // 
            // btn_consulta_dinamica
            // 
            this.btn_consulta_dinamica.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_consulta_dinamica.BackgroundImage = global::DashboardAccidentes.Properties.Resources.map_64;
            this.btn_consulta_dinamica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_consulta_dinamica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consulta_dinamica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta_dinamica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_consulta_dinamica.Location = new System.Drawing.Point(151, 111);
            this.btn_consulta_dinamica.Name = "btn_consulta_dinamica";
            this.btn_consulta_dinamica.Size = new System.Drawing.Size(175, 351);
            this.btn_consulta_dinamica.TabIndex = 1;
            this.btn_consulta_dinamica.Text = "Consulta Dinámica";
            this.btn_consulta_dinamica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_consulta_dinamica.UseVisualStyleBackColor = false;
            this.btn_consulta_dinamica.Click += new System.EventHandler(this.btn_consulta_dinamica_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_consulta_libre);
            this.Controls.Add(this.btn_consulta_indicadores);
            this.Controls.Add(this.btn_consulta_dinamica);
            this.MaximumSize = new System.Drawing.Size(861, 590);
            this.MinimumSize = new System.Drawing.Size(861, 590);
            this.Name = "FormInicial";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consulta_dinamica;
        private System.Windows.Forms.Button btn_consulta_indicadores;
        private System.Windows.Forms.Button btn_consulta_libre;
        private System.Windows.Forms.Label label1;
    }
}

