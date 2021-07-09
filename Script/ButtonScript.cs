using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonScript : MonoBehaviour
{
    private Button button;

    public string sceneName;
    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(onClick);
    }

    void onClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
