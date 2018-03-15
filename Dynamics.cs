using System;

namespace NTPUtil
{
    class Dynamics
    {
        public const double G = 9.8;

        public static double Vel(double vx, double vz)
        {
            return Math.Sqrt(vx * vx + vz * vz);
        }

        public static class LocoMotions
        {

            public static double CalcVelocityUp(double vp, double u, double m, double P, double dt)
            {
                if (vp > 0)
                {
                    double f = u * m * G;
                    double amax = (1.0 - u) * G;
                    double a = (P - f * vp) / (vp * m);
                    if (a > amax) a = amax;
                    return vp + a * dt;
                }
                else
                {
                    return 0.0;
                }
            }

            public static double CalcVelocityUp(double F, double vp, double u, double m, double P, double dt)
            {
                if (vp > 0)
                {
                    double f = u * m * G;
                    double amax = (1.0 - u) * G;
                    double a = (P + (F - f) * vp) / (vp * m);
                    if (a > amax) a = amax;
                    return vp + a * dt;
                }
                else
                {
                    return 0.0;
                }
            }

            public static double CalcVelocityDown(double vp, double u, double m, double B, double L, double R, double dt)
            {
                if (vp > 0)
                {
                    double f = u * m * G;
                    double amax = (1.0 + u) * G;
                    double a = (B * B * L * L * vp / R + f) / m;
                    if (a > amax) a = amax;
                    if (a < u * G) a = u * G;
                    return vp - a * dt;
                }
                else
                {
                    return 0.0;
                }
            }

            public static double CalcVelocityDown(double F, double vp, double u, double m, double B, double L, double R, double dt)
            {
                if (vp > 0)
                {
                    double f = u * m * G;
                    double amax = (1.0 + u) * G;
                    double a = (B * B * L * L * vp / R + f - F) / m;
                    if (a > amax) a = amax;
                    if (a < u * G) a = u * G;
                    return vp - a * dt;
                }
                else
                {
                    return 0.0;
                }
            }

            public static double CalcVelocityUpWithAir(double vp, double u, double m, double P, double dt)
            {
                if (vp > 0)
                {
                    double k = 0.25;
                    double p = 0.5;
                    double f = p * u * G + (1 - p) * k * vp * vp;
                    double a = (P - f * vp) / (vp * m);
                    return vp + a * dt;
                }
                else
                {
                    return 0.0;
                }
            }

            public static double CalcVelocityDownWithAir(double vp, double u, double m, double B, double L, double R, double dt)
            {
                if (vp > 0)
                {
                    double k = 0.25;
                    double p = 0.5;
                    double f = p * u * G + (1 - p) * k * vp * vp;
                    double a = (B * B * L * L * vp / R + f) / m;
                    return vp - a * dt;
                }
                else
                {
                    return 0.0;
                }
            }

        }

    }
}
