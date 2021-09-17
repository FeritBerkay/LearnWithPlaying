using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{
    public void playColors()
    {
        SceneManager.LoadScene(0);
    }
    public void playNumbers()
    {
        SceneManager.LoadScene(3);
    }
    public void playAnimals()
    {
        SceneManager.LoadScene(1);
    }
}
