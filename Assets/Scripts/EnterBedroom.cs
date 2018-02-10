using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnterBedroom : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        if( Input.GetKey(KeyCode.Space) )
        {
            SceneManager.LoadScene("Scene1");
        }
    }
}
