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
            this.Dgv_Grid = new System.Windows.Forms.DataGridView();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Gpb_RadioGroup = new System.Windows.Forms.GroupBox();
            this.Rdb_Word = new System.Windows.Forms.RadioButton();
            this.Rdb_Excel = new System.Windows.Forms.RadioButton();
            this.Rdb_PwrPoint = new System.Windows.Forms.RadioButton();
            this.Rdb_Text = new System.Windows.Forms.RadioButton();
            this.Rdb_Jpeg = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Grid)).BeginInit();
            this.Gpb_RadioGroup.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(492, 326);
            this.panel1.TabIndex = 0;
            // 
            // Dgv_Grid
            // 
            this.Dgv_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Grid.Location = new System.Drawing.Point(32, 105);
            this.Dgv_Grid.Name = "Dgv_Grid";
            this.Dgv_Grid.Size = new System.Drawing.Size(421, 209);
            this.Dgv_Grid.TabIndex = 1;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(197, 54);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(102, 44);
            this.Btn_Buscar.TabIndex = 0;
            this.Btn_Buscar.Text = "Buscar Nombres de Archivos";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Gpb_RadioGroup
            // 
            this.Gpb_RadioGroup.Controls.Add(this.Rdb_Jpeg);
            this.Gpb_RadioGroup.Controls.Add(this.Rdb_Text);
            this.Gpb_RadioGroup.Controls.Add(this.Rdb_PwrPoint);
            this.Gpb_RadioGroup.Controls.Add(this.Rdb_Excel);
            this.Gpb_RadioGroup.Controls.Add(this.Rdb_Word);
            this.Gpb_RadioGroup.Location = new System.Drawing.Point(12, 3);
            this.Gpb_RadioGroup.Name = "Gpb_RadioGroup";
            this.Gpb_RadioGroup.Size = new System.Drawing.Size(472, 45);
            this.Gpb_RadioGroup.TabIndex = 2;
            this.Gpb_RadioGroup.TabStop = false;
            // 
            // Rdb_Word
            // 
            this.Rdb_Word.AutoSize = true;
            this.Rdb_Word.Location = new System.Drawing.Point(7, 20);
            this.Rdb_Word.Name = "Rdb_Word";
            this.Rdb_Word.Size = new System.Drawing.Size(51, 17);
            this.Rdb_Word.TabIndex = 0;
            this.Rdb_Word.TabStop = true;
            this.Rdb_Word.Text = "Word";
            this.Rdb_Word.UseVisualStyleBackColor = true;
            // 
            // Rdb_Excel
            // 
            this.Rdb_Excel.AutoSize = true;
            this.Rdb_Excel.Location = new System.Drawing.Point(99, 20);
            this.Rdb_Excel.Name = "Rdb_Excel";
            this.Rdb_Excel.Size = new System.Drawing.Size(51, 17);
            this.Rdb_Excel.TabIndex = 1;
            this.Rdb_Excel.TabStop = true;
            this.Rdb_Excel.Text = "Excel";
            this.Rdb_Excel.UseVisualStyleBackColor = true;
            // 
            // Rdb_PwrPoint
            // 
            this.Rdb_PwrPoint.AutoSize = true;
            this.Rdb_PwrPoint.Location = new System.Drawing.Point(191, 20);
            this.Rdb_PwrPoint.Name = "Rdb_PwrPoint";
            this.Rdb_PwrPoint.Size = new System.Drawing.Size(82, 17);
            this.Rdb_PwrPoint.TabIndex = 2;
            this.Rdb_PwrPoint.TabStop = true;
            this.Rdb_PwrPoint.Text = "Power Point";
            this.Rdb_PwrPoint.UseVisualStyleBackColor = true;
            // 
            // Rdb_Text
            // 
            this.Rdb_Text.AutoSize = true;
            this.Rdb_Text.Location = new System.Drawing.Point(283, 20);
            this.Rdb_Text.Name = "Rdb_Text";
            this.Rdb_Text.Size = new System.Drawing.Size(46, 17);
            this.Rdb_Text.TabIndex = 3;
            this.Rdb_Text.TabStop = true;
            this.Rdb_Text.Text = "Text";
            this.Rdb_Text.UseVisualStyleBackColor = true;
            // 
            // Rdb_Jpeg
            // 
            this.Rdb_Jpeg.AutoSize = true;
            this.Rdb_Jpeg.Location = new System.Drawing.Point(375, 20);
            this.Rdb_Jpeg.Name = "Rdb_Jpeg";
            this.Rdb_Jpeg.Size = new System.Drawing.Size(86, 17);
            this.Rdb_Jpeg.TabIndex = 4;
            this.Rdb_Jpeg.TabStop = true;
            this.Rdb_Jpeg.Text = "Imagen Jpeg";
            this.Rdb_Jpeg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 326);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Folders";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Grid)).EndInit();
            this.Gpb_RadioGroup.ResumeLayout(false);
            this.Gpb_RadioGroup.PerformLayout();
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
    }
}

