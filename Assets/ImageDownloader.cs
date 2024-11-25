using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;



public class ImageDoanloader : MonoBehaviour
{
    public string URL_1 = "https://www.publicdomainpictures.net/pictures/30000/velka/cat-and-dog.jpg";
    public string URL_2 = "https://as2.ftcdn.net/v2/jpg/02/84/36/59/1000_F_284365935_RQAZNpqkgzIyCRWibM3a3t2tgwWpkHP1.jpg";
    public string URL_3 = "http://res.publicdomainfiles.com/pdf_view/101/13950316215720.jpg";
    void Start() {
        StartCoroutine(GetTexture(URL_1));
        StartCoroutine(GetTexture(URL_2));
        StartCoroutine(GetTexture(URL_3));
    }
 
    IEnumerator GetTexture(string url) {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success) {
            Debug.Log(www.error);
        }
        else {
            Texture myTexture = DownloadHandlerTexture.GetContent(www);
        }
    }

}
