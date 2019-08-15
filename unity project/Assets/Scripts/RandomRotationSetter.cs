using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RandomRotationSetter : MonoBehaviour
{
    public void SetRotation()
    {
        foreach (Transform t in transform)
        {
            t.rotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
        }
    }
}
#if UNITY_EDITOR

[CustomEditor(typeof(RandomRotationSetter))] //拡張するクラスを指定
public class RandomRotationSetterEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //元のInspector部分を表示
        base.OnInspectorGUI();

        //PublicMethodを実行する用のボタン
        if (GUILayout.Button("SetRandomRotation"))
        {
            RandomRotationSetter r = target as RandomRotationSetter;
            r.SetRotation();
        }
    }
}
#endif