using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PosEnd : MonoBehaviour
{
    public float speed = 7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.LeftArrow)){
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    } else if (Input.GetKey(KeyCode.RightArrow)) {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    } 
    if (Input.GetKey(KeyCode.Space)){
        transform.Translate(Vector3.up * (speed*1.5f) * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.E)){
        SceneManager.LoadScene("homeScreen");
    }  
    }
}
