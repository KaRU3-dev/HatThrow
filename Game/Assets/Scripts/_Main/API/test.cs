using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;

public class test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GetText()
    {
        // Test API
        // localhost:3000/api/test
        UnityWebRequest www = UnityWebRequest.Get("http://localhost:3000/api/test"); // Maybe return a JSON code with the data(Hello World)

        yield return www.SendWebRequest();
    }
}
