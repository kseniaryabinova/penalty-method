using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra.Double;

namespace methods_of_optimisation.classes
{
    class newton_method : Unconditional_extremum
    {
        private Matrix<double> H;

        public newton_method(double[] vector, Func<double[], double> f,
            double epsilon1 = 0.01, double epsilon2 = 0.015)
                : base(vector, f, epsilon1, epsilon2)
        { }        

        private void Hesse(Vector<double> vec)
        {
            H = Matrix<double>.Build.Dense(vec.Count, vec.Count);
            vector = vec.ToArray();
            for (int i = 0; i < vec.Count; i++)
                for (int j = 0; j < vec.Count; j++)
                    H[i, j] = Differentiate.PartialDerivative(
                        Differentiate.FirstPartialDerivativeFunc(f, i), vector, j, 1);
        }

        public override string algorithm()
        {
            Vector<double> vect = DenseVector.OfArray(vector), vectorPred = vect,
                grad = vect;
            string str = "";
            int N = 1000;
            double r2 = 0.01;

            while (true)
            {
                if (f(vect.ToArray()) <= epsilon1)
                    return str + "выход по основному условию";
                else
                    vect[vect.Count - 1] = r2 *= 10;
                if (r2 == 100000000000000000d)
                    return str + "r > 100000000000000000";

                grad = gradient(vect);
                Hesse(vect);
                vectorPred = vect;
                vect = vect + H.Inverse() * (-grad);

                str += "\tитерация №" + (1001 - N);
                str += "\r\nминимум = {";
                for (int i = 0; i<vect.Count - 1; ++i)
                    str += (Math.Round(vect[i], 6)).ToString() + ";  ";
                str = str.Substring(0, str.Length - 3);
                str += "}\r\nr = " + r2;
                str += "\r\nf = " + f(vect.ToArray()) + "\r\n\r\n";

                if (--N == 0)
                    return str + "число итераций достигло максимума";
            }
        }
    }
}
