using DotnetExam.Entities;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Windows.Forms;

namespace DotnetExam.WinFormsApp
{
    public partial class Form1 : Form
    {
        private List<Materia> materias = new List<Materia>();
        private List<Alumno> _alumnos = new List<Alumno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MateriaGenerador g = new MateriaGenerador();

            materias = g.Generar(200, 30);
            dgMaterias.DataSource = materias;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            var bsq = txtBusquedaMateria.Text;
            if (bsq != string.Empty)
            {
                List<Materia> lista = (from a in materias
                                       where a.Nombre.ToLower().StartsWith(bsq.ToLower())
                                       select a).ToList();
                dgMaterias.DataSource = lista;
                txtBusquedaMateria.Text = string.Empty;
            }
            else dgMaterias.DataSource = materias;
        }

        private void dgMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cambia el label
            var materiax = dgMaterias.SelectedCells[0].Value.ToString();
            lblAlumnos.Text = $"Alumnos de la materia: {materiax}";

            //genera lista de alumnos
            var alumnos = (from a in materias
                           where a.Nombre == dgMaterias.SelectedCells[0].Value.ToString()
                           select a.Alumnos);
            dgAlumnos.DataSource = _alumnos;

            DataTable datatable = new DataTable();
            datatable.Columns.Add("Nombre Completo");
            datatable.Columns.Add("Nota");
            datatable.Columns.Add("Condicion");

            //genera la DGV de alumnos:
            foreach (var lista in alumnos)
            {

                foreach (var alumno in lista)
                {
                    DataRow row = datatable.NewRow();
                    row["Nombre Completo"] = $"{alumno.NombreCompleto}";
                    row["Nota"] = alumno.Nota;
                    var condicion = "";
                    if (alumno._aprobado == true)
                    {
                        condicion = "Aprobado";
                    }
                    else condicion = "Desaprobado";

                    row["Condicion"] = condicion;

                    datatable.Rows.Add(row);
                }
            }
            dgAlumnos.DataSource = datatable;
        }

        private void dgAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (this.dgAlumnos.Columns[e.ColumnIndex].Name == "Condicion")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        if (e.Value == "Desaprobado")
                        {
                            e.CellStyle.BackColor = Color.Red;
                            e.CellStyle.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }
    }
}
