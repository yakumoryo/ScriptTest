﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	private int mp = 53; // MP

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

    // 魔法用の関数
	public void Magic() {
		for (int i = mp-5; i >0; i -=5){
			Debug.Log("魔法攻撃をした。残りMPは"+i+"。");

			if (i <5){
				Debug.Log("MPが足りないため魔法が使えない。");
			}
		}
	}

}

public class Test : MonoBehaviour {

	void Start () {
		// 課題：配列を宣言して出力しましょう
		int[] array = {1, 3, 5, 7, 9};

		for (int i = 0; i < array.Length; i++){
			Debug.Log (array[i]);
		}

		for (int i = 4; i > -1; i--){
			Debug.Log (array[i]);
		}

		// 発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		// 防御用の関数を呼び出す
		lastboss.Defence(3);
		// 魔法用お関数を呼び出す
		lastboss.Magic ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
