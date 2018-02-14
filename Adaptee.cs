using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternV2
{
    // The Adaptee class
    class Formulas
    {
        private const double G_ACCEL = 32.2; // in feet per second

        public static double AverageAcceleration(double velocityOne, double velocityTwo, double time)
        {
            return ((velocityOne - velocityTwo) / time);
        }

        public static double FallingAcceleration(double velocityStart, double time)
        {
            return (time * G_ACCEL + velocityStart);
        }

        public static double ProjectileVerticalDistance(double velocity, double time)
        {
            return ((velocity * time) - (0.5 * G_ACCEL * time * time));
        }

        public static double ProjectileHorizontalDistance(double velocity, double time)
        {
            return velocity * time;
        }

        public static double ProjectileVerticalVelocity(double velocity, double time)
        {
            return velocity - G_ACCEL * time;
        }
    }
}
