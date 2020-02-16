using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlanetGravity : MonoBehaviour {
    public GameObject planet;       // 引力の発生する星
    public float accelerationScale; // 加速度の大きさ
	public GameObject anemone;       
    public GameObject camera;       
    
	
	public float speed; //プレイヤーの動くスピード

    private Vector3 Player_pos; //プレイヤーのポジション
    private float x; //x方向のImputの値
    private float z; //z方向のInputの値
    private Rigidbody rigd;

	void Start()
    {
        Player_pos = GetComponent<Transform>().position; //最初の時点でのプレイヤーのポジションを取得
        rigd = GetComponent<Rigidbody>(); //プレイヤーのRigidbodyを取得
    }

	void Update () {
		// 星に向かう向きの取得
		var direction = planet.transform.position - transform.position;
		direction.Normalize();
 
		// 加速度与える
		GetComponent<Rigidbody>().AddForce(accelerationScale * direction, ForceMode.Acceleration);

		x = Input.GetAxis("Horizontal"); //x方向のInputの値を取得
        z = Input.GetAxis("Vertical"); //z方向のInputの値を取得

        //rigd.velocity = new Vector3(x * speed, 0, z * speed); //プレイヤーのRigidbodyに対してInputにspeedを掛けた値で更新し移動

        Vector3 diff = transform.position - Player_pos; //プレイヤーがどの方向に進んでいるかがわかるように、初期位置と現在地の座標差分を取得

        if (diff.magnitude > 0.01f) //ベクトルの長さが0.01fより大きい場合にプレイヤーの向きを変える処理を入れる(0では入れないので）
        {
            transform.rotation = Quaternion.LookRotation(diff);  //ベクトルの情報をQuaternion.LookRotationに引き渡し回転量を取得しプレイヤーを回転させる
        }

        Player_pos = transform.position; //プレイヤーの位置を更新

	}

	void ShotAnemone () {
		// // 星に向かう向きの取得
		// var direction = planet.transform.position - transform.position;
		// direction.Normalize();
 
		// // 加速度与える
		// GetComponent<Rigidbody>().AddForce(accelerationScale * direction, ForceMode.Acceleration);

		// x = Input.GetAxis("Horizontal"); //x方向のInputの値を取得
        // z = Input.GetAxis("Vertical"); //z方向のInputの値を取得

        // //rigd.velocity = new Vector3(x * speed, 0, z * speed); //プレイヤーのRigidbodyに対してInputにspeedを掛けた値で更新し移動

        // Vector3 diff = transform.position - Player_pos; //プレイヤーがどの方向に進んでいるかがわかるように、初期位置と現在地の座標差分を取得

        // if (diff.magnitude > 0.01f) //ベクトルの長さが0.01fより大きい場合にプレイヤーの向きを変える処理を入れる(0では入れないので）
        // {
        //     transform.rotation = Quaternion.LookRotation(diff);  //ベクトルの情報をQuaternion.LookRotationに引き渡し回転量を取得しプレイヤーを回転させる
        // }

        // Player_pos = transform.position; //プレイヤーの位置を更新
		
		GameObject runcherAnemone = GameObject.Instantiate(anemone) as GameObject; //runcherbulletにbulletのインスタンスを格納
        runcherAnemone.GetComponent<Rigidbody>().velocity = camera.transform.forward * 3; //アタッチしているオブジェクトの前方にbullet speedの速さで発射
        runcherAnemone.transform.position = camera.transform.position;
	}
}