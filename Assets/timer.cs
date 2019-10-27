using UnityEngine.UI;
using UnityEngine;

public class timer : MonoBehaviour
{
    public Text timerText;
    private float end = 0f;
    private float ini=300f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ini != end)
        {
            ini -= 1 * Time.deltaTime;
        }

        timerText.text = ini.ToString("0");
    }
}
