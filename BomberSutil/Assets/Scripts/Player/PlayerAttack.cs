using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

    public GameObject bomb;

	void Start () {

	}
	
	void Update () {

        SetBombGround();
	}

    void SetBombGround()
    {
        if (Input.GetButtonDown("Attack"))
        {
            Vector3 newPosition = new Vector3(transform.position.x + .1f, transform.position.y + -0.2f);
            Instantiate(bomb, newPosition, transform.rotation);
        }
    }
}
