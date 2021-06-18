using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    private Camera playerCamera;
    // Start is called before the first frame update
    void Start()
    {
        playerCamera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        var ray = playerCamera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));

        RaycastHit hit;
        // Check raycast hit in distance of 1m in game units
        if (Physics.Raycast(ray, out hit, 1f))
        {
            print("I'm looking at " + hit.transform.name);
            Debug.DrawRay(playerCamera.transform.position, playerCamera.transform.forward, Color.green);
        }
        else
        {
            print("I'm looking at nothing!");
            Debug.DrawRay(playerCamera.transform.position, playerCamera.transform.forward, Color.red);
        }
    }
}
