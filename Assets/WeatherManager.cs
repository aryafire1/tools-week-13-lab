using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WeatherManager {

   private const string xmlApi = "http://api.openweathermap.org/geo/1.0/direct?q=Orlando&limit=5&appid=db9758f0e415c0abd573c95394891c7b";

   private IEnumerator CallAPI(string url, Action<string> callback) {
      using (UnityWebRequest request = UnityWebRequest.Get(url)) {
         yield return request.SendWebRequest();
         if (request.result == UnityWebRequest.Result.ConnectionError) {
            Debug.LogError($"network problem: {request.error}");
         } else if (request.result == UnityWebRequest.Result.ProtocolError) {
            Debug.LogError($"response error: {request.responseCode}");
         } else {
             callback(request.downloadHandler.text);
         }
      }
   }

   public IEnumerator GetWeatherXML(Action<string> callback) {
      return CallAPI(xmlApi, callback);
   }

}