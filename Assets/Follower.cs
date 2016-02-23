using UnityEngine;
using System.Collections;

public class Follower : MonoBehaviour {
    bool hasTarget = false;
	
	// Update is called once per frame
	void Update () {

        NavMeshAgent na = GetComponent<NavMeshAgent>();
        if (!hasTarget)
        {
           na.destination = Camera.main.transform.position;
            hasTarget = true;
        }

        if (na.velocity.magnitude < 0.5 || 
            Vector3.Distance(na.destination,Camera.main.transform.position) > 2)
            hasTarget = false;
		Debug.Log (Vector3.Dot (transform.forward, Camera.main.transform.forward));
		if (Vector3.Dot (transform.forward, Camera.main.transform.forward) < 0)
			na.speed = 0;
		else
			na.speed = 3.5f;



    }
}

