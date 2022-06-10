using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scene : MonoBehaviour
{
    public void scene (string scene)
    {
        Application.LoadLevel (scene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
