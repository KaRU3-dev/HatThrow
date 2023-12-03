using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatAnimation : MonoBehaviour
{
    /// <summary>
    /// Hat throw script
    /// </summary>
    public HatThrow hatThrow;

    private void Update()
    {
        // Check if hat is thrown
        if (hatThrow.isThrow == true)
        {
            // Get hat object transform
            Transform trs = this.transform;

            // Rotate hat object
            trs.Rotate(0f, 1.0f, 0f);
        }
    }
}
