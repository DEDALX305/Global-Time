using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Global_Time_Server
{
    //string[] info = { "Челябинск", "Москва" };
    //Console.Write("Полученный текст: " + data + "\n\n");
    //                data = String.Format(data);
    //                if (data == info[0])
    //                {
    //                    data = String.Format("21:00");
    //                }
public class ServerObject
{
    static TcpListener tcpListener; // сервер для прослушивания
    List<ClientObject> clients = new List<ClientObject>(); // все подключения
}

}
