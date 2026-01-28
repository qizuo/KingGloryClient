using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    GameManager()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        _playerItems = new List<PlayerItem>();
    }
    private SocketClient _socketClient;
    // Start is called before the first frame update
    void Start()
    {
        _socketClient = GetComponent<SocketClient>();
        InitSelfPlayer();
    }

    private List<PlayerItem> _playerItems;
    void InitSelfPlayer()
    {
        var onlineCt = GetSocketClient().GetOnlinePlayerCount();

        var item = Resources.Load<GameObject>("Prefabs/player"+onlineCt);
        var obj = Instantiate(item);
        var parent = GameManager.Instance.GetRootNode();
        obj.transform.SetParent(parent);
        obj.transform.localScale = Vector3.one;
        obj.transform.localPosition = new Vector3(0,1,0);
        
        var script = obj.GetComponent<PlayerItem>();
        script.SetId(onlineCt);
        _playerItems.Add(script);
    }
    
    public Transform GetRootNode()
    {
        return transform;
    }
    
    public SocketClient GetSocketClient()
    {
        return _socketClient;
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
