﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hazedumper;

namespace AnimeSoftware
{
    class ScannedOffsets
    {
        public static int ClientCMD;
        public static int UserInfoTable;
        public static int SetConVar;
        public static int LvlBypass;
        public static int Console;
        public static void Init()
        {
            ClientCMD = Memory.FindPattern(new byte[] { 0x55, 0x8B, 0xEC, 0x8B, 0x0D, 0x00, 0x00, 0x00, 0x00, 0x81, 0xF9, 0x00, 0x00, 0x00, 0x00, 0x75, 0x0C, 0xA1, 0x00, 0x00, 0x00, 0x00, 0x35, 0x00, 0x00, 0x00, 0x00, 0xEB, 0x05, 0x8B, 0x01, 0xFF, 0x50, 0x34, 0x50, 0xA1 }, "xxxxx????xx????xxx????x????xxxxxxxxx", Memory.Engine, Memory.EngineSize);
            //UserInfoTable = Memory.FindPattern(new byte[] { 0x8B, 0x89, 0x00, 0x00, 0x00, 0x00, 0x85, 0xC9, 0x0F, 0x84, 0x00, 0x00, 0x00, 0x00, 0x8B, 0x01 }, "xx????xxxx????xx", Memory.Engine, Memory.EngineSize);
            //SetConVar = Memory.FindPattern(new byte[] { 0x8D, 0x4C, 0x24, 0x1C, 0xE8, 0x00, 0x00, 0x00, 0x00, 0x56 }, "xxxxx????x", Memory.Engine, Memory.EngineSize);
            //LvlBypass = Memory.FindPattern(new byte[] { 0x55, 0x8B, 0xEC, 0x8B, 0x55, 0x08, 0x8B, 0xCA, 0x53 }, "xxxxxxxxx", Memory.Client, Memory.ClientSize); //55 8B EC 8B 55 08 8B CA 53
            //Console = Memory.FindPattern(new byte[] { 0x58, 0x81, 0x00, 0x56, 0x00, 0x00, 0x00, 0x00 }, "xx?x????", Memory.Client, Memory.ClientSize);
        }
    }
}
