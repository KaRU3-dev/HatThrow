/*
 * Created by @KaRU3-dev
 * Copyright (c) @KaRU3-dev All rights reserved
 */

// .NET Framework
using System.Collections;
using System.Collections.Generic;

// Unity API
using UnityEngine;

// Original

public class PlayerController : MonoBehaviour
{
    public GameObject Hat;
    public HatThrow HatThrow;
    public GameObject LaunchPosition;

    private void Start()
    {

        // 発射位置のオブジェクトを取得
        LaunchPosition = GameObject.Find("LaunchPosition");

        // プレイヤーのオブジェクト(プレファブ)を生成
        Hat = Instantiate(
            Hat,
            new Vector3(LaunchPosition.transform.position.x, LaunchPosition.transform.position.y + 3, LaunchPosition.transform.position.z),
            Quaternion.identity
        );

        // プレイヤーのオブジェクトのスクリプトを取得
        HatThrow = Hat.GetComponent<HatThrow>();

        // プレイヤーのオブジェクトを子オブジェクトにする
        Hat.transform.parent = LaunchPosition.transform;

        HatThrow.Initialize();
    }

    private void Update()
    {
        // リセット
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ポジションをリセット
            //HatThrow.transform.position = LaunchPosition.transform.position;
            // 投げられたフラグなどをリセット
            HatThrow.Reset(InitPos: LaunchPosition);
        }
        // プレイヤーのオブジェクトのスクリプトを更新
        HatThrow.Move();
    }
}
