using UnityEngine;
using System.Collections;

public class Explosion_Tile : MonoBehaviour {

    public GameObject ground;

	void EndExplosion()
    {
        Instantiate(ground, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
