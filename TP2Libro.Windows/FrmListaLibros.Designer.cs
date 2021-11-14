
namespace TP2Libro.Windows
{
    partial class FrmListaLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaLibros));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colNombreLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadDePaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltrarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.editorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltroEditorialToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltroTemaToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.OrdenarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AscendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DescendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ContadorRegistroLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatosDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.splitContainer1.Panel2.Controls.Add(this.ContadorRegistroLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(644, 476);
            this.splitContainer1.SplitterDistance = 407;
            this.splitContainer1.TabIndex = 0;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.BackgroundColor = System.Drawing.Color.LightCyan;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreLibro,
            this.colEditorial,
            this.colTema,
            this.colCantidadDePaginas,
            this.colISBN,
            this.colAutor});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 58);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(644, 349);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // colNombreLibro
            // 
            this.colNombreLibro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombreLibro.HeaderText = "Nombre";
            this.colNombreLibro.Name = "colNombreLibro";
            this.colNombreLibro.ReadOnly = true;
            // 
            // colEditorial
            // 
            this.colEditorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEditorial.HeaderText = "Editorial";
            this.colEditorial.Name = "colEditorial";
            this.colEditorial.ReadOnly = true;
            // 
            // colTema
            // 
            this.colTema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTema.HeaderText = "Tema";
            this.colTema.Name = "colTema";
            this.colTema.ReadOnly = true;
            // 
            // colCantidadDePaginas
            // 
            this.colCantidadDePaginas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCantidadDePaginas.HeaderText = "N° de Paginas";
            this.colCantidadDePaginas.Name = "colCantidadDePaginas";
            this.colCantidadDePaginas.ReadOnly = true;
            // 
            // colISBN
            // 
            this.colISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            // 
            // colAutor
            // 
            this.colAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAutor.HeaderText = "Autor";
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.BorrarToolStripButton,
            this.EditarToolStripButton,
            this.toolStripSeparator1,
            this.FiltrarToolStripButton,
            this.OrdenarToolStripButton,
            this.ActualizarToolStripButton,
            this.toolStripSeparator2,
            this.SalirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(644, 58);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = global::TP2Libro.Windows.Properties.Resources.add_file_36px;
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 55);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = global::TP2Libro.Windows.Properties.Resources.delete_file_36px;
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(43, 55);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = global::TP2Libro.Windows.Properties.Resources.edit_file_36px;
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(41, 55);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarToolStripButton.Click += new System.EventHandler(this.EditarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // FiltrarToolStripButton
            // 
            this.FiltrarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorialToolStripMenuItem,
            this.temaToolStripMenuItem});
            this.FiltrarToolStripButton.Image = global::TP2Libro.Windows.Properties.Resources.filter_36px;
            this.FiltrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiltrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarToolStripButton.Name = "FiltrarToolStripButton";
            this.FiltrarToolStripButton.Size = new System.Drawing.Size(50, 55);
            this.FiltrarToolStripButton.Text = "Filtrar";
            this.FiltrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // editorialToolStripMenuItem
            // 
            this.editorialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FiltroEditorialToolStripComboBox});
            this.editorialToolStripMenuItem.Name = "editorialToolStripMenuItem";
            this.editorialToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editorialToolStripMenuItem.Text = "Editorial";
            // 
            // FiltroEditorialToolStripComboBox
            // 
            this.FiltroEditorialToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroEditorialToolStripComboBox.Name = "FiltroEditorialToolStripComboBox";
            this.FiltroEditorialToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.FiltroEditorialToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltroEditorialToolStripComboBox_SelectedIndexChanged);
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FiltroTemaToolStripComboBox});
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.temaToolStripMenuItem.Text = "Tema";
            // 
            // FiltroTemaToolStripComboBox
            // 
            this.FiltroTemaToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroTemaToolStripComboBox.Name = "FiltroTemaToolStripComboBox";
            this.FiltroTemaToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.FiltroTemaToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltroTemaToolStripComboBox_SelectedIndexChanged);
            // 
            // OrdenarToolStripButton
            // 
            this.OrdenarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AscendenteToolStripMenuItem,
            this.DescendenteToolStripMenuItem});
            this.OrdenarToolStripButton.Image = global::TP2Libro.Windows.Properties.Resources.up_down_arrow_36px;
            this.OrdenarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OrdenarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenarToolStripButton.Name = "OrdenarToolStripButton";
            this.OrdenarToolStripButton.Size = new System.Drawing.Size(63, 55);
            this.OrdenarToolStripButton.Text = "Ordenar";
            this.OrdenarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // AscendenteToolStripMenuItem
            // 
            this.AscendenteToolStripMenuItem.Name = "AscendenteToolStripMenuItem";
            this.AscendenteToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.AscendenteToolStripMenuItem.Text = "Ascendente";
            this.AscendenteToolStripMenuItem.Click += new System.EventHandler(this.AscendenteToolStripMenuItem_Click);
            // 
            // DescendenteToolStripMenuItem
            // 
            this.DescendenteToolStripMenuItem.Name = "DescendenteToolStripMenuItem";
            this.DescendenteToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.DescendenteToolStripMenuItem.Text = "Descendente";
            this.DescendenteToolStripMenuItem.Click += new System.EventHandler(this.DescendenteToolStripMenuItem_Click);
            // 
            // ActualizarToolStripButton
            // 
            this.ActualizarToolStripButton.Image = global::TP2Libro.Windows.Properties.Resources.available_updates_36px;
            this.ActualizarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarToolStripButton.Name = "ActualizarToolStripButton";
            this.ActualizarToolStripButton.Size = new System.Drawing.Size(50, 55);
            this.ActualizarToolStripButton.Text = "Refresh";
            this.ActualizarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ActualizarToolStripButton.Click += new System.EventHandler(this.ActualizarToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Image = global::TP2Libro.Windows.Properties.Resources.exit_sign_36px;
            this.SalirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(40, 55);
            this.SalirToolStripButton.Text = "Salir";
            this.SalirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // ContadorRegistroLabel
            // 
            this.ContadorRegistroLabel.AutoSize = true;
            this.ContadorRegistroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContadorRegistroLabel.Location = new System.Drawing.Point(147, 25);
            this.ContadorRegistroLabel.Name = "ContadorRegistroLabel";
            this.ContadorRegistroLabel.Size = new System.Drawing.Size(14, 13);
            this.ContadorRegistroLabel.TabIndex = 0;
            this.ContadorRegistroLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contador de Registros:";
            // 
            // FrmListaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(644, 476);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(660, 515);
            this.MinimumSize = new System.Drawing.Size(660, 515);
            this.Name = "FrmListaLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.FrmListaLibros_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ActualizarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Label ContadorRegistroLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadDePaginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.ToolStripDropDownButton FiltrarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem editorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox FiltroEditorialToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox FiltroTemaToolStripComboBox;
        private System.Windows.Forms.ToolStripDropDownButton OrdenarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem AscendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DescendenteToolStripMenuItem;
    }
}