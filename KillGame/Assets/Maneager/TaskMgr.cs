using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TaskMgr : MonoBehaviour
{
    Button _accept;
    Button _giveUp;
    Button _back;
    GameObject _task;
    GameObject _error;
    Text _text;
    Text _tasktext;


    void Awake()
    {
        _task = transform.Find("Task").gameObject;
        _task.SetActive(true);
        _error = transform.Find("Error").gameObject;
        _error.SetActive(false);

        _accept = transform.Find("Task/Accept").GetComponent<Button>();
        _giveUp = transform.Find("Task/GiveUp").GetComponent<Button>();
        _back = transform.Find("Error/Return").GetComponent<Button>();

        _accept.onClick.AddListener(OnPoint);
        _giveUp.onClick.AddListener(UnPoint);
        _back.onClick.AddListener(OnBack);

        _text = transform.Find("RightTask/Text").GetComponent<Text>();
        _tasktext = transform.Find("Task/Text").GetComponent<Text>();
        _tasktext.text = "77777";
    }

    void OnPoint()
    {
        if (_tasktext.text == _text.text)
        {
            _error.SetActive(true);
            _task.SetActive(false);
        }
        else
        {
            _text.text = _tasktext.text;
        }
        
        _task.SetActive(false);
    }

    void UnPoint()
    {
        _task.SetActive(false);
    }

    void OnBack()
    {
        _error.SetActive(false);
    }
}
