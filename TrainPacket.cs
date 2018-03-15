using System;

namespace NTPUtil
{
    class TrainPacket
    {

        public int P, R, Dir;
        public int tmpR = -1;

        public double Velocity;
        public double maxVelocity;
        public double nextVelocity;

        public TrainPacket()
        {
            this.P = 0;
            this.R = 0;
            this.Dir = 0;
        }

        public TrainPacket(int P, int R, int Dir)
        {
            this.P = P;
            this.R = R;
            this.Dir = Dir;
        }

        public void SetVelocity(double v)
        {
            this.Velocity = v;
        }

    }
}
