using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LogoVideoManager : MonoBehaviour
{

    public VideoPlayer video;
    public double time;
    public double currentTime;

    // Start is called before the first frame update
    void Start()
    {
        time = video.clip.length;
        video.Play();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = video.time;

        if(currentTime >= time)
            //Todo: Change Scene
    }
}
