using System.IO;

namespace PCTempSimulator
{
    public partial class Form1 : Form
    {
        private int contador = 0;
        private DateTime ultimaEvaluacion = DateTime.Now;
        private readonly Random random = new Random();
        private readonly string filePath = Path.Combine(AppContext.BaseDirectory, "logTemperaturas.txt");
             
        public Form1()
        {
            InitializeComponent();
        }

        // Random: escoge una temperatura, la muestra en la caja y la evalua
        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = random.Next(0, 151);   // 0 to 150
            EvaluarValor(numericUpDown1.Value);
        }

        // Evaluar: evalua el numero en la caja
        private void button2_Click(object sender, EventArgs e)
        {
            EvaluarValor(numericUpDown1.Value);
        }

        private void EvaluarValor(decimal temp)
        {
            var r = Controlador.Evaluar(temp);   // 'var' porque Resultado se accede desde Controlador

            // Estado
            label3.Text = r.Mensaje;
            label3.ForeColor = r.Estado switch
            {
                "Normal" => Color.ForestGreen,
                "Moderada" => Color.Goldenrod,
                "Alta" => Color.DarkOrange,
                _ => Color.Firebrick
            };

            // Ventilador
            label2.Text = $"Velocidad del ventilador: {r.Velocidad}%";
            progressBar1.Value = r.Velocidad;

            if (listView1.Items.Count >= 10) 
            {
                var records = listView1.Items.Cast<ListViewItem>().
                    Select(item => string.Join(" | ",
                        item.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(s => s.Text)));

                File.AppendAllLines(filePath, records);

                listView1.Items.Clear();
            }

            // Filas de Tabla
            contador++;
            TimeSpan duracion = DateTime.Now - ultimaEvaluacion;
            ultimaEvaluacion = DateTime.Now;

            var fila = new ListViewItem(contador.ToString());
            fila.SubItems.Add($"{temp} °C");
            fila.SubItems.Add(r.Estado);
            fila.SubItems.Add($"{r.Velocidad}%");
            fila.SubItems.Add($"{duracion.TotalSeconds:F1} s");
            fila.SubItems.Add(r.Alerta ? "Sí" : "No");
            fila.SubItems.Add(DateTime.Now.ToString("MM/dd/yyyy"));
            listView1.Items.Add(fila);

            // Popup
            if (r.Alerta)
            {
                MessageBox.Show($"Temperatura crítica: {temp} °C\nVentilador al 100%.",
                    "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}