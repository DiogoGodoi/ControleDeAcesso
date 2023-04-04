﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoConexao
    {
        private static string IP { get; set; }
        private static uint port { get; set; }
        public DaoConexao(string pmtIp, uint pmtPort) { 
            IP = pmtIp;
            port = pmtPort;
        }
        public static string getIP()
        {
            return IP;
        }
        public static uint getPort()
        {
            return port;
        }
    }
}