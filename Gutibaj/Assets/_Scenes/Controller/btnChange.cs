using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class btnChange : MonoBehaviour {

    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;
    public Button btn7;
    public Button btn8;
    public Button btn9;


    public Sprite greenpawn;
    public Sprite redpawn;
    public Sprite tempimage;
    private int counter1 = 0;
    private int counter2 = 0;
    private int counter3 = 0;
    bool click = false;

	// Use this for initialization
	void Start () {
        btn1 = GetComponent<Button>();
        btn2 = GetComponent<Button>();
        btn3 = GetComponent<Button>();
        btn4 = GetComponent<Button>();
        btn5 = GetComponent<Button>();
        btn6 = GetComponent<Button>();
        btn7 = GetComponent<Button>();
        btn8 = GetComponent<Button>();
        btn9 = GetComponent<Button>();

    }
	public void changeButton1()
    {
        if(click==false)
        {
            tempimage = btn1.image.overrideSprite;

        }
        else
        {

        }
        counter1++;
        if(counter1%2==0)
        {
           
            btn1.image.overrideSprite = greenpawn;
        }
        else
        {
            
            btn1.image.overrideSprite = redpawn;
        }
    }

    public void changeButton2()
    {
        counter2++;
        if (counter2 % 2 == 0)
        {
            btn2.image.overrideSprite = greenpawn;
            
        }
        else
        {
            btn2.image.overrideSprite = redpawn;
            
        }
    }

    public void changeButton3()
    {
        counter3++;
        if (counter3 % 2 == 0)
        {
            btn3.image.overrideSprite = greenpawn;

        }
        else
        {
            btn3.image.overrideSprite = redpawn;

        }
    }
}
