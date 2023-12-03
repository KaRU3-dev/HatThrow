using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Hat object
    public GameObject hat;
    // Hat throw script
    [SerializeField] private HatThrow hatThrow;
    // Hat current speed
    [SerializeField] private float hatSpeed;
    // Camera object
    private GameObject cameraObj;

    // Start is called before the first frame update
    private void Start()
    {
        // Initialize hat speed
        hatSpeed = 0f;
        cameraObj = this.gameObject;
    }

    // Update is called once per frame
    private void Update()
    {
        // Check if hat is thrown
        if (hatThrow.isThrow == true)
        {
            // Get hat speed
            hatSpeed = hat.GetComponent<Rigidbody>().velocity.magnitude;

            // Move camera to backward direction
            cameraObj.transform.Translate(0f, 0f, -hatSpeed * Time.deltaTime);

            // Smooth move camera to backward direction (hat object pos - 5)
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
                0.03f
            );
        }
    }
}
