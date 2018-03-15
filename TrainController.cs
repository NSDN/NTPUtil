using System;

namespace NTPUtil
{
    class TrainController
    {
        public const double DT = 0.001;

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
                packet.Velocity = Dynamics.LocoMotions.CalcVelocityDownWithAir(Math.Abs(packet.Velocity), 0.1, 1.0, 1.0, 1.0, packet.R / 10.0, DT);
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
                double MaxP = 20.0;
                double OutP = MaxP / Math.Pow(20.0, 2.0) * Math.Pow((double)packet.P, 2.0);
                packet.nextVelocity = Dynamics.LocoMotions.CalcVelocityUpWithAir(Math.Abs(packet.Velocity), 0.1, 1.0, OutP, DT);

                if (packet.Velocity < packet.nextVelocity)
                {
                    packet.Velocity = packet.nextVelocity;
                }
            }

            if (packet.R < 10)
            {
                packet.Velocity = Dynamics.LocoMotions.CalcVelocityDownWithAir(Math.Abs(packet.Velocity), 0.1, 1.0, 1.0, 1.0, packet.R / 10.0, DT);
                if (packet.Velocity < 0.005) packet.Velocity = 0;
            }

        }

    }
}
