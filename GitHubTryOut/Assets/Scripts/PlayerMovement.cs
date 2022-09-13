using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    void Start()
    {
        
    }

    [SerializeField] private float speed = 2f; //sets the speed of the object
    
    void Update()
    {

        if(Input.GetAxis("Horizontal") !=0)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
        }
        
        
        if(Input.GetAxis("Vertical") !=0)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime * Input.GetAxis("Vertical"));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleVisibility();
        }
    }

    private void ToggleVisibility()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }
    
}
