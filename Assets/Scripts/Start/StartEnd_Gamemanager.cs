using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEnd_Gamemanager : MonoBehaviour
{
    private bool canStart = false;

    private void Start()
    {
        canStart = false;
        StartCoroutine(RestartCooldown());
    }
    void Update()
    {
        if (canStart)
        {
            if (Input.anyKey)
            {
                SceneManager.LoadScene("Game");
            }
        }
    }

    private IEnumerator RestartCooldown()
    {
        yield return new WaitForSeconds(0.5f);
        if (!canStart)
        {
            canStart = true;
        }
    }
}
