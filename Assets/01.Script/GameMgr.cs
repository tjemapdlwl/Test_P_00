using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public GameObject[] UI_Screen; 

    //delay
    float _dalyTime;
    bool _isDaly {get;set;} = false;

    float _waitTime = 1;
    // Start is called before the first frame update
    void Start()
    {
        EnableUI(0);
    }

    // Update is called once per frame
    void Update()
    {
        //Chekc, Event Loop
        if(_isDaly)
        {
            _dalyTime += Time.deltaTime;
            if(_dalyTime > _waitTime)
            {
                 EnableUI(2);
                 _isDaly = false;
            }
        }
    }

    public void InitGame()
    {
        EnableUI(1);
        
        
        
        ResetTimer();





    //    EnableUI(2);
    }

    private void EnableUI(int nidx)
    {
        bool bEnable = true;
       for(int i = 0; i < UI_Screen.Length; i++)
        {
            bEnable = nidx == i ? true : false;
            UI_Screen[i].SetActive(bEnable);
        }
    }

    private void ResetTimer()
    {
        _isDaly = true;
        _dalyTime = 0;
        //_waitTime = 10;
    }
}
