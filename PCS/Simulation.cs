using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;


namespace PCS
{
    internal class Simulation
    {
        private double A;
        private double[] B;
        private double C;
        private double state;

        public Simulation(double a, double[] b, double c, double initialState)
        {
            A = a;
            B = b;
            C = c;
            state = initialState;
        }

        public double UpdateSimulation(double[] u, double dt)
        {

            double xDot = (A * state) + (B[0] * u[0] + B[1] * u[1]);
            xDot = xDot - state;
            state += xDot * dt;

            double output = C * state + 25; // Assuming C is a scalar
                                          // Do something with the output...
            return output;
        }
    }
}
