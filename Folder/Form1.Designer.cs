namespace Folder
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Gpb_RadioGroup = new System.Windows.Forms.GroupBox();
            this.Txt_NFormat = new System.Windows.Forms.TextBox();
            this.Btn_NFormat = new System.Windows.Forms.Button();
            this.Rdb_NFormat = new System.Windows.Forms.RadioButton();
            this.Lbl_Nota = new System.Windows.Forms.Label();
            this.Rdb_Jpeg = new System.Windows.Forms.RadioButton();
            this.Rdb_Text = new System.Windows.Forms.RadioButton();
            this.Rdb_PwrPoint = new System.Windows.Forms.RadioButton();
            this.Rdb_Excel = new System.Windows.Forms.RadioButton();
            this.Rdb_Word = new System.Windows.Forms.RadioButton();
            this.Dgv_Grid = new System.Windows.Forms.DataGridView();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Gpb_RadioGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Gpb_RadioGroup);
            this.panel1.Controls.Add(this.Dgv_Grid);
            this.panel1.Controls.Add(this.Btn_Buscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 435);
            this.panel1.TabIndex = 0;
            // 
            // Gpb_RadioGroup
            // 
            this.Gpb_RadioGroup.BackColor = System.Drawing.Color.Transparent;
            this.Gpb_RadioGroup.Controls.Add(this.Txt_NFormat);
            this.Gpb_RadioGroup.Controls.Add(this.Btn_NFormat);
            this.Gpb_RadioGroup.Controls.Add(this.Rdb_NFormat);
            this.Gpb_RadioGroup.Controls.Add(this.Lbl_Nota);
            this.Gpb_RadioGroup.Controls.Add(this.Rdb_Jpeg);
            this.Gpb_RadioGroup.Controls.Add(this.Rdb_Text);
            this.Gpb_RadioGroup.Controls.Add(this.Rdb_PwrPoint);
            this.Gpb_RadioGroup.Controls.Add(this.Rdb_Excel);
            this.Gpb_RadioGroup.Controls.Add(this.Rdb_Word);
            this.Gpb_RadioGroup.Location = new System.Drawing.Point(3, 12);
            this.Gpb_RadioGroup.Name = "Gpb_RadioGroup";
            this.Gpb_RadioGroup.Size = new System.Drawing.Size(239, 414);
            this.Gpb_RadioGroup.TabIndex = 2;
            this.Gpb_RadioGroup.TabStop = false;
            // 
            // Txt_NFormat
            // 
            this.Txt_NFormat.Location = new System.Drawing.Point(27, 328);
            this.Txt_NFormat.Name = "Txt_NFormat";
            this.Txt_NFormat.Size = new System.Drawing.Size(183, 20);
            this.Txt_NFormat.TabIndex = 6;
            // 
            // Btn_NFormat
            // 
            this.Btn_NFormat.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_NFormat.Location = new System.Drawing.Point(64, 354);
            this.Btn_NFormat.Name = "Btn_NFormat";
            this.Btn_NFormat.Size = new System.Drawing.Size(106, 53);
            this.Btn_NFormat.TabIndex = 3;
            this.Btn_NFormat.Text = "Agregar Formato";
            this.Btn_NFormat.UseVisualStyleBackColor = true;
            this.Btn_NFormat.Click += new System.EventHandler(this.Btn_NFormat_Click);
            // 
            // Rdb_NFormat
            // 
            this.Rdb_NFormat.AutoSize = true;
            this.Rdb_NFormat.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_NFormat.Location = new System.Drawing.Point(27, 292);
            this.Rdb_NFormat.Name = "Rdb_NFormat";
            this.Rdb_NFormat.Size = new System.Drawing.Size(143, 25);
            this.Rdb_NFormat.TabIndex = 5;
            this.Rdb_NFormat.TabStop = true;
            this.Rdb_NFormat.Text = "&Nuevo Formato";
            this.Rdb_NFormat.UseVisualStyleBackColor = false;
            this.Rdb_NFormat.Visible = false;
            // 
            // Lbl_Nota
            // 
            this.Lbl_Nota.AutoSize = true;
            this.Lbl_Nota.Font = new System.Drawing.Font("Franklin Gothic Heavy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nota.Location = new System.Drawing.Point(6, 16);
            this.Lbl_Nota.Name = "Lbl_Nota";
            this.Lbl_Nota.Size = new System.Drawing.Size(180, 60);
            this.Lbl_Nota.TabIndex = 3;
            this.Lbl_Nota.Text = "Selecciona un\r\ntipo de archivo";
            // 
            // Rdb_Jpeg
            // 
            this.Rdb_Jpeg.AutoSize = true;
            this.Rdb_Jpeg.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Jpeg.Location = new System.Drawing.Point(27, 251);
            this.Rdb_Jpeg.Name = "Rdb_Jpeg";
            this.Rdb_Jpeg.Size = new System.Drawing.Size(124, 25);
            this.Rdb_Jpeg.TabIndex = 4;
            this.Rdb_Jpeg.TabStop = true;
            this.Rdb_Jpeg.Text = "&Imagen Jpeg";
            this.Rdb_Jpeg.UseVisualStyleBackColor = true;
            // 
            // Rdb_Text
            // 
            this.Rdb_Text.AutoSize = true;
            this.Rdb_Text.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Text.Location = new System.Drawing.Point(27, 210);
            this.Rdb_Text.Name = "Rdb_Text";
            this.Rdb_Text.Size = new System.Drawing.Size(60, 25);
            this.Rdb_Text.TabIndex = 3;
            this.Rdb_Text.TabStop = true;
            this.Rdb_Text.Text = "&Text";
            this.Rdb_Text.UseVisualStyleBackColor = true;
            // 
            // Rdb_PwrPoint
            // 
            this.Rdb_PwrPoint.AutoSize = true;
            this.Rdb_PwrPoint.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_PwrPoint.Location = new System.Drawing.Point(27, 169);
            this.Rdb_PwrPoint.Name = "Rdb_PwrPoint";
            this.Rdb_PwrPoint.Size = new System.Drawing.Size(119, 25);
            this.Rdb_PwrPoint.TabIndex = 2;
            this.Rdb_PwrPoint.TabStop = true;
            this.Rdb_PwrPoint.Text = "&Power Point";
            this.Rdb_PwrPoint.UseVisualStyleBackColor = true;
            // 
            // Rdb_Excel
            // 
            this.Rdb_Excel.AutoSize = true;
            this.Rdb_Excel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Excel.Location = new System.Drawing.Point(27, 130);
            this.Rdb_Excel.Name = "Rdb_Excel";
            this.Rdb_Excel.Size = new System.Drawing.Size(68, 25);
            this.Rdb_Excel.TabIndex = 1;
            this.Rdb_Excel.TabStop = true;
            this.Rdb_Excel.Text = "&Excel";
            this.Rdb_Excel.UseVisualStyleBackColor = true;
            // 
            // Rdb_Word
            // 
            this.Rdb_Word.AutoSize = true;
            this.Rdb_Word.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Word.Location = new System.Drawing.Point(27, 93);
            this.Rdb_Word.Name = "Rdb_Word";
            this.Rdb_Word.Size = new System.Drawing.Size(67, 25);
            this.Rdb_Word.TabIndex = 0;
            this.Rdb_Word.TabStop = true;
            this.Rdb_Word.Text = "&Word";
            this.Rdb_Word.UseVisualStyleBackColor = true;
            // 
            // Dgv_Grid
            // 
            this.Dgv_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Grid.Location = new System.Drawing.Point(248, 105);
            this.Dgv_Grid.Name = "Dgv_Grid";
            this.Dgv_Grid.Size = new System.Drawing.Size(355, 321);
            this.Dgv_Grid.TabIndex = 1;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Franklin Gothic Heavy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Buscar.Location = new System.Drawing.Point(248, 12);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(355, 86);
            this.Btn_Buscar.TabIndex = 0;
            this.Btn_Buscar.Text = "Buscar Nombres de Archivos";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(606, 435);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Folders";
            this.panel1.ResumeLayout(false);
            this.Gpb_RadioGroup.ResumeLayout(false);
            this.Gpb_RadioGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dgv_Grid;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.GroupBox Gpb_RadioGroup;
        private System.Windows.Forms.RadioButton Rdb_Jpeg;
        private System.Windows.Forms.RadioButton Rdb_Text;
        private System.Windows.Forms.RadioButton Rdb_PwrPoint;
        private System.Windows.Forms.RadioButton Rdb_Excel;
        private System.Windows.Forms.RadioButton Rdb_Word;
        private System.Windows.Forms.Label Lbl_Nota;
        private System.Windows.Forms.RadioButton Rdb_NFormat;
        private System.Windows.Forms.TextBox Txt_NFormat;
        private System.Windows.Forms.Button Btn_NFormat;
    }
}

