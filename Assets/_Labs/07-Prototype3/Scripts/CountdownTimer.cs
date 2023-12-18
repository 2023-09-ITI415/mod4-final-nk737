
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currenttime = 0f;
    float startingtime = 400f;

    [SerializeField] Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currenttime = startingtime;
    }

    // Update is called once per frame
    void Update()
    {
        currenttime -= 1 * Time.deltaTime;
        countdownText.text = currenttime.ToString ("0");

        if(currenttime <=0)
        {
            currenttime = 0;
            SceneManager.LoadScene("MainMenu");
        }
    }
}
