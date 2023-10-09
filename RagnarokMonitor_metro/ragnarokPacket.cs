﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RagnarokMonitor_metro
{
    public enum Protocol
    {
        TCP = 6,
        UDP = 17,
        Unknown = -1
    };

    class ragnarokPacket
    {
        public static bool verifyServerInfo(byte[] data, int nRecv)
        {
            if (data[0] == 0xc0 && data[1] == 0xa8)
                return true;
            else
                return false;
        }

        public static int getServerInfoSetsNumber(int nRecv,int infoOffset)
        {          
            return nRecv / infoOffset;
        }
    }
}
