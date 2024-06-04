using UnityEngine;

public class AndroidStuff
{
    public static bool isSetup;
    public static AndroidJavaObject currentJavaAndroidObject;
    public static void Setup()
    {
        currentJavaAndroidObject = GetCurrentAndroidJavaObject();


        isSetup = true;
    }
    public static AndroidJavaObject GetCurrentAndroidJavaObject()
    {
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        return unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
    }
    public static T Call<T>(string methodName, params object[] objects) => currentJavaAndroidObject.Call<T>(methodName, objects);

    public static void Call(string methodName, params object[] objects) => currentJavaAndroidObject.Call(methodName, objects);
    public static void SetField<FieldType>(string fieldName, FieldType data) => currentJavaAndroidObject.Set(fieldName, data);




    public static void CopyToClipboard(string text)
    {
        Call("ClipboardInput", text);
    }
}
