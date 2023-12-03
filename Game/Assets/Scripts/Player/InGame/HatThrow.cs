using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatThrow : MonoBehaviour, IHat
{

    public bool IsThrow {get; set;} = false;
    public bool IsGround {get; set;} = false;
    public float ThrowPower {get; set;}
    public float ThrowPowerDown {get; set;}
    public Vector3 MouseStartPos {get; set;}
    public Vector3 MouseEndPos {get; set;}
    public Rigidbody RootObjRb {get; set;}
    public HatAnimation HatAnimation {get; set;}
    public CameraController CameraController {get; set;}

    private void Start()
    {

        // オブジェクトの値の初期化
        IsThrow = false;
        IsGround = false;
        ThrowPower = 50f;
        ThrowPowerDown = 2f;
        MouseStartPos = Vector3.zero;
        MouseEndPos = Vector3.zero;
        RootObjRb = GetComponent<Rigidbody>();

        // アニメーションスクリプトの初期化
        HatAnimation = GetComponent<HatAnimation>();
        HatAnimation.Init();

        // カメラスクリプトの初期化
        CameraController = GetComponent<CameraController>();
        CameraController.Init();

    }

    private void Update()
    {

        // 投げる
        if (IsThrow == false && IsGround == true)
        {
            Throw();
        }

        // オブジェクトが投げられたらアニメーションを再生
        if (IsThrow == true && IsGround == false)
        {
            // アニメーションを再生
            HatAnimation.Animation();
            // カメラを動かす
            CameraController.Action();
        }

        // 設置したらカメラの位置を初期化
        if (IsGround == true)
        {
            CameraController.ReturnAction();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        // オブジェクトが地面に着いたら
        if (collision.gameObject.tag == "Ground")
        {
            // フラグを立てる
            IsGround = true;

            // デバッグログ
            Debug.Log("Hat is grounded");
        }
    }

    private void OnCollisionExit(Collision other)
    {
        // オブジェクトが地面から離れたら
        if (other.gameObject.tag == "Ground")
        {
            // フラグを折る
            IsGround = false;

            // デバッグログ
            Debug.Log("Hat is not grounded");
        }
    }

    private void Throw()
    {
        // 既に投げられていたら何もしない
        if (IsThrow == true)
        {
            return;
        }

        // マウスの始点座標を取得
        if (Input.GetMouseButtonDown(0))
        {
            // マウスの始点座標を取得
            MouseStartPos = Input.mousePosition;
        }

        // マウスの終点座標を取得
        if (Input.GetMouseButton(0))
        {
            // マウスの終点座標を取得
            MouseEndPos = Input.mousePosition;
        }

        // マウスの始点座標と終点座標の差を取得
        if (Input.GetMouseButtonUp(0))
        {
            // マウスの始点座標と終点座標の差を投げる力に設定
            float ThrowForce = Vector3.Distance(MouseStartPos, MouseEndPos) % ThrowPowerDown * ThrowPower;

            // 投げる力を制限
            ThrowForce = Mathf.Clamp(ThrowForce, 0f, 50f);

            // デバッグログ
            Debug.Log("MouseStart: " + MouseStartPos + "MouseEnd: " + MouseEndPos + "ThrowForce: " + ThrowForce);

            // 投げる力を設定
            Vector3 f = new Vector3(0f, 5f, ThrowForce);

            // 投げたらフラグを立てる
            IsThrow = true;

            // Rigidbodyに力を加える
            RootObjRb.AddForce(f, ForceMode.Impulse);
        }
    }
}
