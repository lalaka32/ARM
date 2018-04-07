
using UnityEngine;

public class BallScript : MonoBehaviour {

    public GameObject SpawnPlace;
    public GameObject Plane;
    // Use this for initialization
    void Start () {
        
    }
	// Update is called once per frame
	void Update () {
        if (transform.position.y<Plane.transform.position.y-10)
        {
            transform.position = SpawnPlace.transform.position;
        }
    }
}
