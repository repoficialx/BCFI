using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCFI
{
    public partial class Datos : Form
    {
        public Datos(dosu.Food.FInfo finfo)
        {
            InitializeComponent();
            if (finfo != null)
            {
                labelNombre.Text = finfo.Name ?? "Desconocido";
                labelMarca.Text = finfo.Brand ?? "Sin marca";

                // Cargar imagen (control PictureBox)
                if (!string.IsNullOrEmpty(finfo.ImageURL))
                    pictureBoxProducto.LoadAsync(finfo.ImageURL);

                // Mostrar NutriScore con imagen o color
                pictureBoxNutriScore.Image = GetNutriScoreImage(finfo.NutriScore);

                // Mostrar EcoScore con imagen o color
                pictureBoxEcoScore.Image = GetEcoScoreImage(finfo.EcoScore);

                // Opcional: ingredientes y alérgenos en un TextBox o Label multiline
                textBoxIngredientes.Text = finfo.IngredientsText ?? "Ingredientes no disponibles";

                // Puedes añadir más info aquí...

                textBoxAditivos.Text = finfo.Additives?.Count > 0 ? string.Join("\r\n", finfo.Additives.Select(a => { string code = a.Replace("en:", ""); var m = Regex.Match(code, @"^(E\d{3,})(.*)$", RegexOptions.IgnoreCase); return m.Success ? m.Groups[1].Value.ToUpper() + m.Groups[2].Value.ToLower() : code.ToUpper(); })) : "Aditivos no disponibles";
                ShowDialog();
            }
            else
            {
                Dispose();
            }
        }

        private Image GetNutriScoreImage(string score)
        {
            switch (score?.ToLower())
            {
                case "a": return Properties.Resources.NutriScore_A;
                case "b": return Properties.Resources.NutriScore_B;
                case "c": return Properties.Resources.NutriScore_C;
                case "d": return Properties.Resources.NutriScore_D;
                case "e": return Properties.Resources.NutriScore_E;
                default: return Properties.Resources.NutriScore_NA;
            }
        }

        private Image GetEcoScoreImage(string score)
        {
            switch (score?.ToLower())
            {
                case "a": return Properties.Resources.EcoScore_A;
                case "b": return Properties.Resources.EcoScore_B;
                case "c": return Properties.Resources.EcoScore_C;
                case "d": return Properties.Resources.EcoScore_D;
                case "e": return Properties.Resources.EcoScore_E;
                default: return Properties.Resources.EcoScore_NA;
            }
        }
    }
}
