using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Validaciones_C_Sharp
{
    public partial class Form1 : Form
    {
        Cola myCola = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        public void Actualizar()
        {
            Personas aux = myCola.Primero;
            DGV_1.DataSource = null;
            List<Personas> lista = new List<Personas>();
            while (aux != null)
            {
                lista.Add(aux);
                aux = aux._Next;
            }
            DGV_1.DataSource = lista;

        }
        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    Regex validar = new Regex(@"^[A-Z]{1}[0-9]{2}$");

                    if (validar.IsMatch(textBox1.Text))
                    {
                        Personas newP = new Personas(textBox1.Text, dateTimePicker1.Value, DUP1.Text);
                        myCola.Encolar(newP);
                    }
                    else
                    {
                        throw new Exception("^[Error] Ingrese una Letra y dos numeros");
                    }
                }
                else
                {
                    throw new Exception("^[Error] Ingrese numeros validos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                Actualizar();
            }
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                myCola.Desencolar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                Actualizar();
            }
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                var selection = DGV_1.SelectedRows.Count > 0 ? DGV_1.SelectedRows[0].DataBoundItem as Personas : null;
                if (selection != null)
                {
                    string Nombre = Interaction.InputBox("Ingrese nombre");
                    string Id = Interaction.InputBox("Ingrese ID");
                    Personas newP = new Personas(Nombre,DateTime.Now,Id);
                    myCola.Modificar(selection, newP);
                }
                else
                {
                    throw new Exception($"[ERROR] Seleccione para modificar");
                }
            }
            catch(Exception es)
            {
                MessageBox.Show($"{es.Message}");
            }
            finally
            {
                Actualizar();
            }
        }
    }
}
