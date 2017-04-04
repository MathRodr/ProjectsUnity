using UnityEngine;
using System.Collections;

public class BombAttack : MonoBehaviour {

    //Time of bomb to explodes in seconds
    public float timeBomb;
    private float timeFinalBomb;

    public GameObject explosion;

	void Start ()
    {
        timeFinalBomb = timeBomb + Time.time;
	}
	
	void Update ()
    {
        if (timeFinalBomb < Time.time)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }	

	}
}
