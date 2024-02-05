using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using Newtonsoft.Json;

public class JSONConverter
{
    public string[] ides { get; set;}
    public string[] Score { get; set; }
}

public class Cliente : MonoBehaviour
{
    JSONConverter jSON;
    public TMP_InputField n;
    public TMP_Text tx;
 
    public void OnClick()
    {
        StartClient(n.text, GameManager.gm.ReturnPoints());
    
    }
  
    public void StartClient(string _Name, int _Score)
    {
        IPHostEntry host = Dns.GetHostEntry("localhost");
        IPAddress ipAddress = host.AddressList[0];
        IPEndPoint remoteEP = new IPEndPoint(ipAddress, 9000);

        // Crea un TCP/IP  socket.
        Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
       
        // Connecta el socket al servidor. Captura qualsevol error.
        try
        {
            // Connecta al servidor
            sender.Connect(remoteEP);
            NetworkStream NS = new NetworkStream(sender);
            StreamReader SR = new StreamReader(NS);
            StreamWriter SW = new StreamWriter(NS);
            SW.WriteLine(_Name + "/" + _Score);
            SW.Flush();
            String data;
           
            while((data=SR.ReadLine())!=null)
            {
                jSON = JsonConvert.DeserializeObject<JSONConverter>(data);
                
            }
            Debug.Log(jSON.ides[3] + jSON.Score[3]);
            Scoreboard.Instance.SetLoad(jSON.ides, jSON.Score);
            sender.Close();

        }
        catch(Exception e)
        {
            Debug.Log(e.Message);
            
            }
          

        
       
    }
   
}
