using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialoguemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public string[] sentences;
    public int index;
    public Button button;
    public SpriteRenderer face;
    public Sprite[] listofsprites;
    public Button beforebutton;

    void Start()
    {
        button.onClick.AddListener(counterup);
        beforebutton.onClick.AddListener(down);
        text.text = sentences[0];
        face.sprite = listofsprites[0];
    }
    void counterup()
    {
        if (index < 4)
        {
            index++;
            text.text = sentences[index];
            face.sprite = listofsprites[index];
        }
    }
    void down()
    {
        if (index > 0)
        index--;
        text.text = sentences[index];
        face.sprite = listofsprites[index];
    }


}
