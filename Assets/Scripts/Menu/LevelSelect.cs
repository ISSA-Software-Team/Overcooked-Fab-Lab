using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    [SerializeField] private Button level1Button;
    [SerializeField] private Button level2Button;

    private void Awake()
    {
        level1Button.onClick.AddListener(() => {
            Loader.Load(Loader.Scene.Level1);
        });

        level2Button.onClick.AddListener(() => {  
            Loader.Load(Loader.Scene.Level2);
        });
    }
}
