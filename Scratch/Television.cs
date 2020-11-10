﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratch
{
    class Television
    {

        private int channel = 0;
        private int volume = 0;
        private bool isOn = false;

        public bool IsOn()
        {
            return isOn;
        }
        public void TurnOn()
        {
            isOn = true;
            // do the code to turn the tv on
        }
        public void TurnOff()
        {
            isOn = false;
            // do the code to turn the tv off
        }

        public int CurrentVolume()
        {
            return volume;
        }
        public void IncreaseVolume()
        {
            if (volume < 100)
            {
                volume = volume + 1;
                // do the code to increase the volume
            }
        }
        public void DecreaseVolume()
        {
            if (volume > 0)
            {
                volume = volume - 1;
                // do the code to decrease the volume
            }
        }

        public int CurrentChannel()
        {
            return channel;
        }
        public void ChangeChannel(int channel)
        {
            if (channel > 0 && channel < 50)
            {
                // We use "this" because the parameter channel is the same
                // name as the instance variable channel.

                this.channel = channel;

                // do the code to change the
                // channel on the tv
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // var is used as a shorthand for Television (or whatever type is on the right-hand side)
            var tv = new Television();

            if (tv.IsOn() == false)
            {
                tv.TurnOn();
            }

            tv.ChangeChannel(3);

            tv.IncreaseVolume();
            tv.IncreaseVolume();
            tv.IncreaseVolume();
            tv.IncreaseVolume();

            tv.TurnOff();
        }
    }
}
