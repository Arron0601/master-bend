﻿using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class VidPlayer2 : MonoBehaviour
{
    VideoPlayer a = new VideoPlayer();
   
    public List<VideoClip> videos = new List<VideoClip>();
    public Transform skip;
    //System.Collections.Generic.IList<VideoClip> videos = new IList<VideoClip>()


    private void Start()
    {
        a = GetComponent<VideoPlayer>();
        //a.clip;
        a.loopPointReached += EndReached;

        //結束程式
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

    }

    void EndReached(UnityEngine.Video.VideoPlayer a)
    {
        SceneManager.LoadScene(5);
        //停止目前影片


        /**a.clip = videos[1];//播放陣列1影片
        a.Play();
        a.Stop();//停止目前影片

        

        a.clip = videos[2];//播放陣列2影片
        a.Play();
        a.Stop();//停止目前影片
        a.clip = videos[3];//播放陣列3影片
        a.Play();
        a.Stop();
        Application.Quit();**/
    }
    /*private void OnGUI()
    {
        if (GUILayout.Button("Skip"))
        {
            a.Stop();//停止目前影片
            a.clip = videos[2];//播放陣列2影片
            a.Play();
        }

        else if (GUILayout.Button("Skip2"))
        {
            a.Stop();//停止目前影片
            a.clip = videos[3];//播放陣列3影片
            a.Play();
        }



    }
    */


    internal class waitforseconds
    {
        public waitforseconds()
        {
        }
    }
}

/*private void OnGUI()
{
    if (Input.GetKeyDown("Mouse0"))
    {
        a.Stop();//停止目前影片
        a.clip = videos[2];//播放陣列2影片
        a.Play();
    }
}*/

/**if (GUI.Button(new Rect(300,0,0,0),ButtonText))
{
    if(SkipORnot==false)
    {
    SkipORnot = true;
    }
}**/




