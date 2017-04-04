using UnityEngine;
using System.Collections;

public class ExplosionEnd : MonoBehaviour {

	void EndExplosion()
    {
        Destroy(transform.parent.gameObject);
    }

}
