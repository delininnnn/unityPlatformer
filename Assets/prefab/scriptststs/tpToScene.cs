using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{
    // Start is called before the first frame update
    public void scenLoad(int numbScen)
    {
        SceneManager.LoadScene(numbScen);
    }

    
}
