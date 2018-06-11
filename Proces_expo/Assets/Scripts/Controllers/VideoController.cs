using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour {

    public VideoPlayer[] myVideos;
    public bool[] allowedToPlay;

    public int videoCounter = 0;

	void Start () {
		
	}
	
	void Update () {
        foreach(VideoPlayer videos in myVideos){
        }
            
	}
}
