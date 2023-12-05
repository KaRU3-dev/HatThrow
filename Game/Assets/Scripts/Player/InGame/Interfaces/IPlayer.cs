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

public interface IPlayer
{
    /// <summary>
    /// 帽子のスクリプト
    /// </summary>
    /// <value>HatThrow</value>
    public HatThrow HatThrow {get; set;}
    /// <summary>
    /// 初期位置
    /// </summary>
    /// <value>GameObject</value>
    public GameObject LaunchPosition {get; set;}

}
