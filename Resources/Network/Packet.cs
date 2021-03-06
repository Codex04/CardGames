﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameResources.Network
{
    public enum PacketType
    {
        ERR = -1,
        SYS = 0,
        GAME,
        API
    }
    public class Packet
    {
        private string name;
        private PacketType type;
        private Object data;

        public Packet(string name_, PacketType type_, Object data_)
        {
            this.Name = name_;
            this.Type = type_;
            this.Data = data_;
        }

        public string Name { get => name; set => name = value; }
        public PacketType Type { get => type; set => type = value; }
        public object Data { get => data; set => data = value; }
    }
}
