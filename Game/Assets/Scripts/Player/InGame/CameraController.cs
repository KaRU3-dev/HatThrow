using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Hat object
    public GameObject hat;
    // Camera object
    public GameObject cameraObj;
    // Initial camera position
    public Vector3 InitCameraPos = new Vector3(0f, 0.7f, -2f);

    public void Init()
    {

        // 初期化
        InitLocalPos();

    }

    public void InitLocalPos()
    {
        // カメラの位置を初期化
        cameraObj.transform.localPosition = InitCameraPos;
    }

    public void ReturnAction()
    {
        // カメラの位置を滑らかに戻す
        cameraObj.transform.localPosition = Vector3.Lerp(
            // Position A
            cameraObj.transform.localPosition,
            // Position B
            InitCameraPos,
            // Smooth time (percent of distance between A and B)
            0.1f
        );
    }

    // Update is called once per frame
    public void Action()
    {
        // カメラの位置を変更（ポジションAとポジションBの間のA側からの10％後ろを追従）
        cameraObj.transform.position = Vector3.Lerp(
            // Position A
            cameraObj.transform.position,
            // Position B
            new Vector3(
                cameraObj.transform.position.x,
                cameraObj.transform.position.y,
                hat.transform.position.z - 5
            ),
            // Smooth time (percent of distance between A and B)
            0.1f
        );
    }
}
