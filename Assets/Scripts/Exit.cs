using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Exit : MonoBehaviour
{
    public Button playButton;
    void Start()
    {
        Button btn = playButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.Quit();
    }
}