using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class TestConnector : MonoBehaviour
{
    public string userId;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetCharacterData());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GetCharacterData()
    {
        UnityWebRequest request = UnityWebRequest.Get($"http://localhost:8000/get/character/{userId}");
        yield return request.SendWebRequest();

        if (request.error != null)
        {
            Debug.Log(request.error);
        }
        else
        {
            string json = request.downloadHandler.text;
            Debug.Log(json);
        }
    }
}
