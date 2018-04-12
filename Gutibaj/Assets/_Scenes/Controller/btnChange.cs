using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public AudioSource myMusic;

    public Sprite greenpawn;
    public Sprite redpawn;
    public Sprite tempimage;
    private int counter1 = 0;
    private int counter2 = 0;
    private int counter3 = 0;
    bool click = false;
    int[] a = new int[] { 1, 1, 1, 0, 0, 0, 2, 2, 2};
    int v = 0;
  
    int temp = 0;
    bool clicked = false;

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
    public void win(int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9)
    {
        if(a1==1&&a4==1&&a7==1||a1==1&&a5==1&&a9==1||a2==1&&a5==1&&a8==1||a3==1&&a6==1&&a9==1||a3==1&&a5==1&&a7==1||a4==1&&a5==1&&a6==1||a7==1&&a8==1&&a9==1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
        else if (a1 == 2 && a4 == 2 && a7 == 2 || a1 == 2 && a5 == 2 && a9 == 2|| a2 == 2 && a5 == 2 && a8 == 2 || a3 == 2 && a6 == 2 && a9 == 2 || a3 == 2 && a5 == 2 && a7 == 2 || a4 == 2 && a5 == 2 && a6 == 2 || a1==2&&a2==2&&a3==2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
	public void changeButton1()
    {
        if(clicked == false && a[0]!=0)
        {
            v = a[0];
            clicked = true;
            temp = 1;

        }
        else
        {
            if(temp ==2)
            {
                btn2.image.overrideSprite = tempimage;
                a[1] = 0;
            }
            else if(temp==4)
            {
                btn4.image.overrideSprite = tempimage;
                a[3] = 0;
            }
            else if(temp ==5)
            {
                btn5.image.overrideSprite = tempimage;
                a[4] = 0;
            }
            if(v==1)
            {
                btn1.image.overrideSprite = greenpawn;
                a[0] = 1;
                myMusic.Play();
            }
            else if(v==2)
            {
                btn1.image.overrideSprite = redpawn;
                a[0] = 2;
                myMusic.Play();
            }
            clicked = false;
            win(a[0],a[1],a[2],a[3],a[4],a[5],a[6],a[7],a[8]);
        }
       
        
        
    }

    public void changeButton2()
    {

        if (clicked == false && a[1] != 0)
        {
            v = a[1];
            clicked = true;
            temp = 2;

        }
        else
        {
            if (temp == 1)
            {
                btn1.image.overrideSprite = tempimage;
                a[0] = 0;
            }
            else if (temp == 7)
            {
                btn7.image.overrideSprite = tempimage;
                a[6] = 0;
            }
            else if (temp == 5)
            {
                btn5.image.overrideSprite = tempimage;
                a[4] = 0;
            }
            if (v == 1)
            {
                btn2.image.overrideSprite = greenpawn;
                a[1] = 1;
                myMusic.Play();
            }
            else if (v == 2)
            {
                btn4.image.overrideSprite = redpawn;
                a[1] = 2;
                myMusic.Play();
            }
            clicked = false;
            win(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8]);
        }
    }

    public void changeButton3()
    {
        if (clicked == false && a[2] != 0)
        {
            v = a[2];
            clicked = true;
            temp = 3;

        }
        else
        {
            if (temp == 2)
            {
                btn2.image.overrideSprite = tempimage;
                a[1] = 0;
            }
            else if (temp == 6)
            {
                btn6.image.overrideSprite = tempimage;
                a[5] = 0;
            }
            else if (temp == 5)
            {
                btn5.image.overrideSprite = tempimage;
                a[4] = 0;
            }
            if (v == 1)
            {
                btn3.image.overrideSprite = greenpawn;
                a[2] = 1;
                myMusic.Play();
            }
            else if (v == 2)
            {
                btn3.image.overrideSprite = redpawn;
                a[2] = 2;
                myMusic.Play();
            }
            
            clicked = false;
            win(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8]);

        }
    }

    public void changeButton4()
    {
        if (clicked == false && a[3] != 0)
        {
            v = a[3];
            clicked = true;
            temp = 4;

        }
        else
        {
            if (temp == 1)
            {
                btn1.image.overrideSprite = tempimage;
                a[0] = 0;
            }
            else if (temp == 7)
            {
                btn7.image.overrideSprite = tempimage;
                a[6] = 0;
            }
            else if (temp == 5)
            {
                btn5.image.overrideSprite = tempimage;
                a[4] = 0;
            }
            if(v==1)
            {
                btn4.image.overrideSprite = greenpawn;
                a[3] = 1;
                myMusic.Play();
            }
            else if (v==2)
            {
                btn4.image.overrideSprite = redpawn;
                a[3] = 2;
                myMusic.Play();
            }
            clicked = false;
            win(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8]);
        }
    }

    public void changeButton5()
    {
        if (clicked == false && a[4] != 0)
        {
            v = a[4];
            clicked = true;
            temp = 5;

        }
        else
        {
            if (temp == 1)
            {
                btn1.image.overrideSprite = tempimage;
                a[0] = 0;
            }
            else if (temp == 2)
            {
                btn2.image.overrideSprite = tempimage;
                a[1] = 0;
            }
            else if (temp == 3)
            {
                btn3.image.overrideSprite = tempimage;
                a[2] = 0;
            }
            else if (temp == 4)
            {
                btn4.image.overrideSprite = tempimage;
                a[3] = 0;
            }
            else if (temp == 6)
            {
                btn6.image.overrideSprite = tempimage;
                a[5] = 0;
            }
            else if (temp == 7)
            {
                btn7.image.overrideSprite = tempimage;
                a[6] = 0;
            }
            else if (temp == 8)
            {
                btn8.image.overrideSprite = tempimage;
                a[7] = 0;

            }
            else if (temp == 9)
            {
                btn9.image.overrideSprite = tempimage;
                a[8] = 0;
            }
            if (v == 1)
            {
                btn5.image.overrideSprite = greenpawn;
                a[4] = 1;
                myMusic.Play();
            }
            else if (v == 2)
            {
                btn5.image.overrideSprite = redpawn;
                a[4] = 2;
                myMusic.Play();
            }
            clicked = false;
            win(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8]);
        }
    }

    public void changeButton6()
    {
        if (clicked == false && a[5] != 0)
        {
            v = a[5];
            clicked = true;
            temp = 6;

        }
        else
        {
            if (temp == 3)
            {
                btn3.image.overrideSprite = tempimage;
                a[2] = 0;
            }
            else if (temp == 9)
            {
                btn9.image.overrideSprite = tempimage;
                a[8] = 0;
            }
            else if (temp == 5)
            {
                btn5.image.overrideSprite = tempimage;
                a[4] = 0;
            }
            if (v == 1)
            {
                btn6.image.overrideSprite = greenpawn;
                a[5] = 1;
                myMusic.Play();
            }
            else if (v == 2)
            {
                btn6.image.overrideSprite = redpawn;
                a[5] = 2;
                myMusic.Play();
            }
            clicked = false;
            win(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8]);
        }
    }

    public void changeButton7()
    {
        if (clicked == false && a[6] != 0)
        {
            v = a[6];
            clicked = true;
            temp = 7;

        }
        else
        {
            if (temp == 4)
            {
                btn4.image.overrideSprite = tempimage;
                a[3] = 0;
            }
            else if (temp == 8)
            {
                btn8.image.overrideSprite = tempimage;
                a[7] = 0;
            }
            else if (temp == 5)
            {
                btn5.image.overrideSprite = tempimage;
                a[4] = 0;
            }
            if (v == 1)
            {
                btn7.image.overrideSprite = greenpawn;
                a[6] = 1;
                myMusic.Play();
            }
            else if (v == 2)
            {
                btn7.image.overrideSprite = redpawn;
                a[6] = 2;
                myMusic.Play();
            }
            clicked = false;
            win(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8]);
        }
    }

    public void changeButton8()
    {
        if (clicked == false && a[7] != 0)
        {
            v = a[7];
            clicked = true;
            temp = 8;

        }
        else
        {
            if (temp == 7)
            {
                btn7.image.overrideSprite = tempimage;
                a[6] = 0;
            }
            else if (temp == 9)
            {
                btn9.image.overrideSprite = tempimage;
                a[8] = 0;
            }
            else if (temp == 5)
            {
                btn5.image.overrideSprite = tempimage;
                a[4] = 0;
            }
            if (v == 1)
            {
                btn8.image.overrideSprite = greenpawn;
                a[7] = 1;
                myMusic.Play();
            }
            else if (v == 2)
            {
                btn8.image.overrideSprite = redpawn;
                a[7] = 2;
                myMusic.Play();
            }
            clicked = false;
            win(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8]);
        }
    }

    public void changeButton9()
    {
        if (clicked == false && a[8] != 0)
        {
            v = a[8];
            clicked = true;
            temp = 9;

        }
        else
        {
            if (temp == 8)
            {
                btn8.image.overrideSprite = tempimage;
                a[7] = 0;
            }
            else if (temp == 6)
            {
                btn6.image.overrideSprite = tempimage;
                a[5] = 0;
            }
            else if (temp == 5)
            {
                btn5.image.overrideSprite = tempimage;
                a[4] = 0;
            }
            if (v == 1)
            {
                btn9.image.overrideSprite = greenpawn;
                a[8] = 1;
                myMusic.Play();
            }
            else if (v == 2)
            {
                btn9.image.overrideSprite = redpawn;
                a[8] = 2;
                myMusic.Play();
            }
            clicked = false;
            win(a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8]);
        }
    }

}
