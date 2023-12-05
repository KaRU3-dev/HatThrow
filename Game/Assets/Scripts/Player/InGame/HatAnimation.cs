/*
 * Created by @KaRU3-dev
 * Copyright (c) @KaRU3-dev All rights reserved
 */

// .NET Framework
using System.Collections;
using System.Collections.Generic;

// Unity API
using UnityEngine;

public class HatAnimation : MonoBehaviour
{
    /// <summary>
    /// 回転させるオブジェクト
    /// </summary>
    public GameObject RotateObj;

    public void Init()
    {

        // 初期化
        // RotateObj = GameObject.Find("Hat");

    }

    public void Animation()
    {
        // オブジェクトのTransformを取得
        Transform trs = RotateObj.transform;

        // オブジェクトを回転させる
        trs.Rotate(0f, 1.0f, 0f);
    }
}
