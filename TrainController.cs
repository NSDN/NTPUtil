using System;

namespace NTPUtil
{
    class TrainController
    {
        public const double DT = 0.001;
        public const double minV = 0.2;

        public static void DoMotionWithAir(TrainPacket packet)
        {
            if (packet.P > 0 && packet.Velocity < 0.005)
            {
                packet.Velocity = 0.005;
            }

            if (packet.R > 1)
            {
                double MaxP = 4.0;
                double OutP = MaxP / Math.Pow(20.0, Math.E / 2.0) * Math.Pow((double)packet.P, Math.E / 2.0);
                packet.nextVelocity = Dynamics.LocoMotions.CalcVelocityUpWithAir(Math.Abs(packet.Velocity), 0.1, 1.0, OutP, DT);

                if (packet.Velocity < packet.nextVelocity)
                {
                    packet.Velocity = packet.nextVelocity;
                }
            }

            if (packet.R < 10)
            {
                double B = Math.Abs(packet.Velocity) < minV ? 2.0 : 1.0;
                packet.Velocity = Dynamics.LocoMotions.CalcVelocityDownWithAir(Math.Abs(packet.Velocity), 0.1, 1.0, B, 1.0, packet.R / 10.0, DT);
                if (packet.Velocity < 0.005) packet.Velocity = 0;
            }

        }

        public static void DoMotionWithAirEx(TrainPacket packet)
        {
            if (packet.P > 0 && packet.Velocity < 0.005)
            {
                packet.Velocity = 0.005;
            }

            if (packet.R > 1)
            {
                double MaxP = 10.0;
                double OutP = MaxP / Math.Pow(20.0, Math.E / 2.0) * Math.Pow((double)packet.P, Math.E / 2.0);
                packet.nextVelocity = Dynamics.LocoMotions.CalcVelocityUpWithAir(Math.Abs(packet.Velocity), 0.1, 1.0, OutP, DT);

                if (packet.Velocity < packet.nextVelocity)
                {
                    packet.Velocity = packet.nextVelocity;
                }
            }

            if (packet.R < 10)
            {
                double B = Math.Abs(packet.Velocity) < minV ? 2.0 : 1.0;
                packet.Velocity = Dynamics.LocoMotions.CalcVelocityDownWithAir(Math.Abs(packet.Velocity), 0.1, 1.0, B, 1.0, packet.R / 10.0, DT);
                if (packet.Velocity < 0.005) packet.Velocity = 0;
            }

        }

        public static void DoMotionWithAirHigh(TrainPacket packet)
        {

            if (packet.P > 0 && packet.Velocity < 0.005)
            {
                packet.Velocity = 0.005;
            }

            if (packet.R > 1)
            {
                double MaxP = 40.0;
                double OutP = MaxP / Math.Pow(20.0, 2.0) * Math.Pow((double)packet.P, 2.0);
                packet.nextVelocity = Dynamics.LocoMotions.CalcVelocityUpWithAir(Math.Abs(packet.Velocity), 0.1, 1.0, OutP, DT);

                if (packet.Velocity < packet.nextVelocity)
                {
                    packet.Velocity = packet.nextVelocity;
                }
            }

            if (packet.R < 10)
            {
                double B = Math.Abs(packet.Velocity) < minV ? 2.0 : 1.0;
                packet.Velocity = Dynamics.LocoMotions.CalcVelocityDownWithAir(Math.Abs(packet.Velocity), 0.1, 1.0, B, 1.0, packet.R / 10.0, DT);
                if (packet.Velocity < 0.005) packet.Velocity = 0;
            }

            if (packet.Velocity > 6.0) packet.Velocity = 6.0; 

        }

        public static void DoMotionWithAirHighEx(TrainPacket packet)
        {

            if (packet.P > 0 && packet.Velocity < 0.005)
            {
                packet.Velocity = 0.005;
            }

            if (packet.R > 1)
            {
                double MaxP = 80.0;
                double OutP = MaxP / Math.Pow(20.0, 2.0) * Math.Pow((double)packet.P, 2.0);
                packet.nextVelocity = Dynamics.LocoMotions.CalcVelocityUpWithAir(Math.Abs(packet.Velocity), 0.1, 1.0, OutP, DT);

                if (packet.Velocity < packet.nextVelocity)
                {
                    packet.Velocity = packet.nextVelocity;
                }
            }

            if (packet.R < 10)
            {
                double B = Math.Abs(packet.Velocity) < minV ? 2.0 : 1.0;
                packet.Velocity = Dynamics.LocoMotions.CalcVelocityDownWithAir(Math.Abs(packet.Velocity), 0.1, 1.0, B, 1.0, packet.R / 10.0, DT);
                if (packet.Velocity < 0.005) packet.Velocity = 0;
            }

            if (packet.Velocity > 8.0) packet.Velocity = 8.0;

        }

        public static void DoMotionWithEuler(TrainPacket packet, double maxV)
        {
            double minV = 0.02;
            if (packet.P > 0 && packet.Velocity < minV)
                packet.Velocity = minV;

            double p = packet.P / 20.0, r = 1.0 - (packet.R - 1.0) / 9.0;
            packet.nextVelocity = Dynamics.LocoMotions.CalcVelocityWithEuler(Math.Abs(packet.Velocity), p, r, maxV, 0.05);

            if ((packet.R > 1 && packet.Velocity < packet.nextVelocity) || packet.R < 10)
                packet.Velocity = packet.nextVelocity;

            if (packet.Velocity < minV) packet.Velocity = 0;
            if (packet.Velocity > maxV) packet.Velocity = maxV;
        }

    }
}
