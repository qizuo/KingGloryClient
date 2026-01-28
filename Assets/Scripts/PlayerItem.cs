using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItem : MonoBehaviour
{
    private void Awake()
    {
        _entity = new PlayerEntity();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private PlayerEntity _entity;

    public void SetId(int id)
    {
        _entity.id = id;
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
