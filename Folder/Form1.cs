namespace Folder
{
    using System;
    using System.Data;
    using System.Windows.Forms;
    using System.IO;

    /// <summary>
    /// Clase principal de la inxializacion de la forma
    /// </summary>
    public partial class Form1 : Form
    {

        /// <summary>
        /// Inicializacion de la forma principal
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clase publica de variables globales
        /// </summary>
        public class VGlobales{
            // Variable tipo
            public static string tipo  { get; set; }
        }

        /// <summary>
        ///  Metodo para buscar nombres de folders
        /// </summary>
        public void Buscar()
        {
            // Variable folder
            string folder = "";
            // Inicializacion de FolderBrowserDialog
            FolderBrowserDialog buscarf = new FolderBrowserDialog();
            //Desactivacion de NewFolderButton
            buscarf.ShowNewFolderButton = false;
            // Validacion de cuadro de dialogo
            if (buscarf.ShowDialog() == DialogResult.OK)
            {
                folder = buscarf.SelectedPath;
                // Inicializacion de DirectoryInfo dando el camino variable "folder"
                var di = new DirectoryInfo(folder);
                // Obtiene los archivos con la variable di y los asigna a la variable files
                var files = di.GetFiles("*." + VGlobales.tipo.ToString());
                // Inicializacion de un DataTable llamado Dtable
                DataTable Dtable = new DataTable();
                // Asignacion de columna Archivos en la DataTable y su tipo a texto
                Dtable.Columns.Add("Archivos",typeof (string));
                //Se inicializa una fila llamada line
                DataRow line;
                // Loop para listar los archivos en el folder
                foreach (var obj in files)
                {
                    line = Dtable.NewRow();
                    line["Archivos"] = obj.ToString();
                    Dtable.Rows.Add(line);
                }
                MessageBox.Show("Listo");
                // Asigna la Data?Table para mostrarse en un DataGridView
                Dgv_Grid.DataSource = Dtable;
            }
        }

        /// <summary>
        /// Evento boton click, contirnr validacion de radiobutttons, cambia elvalor de la variable global e inicia el metodo Buscar
        /// </summary>
        /// <param name="sender">Parametro default de envio</param>
        /// <param name="e">Argumentos default</param>
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            // Si el radiobutton Word esta checado, convierte la variable global tipo en una cadena con el tipo de formato de Microsoft Word
            if (Rdb_Word.Checked)
            {
                VGlobales.tipo = ("docx");
                Buscar();
            }
            // Si el radiobutton Excel esta checado, convierte la variable global tipo en una cadena con el tipo de formato de Microsoft Excel
            else if (Rdb_Excel.Checked)
            {
                VGlobales.tipo = ("xlsx");
                Buscar();
            }
            // Si el radiobutton PwrPoint esta checado, convierte la variable global tipo en una cadena con el tipo de formato de Microsoft Power Point
            else if (Rdb_PwrPoint.Checked)
            {
                VGlobales.tipo = ("pptx");
                Buscar();
            }
            // Si el radiobutton Text esta checado, convierte la variable global tipo en una cadena con el tipo de formato de texto
            else if (Rdb_Text.Checked)
            {
                VGlobales.tipo = ("txt");
                Buscar();
            }
            // Si el radiobutton Jpeg esta checado, convierte la variable global tipo en una cadena con el tipo de formato de Imagenes jpeg
            else if (Rdb_Jpeg.Checked)
            {
                VGlobales.tipo = ("jpg");
                Buscar();
            }
            // Sino se cumple ninguna condicion, se muestra un mensaje indicando al usuario que debe seleccionar un formato
            else
            {
                MessageBox.Show("Debes seleccionar un tipo de formato");
            }
        }
    }
}
