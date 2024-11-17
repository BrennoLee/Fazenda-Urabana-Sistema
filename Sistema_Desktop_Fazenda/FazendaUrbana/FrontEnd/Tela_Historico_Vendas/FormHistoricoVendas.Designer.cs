namespace FazendoUrbanaCRUD.FrontEnd
{
    partial class FormHistoricoVendas
    {
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.ComboBox cbOrdem;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvHistoricoVendas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvHistoricoVendas = new System.Windows.Forms.DataGridView();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.cbOrdem = new System.Windows.Forms.ComboBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoVendas)).BeginInit();
            this.SuspendLayout();

            // dgvHistoricoVendas
            this.dgvHistoricoVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoricoVendas.Location = new System.Drawing.Point(12, 50); // Movendo DataGridView para baixo
            this.dgvHistoricoVendas.Name = "dgvHistoricoVendas";
            this.dgvHistoricoVendas.Size = new System.Drawing.Size(760, 400);
            this.dgvHistoricoVendas.TabIndex = 0;

            // cbFiltro
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.Items.AddRange(new object[] {
                "Data",
                "Nome",
                "Quantidade",
                "Preço"});
            this.cbFiltro.Location = new System.Drawing.Point(12, 12);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbFiltro.TabIndex = 1;

            // cbOrdem
            this.cbOrdem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrdem.Items.AddRange(new object[] {
                "Ascendente",
                "Descendente"});
            this.cbOrdem.Location = new System.Drawing.Point(150, 12);
            this.cbOrdem.Name = "cbOrdem";
            this.cbOrdem.Size = new System.Drawing.Size(121, 21);
            this.cbOrdem.TabIndex = 2;

            // btnAplicarFiltro
            this.btnAplicarFiltro.Location = new System.Drawing.Point(290, 10);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnAplicarFiltro.TabIndex = 3;
            this.btnAplicarFiltro.Text = "Aplicar Filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);

            // FormHistoricoVendas
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvHistoricoVendas);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.cbOrdem);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Name = "FormHistoricoVendas";
            this.Text = "Histórico de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoVendas)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
