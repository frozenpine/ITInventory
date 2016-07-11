using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace CommonClass
{
    public enum Maskv4
    {
        m128_0_0_0 = 1,
        m192_0_0_0,
        m224_0_0_0,
        m240_0_0_0,
        m248_0_0_0,
        m252_0_0_0,
        m254_0_0_0,
        m255_0_0_0,
        m255_128_0_0,
        m255_192_0_0,
        m255_224_0_0,
        m255_240_0_0,
        m255_248_0_0,
        m255_252_0_0,
        m255_254_0_0,
        m255_255_0_0,
        m255_255_128_0,
        m255_255_192_0,
        m255_255_224_0,
        m255_255_240_0,
        m255_255_248_0,
        m255_255_252_0,
        m255_255_254_0,
        m255_255_255_0,
        m255_255_255_128,
        m255_255_255_192,
        m255_255_255_224,
        m255_255_255_240,
        m255_255_255_248,
        m255_255_255_252
    };

    [Serializable]
    public class TCPIP
    {
        private uint ipv4 = 0;
        public string IPv4Address
        {
            set
            {
                ipv4 = Str2UintAddr4(value);
            }
            get
            {
                return Uint2StrAddr4(ipv4);
            }
        }
        public byte[] IPv4AddrBytes
        {
            get
            {
                return BitConverter.GetBytes(ipv4);
            }
            set
            {
                ipv4 = System.BitConverter.ToUInt32(value, 0);
            }
        }

        private uint maskv4 = 0;
        public string IPv4Mask
        {
            set
            {
                if(Regex.IsMatch(value,@"^[1-3]?[0-9]$"))
                {
                    maskv4 = Bit2UintMask(int.Parse(value));
                }
                else if(Regex.IsMatch(value, @"^([0-9]{1,3}\.){3}[0-9]{1,3}$"))
                {
                    try
                    {
                        maskv4 = Bit2UintMask((int)Enum.Parse(typeof(Maskv4), "m" + value.Replace('.', '_')));
                    }
                    catch
                    {
                        Debug.WriteLine("illegal mask input.");
                    }
                }
                else
                {
                    Debug.WriteLine("illegal mask format.");
                }
            }
            get
            {
                return Uint2StrAddr4(maskv4);
            }
        }
        public byte[] IPv4MaskBytes
        {
            get
            {
                return BitConverter.GetBytes(maskv4);
            }
            set
            {
                maskv4 = System.BitConverter.ToUInt32(value, 0);
            }
        }
        public int IPv4MaskBit
        {
            get
            {
                int count = 0;
                uint temp = maskv4;
                while (temp > 0)
                {
                    count++;
                    temp = temp << 1;
                }
                return count;
            }
        }

        private uint gwv4 = 0;
        public string IPv4Gw
        {
            set
            {
                uint tempgw = Str2UintAddr4(value);
                if (tempgw != 0 && (gwv4 > (ipv4 & maskv4) && gwv4 < (ipv4 | ~maskv4)))
                    gwv4 = tempgw;
            }
            get
            {
                return Uint2StrAddr4(gwv4);
            }
        }
        public byte[] IPv4GwBytes
        {
            get
            {
                return BitConverter.GetBytes(gwv4);
            }
            set
            {
                gwv4 = System.BitConverter.ToUInt32(value, 0);
            }
        }

        private string ipv4Description;
        public string IPv4Description
        {
            get { return ipv4Description; }
            set { ipv4Description = value; }
        }

        public string IPv4NetID
        {
            get { return Uint2StrAddr4(ipv4 & maskv4); }
        }
        public string IPv4BroadcastAddr
        {
            get { return Uint2StrAddr4(ipv4 | ~maskv4); }
        }
        public int IPv4ValidHostsCount
        {
            get
            {
                return (int)(~maskv4 - 1U);
            }
        }
        public string IPv4ValidFirstHost
        {
            get { return Uint2StrAddr4(ipv4 & maskv4 | 1U); }
        }
        public string IPv4ValidLastHost
        {
            get { return Uint2StrAddr4((ipv4 | ~maskv4) & 0xFFFFFFFE); }
        }
        public bool IPv4Valid
        {
            get
            {
                if (ipv4 > (ipv4 & maskv4) && ipv4 < (ipv4 | ~maskv4))
                    return true;
                else
                    return false;
            }
        }

        public static string Uint2StrAddr4(uint ip)
        {
            string sec1, sec2, sec3, sec4;
            sec1 = (ip >> 24).ToString();
            sec2 = ((ip & 0x00FF0000) >> 16).ToString();
            sec3 = ((ip & 0x0000FF00) >> 8).ToString();
            sec4 = (ip & 0x000000FF).ToString();
            return sec1 + "." + sec2 + "." + sec3 + "." + sec4;
        }
        public static uint Str2UintAddr4(string ip)
        {
            if (Regex.IsMatch(ip, @"^([0-9]{1,3}\.){3}[0-9]{1,3}$"))
            {
                string[] sec = ip.Split('.');
                uint[] result = new uint[4];
                for (int i = 0; i < 4; i++)
                {
                    result[i] = uint.Parse(sec[i]);
                    if (result[i] >= 0 && result[i] <= 255)
                        continue;
                    else
                        return 0;
                }
                return ((result[0] << 24) | (result[1] << 16) | (result[2] << 8) | result[3]);
            }
            else
            {
                Debug.WriteLine("illegal address format.");
                return 0;
            }
        }
        public static uint Bit2UintMask(int bit)
        {
            if (bit >= 1 && bit <= 30)
            {
                return 0xFFFFFFFF << (32 - bit);
            }
            else
            {
                Debug.WriteLine("mask bit out of rang.");
                return 0;
            }
        }
        public static bool IsIPv4AddrValid(string ip,string mask)                           //判断ip地址是否属于ip/mask地址范围内
        {
            uint tempip = 0;
            uint tempmask = 0;
            tempip = Str2UintAddr4(ip);
            tempmask = Str2UintAddr4(mask);
            if (tempip > (tempip & tempmask) && tempip < (tempip | ~tempmask))
                return true;
            else
                return false;
        }

        public static bool IsIPv4FormatValid(string ip)                                       //判断ip地址格式是否正确
        {
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }
        public static bool IsIPv4MaskValid(string mask)                                        //判断掩码格式是否正确
        {
            try
            {
                Enum.Parse(typeof(Maskv4), "m" + mask.Replace(".", "_"), true);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static byte[] ARP(string ipv4)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Raw);
            return new byte[6];
        }
    }
}
