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

            
            /*var xlApp = new Excel.Application();


            xlApp.Visible = false;
            
            var xlWb = xlApp.Workbooks.Add();

            xlWb.Worksheets.Add(Type.Missing,Type.Missing,3,Excel.XlSheetType.xlWorksheet);

            MessageBox.Show(xlWb.Worksheets.Count.ToString());*/

            



            

          

            InitializeComponent();
        }

        /// <summary>
        /// Clase publica de variables globales
        /// </summary>
        public class VGlobales{
            // Variable tipo
            public static string tipo  { get; set; }
            public static string f { get; set; }
        }

        /// <summary>
        ///  Metodo para buscar nombres de folders
        /// </summary>
        public void Buscar()
        {
       



            // Variable x
            int x = 0;
            // Variable folder
            string folder = "";
            // Inicializacion de FolderBrowserDialog
            FolderBrowserDialog buscarf = new FolderBrowserDialog();
            // Descripcion del objeto buscarf
            buscarf.Description = "Selecciona el folder con los archivos a evaluar";
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
                    x++;
                }
                MessageBox.Show("Listo \n se encontraron " + x + " valores");
                // Asigna la DataTable para mostrarse en un DataGridView
                Dgv_Grid.DataSource = Dtable;
                // Restringe al usuario a solo lectura, a no aderir filas, a no borrar filas y no cambiar su tamaño
                Dgv_Grid.Columns[0].ReadOnly = true;
                Dgv_Grid.AllowUserToAddRows = false;
                Dgv_Grid.AllowUserToDeleteRows = false;
                Dgv_Grid.AllowUserToResizeRows = false;
                // Inicializacion de DataGidViewColumn llamado columna, se asigna tamaño automatico dependiendo del tamaño de las celdas mostradas
                DataGridViewColumn columna = Dgv_Grid.Columns[0];
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        /// <summary>
        /// Metodo para agregar un nuevo tipo de formato
        /// </summary>
        public void NFormat()
        {
            // Si el texto del textbox NFormat no tiene nada
            if (Txt_NFormat.Text.ToString() == "")
            {
                // Se activa un messagebox pidiendo agregar la extension
                MessageBox.Show("Agrega una extencion");
            }
            else
            {
                // Sino, el valor de la variable f de la clase VGlobales sera igual al texto del textbox
                VGlobales.f = Txt_NFormat.Text.ToString();
                // Radiobutton NFormat adquiere el texto que se coloco en el textbox
                Rdb_NFormat.Text = Txt_NFormat.Text.ToString();
                // Se visualiza el Radiobutton NFormat
                Rdb_NFormat.Visible = true;
            }
        }

        private void Btn_NFormat_Click(object sender, EventArgs e)
        {
            NFormat();
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
            // Si el radiobutton extra esta checado, convierte la variable global tipo en una cadena con el tipo de formato elegido
            else if (Rdb_NFormat.Checked)
            {
                VGlobales.tipo = VGlobales.f.ToString();
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
