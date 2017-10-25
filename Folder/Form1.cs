using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Folder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class VGlobales {
            //Variable tipo
            public static string tipo  { get; set; }
        }

        //Metodo para buscar nombres de folders
        public void Buscar()
        {
            //Variable folder
            string folder = "";
            //Inicializacion de FolderBrowserDialog
            FolderBrowserDialog buscarf = new FolderBrowserDialog();
            //Desactivacion de NewFolderButton
            buscarf.ShowNewFolderButton = false;
            //Validacion de cuadro de dialogo
            if (buscarf.ShowDialog() == DialogResult.OK)
            {
                folder = buscarf.SelectedPath;
                //Inicializacion de DirectoryInfo dando el camino variable "folder"
                var di = new DirectoryInfo(folder);
                //Obtiene los archivos con la variable di y los asigna a la variable files
                var files = di.GetFiles("*.txt");
                //Inicializacion de un DataTable llamado Dtable
                DataTable Dtable = new DataTable();
                //Asignacion de columna Archivos en la DataTable y su tipo a texto
                Dtable.Columns.Add("Archivos",typeof (string));
                //Se inicializa una fila llamada line
                DataRow line;
                //Loop para listar los archivos en el folder
                foreach (var obj in files)
                {
                    line = Dtable.NewRow();
                    line["Archivos"] = obj.ToString();
                    Dtable.Rows.Add(line);
                }
                MessageBox.Show("Listo");
                //Asigna la Data?Table para mostrarse en un DataGridView
                Dgv_Grid.DataSource = Dtable;
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
