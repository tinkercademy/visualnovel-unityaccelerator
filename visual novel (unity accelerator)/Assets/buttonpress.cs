using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonpress : MonoBehaviour
{
    public Text GameText;
    public SpriteRenderer spriteRenderer;
    public Sprite newSpriteA;
    public Sprite newspriteB;
    public Button myButton;
    

    void Start()
    {
        Button btn = myButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        GameText.text = "bye bye";
    }
    void Update() 
    {
        if (Input.GetKeyDown("space"))
        {
           
            if (GameText.text == "bye bye")
            {
                GameText.text = "what did you say";
                spriteRenderer.sprite = newSpriteA;

            }
            else if (GameText.text == "what did you say")
            {
                GameText.text = "bye bye";
                spriteRenderer.sprite = newspriteB;
            }
            else
            {
                GameText.text = "bye bye";
            }
        }
    }
}
