using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_MainTitle : MonoBehaviour
{
    public GameMgr _gameMgr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btnNewGame()
    {
        //Send meassge 'Init Game' Meassge to Game manager
        if (_gameMgr)
            _gameMgr.InitGame();

        //this.gameObject.SetActive(false);
    }

    public void btnConnectGame()
    {
        //if(connect)
        //Receive Data From Server
        //
    }

    public void btnExit()
    {
        _gameMgr.InitGame();
    }
}
