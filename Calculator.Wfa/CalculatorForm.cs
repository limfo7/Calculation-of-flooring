using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Wfa
{
    // TODO: Длина покрытия у кавролина и линолеума отсутствует (metry)


    public partial class CalculatorForm : Form
    {
        private object[] _coverageTypes = { "Керамическая плитка", "Линолеум", "Паркет", "Паркетная доска", "Ковролин", "Ламинат" };

        public CalculatorForm()
        {

            InitializeComponent();
            //CovTypeComboBox.Items.AddRange(_coverageTypes);
        }

        private string getResult()
        {
            var result = 1d;
            if (!(CovTypeComboBox.SelectedItem.ToString().Equals("Ковролин") || CovTypeComboBox.SelectedItem.ToString().Equals("Линолеум")))
            {
                result =
                    Round(double.Parse(FloorLengthTextBox.Text) / double.Parse(CovLengthTxtBox.Text)) *
                    Round(double.Parse(FloorWidthTextBox.Text) / double.Parse(CovWidthTextBox.Text));

                return $"{result} шт.";

            }
            result =
                Round(double.Parse(FloorLengthTextBox.Text)) *
                Round(double.Parse(FloorWidthTextBox.Text) / double.Parse(CovWidthTextBox.Text));

            return $"{result} м.";
        }

        private double Round(double value)
        {
            var strValue = value.ToString().Split(',');
            if (strValue.Length == 2 && Convert.ToDouble(strValue[1]) > 0d)
            {
                return Convert.ToDouble(strValue[0]) + 1;
            }
            return value;
        }

        private void ResultBtn_Click(object sender, EventArgs e)
        {
            var result = getResult();
            MinExpenseResultLbl.Text = result;
        }


    }
}
//function calc_s()
//{
//    var calcil =$('#form').get(0);
//    var result = document.getElementById("resultat");
//    if (calcil._type.value == 1)
//    {
//        t = Math.ceil(calcil.sa.value / calcil._a.value) * Math.ceil(calcil.sb.value / calcil._b.value);
//        n = String(t) + "(шт.)"
//    }
//    else
//    {
//        t = calcil.sa.value * (Math.ceil(calcil.sb.value / calcil._b.value));
//        n = String(t) + "(м.)"
//    };
//    if (isNaN(t) == !1) result.innerHTML = n;
//    else resultat.innerHTML = "0"; return !1
//    }
// math.ceil - округление до большего
// sa -dliana pola
// _b - shirina pokritiya
// sb - shirina pola
// _a - dlina pokritiya