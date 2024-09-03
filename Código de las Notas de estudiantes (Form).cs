namespace NotasEstudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPromedios_Click(object sender, EventArgs e)
        {
            // Declaración de la matriz para almacenar las calificaciones
            double[,] calificaciones = new double[4, 3];

            // Obtener calificaciones desde los TextBoxes
            calificaciones[0, 0] = Convert.ToDouble(txtEst1Ex1.Text);
            calificaciones[0, 1] = Convert.ToDouble(txtEst1Ex2.Text);
            calificaciones[0, 2] = Convert.ToDouble(txtEst1Ex3.Text);

            calificaciones[1, 0] = Convert.ToDouble(txtEst2Ex1.Text);
            calificaciones[1, 1] = Convert.ToDouble(txtEst2Ex2.Text);
            calificaciones[1, 2] = Convert.ToDouble(txtEst2Ex3.Text);

            calificaciones[2, 0] = Convert.ToDouble(txtEst3Ex1.Text);
            calificaciones[2, 1] = Convert.ToDouble(txtEst3Ex2.Text);
            calificaciones[2, 2] = Convert.ToDouble(txtEst3Ex3.Text);

            calificaciones[3, 0] = Convert.ToDouble(txtEst4Ex1.Text);
            calificaciones[3, 1] = Convert.ToDouble(txtEst4Ex2.Text);
            calificaciones[3, 2] = Convert.ToDouble(txtEst4Ex3.Text);

            // Variables para almacenar los promedios
            double[] promediosEstudiantes = new double[4];
            double sumaGeneral = 0;

            // Calcular los promedios
            for (int i = 0; i < calificaciones.GetLength(0); i++)
            {
                double sumaEstudiante = 0;
                for (int j = 0; j < calificaciones.GetLength(1); j++)
                {
                    sumaEstudiante += calificaciones[i, j];
                }
                promediosEstudiantes[i] = sumaEstudiante / calificaciones.GetLength(1);
                sumaGeneral += promediosEstudiantes[i];
            }

            // Calcular el promedio general
            double promedioGeneral = sumaGeneral / calificaciones.GetLength(0);

            // Mostrar los promedios en el ListBox
            lstPromedios.Items.Clear();
            for (int i = 0; i < promediosEstudiantes.Length; i++)
            {
                lstPromedios.Items.Add($"Promedio del Estudiante {i + 1}: " +
                    $"{promediosEstudiantes[i]:0.00}");
            }

            // Mostrar el promedio general en el Label
            lblPromedioGeneral.Text = $"Promedio General de la Clase: {promedioGeneral:0.00}";

        }
    }
}
