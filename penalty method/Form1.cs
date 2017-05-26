using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jace;
using methods_of_optimisation.classes;
using methods_of_optimisation;
using System.IO;

namespace penalty_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check())
            {
                var variables = new Dictionary<string, double>();
                var engine = new CalculationEngine();
                double[] arr = { 1, 2, 0.01 };
                Func<double[], double> f = (double[] x) =>
                {
                    for (int i = 0; i < x.Length-1; ++i)
                        variables["x" + (i + 1).ToString()] = x[i];
                    return engine.Calculate(equation.Text, variables) +
                        x[x.Length-1] / 2 * Math.Pow(engine.Calculate(penalty.Text, variables), 2);
                };
                Unconditional_extremum method = new newton_method(arr, f);
                output.Text = method.algorithm();
            }
            else
                MessageBox.Show("заполните все поля");
        }

        private bool check()
        {
            return equation.Text != "введите функцию" &&
                penalty.Text != "введите функцию штрафов";
        }

        private void penalty_Leave(object sender, EventArgs e)
        {
            if (!penalty.Items.Contains(penalty.Text)
                && penalty.Text != ""
                && penalty.Text != "введите функцию штрафов")
            {
                penalty.Items.Add(penalty.Text);
                StreamWriter file = File.AppendText("../../penalties.txt");
                file.WriteLine(penalty.Text);
                file.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            equation.Items.Clear();
            StreamReader file = new StreamReader("../../equations.txt");
            string line;
            while ((line = file.ReadLine()) != null)
                equation.Items.Add(line);
            file.Close();

            penalty.Items.Clear();
            file = new StreamReader("../../penalties.txt");
            while ((line = file.ReadLine()) != null)
                penalty.Items.Add(line);
            file.Close();
        }

        private void equation_Leave(object sender, EventArgs e)
        {
            if (!equation.Items.Contains(equation.Text)
                && equation.Text != ""
                && equation.Text != "введите функцию")
            {
                equation.Items.Add(equation.Text);
                StreamWriter file = File.AppendText("../../equations.txt");
                file.WriteLine(equation.Text);
                file.Close();
            }
        }
    }
}
