using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidListener : MonoBehaviour
{
    public static AndroidListener instance;
    public static Action fingerprintAction;
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        AndroidStuff.Setup();
    }


    public void ConfirmFingerprint(string fuckUnityAndroid) => fingerprintAction?.Invoke();
}
