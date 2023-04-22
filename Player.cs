using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const string CALL_BOX_TAG = "call-box";
    private const string API_URL = "your-cool-api-url";

    private async Task MakeHttpRequest()
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(API_URL);
            if (response.IsSuccessStatusCode)
            {
                string responseText = await response.Content.ReadAsStringAsync();
                Debug.Log("HTTP Response: " + responseText);
            }
            else
            {
                Debug.LogError("Something terrible happened! Status code: " + response.StatusCode);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(CALL_BOX_TAG))
        {
            StartCoroutine(MakeHttpRequest());
        }
    }
}