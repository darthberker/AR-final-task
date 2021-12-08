using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCount : MonoBehaviour
{
    Text text;
    public Text changingText;
    public static int listCount;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = listCount.ToString();
    }

    //AJSFJKGagSKFJGHJKASFJhgla
}
