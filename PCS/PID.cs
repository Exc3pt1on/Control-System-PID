using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PCS
{
    internal class PID
    {
        public double U { get; private set; }
        private double E { get; set; }
        private double I_iterated { get; set; }
        public double Kp { get; set; }
        public double Ti { get; set; }
        public double Td { get; set; }
        public double antiWindup { get; set; }

        private double previousFilteredDerivative = 0;
        public double alpha { get; set; }

        public PID(double Kp, double Ti, double Td, double antiWindup)
        {
            I_iterated = 0;
            E = 0;
            this.Kp = Kp;
            this.Ti = Ti;
            this.Td = Td;
            U = 0;
            this.antiWindup = antiWindup;
            alpha = 0.1;
        }

        public PID(double Kp, double Ti, double antiWindup)
        {
            I_iterated = 0;
            E = 0;
            this.Kp = Kp;
            this.Ti = Ti;
            this.Td = 0;
            U = 0;
            this.antiWindup = antiWindup;
            alpha = 0.1;
        }
        public PID(double Kp, double antiWindup)
        {
            I_iterated = 0;
            E = 0;
            this.Kp = Kp;
            this.Ti = Double.MaxValue;
            this.Td = 0;
            U = 0;
            this.antiWindup = antiWindup;
            alpha = 0.1;
        }
        public PID()
        {
            I_iterated = 0;
            E = 0;
            this.Kp = 0;
            this.Ti = Double.MaxValue;
            this.Td = 0;
            U = 0;
            this.antiWindup = 0;
            alpha = 0.1;
        }

        public double NextU(double y, double setpoint, double dt)
        {
            double e;
            e = setpoint - y;
            I_iterated += e * dt;

            if (Math.Abs(I_iterated) > antiWindup)
            {
                I_iterated = Math.Sign(I_iterated) * antiWindup;
            }

            double derivative = (e - E) / dt;

            // Low-pass filter on the derivative term
            double filteredDerivative = alpha * derivative + (1 - alpha) * previousFilteredDerivative;

            // Update previous filtered derivative for next iteration
            previousFilteredDerivative = filteredDerivative;

            U = Kp * (e + (1/Ti) * I_iterated + Td * filteredDerivative);
            E = e;
            return U;
        }
    }
}
