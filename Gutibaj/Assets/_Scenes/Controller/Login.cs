using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class Login : MonoBehaviour {

    public GameObject username;
    public GameObject password;
    private string Username;
    private string Password;
    private string[] Lines;
    private string DecryptedPass;

    public void LoginButton()
    {
        bool UN = false;
        bool PW = false;
        if(Username !="")
        {
            if (System.IO.File.Exists(@"F:/UnityTestFolder/" + Username + ".txt"))
            {
                UN = true;
                Lines = System.IO.File.ReadAllLines(@"F:/UnityTestFolder/" + Username + ".txt");
            }
            else
            {
                Debug.LogWarning("Username Invalid");
            }
        }
        else
        {
            Debug.LogWarning("Username Field Empty");
        }

        if(Password != "")
        {
            if(System.IO.File.Exists(@"F:/UnityTestFolder/" + Username + ".txt"))
            {
                int i = 1;
                foreach (char c in Lines[2])
                {
                    i++;
                    char Decrypted = (char)(c / i);
                    DecryptedPass += Decrypted.ToString();
                }
                if(Password == DecryptedPass)
                {
                    PW = true;
                }
                else
                {
                    Debug.LogWarning("Password Doesn't Match");
                }
            }
            else
            {
                Debug.LogWarning("Password is Invalid");
            }

        }
        else
        {
            Debug.LogWarning("Password Field Empty");
        }

        if(UN = true && PW == true)
        {
           username.GetComponent<InputField>().text = "";
           password.GetComponent<InputField>().text = "";
           print("Login Successfull");
            Application.LoadLevel("Main");

        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Username != ""&& Password != "")
            {
                LoginButton();
            }
        }

        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
    }
}
