namespace Tela01
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cadiDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadiDbDataSet = new Tela01.CadiDbDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gv_pedidospendentes = new System.Windows.Forms.DataGridView();
            this.Inf = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Status = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gv_pedidosexecutados = new System.Windows.Forms.DataGridView();
            this.gv_informacoes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadiDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadiDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_pedidospendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_pedidosexecutados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_informacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // cadiDbDataSetBindingSource
            // 
            this.cadiDbDataSetBindingSource.DataSource = this.cadiDbDataSet;
            this.cadiDbDataSetBindingSource.Position = 0;
            // 
            // cadiDbDataSet
            // 
            this.cadiDbDataSet.DataSetName = "CadiDbDataSet";
            this.cadiDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pedidos pendentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1405, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pedidos conclúidos";
            // 
            // gv_pedidospendentes
            // 
            this.gv_pedidospendentes.AllowUserToAddRows = false;
            this.gv_pedidospendentes.AllowUserToDeleteRows = false;
            this.gv_pedidospendentes.BackgroundColor = System.Drawing.Color.White;
            this.gv_pedidospendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_pedidospendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inf,
            this.Status});
            this.gv_pedidospendentes.Location = new System.Drawing.Point(77, 52);
            this.gv_pedidospendentes.Name = "gv_pedidospendentes";
            this.gv_pedidospendentes.ReadOnly = true;
            this.gv_pedidospendentes.RowHeadersWidth = 51;
            this.gv_pedidospendentes.RowTemplate.Height = 24;
            this.gv_pedidospendentes.Size = new System.Drawing.Size(951, 565);
            this.gv_pedidospendentes.TabIndex = 5;
            this.gv_pedidospendentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pedidospendentes_CellContentClick_1);
            // 
            // Inf
            // 
            this.Inf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            this.Inf.DefaultCellStyle = dataGridViewCellStyle1;
            this.Inf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Inf.HeaderText = "Informações";
            this.Inf.MinimumWidth = 6;
            this.Inf.Name = "Inf";
            this.Inf.ReadOnly = true;
            this.Inf.Width = 91;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lime;
            this.Status.DefaultCellStyle = dataGridViewCellStyle2;
            this.Status.FillWeight = 50F;
            this.Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Status.HeaderText = "Finalizar";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.Text = "";
            this.Status.Width = 67;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gv_pedidosexecutados
            // 
            this.gv_pedidosexecutados.AllowUserToAddRows = false;
            this.gv_pedidosexecutados.AllowUserToDeleteRows = false;
            this.gv_pedidosexecutados.BackgroundColor = System.Drawing.Color.White;
            this.gv_pedidosexecutados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_pedidosexecutados.Location = new System.Drawing.Point(1102, 52);
            this.gv_pedidosexecutados.Name = "gv_pedidosexecutados";
            this.gv_pedidosexecutados.ReadOnly = true;
            this.gv_pedidosexecutados.RowHeadersWidth = 51;
            this.gv_pedidosexecutados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Lime;
            this.gv_pedidosexecutados.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_pedidosexecutados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_pedidosexecutados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Lime;
            this.gv_pedidosexecutados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gv_pedidosexecutados.RowTemplate.Height = 24;
            this.gv_pedidosexecutados.Size = new System.Drawing.Size(810, 962);
            this.gv_pedidosexecutados.TabIndex = 8;
            // 
            // gv_informacoes
            // 
            this.gv_informacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_informacoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gv_informacoes.BackgroundColor = System.Drawing.Color.White;
            this.gv_informacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_informacoes.Location = new System.Drawing.Point(77, 681);
            this.gv_informacoes.Name = "gv_informacoes";
            this.gv_informacoes.RowHeadersWidth = 51;
            this.gv_informacoes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_informacoes.RowTemplate.Height = 24;
            this.gv_informacoes.Size = new System.Drawing.Size(951, 333);
            this.gv_informacoes.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 638);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "Informações";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1924, 1017);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gv_informacoes);
            this.Controls.Add(this.gv_pedidosexecutados);
            this.Controls.Add(this.gv_pedidospendentes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.cadiDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadiDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_pedidospendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_pedidosexecutados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_informacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource cadiDbDataSetBindingSource;
        private CadiDbDataSet cadiDbDataSet;
        private System.Windows.Forms.DataGridView gv_pedidospendentes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView gv_pedidosexecutados;
        private System.Windows.Forms.DataGridView gv_informacoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewButtonColumn Inf;
        private System.Windows.Forms.DataGridViewButtonColumn Status;
    }
}

