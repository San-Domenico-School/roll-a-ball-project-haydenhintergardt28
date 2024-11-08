using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 offset;

    // Start is called before first frame update
    void Start()
    {
		offset = transform.position - player.transform.position;
    }
	
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
