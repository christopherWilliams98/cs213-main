using UnityEngine;
using UnityEngine.UI;
using TMPro;

/**
	This class is the implementation of the timer used in the game and how it is handled in it
*/
public class Timer : MonoBehaviour
{
    private float initTimerValue;
    private TextMeshProUGUI timerText;
    public Slider slider;
    public float maxMinutes = 5;
    public GameManager gameManager;

    public void Awake() {
        initTimerValue = Time.time; 
    }

    // Start is called before the first frame update
    public void Start() {
        timerText = this.gameObject.GetComponent<TextMeshProUGUI>();
        timerText.text = "TIME " + string.Format("{0:00}:{1:00}", 0, 0);
        initTimerValue = 0.0f;
    }

    // Update is called once per frame
    public void Update() {

        initTimerValue += Time.deltaTime;
        timerText.text = "TIME " + string.Format("{0:00}:{1:00}", 0, initTimerValue);
        if(initTimerValue == maxMinutes*60){
            // END GAME CODE
        }
        
    }

}
