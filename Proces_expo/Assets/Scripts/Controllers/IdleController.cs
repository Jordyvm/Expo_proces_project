using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleController : MonoBehaviour
{
    [Header("Time Variables")]
    [Tooltip("The current time in the scene")]
    public float currentTime;
    [Tooltip("The delay till the scene is reloaded")]
    public float IdleDelay;
    float timeLeft;
    MenuController menuController;

    private void Awake()
    {
        menuController = GameObject.Find("GameController").GetComponent<MenuController>();
        timeLeft = IdleDelay;
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        if(timeLeft < currentTime){
            print("delay is over");
            timeLeft = timeLeft + IdleDelay;
            menuController._idleScene();
        }
    }
}
