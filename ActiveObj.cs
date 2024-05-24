
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActiveObj : MonoBehaviour
{
 
    public GameObject obj;
    public float delay = 3;
    public float delayGun = 37;
    public GameObject gun;
    public GameObject objOff;
    public GameObject objOn;
    float timer;
    public float nextScene = 42;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            StartText();
        }
        if (timer > delayGun) 
        {
            StartGun();
        }
        if (timer > nextScene)
        {
            NextScene();
        }
    }

    void StartText()
    {
        obj.SetActive(true);
    }

    void StartGun() 
    {
        gun.SetActive(true);
        objOff.SetActive(false);
        objOn.SetActive(true);
    }
    void NextScene() 
    {
        SceneManager.LoadScene(1);
    }
}
