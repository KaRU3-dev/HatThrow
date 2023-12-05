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

public class GameController : MonoBehaviour
{
    // プレイヤーのオブジェクト
    public GameObject Player;
    // プレイヤーのプレファブ
    public GameObject PlayerPrefab;

    // スポーン位置
    public Vector3 SpawnPos;

    private void Start()
    {
        // スポーン位置の初期化
        SpawnPos = new Vector3(0f, 0f, 0f);

        // プレイヤーの初期化
        Player = Instantiate(
            PlayerPrefab,
            SpawnPos,
            Quaternion.identity
        );

    }

    private void Update()
    {
        //
    }
}
