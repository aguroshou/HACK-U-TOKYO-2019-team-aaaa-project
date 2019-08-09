using UnityEngine;
//using HoloToolkit.Unity.InputModule;    // InputModuleをusingで追加しておく
using HoloToolkit.Unity;    // InputModuleをusingで追加しておく

public class GestureTest : MonoBehaviour, IInputClickHandler {  // IInputClickHandlerを追加

    // OnInputClickedイベントを追加する（これがエアタップされた時にイベントハンドラとして呼ばれる）
    public void OnInputClicked(InputClickedEventData eventData)
    {
        // ここにエアタップされた時の処理を記述（以下はオブジェクトのカラーを赤に変えている）
        GetComponent<Renderer>().material.color = Color.red;
    }

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }
}