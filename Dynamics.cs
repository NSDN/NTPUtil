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
                    double f = p * u * m * G + (1 - p) * k * vp * vp;
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
                    double f = p * u * m * G + (1 - p) * k * vp * vp;
                    double a = (B * B * L * L * vp / R + f) / m;
                    return vp - a * dt;
                }
                else
                {
                    return 0.0;
                }
            }

            public static double FMod(double f, double v)
            {
                double k = 1;
                double res = f * (1 - Math.Exp(-k * v * v));
                return res;
            }

            public static double ElectricLoco(double y, double power, double brake, double maxV, string type)
            {
                double P = 1000 * Math.Pow(maxV, 4) * power;
                double R = (1 - brake) * 10 + 1;
                double m = 5000, g = 9.8;
                double k = 0.1, B = 1, L = 10;
                double v = y * 3.6;
                double ub = 1;
                double ud = 1;
                double fb = ub * m * g;
                double fd = ud * m * g;

                double res = 0, ft = 0;
                if (type == "up")
                {
                    ft = P / y;
                    if (ft > fd) ft = fd;
                    res = (ft - k * y * y) / m;
                }
                else if (type == "down")
                {
                    if (v < 120) B = B * 2;
                    ft = (B * B * L * L * y) / R;
                    if (v < 60) ft = FMod(fb, y) * brake;
                    else if (ft > fd) ft = fd;
                    res = -(ft + k * y * y) / m;
                }
                return res;
            }

            public static double ElectricLocoWithSlip(double y, double power, double brake, double maxV, string type)
            {
                double P = 916.48 * Math.Pow(maxV, 2.9305) * power;
                double R = (1 - brake) * 10 + 1;
                double m = 5000, g = 9.8;
                double k = 0.1, B = 1, L = 10;
                double v = y * 3.6;
                double ub = 0.31 + 3 / (30 + 10 * v);
                double ud = 0.06 + 46.6 / (260 + v);
                double fb = ub * m * g;
                double fd = ud * m * g;

                double res = 0, ft = 0;
                if (type == "up")
                {
                    ft = P / y;
                    if (ft > fd) ft = fd;
                    res = (ft - k * y * y) / m;
                }
                else if (type == "down")
                {
                    if (v < 120) B = B * 2;
                    ft = (B * B * L * L * y) / R;
                    if (v < 60) ft = FMod(fb, y) * brake;
                    else if (ft > fd) ft = fd;
                    res = -(ft + k * y * y) / m;
                }
                return res;
            }

            public static double CalcVelocityWithEuler(double vp, double power, double brake, double maxV, double h)
            {
                vp = vp * 20;
                if (power < 0) power = 0; else if (power > 1) power = 1;
                if (brake < 0) brake = 0; else if (brake > 1) brake = 1;
                double k1 = ElectricLoco(vp, power, brake, maxV, "up");
                double k2 = ElectricLoco(vp + h * k1, power, brake, maxV, "up");
                double dv = h / 2 * (k1 + k2);
                if (brake > 0)
                {
                    k1 = ElectricLoco(vp, power, brake, maxV, "down");
                    k2 = ElectricLoco(vp + h * k1, power, brake, maxV, "down");
                    dv = h / 2 * (k1 + k2);
                }
                double res = vp + dv;
                res = res / 20;
                return res;
            }

            public static double CalcVelocityWithSlip(double vp, double power, double brake, double maxV, double h)
            {
                vp = vp * 20;
                if (power < 0) power = 0; else if (power > 1) power = 1;
                if (brake < 0) brake = 0; else if (brake > 1) brake = 1;
                double k1 = ElectricLocoWithSlip(vp, power, brake, maxV, "up");
                double k2 = ElectricLocoWithSlip(vp + h * k1, power, brake, maxV, "up");
                double dv = h / 2 * (k1 + k2);
                if (brake > 0)
                {
                    k1 = ElectricLocoWithSlip(vp, power, brake, maxV, "down");
                    k2 = ElectricLocoWithSlip(vp + h * k1, power, brake, maxV, "down");
                    dv = h / 2 * (k1 + k2);
                }
                double res = vp + dv;
                res = res / 20;
                return res;
            }

        }

    }
}
