﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRCTools.networking.commands
{
    internal class ModListChangedCommand : Command
    {

        public void Send(string instanceId)
        {
            WriteLine(instanceId);
            Destroy();
        }

        public override void Handle(string parts) { }
    }
}
