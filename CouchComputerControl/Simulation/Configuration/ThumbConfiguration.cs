using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouchComputerControl.Simulation.Configuration
{
    public class ThumbConfiguration
    {
        [JsonIgnore]
        public Vector2 Vector
        {
            get
            {
                if (Thumb == null)
                    return Vector2.Zero;

                var sX = Math.Sign(Thumb.X);
                var sY = Math.Sign(Thumb.Y);
                var aX = Math.Abs(Thumb.X);
                var aY = Math.Abs(Thumb.Y);

                if (aX <= DeadZoneX / 100f)
                    aX = 0f;
                else
                    aX = (aX - (DeadZoneX / 100f)) * (100f / (100f - DeadZoneX));
                if (aY <= DeadZoneY / 100f)
                    aY = 0f;
                else
                    aY = (aY - (DeadZoneY / 100f)) * (100f / (100f - DeadZoneY));

                return new Vector2(aX * sX, aY * sY);
            }
        }
        public float DeadZoneX
        {
            get { return deadX; }
            set { deadX.Value = value; }
        }
        public float DeadZoneY
        {
            get { return deadY; }
            set { deadY.Value = value; }
        }
        [JsonIgnore]
        public SmartController.GamepadThumb Thumb { get; set; }

        private BindableProperty<float> deadX, deadY;

        public ThumbConfiguration()
        {
            deadX = new BindableProperty<float>();
            deadY = new BindableProperty<float>();
            deadX.Value = 1f;
            deadY.Value = 1f;
        }

        public void Bind(Func<float> gDeadX, Action<float> sDeadX, Func<float> gDeadY, Action<float> sDeadY)
        {
            deadX.Bind(gDeadX, sDeadX);
            deadY.Bind(gDeadY, sDeadY);
        }
        public void Unbind()
        {
            deadX.Unbind();
            deadY.Unbind();
        }
    }
}
