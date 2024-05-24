
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActiveObj1 : MonoBehaviour
{
 
    public GameObject obj;
    public float delay = 3;
    public float delayGun = 37;
    float timer;
    public float nextScene = 42;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            StartText();
        }

    }

    void StartText()
    {
        obj.SetActive(true);
    }


}
