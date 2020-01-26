using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosPracticaArrays
{
    public partial class Form1 : Form
    {
        #region Cosas por defecto
        string[] MONTHS = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        string[] CATEGORIASBOXEO = { "Peso minimosca", "Peso mosca", "Peso gallo", "Peso pluma", "Peso ligero", "Peso superligero", "Peso wélter", "Peso mediano", "Peso mediopesado", "Peso pesado", "Peso superpesado" };
        int[] PESOSBOXEO = { 48, 51, 54, 57, 60, 64, 69, 75, 81, 91 };

        int[] vectorPrueba1 = { 0, 0, 0, 1, 1, 0, 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1 };
        int[] vectorPrueba2 = { 1, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1 };
        int[] vectorPrueba3 = { 0, 0, 0, 0, 0, 0, 0, 1, 0 };
        int[] vectorPrueba4 = { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 };

        int[,] matrizMagica1 = { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } };
        int[,] matrizMagica2 = { { 11, 18, 25, 2, 9 }, { 10, 12, 19, 21, 3 }, { 4, 6, 13, 20, 22 }, { 23, 5, 7, 14, 16 }, { 17, 24, 1, 8, 15 } };
        int[,] matrizNoMagica = { { 1, 2, 3 }, { 9, 8, 7 }, { 5, 6, 4 } };
        int[,] matrizNoMagica2 = { { 1, 2, 3 }, { 9, 8, 7 }, { 5, 6, 4 } };
        int[,] matrizNoMagica3 = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
        #endregion


        public Form1()
        {
            InitializeComponent();
        }
    }
}
