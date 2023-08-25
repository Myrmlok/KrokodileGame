using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Register : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI NickNameText;
    [SerializeField]
    TextMeshProUGUI PasswordText;
    [SerializeField]
    TextMeshProUGUI RepeatPasswordText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //function is called if required fields are not filled
    void NotFild()
    {
        Debug.Log("Not filed");
    }
    // function called if passwords do not match
    void Password_mismatch()
    {
        Debug.Log("Password_mismatch");
    }
    public void ButtonClickRegister()
    {

        if(NickNameText.text.Length==1||
           PasswordText.text.Length==1||
           RepeatPasswordText.text.Length == 1)
        {
            NotFild();
            return;
        }
        if (RepeatPasswordText.text != PasswordText.text)
        {
            Password_mismatch();
            return;
        }
        UserParsed userParsed = new UserParsed() {
            ReceiveAndAnswer="Register",
            Name=NickNameText.text,
            Password=PasswordText.text,
            CommandExecute=false,
        };
        //NEXT CODE FOR BACKEND SENDING DATA TO THE SERVER
    }
    class UserParsed
    {
        public string ReceiveAndAnswer;
        public string Name;
        public string Password;
        public bool CommandExecute;
    }
}
