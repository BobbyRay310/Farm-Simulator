using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

   // [SerializeField] float duration, currentTime;

    //[SerializeField] GameObject panel;

  //  [SerializeField] Image timeImage;
  /*   void Start()
    {
        panel.SetActive(false);
        currentTime = duration;
        timerText.text = currentTime.ToString();
        StartCoroutine(TimeIEn());
    }

    IEnumerator TimeIEn()
    {
        while(currentTime >-0)
        {
            timeImage.fillAmount = Mathf.InverseLerp(0, duration, currentTime);
            timerText.text = currentTime.ToString();
            yield return new WaitForSeconds(1f);
            currentTime--;

        }
        OpenPanel();
    }

    void OpenPanel()
    {
        timerText.text = "";
        panel.SetActive(true);

    }

    */
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            // Application.LoadLevel(LevelToload);
        }
        if (remainingTime <= 0)
        {
            remainingTime = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
