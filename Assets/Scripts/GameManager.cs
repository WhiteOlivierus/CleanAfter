using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
    }

    public void loadLevel(int sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    private void Start()
    {
        Destroy(GameObject.Find("Tutorial"), 10f);
    }
}
