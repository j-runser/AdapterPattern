using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternV2
{
    class MetricFormulas : RequiredFormulas
    {
        private const double FOOT_PER_METER = 3.28084;
        private const double METER_PER_FOOT = 0.3048;

        public override double AverageAcceleration(double velocityOne, double velocityTwo, double time)
        {
            // It will work as is.
            return Formulas.AverageAcceleration(velocityOne, velocityTwo, time);
        }

        public override double FallingAcceleration(double velocityStart, double time)
        {
            velocityStart = velocityStart * FOOT_PER_METER;
            return Formulas.FallingAcceleration(velocityStart, time) * METER_PER_FOOT;
        }

        public override double ProjectileHorizontalDistance(double velocity, double time)
        {
            // Will also work as is.
            return Formulas.ProjectileHorizontalDistance(velocity, time);
        }

        public override double ProjectileVerticalDistance(double velocity, double time)
        {
            velocity = velocity * FOOT_PER_METER;
            return Formulas.ProjectileVerticalDistance(velocity, time) * METER_PER_FOOT;
        }

        public override double ProjectileVerticalVelocity(double velocity, double time)
        {
            velocity = velocity * FOOT_PER_METER;
            return Formulas.ProjectileVerticalVelocity(velocity, time) * METER_PER_FOOT;
        }
    }
}
