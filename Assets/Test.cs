using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public static WWW GetWWWForStreamingAssetsPath(string relativePath)
    {
        string fileNameUrl = null;
        if (Application.platform == RuntimePlatform.Android)
        {
            fileNameUrl = Application.streamingAssetsPath + "/" + relativePath; //when split binary build is enabled in playerprefs it will always return the obb path - otherwise apk path

#if UNITY_ANDROID && !UNITY_EDITOR
            //using (AndroidJavaClass player = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            //{
            //    AndroidJavaObject activity = player.GetStatic<AndroidJavaObject>("currentActivity");
            //    //logger.Debug(" Context.getPackageResourcePath: " + activity.Call<string>("getPackageResourcePath") );
            //    //fileNameUrl = "jar:file://" + activity.Call<string>("getPackageResourcePath") + "!/assets/" + relativePath; //Construct assets path using apk
            //    fileNameUrl = "file://" + activity.Call<string>("getPackageResourcePath") + "!/assets/" + relativePath; //Construct assets path using apk
            //}
#endif
        }
        return new WWW(fileNameUrl);
    }

    // Use this for initialization
    void Start () {
        // System.Threading.Thread.Sleep(5000);
        // var www = GetWWWForStreamingAssetsPath("bin/Data/level0");
        // var www2 = GetWWWForStreamingAssetsPath("readme");
        // var www3 = GetWWWForStreamingAssetsPath("unknown");
    }

    // Update is called once per frame
    void Update () {

	}
}
