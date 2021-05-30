using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public Collider collider;
    public string text;
    private TextMesh textMesh;
    void Start()
    {
        textMesh = GetComponentInChildren<TextMesh>();
        textMesh.text = text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("Closed", false);
    }
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("Closed", true);
    }
}
