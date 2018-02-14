using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternV2
{
    // The Target class
    abstract class RequiredFormulas
    {
        public abstract double AverageAcceleration(double velocityOne, double velocityTwo, double time);
        public abstract double FallingAcceleration(double velocityStart, double time);
        public abstract double ProjectileVerticalDistance(double velocity, double time);
        public abstract double ProjectileHorizontalDistance(double velocity, double time);
        public abstract double ProjectileVerticalVelocity(double velocity, double time);
    }
}
