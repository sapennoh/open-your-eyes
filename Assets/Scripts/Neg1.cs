using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Neg1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;
    public bool heartColl = false;
    
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
    if (heartColl == true){
        SceneManager.LoadScene("NegScene2");
    }
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Heart")){
            //Debug.Log("Hey its me goku");
            //Application.LoadLevel("DarkScene1");
            heartColl = true;   
            //Debug.Log("heartColl is true");        
        }
    }

}
