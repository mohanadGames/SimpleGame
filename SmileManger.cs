using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SmileManger : MonoBehaviour
{
    

    void Update()
    {
        Vector2 mouseP = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mouseP;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadSceneAsync(0);
    }
}
