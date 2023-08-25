using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveToLogin : MonoBehaviour
{
    // Start is called before the first frame update
    //id login scenes
    [SerializeField]
    int id_scene;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TextClickLogin()
    {
        SceneManager.LoadScene(id_scene);
    }
}
