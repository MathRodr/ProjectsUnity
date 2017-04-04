using UnityEngine;
using System.Collections;

public class MapControl : MonoBehaviour {

    public GameObject wall;
    public GameObject ground;
    public GameObject pillarIndestructible;

    public int colums;
    public int rows;
    
    void Start()
    {
        ConstructWalls();
    }

	void ConstructWalls()
    {
        for (int x=0; x < rows; x++)
        {
            for (int y=0; y < colums; y++)
            {
                if (x == 0 || x == (rows - 1) || y == 0 || y == (colums - 1))
                {
                    VerifyRotationWall(x, y);
                }
                else if ((x % 2 == 0) && (y % 2 == 0))
                {
                    Instantiate(pillarIndestructible, new Vector3(x, y), Quaternion.identity);
                }
                else
                {
                    Instantiate(ground, new Vector3(x, y), Quaternion.identity);
                }
            }
        }
    }

    void VerifyRotationWall(int x, int y)
    {
        if (x == 0)
        {
            Instantiate(wall, new Vector3(x, y), Quaternion.identity);
            print("If 1 : " + x + "/" + y);
        }
        else if (y == 0)
        {
            Instantiate(wall, new Vector3(x, y), Quaternion.Euler(0, 0 , 90f));
            print("If 2 : " + x + "/" + y);
        }
        else if (y == colums - 1)
        {
            Instantiate(wall, new Vector3(x, y), Quaternion.Euler(0, 0, 270f));
            print("If 3 : " + x + "/" + y);
        }
        else if (x == rows - 1)
        {
            print("If 4 : " + x + "/" + y);
            Instantiate(wall, new Vector3(x, y), Quaternion.Euler(0, 0, 180f));
        }
    }

}
