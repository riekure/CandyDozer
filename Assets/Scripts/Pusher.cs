﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{

    Vector3 startPosition;

    // 移動量パラメータ
    public float amplitude;
    // 移動速度パラメータ
    public float spped;

	// Use this for initialization
	void Start ()
    {
        // 初期位置を保存
        startPosition = transform.localPosition;	
	}
	
	// Update is called once per frame
	void Update ()
    {
        // 変位を計算
        float z = amplitude * Mathf.Sin(Time.time * spped);

        // zを変位させたポジションに再設定
        transform.localPosition = startPosition + new Vector3(0, 0, z);
	}
}
