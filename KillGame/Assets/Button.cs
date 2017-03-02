using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{
    public GameObject PlayerUI;
    public GameObject CreatButton;


    // Use this for initialization
    void Awake()
    {
        
        UIEventListener.Get(CreatButton).onClick = CreatButtonFunc;
    }
    void CreatButtonFunc(GameObject ob)
    {
        GameObject temp = Instantiate(PlayerUI) as GameObject;
        temp.transform.parent = gameObject.transform;
        temp.transform.localPosition = Vector3.zero;
        temp.transform.localScale = Vector3.one;
    }
}
