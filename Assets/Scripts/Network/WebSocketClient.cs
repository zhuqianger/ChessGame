using UnityEngine;
using WebSocketSharp;

public class WebSocketClient : MonoBehaviour
{
    private WebSocket ws;

    void Start()
    {
        ws = new WebSocket("ws://localhost:8080/websocket");

        ws.OnOpen += (sender, e) =>
        {
            Debug.Log("WebSocket connected");
        };

        ws.OnMessage += (sender, e) =>
        {
            Debug.Log("Message received: " + e.Data);
        };

        ws.Connect();
    }

    void Update()
    {
        // 在需要的情况下发送消息给后台
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ws.Send("Hello from Unity!");
        }
    }

    void OnApplicationQuit()
    {
        ws.Close();
    }
}
