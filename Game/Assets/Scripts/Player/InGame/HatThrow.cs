using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatThrow : MonoBehaviour
{

    /// <summary>
    /// Get or set "hat" status
    /// </summary>
    /// <value>bool: get; set; = false;</value>
    public bool isThrow { get; set; } = false;

    /// <summary>
    /// Throwable object body
    /// </summary>
    private Rigidbody objRb;

    // Start is called before the first frame update
    private void Start()
    {
        // Initialize "hat" status
        isThrow = false;

        objRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        // Input get
        if (Input.GetMouseButtonDown(0) && isThrow == false)
        {
            isThrow = true;
            Vector3 f = new Vector3(0f, 5f, 50f);
            objRb.AddForce(f, ForceMode.Impulse);
        }
    }
}
