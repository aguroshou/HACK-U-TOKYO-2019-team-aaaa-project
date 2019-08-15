using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotAnemone : MonoBehaviour
{
    public GameObject anemone;     
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
            GameObject runcherAnemone = GameObject.Instantiate(anemone) as GameObject; //runcherbulletにbulletのインスタンスを格納
            runcherAnemone.GetComponent<Rigidbody>().velocity = transform.forward;// * 3; //アタッチしているオブジェクトの前方にbullet speedの速さで発射
            runcherAnemone.transform.position = transform.position;
            this.GetComponent<ShotAnemone>().enabled=false;
    }
}
