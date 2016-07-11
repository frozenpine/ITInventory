using System;
using System.Collections;
using System.Linq;
using System.Text;
using CommonClass;
using System.Data;
using System.Data.OleDb;

namespace TCPIP_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            TCPIP tcpip = new TCPIP();
            DB test = new DB(@"Provider=SQLOLEDB;Data Source=localhost;Persist Security Info=True;Password=quantdo;User ID=quantdo;Initial Catalog=ITInventory");
            label1:
            /*
            Console.WriteLine("Please input IPv4 Address:");
            tcpip.IPv4Address=Console.ReadLine();
            Console.WriteLine("Please input Netmask Address( prefix / netmask ):");
            tcpip.IPv4Mask = Console.ReadLine();
            if (tcpip.IPv4Valid)
            {
                Console.WriteLine("Your input is：");
                Console.WriteLine("IP Address :{0}", tcpip.IPv4Address);
                Console.WriteLine("   Netmask :{0}  Prefix:{1}", tcpip.IPv4Mask, tcpip.IPv4MaskBit);
                Console.WriteLine("Network ID is {0}, Broadcast Address is {1}.", tcpip.IPv4NetID, tcpip.IPv4BroadcastAddr);
                Console.WriteLine("First valid host is {0}, Last valid host is {1}", tcpip.IPv4ValidFirstHost, tcpip.IPv4ValidLastHost);
                Console.WriteLine("Total valid hosts count is {0}\n", tcpip.IPv4ValidHostsCount);
                
                OleDbParameter addr = new OleDbParameter("@P1", OleDbType.VarBinary,4);
                addr.Value = tcpip.IPv4AddrBytes;
                OleDbParameter mask = new OleDbParameter("@P2", OleDbType.VarBinary, 4);
                mask.Value = tcpip.IPv4MaskBytes;
                OleDbParameter id = new OleDbParameter("@P3", OleDbType.Integer);
                Console.WriteLine("Bind address to which socket?");
                id.Value = int.Parse(Console.ReadLine());
                DBCode result = test.InsertData("INSERT INTO SocketAddressInfo(socket_ipv4_addr,socket_ipv4_mask,socket_info_id_ref) VALUES (?,?,?)", new OleDbParameter[] { addr, mask, id });        //OleDb的参数用问号
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Your IP Address is invalid.");
            }
            */
            OleDbDataReader reader = test.GetData("SELECT socket_ipv4_addr,socket_ipv4_mask FROM SocketAddressInfo WHERE socket_info_id_ref=1037");
            while(reader.Read())
            {
                tcpip.IPv4AddrBytes = (byte[])reader[0];
                tcpip.IPv4MaskBytes = (byte[])reader[1];
                Console.WriteLine(tcpip.IPv4Address);
                Console.WriteLine(tcpip.IPv4Mask);
            }
            reader.Close();
            if (TCPIP.IsIPv4MaskValid(Console.ReadLine()))
                Console.WriteLine("valid mask.");
            else
                Console.WriteLine("invalid mask.");
            goto label1;
        }
    }
}
