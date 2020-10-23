using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider col){
        if(col.gameObject.tag == "Ball"){
            Invoke("FallDown",0.2f);
        }
    }

    void FallDown(){
        transform.parent.gameObject.GetComponentInParent<Rigidbody>().useGravity = true;
        transform.parent.gameObject.GetComponentInParent<Rigidbody>().isKinematic = false;
        Destroy(transform.parent.gameObject, 1f);
    }
}
