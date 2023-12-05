/*
 * Created by @KaRU3-dev
 * Copyright (c) @KaRU3-dev All rights reserved
 */

// .NET Framework
using System.Collections;
using System.Collections.Generic;

// Unity API
using UnityEngine;

/// <summary>
/// Interface for hat root object
/// </summary>
public interface IHat
{
    #region Hat root object
    /// <summary>
    /// オブジェクトが投げられたかどうか
    /// </summary>
    public bool IsThrow { get; set; }
    /// <summary>
    /// 設置されているかどうか
    /// </summary>
    public bool IsGround { get; set; }
    /// <summary>
    /// 投げる力
    /// </summary>
    public float ThrowPower { get; set; }
    /// <summary>
    /// 投げる力を弱くする
    /// </summary>
    public float ThrowPowerDown { get; set; }
    /// <summary>
    /// マウスの始点座標
    /// </summary>
    public Vector3 MouseStartPos { get; set; }
    /// <summary>
    /// マウスの終点座標
    /// </summary>
    public Vector3 MouseEndPos { get; set; }
    /// <summary>
    /// ルートオブジェクトのRigidbody
    /// </summary>
    public Rigidbody RootObjRb { get; set; }

    #endregion

    #region Hat animation

    /// <summary>
    /// オブジェクトのアニメーション
    /// </summary>
    public HatAnimation HatAnimation { get; set; }

    #endregion

    #region Hat camera

    /// <summary>
    /// オブジェクトのカメラ
    /// </summary>
    public CameraController CameraController { get; set; }

    #endregion
}
