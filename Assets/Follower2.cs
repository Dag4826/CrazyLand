using UnityEngine;
using System.Collections;

public class Follower2 : MonoBehaviour {

    bool hasTarget = false;

    // Update is called once per frame
    void Update()
    {

        NavMeshAgent na = GetComponent<NavMeshAgent>();

     



        

        if (!hasTarget)
        {
            na.destination = Camera.main.transform.position;
            hasTarget = true;
        }

      

            if (na.velocity.magnitude < 0.5 ||
            Vector3.Distance(na.destination, Camera.main.transform.position) > 3)
            
        hasTarget = false;
       
    }
    
}