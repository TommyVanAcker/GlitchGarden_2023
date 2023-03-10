using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float waitInSeconds = 4f;
    int currentSceneIndex;
   
    
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            StartCoroutine(GoToStartScreen());
        }
        
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    
    IEnumerator GoToStartScreen()
    {
        yield return new WaitForSeconds(waitInSeconds);
        LoadNextScene();
    }
}
