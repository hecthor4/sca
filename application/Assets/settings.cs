using UnityEngine;
using UnityEngine.SceneManagement;

public class settings : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject settingsScreen;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        settingsScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSettingsShow()
    {
        anim.SetBool("Show", true);
    }

    public void OnSettingsHidden()
    {
        anim.SetBool("Show", false);
    }
}
