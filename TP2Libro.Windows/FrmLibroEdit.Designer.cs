
namespace TP2Libro.Windows
{
    partial class FrmLibroEdit
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.PaginasTextBox = new System.Windows.Forms.TextBox();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.AutorTextBox = new System.Windows.Forms.TextBox();
            this.EditorialComboBox = new System.Windows.Forms.ComboBox();
            this.TemaComboBox = new System.Windows.Forms.ComboBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Editorial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tema:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "N° de Paginas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ISBN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Autor:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(160, 22);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(121, 20);
            this.NombreTextBox.TabIndex = 0;
            // 
            // PaginasTextBox
            // 
            this.PaginasTextBox.Location = new System.Drawing.Point(160, 119);
            this.PaginasTextBox.Name = "PaginasTextBox";
            this.PaginasTextBox.Size = new System.Drawing.Size(121, 20);
            this.PaginasTextBox.TabIndex = 3;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(160, 150);
            this.ISBNTextBox.MaxLength = 13;
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(121, 20);
            this.ISBNTextBox.TabIndex = 4;
            // 
            // AutorTextBox
            // 
            this.AutorTextBox.Location = new System.Drawing.Point(160, 181);
            this.AutorTextBox.Name = "AutorTextBox";
            this.AutorTextBox.Size = new System.Drawing.Size(121, 20);
            this.AutorTextBox.TabIndex = 5;
            // 
            // EditorialComboBox
            // 
            this.EditorialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditorialComboBox.FormattingEnabled = true;
            this.EditorialComboBox.Location = new System.Drawing.Point(160, 53);
            this.EditorialComboBox.Name = "EditorialComboBox";
            this.EditorialComboBox.Size = new System.Drawing.Size(121, 21);
            this.EditorialComboBox.TabIndex = 1;
            // 
            // TemaComboBox
            // 
            this.TemaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TemaComboBox.FormattingEnabled = true;
            this.TemaComboBox.Location = new System.Drawing.Point(160, 88);
            this.TemaComboBox.Name = "TemaComboBox";
            this.TemaComboBox.Size = new System.Drawing.Size(121, 21);
            this.TemaComboBox.TabIndex = 2;
            // 
            // CancelarButton
            // 
            this.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarButton.Image = global::TP2Libro.Windows.Properties.Resources.cancel_35px;
            this.CancelarButton.Location = new System.Drawing.Point(206, 243);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 56);
            this.CancelarButton.TabIndex = 7;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Image = global::TP2Libro.Windows.Properties.Resources.book_shelf_35px;
            this.OKButton.Location = new System.Drawing.Point(39, 243);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 56);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmLibroEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 329);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.TemaComboBox);
            this.Controls.Add(this.EditorialComboBox);
            this.Controls.Add(this.AutorTextBox);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.PaginasTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(338, 368);
            this.MinimumSize = new System.Drawing.Size(338, 368);
            this.Name = "FrmLibroEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLibroEdit";
            this.Load += new System.EventHandler(this.FrmLibroEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox PaginasTextBox;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.TextBox AutorTextBox;
        private System.Windows.Forms.ComboBox EditorialComboBox;
        private System.Windows.Forms.ComboBox TemaComboBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}